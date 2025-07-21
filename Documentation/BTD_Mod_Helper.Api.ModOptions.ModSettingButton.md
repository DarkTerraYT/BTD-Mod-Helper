#### [BloonsTD6 Mod Helper](README.md 'README')
### [BTD_Mod_Helper.Api.ModOptions](README.md#BTD_Mod_Helper.Api.ModOptions 'BTD_Mod_Helper.Api.ModOptions')

## ModSettingButton Class

ModSetting for adding a button in the settings that performs a given action, with the setting just tracking  
the number of times that the button has been pressed.

```csharp
public class ModSettingButton : BTD_Mod_Helper.Api.ModOptions.ModSetting
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [ModSetting](BTD_Mod_Helper.Api.ModOptions.ModSetting.md 'BTD_Mod_Helper.Api.ModOptions.ModSetting') &#129106; ModSettingButton
### Fields

<a name='BTD_Mod_Helper.Api.ModOptions.ModSettingButton.action'></a>

## ModSettingButton.action Field

The action that this button performs

```csharp
public Action action;
```

#### Field Value
[System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

<a name='BTD_Mod_Helper.Api.ModOptions.ModSettingButton.buttonSprite'></a>

## ModSettingButton.buttonSprite Field

The sprite to use for the button, BlueBtnLong by default

```csharp
public string buttonSprite;
```

#### Field Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='BTD_Mod_Helper.Api.ModOptions.ModSettingButton.buttonText'></a>

## ModSettingButton.buttonText Field

The text that will appear on the button, "Dew It" by default

```csharp
public string buttonText;
```

#### Field Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='BTD_Mod_Helper.Api.ModOptions.ModSettingButton.modifyButton'></a>

## ModSettingButton.modifyButton Field

Action to modify the ModHelperButton after it's created

```csharp
public Action<ModHelperButton> modifyButton;
```

#### Field Value
[System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[ModHelperButton](BTD_Mod_Helper.Api.Components.ModHelperButton.md 'BTD_Mod_Helper.Api.Components.ModHelperButton')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')