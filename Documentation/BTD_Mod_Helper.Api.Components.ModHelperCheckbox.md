#### [BloonsTD6 Mod Helper](README.md 'README')
### [BTD_Mod_Helper.Api.Components](README.md#BTD_Mod_Helper.Api.Components 'BTD_Mod_Helper.Api.Components')

## ModHelperCheckbox Class

ModHelperComponent for a Checkbox

```csharp
public class ModHelperCheckbox : BTD_Mod_Helper.Api.Components.ModHelperComponent
```

Inheritance [UnityEngine.MonoBehaviour](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.MonoBehaviour 'UnityEngine.MonoBehaviour') &#129106; [ModHelperComponent](BTD_Mod_Helper.Api.Components.ModHelperComponent.md 'BTD_Mod_Helper.Api.Components.ModHelperComponent') &#129106; ModHelperCheckbox
### Properties

<a name='BTD_Mod_Helper.Api.Components.ModHelperCheckbox.Check'></a>

## ModHelperCheckbox.Check Property

The ModHelperImage for the Checkmark

```csharp
public BTD_Mod_Helper.Api.Components.ModHelperImage Check { get; }
```

#### Property Value
[ModHelperImage](BTD_Mod_Helper.Api.Components.ModHelperImage.md 'BTD_Mod_Helper.Api.Components.ModHelperImage')

<a name='BTD_Mod_Helper.Api.Components.ModHelperCheckbox.CurrentValue'></a>

## ModHelperCheckbox.CurrentValue Property

Whether it is currently checked or not

```csharp
public bool CurrentValue { get; }
```

#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

<a name='BTD_Mod_Helper.Api.Components.ModHelperCheckbox.Toggle'></a>

## ModHelperCheckbox.Toggle Property

The Toggle component

```csharp
public Toggle Toggle { get; }
```

#### Property Value
[UnityEngine.UI.Toggle](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.UI.Toggle 'UnityEngine.UI.Toggle')

<a name='BTD_Mod_Helper.Api.Components.ModHelperCheckbox.UnCheck'></a>

## ModHelperCheckbox.UnCheck Property

The ModHelperImage for the un checked indicator, if there is one

```csharp
public BTD_Mod_Helper.Api.Components.ModHelperImage UnCheck { get; }
```

#### Property Value
[ModHelperImage](BTD_Mod_Helper.Api.Components.ModHelperImage.md 'BTD_Mod_Helper.Api.Components.ModHelperImage')
### Methods

<a name='BTD_Mod_Helper.Api.Components.ModHelperCheckbox.AddUnCheckedIcon(string)'></a>

## ModHelperCheckbox.AddUnCheckedIcon(string) Method

Adds an icon that appears when the checkbox is unchecked, such as an X

```csharp
public void AddUnCheckedIcon(string icon);
```
#### Parameters

<a name='BTD_Mod_Helper.Api.Components.ModHelperCheckbox.AddUnCheckedIcon(string).icon'></a>

`icon` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='BTD_Mod_Helper.Api.Components.ModHelperCheckbox.Create(BTD_Mod_Helper.Api.Components.Info,bool,string,UnityAction_bool_,string,int)'></a>

## ModHelperCheckbox.Create(Info, bool, string, UnityAction<bool>, string, int) Method

Creates a new ModHelperCheckbox

```csharp
public static BTD_Mod_Helper.Api.Components.ModHelperCheckbox Create(BTD_Mod_Helper.Api.Components.Info info, bool defaultValue, string background, UnityAction<bool> onValueChanged=null, string checkImage=null, int padding=0);
```
#### Parameters

<a name='BTD_Mod_Helper.Api.Components.ModHelperCheckbox.Create(BTD_Mod_Helper.Api.Components.Info,bool,string,UnityAction_bool_,string,int).info'></a>

`info` [Info](BTD_Mod_Helper.Api.Components.Info.md 'BTD_Mod_Helper.Api.Components.Info')

The name/position/size info

<a name='BTD_Mod_Helper.Api.Components.ModHelperCheckbox.Create(BTD_Mod_Helper.Api.Components.Info,bool,string,UnityAction_bool_,string,int).defaultValue'></a>

`defaultValue` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

If it starts out checked or not

<a name='BTD_Mod_Helper.Api.Components.ModHelperCheckbox.Create(BTD_Mod_Helper.Api.Components.Info,bool,string,UnityAction_bool_,string,int).background'></a>

`background` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The background behind the check, or null for nothing

<a name='BTD_Mod_Helper.Api.Components.ModHelperCheckbox.Create(BTD_Mod_Helper.Api.Components.Info,bool,string,UnityAction_bool_,string,int).onValueChanged'></a>

`onValueChanged` [UnityEngine.Events.UnityAction](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Events.UnityAction 'UnityEngine.Events.UnityAction')

Action to perform when it is checked/unchecked, or null

<a name='BTD_Mod_Helper.Api.Components.ModHelperCheckbox.Create(BTD_Mod_Helper.Api.Components.Info,bool,string,UnityAction_bool_,string,int).checkImage'></a>

`checkImage` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The checkmark itself, or null for the default checkmark

<a name='BTD_Mod_Helper.Api.Components.ModHelperCheckbox.Create(BTD_Mod_Helper.Api.Components.Info,bool,string,UnityAction_bool_,string,int).padding'></a>

`padding` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

How much space around the outside of the check there is

#### Returns
[ModHelperCheckbox](BTD_Mod_Helper.Api.Components.ModHelperCheckbox.md 'BTD_Mod_Helper.Api.Components.ModHelperCheckbox')  
The new ModHelperCheckbox

<a name='BTD_Mod_Helper.Api.Components.ModHelperCheckbox.SetChecked(bool,bool)'></a>

## ModHelperCheckbox.SetChecked(bool, bool) Method

Sets the current value of this

```csharp
public void SetChecked(bool isChecked, bool sendCallback=true);
```
#### Parameters

<a name='BTD_Mod_Helper.Api.Components.ModHelperCheckbox.SetChecked(bool,bool).isChecked'></a>

`isChecked` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

The new value

<a name='BTD_Mod_Helper.Api.Components.ModHelperCheckbox.SetChecked(bool,bool).sendCallback'></a>

`sendCallback` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

Whether the onValueChanged listener should fire