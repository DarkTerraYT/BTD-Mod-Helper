#### [BloonsTD6 Mod Helper](index.md 'index')
### [BTD_Mod_Helper.Api.Scenarios](index.md#BTD_Mod_Helper.Api.Scenarios 'BTD_Mod_Helper.Api.Scenarios')

## ModGameMode Class

Class for a custom GameMode that will be added to the modes screen when starting a new match

```csharp
public abstract class ModGameMode : BTD_Mod_Helper.Api.NamedModContent
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [ModContent](BTD_Mod_Helper.Api.ModContent.md 'BTD_Mod_Helper.Api.ModContent') &#129106; [NamedModContent](BTD_Mod_Helper.Api.NamedModContent.md 'BTD_Mod_Helper.Api.NamedModContent') &#129106; ModGameMode
### Properties

<a name='BTD_Mod_Helper.Api.Scenarios.ModGameMode.BaseGameMode'></a>

## ModGameMode.BaseGameMode Property

The id of the existing GameMode to use as a base. Use GameModeType.[name]  
If this GameModeType.None, empty, or null, then an empty base will be used

```csharp
public abstract string BaseGameMode { get; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='BTD_Mod_Helper.Api.Scenarios.ModGameMode.Difficulty'></a>

## ModGameMode.Difficulty Property

Where this Mode should show up within the Mode Select screen. Use DifficultyType.[name]

```csharp
public abstract string Difficulty { get; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='BTD_Mod_Helper.Api.Scenarios.ModGameMode.DisplayNamePlural'></a>

## ModGameMode.DisplayNamePlural Property

The name that will actually be display when referring to multiple of these

```csharp
public sealed override string DisplayNamePlural { get; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='BTD_Mod_Helper.Api.Scenarios.ModGameMode.Icon'></a>

## ModGameMode.Icon Property

The Icon for the Button for this Mode within the UI, by default looking for the same name as the file

```csharp
public virtual string Icon { get; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='BTD_Mod_Helper.Api.Scenarios.ModGameMode.IconReference'></a>

## ModGameMode.IconReference Property

If you're not going to use a custom .png for your Icon, use this to directly control its SpriteReference

```csharp
public virtual Assets.Scripts.Utils.SpriteReference IconReference { get; }
```

#### Property Value
[Assets.Scripts.Utils.SpriteReference](https://docs.microsoft.com/en-us/dotnet/api/Assets.Scripts.Utils.SpriteReference 'Assets.Scripts.Utils.SpriteReference')

<a name='BTD_Mod_Helper.Api.Scenarios.ModGameMode.PreApplies'></a>

## ModGameMode.PreApplies Property

Whether this GameMode ...

```csharp
protected virtual bool PreApplies { get; }
```

#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

<a name='BTD_Mod_Helper.Api.Scenarios.ModGameMode.RegistrationPriority'></a>

## ModGameMode.RegistrationPriority Property

Registers after Round Sets

```csharp
protected override float RegistrationPriority { get; }
```

#### Property Value
[System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')
### Methods

<a name='BTD_Mod_Helper.Api.Scenarios.ModGameMode.ModifyBaseGameModeModel(Assets.Scripts.Models.Towers.Mods.ModModel)'></a>

## ModGameMode.ModifyBaseGameModeModel(ModModel) Method

Implemented by a ModGameMode to modify the base game mode, for instance by adding or removing mutator mods

```csharp
public abstract void ModifyBaseGameModeModel(Assets.Scripts.Models.Towers.Mods.ModModel gameModeModel);
```
#### Parameters

<a name='BTD_Mod_Helper.Api.Scenarios.ModGameMode.ModifyBaseGameModeModel(Assets.Scripts.Models.Towers.Mods.ModModel).gameModeModel'></a>

`gameModeModel` [Assets.Scripts.Models.Towers.Mods.ModModel](https://docs.microsoft.com/en-us/dotnet/api/Assets.Scripts.Models.Towers.Mods.ModModel 'Assets.Scripts.Models.Towers.Mods.ModModel')

<a name='BTD_Mod_Helper.Api.Scenarios.ModGameMode.Register()'></a>

## ModGameMode.Register() Method

(Cross-Game compatible) Registers this ModContent into the game

```csharp
public override void Register();
```

<a name='BTD_Mod_Helper.Api.Scenarios.ModGameMode.RegisterText(Il2CppSystem.Collections.Generic.Dictionary_string,string_)'></a>

## ModGameMode.RegisterText(Dictionary<string,string>) Method

Registers the text for this in the LocalizationManager

```csharp
public override void RegisterText(Il2CppSystem.Collections.Generic.Dictionary<string,string> textTable);
```
#### Parameters

<a name='BTD_Mod_Helper.Api.Scenarios.ModGameMode.RegisterText(Il2CppSystem.Collections.Generic.Dictionary_string,string_).textTable'></a>

`textTable` [Il2CppSystem.Collections.Generic.Dictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/Il2CppSystem.Collections.Generic.Dictionary-2 'Il2CppSystem.Collections.Generic.Dictionary`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/Il2CppSystem.Collections.Generic.Dictionary-2 'Il2CppSystem.Collections.Generic.Dictionary`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/Il2CppSystem.Collections.Generic.Dictionary-2 'Il2CppSystem.Collections.Generic.Dictionary`2')