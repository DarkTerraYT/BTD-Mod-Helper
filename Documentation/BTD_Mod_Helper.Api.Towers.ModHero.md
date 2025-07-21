#### [BloonsTD6 Mod Helper](README.md 'README')
### [BTD_Mod_Helper.Api.Towers](README.md#BTD_Mod_Helper.Api.Towers 'BTD_Mod_Helper.Api.Towers')

## ModHero Class

Class for adding a custom Hero to the game. Use alongside [ModHeroLevel](BTD_Mod_Helper.Api.Towers.ModHeroLevel.md 'BTD_Mod_Helper.Api.Towers.ModHeroLevel') to give multiple levels.

```csharp
public abstract class ModHero : BTD_Mod_Helper.Api.Towers.ModTower
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [ModContent](BTD_Mod_Helper.Api.ModContent.md 'BTD_Mod_Helper.Api.ModContent') &#129106; [NamedModContent](BTD_Mod_Helper.Api.NamedModContent.md 'BTD_Mod_Helper.Api.NamedModContent') &#129106; [ModTower](BTD_Mod_Helper.Api.Towers.ModTower.md 'BTD_Mod_Helper.Api.Towers.ModTower') &#129106; ModHero
### Properties

<a name='BTD_Mod_Helper.Api.Towers.ModHero.Abilities'></a>

## ModHero.Abilities Property

The total number of abilities that this hero has as max level  
<br/>  
OBSOLETE: No longer required to manually specify

```csharp
public virtual int Abilities { get; }
```

#### Property Value
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

<a name='BTD_Mod_Helper.Api.Towers.ModHero.BackgroundStyle'></a>

## ModHero.BackgroundStyle Property

The other hero that has the same background color in the Heroes menu as you want to use

```csharp
public virtual string BackgroundStyle { get; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='BTD_Mod_Helper.Api.Towers.ModHero.BaseTower'></a>

## ModHero.BaseTower Property

The default hero (or tower) to base your hero off of

```csharp
public override string BaseTower { get; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='BTD_Mod_Helper.Api.Towers.ModHero.BottomPathUpgrades'></a>

## ModHero.BottomPathUpgrades Property

No other upgrade paths used

```csharp
public sealed override int BottomPathUpgrades { get; }
```

#### Property Value
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

<a name='BTD_Mod_Helper.Api.Towers.ModHero.Button'></a>

## ModHero.Button Property

The png name of the Button icon for this hero in the UI, by default Name-Button

```csharp
public virtual string Button { get; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='BTD_Mod_Helper.Api.Towers.ModHero.ButtonReference'></a>

## ModHero.ButtonReference Property

The exact sprite reference used for the button

```csharp
public virtual SpriteReference ButtonReference { get; }
```

#### Property Value
[Il2CppNinjaKiwi.Common.ResourceUtils.SpriteReference](https://docs.microsoft.com/en-us/dotnet/api/Il2CppNinjaKiwi.Common.ResourceUtils.SpriteReference 'Il2CppNinjaKiwi.Common.ResourceUtils.SpriteReference')

<a name='BTD_Mod_Helper.Api.Towers.ModHero.DontAddToShop'></a>

## ModHero.DontAddToShop Property

Heroes aren't in the default shop

```csharp
public sealed override bool DontAddToShop { get; }
```

#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

<a name='BTD_Mod_Helper.Api.Towers.ModHero.GlowStyle'></a>

## ModHero.GlowStyle Property

The other hero that has the same glow color in the Heroes menu as you want to use

```csharp
public virtual string GlowStyle { get; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='BTD_Mod_Helper.Api.Towers.ModHero.IncludeInMonkeyTeams'></a>

## ModHero.IncludeInMonkeyTeams Property

Not a thing anyway

```csharp
public sealed override bool IncludeInMonkeyTeams { get; }
```

#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

<a name='BTD_Mod_Helper.Api.Towers.ModHero.Level1Description'></a>

## ModHero.Level1Description Property

The description to use for the first level of your hero

```csharp
public abstract string Level1Description { get; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='BTD_Mod_Helper.Api.Towers.ModHero.MaxLevel'></a>

## ModHero.MaxLevel Property

The total number of levels this hero has. Do not set this to anything other than number of ModHeroLevels  
that you've actually created for your Hero.

```csharp
public virtual int MaxLevel { get; }
```

#### Property Value
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

<a name='BTD_Mod_Helper.Api.Towers.ModHero.MiddlePathUpgrades'></a>

## ModHero.MiddlePathUpgrades Property

No other upgrade paths used

```csharp
public sealed override int MiddlePathUpgrades { get; }
```

#### Property Value
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

<a name='BTD_Mod_Helper.Api.Towers.ModHero.NameStyle'></a>

## ModHero.NameStyle Property

The other hero that has the same colored name in the Heroes menu as you want to use

```csharp
public virtual string NameStyle { get; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='BTD_Mod_Helper.Api.Towers.ModHero.ParagonMode'></a>

## ModHero.ParagonMode Property

No paragon heroes

```csharp
public sealed override BTD_Mod_Helper.Api.Towers.ParagonMode ParagonMode { get; }
```

#### Property Value
[ParagonMode](BTD_Mod_Helper.Api.Towers.ParagonMode.md 'BTD_Mod_Helper.Api.Towers.ParagonMode')

<a name='BTD_Mod_Helper.Api.Towers.ModHero.RogueStarterArtifact'></a>

## ModHero.RogueStarterArtifact Property

The starting artifact this hero should have in Rogue Legends

```csharp
public virtual string RogueStarterArtifact { get; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='BTD_Mod_Helper.Api.Towers.ModHero.RogueStarterInstas'></a>

## ModHero.RogueStarterInstas Property

The starting insta towers this hero should have in Rogue Legends.

```csharp
public virtual System.Collections.Generic.IEnumerable<(string baseId,int[] tiers)> RogueStarterInstas { get; }
```

#### Property Value
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.ValueTuple 'System.ValueTuple')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.ValueTuple 'System.ValueTuple')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.ValueTuple 'System.ValueTuple')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

<a name='BTD_Mod_Helper.Api.Towers.ModHero.SelectScreenPortraits'></a>

## ModHero.SelectScreenPortraits Property

If you want to manually override which portraits your hero uses in the select screen, mess with this  
<br/>  
By default will find any [PortraitReference](BTD_Mod_Helper.Api.Towers.ModUpgrade.md#BTD_Mod_Helper.Api.Towers.ModUpgrade.PortraitReference 'BTD_Mod_Helper.Api.Towers.ModUpgrade.PortraitReference')s defined in your [ModHeroLevel](BTD_Mod_Helper.Api.Towers.ModHeroLevel.md 'BTD_Mod_Helper.Api.Towers.ModHeroLevel')s  
<br/>  
The SpriteReference is the actual image that will be displayed

```csharp
public virtual System.Collections.Generic.Dictionary<int,SpriteReference> SelectScreenPortraits { get; }
```

#### Property Value
[System.Collections.Generic.Dictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')[Il2CppNinjaKiwi.Common.ResourceUtils.SpriteReference](https://docs.microsoft.com/en-us/dotnet/api/Il2CppNinjaKiwi.Common.ResourceUtils.SpriteReference 'Il2CppNinjaKiwi.Common.ResourceUtils.SpriteReference')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')

<a name='BTD_Mod_Helper.Api.Towers.ModHero.SelectSound'></a>

## ModHero.SelectSound Property

Sound to play when you select this hero in the hero select screen, the sound must be registered in the game for it to  
play

```csharp
public virtual string SelectSound { get; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='BTD_Mod_Helper.Api.Towers.ModHero.Square'></a>

## ModHero.Square Property

The name of the png to try to find for the new hero select screen button

```csharp
public virtual string Square { get; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='BTD_Mod_Helper.Api.Towers.ModHero.SquareReference'></a>

## ModHero.SquareReference Property

The SpriteReference for this hero's Square icon in the new revamped HeroScreen

```csharp
public virtual SpriteReference SquareReference { get; }
```

#### Property Value
[Il2CppNinjaKiwi.Common.ResourceUtils.SpriteReference](https://docs.microsoft.com/en-us/dotnet/api/Il2CppNinjaKiwi.Common.ResourceUtils.SpriteReference 'Il2CppNinjaKiwi.Common.ResourceUtils.SpriteReference')

<a name='BTD_Mod_Helper.Api.Towers.ModHero.Title'></a>

## ModHero.Title Property

The short description that appears under the name of the hero

```csharp
public abstract string Title { get; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='BTD_Mod_Helper.Api.Towers.ModHero.TopPathUpgrades'></a>

## ModHero.TopPathUpgrades Property

Putting all the hero level upgrades in the top path

```csharp
public sealed override int TopPathUpgrades { get; }
```

#### Property Value
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

<a name='BTD_Mod_Helper.Api.Towers.ModHero.TowerSet'></a>

## ModHero.TowerSet Property

Heroes can only be in the Hero tower set

```csharp
public sealed override TowerSet TowerSet { get; }
```

#### Property Value
[Il2CppAssets.Scripts.Models.TowerSets.TowerSet](https://docs.microsoft.com/en-us/dotnet/api/Il2CppAssets.Scripts.Models.TowerSets.TowerSet 'Il2CppAssets.Scripts.Models.TowerSets.TowerSet')

<a name='BTD_Mod_Helper.Api.Towers.ModHero.XpRatio'></a>

## ModHero.XpRatio Property

XpRatio to use when determining the default xp costs of the levels.  
<br/>  
All four base heroes (Quincy, Gwendolin, Striker Jones, Obyn Greenfoot) as well as Etienne have an XP ratio of 1x.  
<br/>  
Ezili, Pat Fusty, Admiral Brickell, and Sauda have a 1.425x XP ratio.  
<br/>  
Benjamin and Psi have an XP ratio of 1.5x.  
<br/>  
Captain Churchill and Adora have a ratio of 1.71x.

```csharp
public abstract float XpRatio { get; }
```

#### Property Value
[System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')
### Methods

<a name='BTD_Mod_Helper.Api.Towers.ModHero.CreateDefaultSkin(System.Collections.Generic.Dictionary_string,SkinData_)'></a>

## ModHero.CreateDefaultSkin(Dictionary<string,SkinData>) Method

Creates the SkinData for the default tower

```csharp
public virtual SkinData CreateDefaultSkin(System.Collections.Generic.Dictionary<string,SkinData> skinsByName);
```
#### Parameters

<a name='BTD_Mod_Helper.Api.Towers.ModHero.CreateDefaultSkin(System.Collections.Generic.Dictionary_string,SkinData_).skinsByName'></a>

`skinsByName` [System.Collections.Generic.Dictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')[Il2CppAssets.Scripts.Data.Skins.SkinData](https://docs.microsoft.com/en-us/dotnet/api/Il2CppAssets.Scripts.Data.Skins.SkinData 'Il2CppAssets.Scripts.Data.Skins.SkinData')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')

Existing hero skins by their skin/tower name

#### Returns
[Il2CppAssets.Scripts.Data.Skins.SkinData](https://docs.microsoft.com/en-us/dotnet/api/Il2CppAssets.Scripts.Data.Skins.SkinData 'Il2CppAssets.Scripts.Data.Skins.SkinData')

<a name='BTD_Mod_Helper.Api.Towers.ModHero.GetBackgroundBanner(System.Collections.Generic.Dictionary_string,SkinData_)'></a>

## ModHero.GetBackgroundBanner(Dictionary<string,SkinData>) Method

Gets the Background Banner for the default SkinData

```csharp
public virtual PrefabReference GetBackgroundBanner(System.Collections.Generic.Dictionary<string,SkinData> skinsByName);
```
#### Parameters

<a name='BTD_Mod_Helper.Api.Towers.ModHero.GetBackgroundBanner(System.Collections.Generic.Dictionary_string,SkinData_).skinsByName'></a>

`skinsByName` [System.Collections.Generic.Dictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')[Il2CppAssets.Scripts.Data.Skins.SkinData](https://docs.microsoft.com/en-us/dotnet/api/Il2CppAssets.Scripts.Data.Skins.SkinData 'Il2CppAssets.Scripts.Data.Skins.SkinData')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')

Existing hero skins by their skin/tower name

#### Returns
[Il2CppNinjaKiwi.Common.ResourceUtils.PrefabReference](https://docs.microsoft.com/en-us/dotnet/api/Il2CppNinjaKiwi.Common.ResourceUtils.PrefabReference 'Il2CppNinjaKiwi.Common.ResourceUtils.PrefabReference')

<a name='BTD_Mod_Helper.Api.Towers.ModHero.GetBackgroundColor(System.Collections.Generic.Dictionary_string,SkinData_)'></a>

## ModHero.GetBackgroundColor(Dictionary<string,SkinData>) Method

Gets the background color for the default SkinData

```csharp
public virtual Color GetBackgroundColor(System.Collections.Generic.Dictionary<string,SkinData> skinsByName);
```
#### Parameters

<a name='BTD_Mod_Helper.Api.Towers.ModHero.GetBackgroundColor(System.Collections.Generic.Dictionary_string,SkinData_).skinsByName'></a>

`skinsByName` [System.Collections.Generic.Dictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')[Il2CppAssets.Scripts.Data.Skins.SkinData](https://docs.microsoft.com/en-us/dotnet/api/Il2CppAssets.Scripts.Data.Skins.SkinData 'Il2CppAssets.Scripts.Data.Skins.SkinData')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')

Existing hero skins by their skin/tower name

#### Returns
[UnityEngine.Color](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Color 'UnityEngine.Color')

<a name='BTD_Mod_Helper.Api.Towers.ModHero.GetFontMaterial(System.Collections.Generic.Dictionary_string,SkinData_)'></a>

## ModHero.GetFontMaterial(Dictionary<string,SkinData>) Method

Gets the font material for the default SkinData

```csharp
public virtual string GetFontMaterial(System.Collections.Generic.Dictionary<string,SkinData> skinsByName);
```
#### Parameters

<a name='BTD_Mod_Helper.Api.Towers.ModHero.GetFontMaterial(System.Collections.Generic.Dictionary_string,SkinData_).skinsByName'></a>

`skinsByName` [System.Collections.Generic.Dictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')[Il2CppAssets.Scripts.Data.Skins.SkinData](https://docs.microsoft.com/en-us/dotnet/api/Il2CppAssets.Scripts.Data.Skins.SkinData 'Il2CppAssets.Scripts.Data.Skins.SkinData')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')

Existing hero skins by their skin/tower name

#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='BTD_Mod_Helper.Api.Towers.ModHero.GetHeroIndex(System.Collections.Generic.List_HeroDetailsModel_)'></a>

## ModHero.GetHeroIndex(List<HeroDetailsModel>) Method

The index to add this hero at in relation to other heroes

```csharp
public virtual int GetHeroIndex(System.Collections.Generic.List<HeroDetailsModel> heroSet);
```
#### Parameters

<a name='BTD_Mod_Helper.Api.Towers.ModHero.GetHeroIndex(System.Collections.Generic.List_HeroDetailsModel_).heroSet'></a>

`heroSet` [System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[Il2CppAssets.Scripts.Models.TowerSets.HeroDetailsModel](https://docs.microsoft.com/en-us/dotnet/api/Il2CppAssets.Scripts.Models.TowerSets.HeroDetailsModel 'Il2CppAssets.Scripts.Models.TowerSets.HeroDetailsModel')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')

#### Returns
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

<a name='BTD_Mod_Helper.Api.Towers.ModHero.TowerTiers()'></a>

## ModHero.TowerTiers() Method

Heroes tower tiers are always Level-0-0

```csharp
public sealed override System.Collections.Generic.IEnumerable<int[]> TowerTiers();
```

#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')