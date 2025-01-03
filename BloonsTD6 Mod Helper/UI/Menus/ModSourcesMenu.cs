using BTD_Mod_Helper.Api;
using BTD_Mod_Helper.Api.Components;
using BTD_Mod_Helper.Api.Enums;
using BTD_Mod_Helper.Api.Helpers;
using Il2CppAssets.Scripts.Unity.UI_New.Popups;
using Il2CppAssets.Scripts.Unity.UI_New.Settings;
using Il2CppNinjaKiwi.Common;
using System;
using System.Collections;
using System.IO;
using System.Linq;
using Il2CppAssets.Scripts.Unity.Menu;
using UnityEngine;

namespace BTD_Mod_Helper.UI.Menus
{
    internal class ModSourcesMenu : ModGameMenu<SettingsScreen>
    {
        internal static bool ModSourcesPresent => Directory.GetFiles(MelonMain.ModSourcesFolder).Length > 0;

        private static ModHelperScrollPanel sourcesScroll;

        private static ModHelperPanel leftSide;
        private static ModHelperPanel rightSide;

        private static ModHelperPanel menu;

        private static bool currentlyLoadingSources = false;

        private static object generateScrollContentToken = null;
        
        bool IsModSource(string path)
        {
            foreach (var file in Directory.GetFiles(path))
            {
                if (Path.GetExtension(file) == ".sln")
                {
                    return true;
                }
            }

            return false;
        }

        public override bool OnMenuOpened(Il2CppSystem.Object data)
        {
            GameMenu.gameObject.DestroyAllChildren();
            CommonForegroundHeader.SetText("Mod Sources");

            menu  = GameMenu.gameObject.AddModHelperPanel(new("Panel", -450, -150, ModsMenu.MenuWidth, ModsMenu.MenuHeight), VanillaSprites.MainBGPanelBlue);

            CreateExtraElements(menu);

            sourcesScroll = menu.AddScrollPanel(new("ScrollPanel", InfoPreset.Flex), RectTransform.Axis.Vertical, VanillaSprites.BlueInsertPanelRound, 100, 100);

            menu.AddComponent<Animator>().runtimeAnimatorController = Animations.PopupAnim;
            menu.GetComponent<Animator>().Play("PopupSlideIn");
            
            generateScrollContentToken = MelonCoroutines.Start(GenerateScrollContent());

            return true;
        }

        public IEnumerator GenerateScrollContent(string search = "")
        {
            if(currentlyLoadingSources)
            {

            }

            currentlyLoadingSources = true;

            sourcesScroll.ScrollContent.RectTransform.DestroyAllChildren();


            foreach (var folder in Directory.GetDirectories(MelonMain.ModSourcesFolder).OrderBy(path => path))
            {
                Sprite icon = null;
                string name = "";

                foreach(var file in Directory.GetFiles(folder))
                {
                    if(Path.GetFileName(file) == "Icon.png")
                    {
                        Texture2D iconTexture = new(2, 2);
                        iconTexture.LoadFromFile(file);

                        icon = Sprite.Create(new Rect(0, 0, iconTexture.width, iconTexture.height), new Vector2(), 10, iconTexture);
                    }

                    if(Path.GetExtension(file) == ".sln" && name == "")
                    {
                        name = Path.GetFileNameWithoutExtension(file);
                        
                    }

                    if (Closing) { currentlyLoadingSources = false; yield break; }
                }

                if (Closing) { currentlyLoadingSources = false; yield break; }

                if (name != "" && name.ToLower().Contains(search)) sourcesScroll.AddScrollContent(CreateSourcePanel(name, folder, icon));

                yield return null;
            }

            currentlyLoadingSources = false;
            generateScrollContentToken = null;
        }

        public override void OnMenuClosed()
        {
            menu.GetComponent<Animator>().Play("PopupSlideOut");
        }

        internal void CreateExtraElements(ModHelperPanel panel)
        {
            string searchText = "";


            panel.AddImage(new("Image",-1500, 700, 175), VanillaSprites.SearchIcon);

            var searchBar = panel.AddInputField(new("SearchBar", -650, 700, 1500, 125), searchText, VanillaSprites.BlueInsertPanel, new Action<string>(input =>
            {
                if(input != null)
                {
                    searchText = input.ToLower();
                    if (generateScrollContentToken != null)
                    {
                        MelonCoroutines.Stop(generateScrollContentToken);
                    }
                    generateScrollContentToken = MelonCoroutines.Start(GenerateScrollContent(searchText));
                }
            }), 75, Il2CppTMPro.TMP_InputField.CharacterValidation.Alphanumeric, Il2CppTMPro.TextAlignmentOptions.Left, "", 20);

            var refreshButton = panel.AddButton(new("RefreshBtn", 1400, 750, 250), VanillaSprites.RestartBtn, new Action(() =>
            {
                if (generateScrollContentToken != null)
                {
                    MelonCoroutines.Stop(generateScrollContentToken);
                }
                generateScrollContentToken = MelonCoroutines.Start(GenerateScrollContent(searchText));
                MenuManager.instance.buttonClickSound.Play("ClickSounds");
            }));
        }

        private ModHelperPanel CreateSourcePanel(string name, string path, Sprite iconSprite)
        {
            var panel = ModHelperPanel.Create(new("SourcePanel_" + name, ModsMenu.ModPanelHeight) { FlexWidth = 1}, VanillaSprites.MainBGPanelBlue);

            var nameText = panel.AddText(new("Name", 100, 100, 1500, 200), name.Localize());
            nameText.EnableAutoSizing(200);

            var pathText = panel.AddText(new("Path", 100, -100, 1500, 150), path);
            pathText.EnableAutoSizing(150);
            var openFolder = panel.AddButton(new("OpenFolderButton", 1050, 150, 250), VanillaSprites.BlueBtn, new Action(() =>
            {
                ProcessHelper.OpenFolder(path);
                MenuManager.instance.buttonClick2Sound.Play("ClickSounds");
                
            }));
            openFolder.AddImage(new("Icon", 150), GetSprite("OpenFolderIcon"));

            var openProject = panel.AddButton(new("OpenProjectBtn", 1050, -150, 250), VanillaSprites.EditBtn, new Action(
                () =>
                {
                    ProcessHelper.OpenFile(Path.Combine(path, name + ".sln"));
                    MenuManager.instance.buttonClick2Sound.Play("ClickSounds");
                }));


            // -- DOESN'T WORK-- (idk why)
            /*if (iconSprite != null)
            {
                panel.AddImage(new("Icon", -1900, 0, 500), iconSprite); 
            }*/
            
            return panel;
        }
    }
}
