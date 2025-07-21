﻿using System;
using Il2CppNinjaKiwi.Common;
using Il2CppTMPro;
namespace BTD_Mod_Helper.Api.Components;

/// <summary>
/// ModHelperComponent for a background panel
/// </summary>
[RegisterTypeInIl2Cpp(false)]
public class ModHelperText : ModHelperComponent
{


    /// <inheritdoc />
    public ModHelperText(IntPtr ptr) : base(ptr)
    {
    }

    /// <summary>
    /// The component that handles the Text rendering
    /// </summary>
    public NK_TextMeshProUGUI Text => GetComponent<NK_TextMeshProUGUI>();

    /// <summary>
    /// Sets the text of this text to the given text
    /// </summary>
    public void SetText(string text)
    {
        if (Text.AutoLocalize)
        {
            Text.localizeKey = text;
            Text.SetText(text.Localize());
        }
        else
        {
            Text.SetText(text);
        }
    }

    /// <summary>
    /// Enables auto sizing on the text component
    /// </summary>
    public void EnableAutoSizing()
    {
        Text.enableAutoSizing = true;
    }

    /// <summary>
    /// Enables auto sizing on the text component.
    /// Changes the maximum font size.
    /// </summary>
    /// <param name="fontSizeMax">New max font size</param>
    public void EnableAutoSizing(float fontSizeMax)
    {
        EnableAutoSizing();
        Text.fontSizeMax = fontSizeMax;
    }

    /// <summary>
    /// Enables auto sizing on the text component.
    /// Changes the maximum and minimum font size.
    /// </summary>
    /// <param name="fontSizeMax">New max font size</param>
    /// <param name="fontSizeMin">New min font size</param>
    public void EnableAutoSizing(float fontSizeMax, float fontSizeMin)
    {
        EnableAutoSizing(fontSizeMax);
        Text.fontSizeMin = fontSizeMin;
    }

    /// <summary>
    /// Creates a new ModHelperText
    /// </summary>
    /// <param name="info">The name/position/size info</param>
    /// <param name="text">The text to display</param>
    /// <param name="fontSize">Size of font</param>
    /// <param name="align">Alignment of text</param>
    /// <returns>The created ModHelperText</returns>
    public static ModHelperText Create(Info info, string text, float fontSize = 42,
        TextAlignmentOptions align = DefaultTextAlignment)
    {
        var modHelperText = Create<ModHelperText>(info);

        var textMesh = modHelperText.AddComponent<NK_TextMeshProUGUI>();

        textMesh.AutoLocalize = true;
        textMesh.localizeKey = text;
        textMesh.SetText(text.Localize());
        textMesh.alignment = align;
        textMesh.fontSize = fontSize;
        textMesh.font = Fonts.Btd6FontTitle;
        textMesh.overflowMode = TextOverflowModes.Ellipsis;
        textMesh.lineSpacing = fontSize / 2;
        textMesh.parseCtrlCharacters = false;

        return modHelperText;
    }


    /// <summary>
    /// Enables auto sizing for this <see cref="Text"/> component
    /// </summary>
    public void EnableAutoSizing()
    {
        Text.enableAutoSizing = true;
    }

    /// <summary>
    /// Enables or disables auto sizing for this <see cref="Text"/> component
    /// </summary>
    public void EnableAutoSizing(bool enabled)
    {
        Text.enableAutoSizing = enabled;
    }
    /// <summary>
    /// Enables auto sizing for this <see cref="Text"/> component
    /// </summary>
    public void EnableAutoSizing(float fontSizeMax)
    {
        Text.enableAutoSizing = true;
        Text.fontSizeMax = fontSizeMax;
    }
    /// <summary>
    /// Enables auto sizing for <see cref="Text"/> 
    /// </summary>
    public void EnableAutoSizing(float fontSizeMax, float fontSizeMin)
    {
        Text.enableAutoSizing = true;
        Text.fontSizeMax = fontSizeMax;
        Text.fontSizeMin = fontSizeMin;
    }
}