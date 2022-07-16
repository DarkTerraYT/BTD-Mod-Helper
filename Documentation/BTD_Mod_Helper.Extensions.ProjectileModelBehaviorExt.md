#### [BloonsTD6 Mod Helper](index.md 'index')
### [BTD_Mod_Helper.Extensions](index.md#BTD_Mod_Helper.Extensions 'BTD_Mod_Helper.Extensions')

## ProjectileModelBehaviorExt Class

Behavior Extensions for ProjectileModels

```csharp
public static class ProjectileModelBehaviorExt
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; ProjectileModelBehaviorExt
### Methods

<a name='BTD_Mod_Helper.Extensions.ProjectileModelBehaviorExt.AddBehavior_T_(thisAssets.Scripts.Models.Towers.Projectiles.ProjectileModel,T)'></a>

## ProjectileModelBehaviorExt.AddBehavior<T>(this ProjectileModel, T) Method

(Cross-Game compatible) Add a Behavior to this

```csharp
public static void AddBehavior<T>(this Assets.Scripts.Models.Towers.Projectiles.ProjectileModel model, T behavior)
    where T : Assets.Scripts.Models.Model;
```
#### Type parameters

<a name='BTD_Mod_Helper.Extensions.ProjectileModelBehaviorExt.AddBehavior_T_(thisAssets.Scripts.Models.Towers.Projectiles.ProjectileModel,T).T'></a>

`T`

The Behavior you want to add
#### Parameters

<a name='BTD_Mod_Helper.Extensions.ProjectileModelBehaviorExt.AddBehavior_T_(thisAssets.Scripts.Models.Towers.Projectiles.ProjectileModel,T).model'></a>

`model` [Assets.Scripts.Models.Towers.Projectiles.ProjectileModel](https://docs.microsoft.com/en-us/dotnet/api/Assets.Scripts.Models.Towers.Projectiles.ProjectileModel 'Assets.Scripts.Models.Towers.Projectiles.ProjectileModel')

<a name='BTD_Mod_Helper.Extensions.ProjectileModelBehaviorExt.AddBehavior_T_(thisAssets.Scripts.Models.Towers.Projectiles.ProjectileModel,T).behavior'></a>

`behavior` [T](BTD_Mod_Helper.Extensions.ProjectileModelBehaviorExt.md#BTD_Mod_Helper.Extensions.ProjectileModelBehaviorExt.AddBehavior_T_(thisAssets.Scripts.Models.Towers.Projectiles.ProjectileModel,T).T 'BTD_Mod_Helper.Extensions.ProjectileModelBehaviorExt.AddBehavior<T>(this Assets.Scripts.Models.Towers.Projectiles.ProjectileModel, T).T')

<a name='BTD_Mod_Helper.Extensions.ProjectileModelBehaviorExt.GetBehavior_T_(thisAssets.Scripts.Models.Towers.Projectiles.ProjectileModel)'></a>

## ProjectileModelBehaviorExt.GetBehavior<T>(this ProjectileModel) Method

(Cross-Game compatible) Return the first Behavior of type T

```csharp
public static T GetBehavior<T>(this Assets.Scripts.Models.Towers.Projectiles.ProjectileModel model)
    where T : Assets.Scripts.Models.Model;
```
#### Type parameters

<a name='BTD_Mod_Helper.Extensions.ProjectileModelBehaviorExt.GetBehavior_T_(thisAssets.Scripts.Models.Towers.Projectiles.ProjectileModel).T'></a>

`T`

The Behavior you want
#### Parameters

<a name='BTD_Mod_Helper.Extensions.ProjectileModelBehaviorExt.GetBehavior_T_(thisAssets.Scripts.Models.Towers.Projectiles.ProjectileModel).model'></a>

`model` [Assets.Scripts.Models.Towers.Projectiles.ProjectileModel](https://docs.microsoft.com/en-us/dotnet/api/Assets.Scripts.Models.Towers.Projectiles.ProjectileModel 'Assets.Scripts.Models.Towers.Projectiles.ProjectileModel')

#### Returns
[T](BTD_Mod_Helper.Extensions.ProjectileModelBehaviorExt.md#BTD_Mod_Helper.Extensions.ProjectileModelBehaviorExt.GetBehavior_T_(thisAssets.Scripts.Models.Towers.Projectiles.ProjectileModel).T 'BTD_Mod_Helper.Extensions.ProjectileModelBehaviorExt.GetBehavior<T>(this Assets.Scripts.Models.Towers.Projectiles.ProjectileModel).T')

<a name='BTD_Mod_Helper.Extensions.ProjectileModelBehaviorExt.GetBehaviors_T_(thisAssets.Scripts.Models.Towers.Projectiles.ProjectileModel)'></a>

## ProjectileModelBehaviorExt.GetBehaviors<T>(this ProjectileModel) Method

(Cross-Game compatible) Return all Behaviors of type T

```csharp
public static System.Collections.Generic.List<T> GetBehaviors<T>(this Assets.Scripts.Models.Towers.Projectiles.ProjectileModel model)
    where T : Assets.Scripts.Models.Model;
```
#### Type parameters

<a name='BTD_Mod_Helper.Extensions.ProjectileModelBehaviorExt.GetBehaviors_T_(thisAssets.Scripts.Models.Towers.Projectiles.ProjectileModel).T'></a>

`T`

The Behavior you want
#### Parameters

<a name='BTD_Mod_Helper.Extensions.ProjectileModelBehaviorExt.GetBehaviors_T_(thisAssets.Scripts.Models.Towers.Projectiles.ProjectileModel).model'></a>

`model` [Assets.Scripts.Models.Towers.Projectiles.ProjectileModel](https://docs.microsoft.com/en-us/dotnet/api/Assets.Scripts.Models.Towers.Projectiles.ProjectileModel 'Assets.Scripts.Models.Towers.Projectiles.ProjectileModel')

#### Returns
[System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[T](BTD_Mod_Helper.Extensions.ProjectileModelBehaviorExt.md#BTD_Mod_Helper.Extensions.ProjectileModelBehaviorExt.GetBehaviors_T_(thisAssets.Scripts.Models.Towers.Projectiles.ProjectileModel).T 'BTD_Mod_Helper.Extensions.ProjectileModelBehaviorExt.GetBehaviors<T>(this Assets.Scripts.Models.Towers.Projectiles.ProjectileModel).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')

<a name='BTD_Mod_Helper.Extensions.ProjectileModelBehaviorExt.HasBehavior_T_(thisAssets.Scripts.Models.Towers.Projectiles.ProjectileModel)'></a>

## ProjectileModelBehaviorExt.HasBehavior<T>(this ProjectileModel) Method

(Cross-Game compatible) Check if this has a specific Behavior

```csharp
public static bool HasBehavior<T>(this Assets.Scripts.Models.Towers.Projectiles.ProjectileModel model)
    where T : Assets.Scripts.Models.Model;
```
#### Type parameters

<a name='BTD_Mod_Helper.Extensions.ProjectileModelBehaviorExt.HasBehavior_T_(thisAssets.Scripts.Models.Towers.Projectiles.ProjectileModel).T'></a>

`T`

The Behavior you're checking for
#### Parameters

<a name='BTD_Mod_Helper.Extensions.ProjectileModelBehaviorExt.HasBehavior_T_(thisAssets.Scripts.Models.Towers.Projectiles.ProjectileModel).model'></a>

`model` [Assets.Scripts.Models.Towers.Projectiles.ProjectileModel](https://docs.microsoft.com/en-us/dotnet/api/Assets.Scripts.Models.Towers.Projectiles.ProjectileModel 'Assets.Scripts.Models.Towers.Projectiles.ProjectileModel')

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

<a name='BTD_Mod_Helper.Extensions.ProjectileModelBehaviorExt.HasBehavior_T_(thisAssets.Scripts.Models.Towers.Projectiles.ProjectileModel,T)'></a>

## ProjectileModelBehaviorExt.HasBehavior<T>(this ProjectileModel, T) Method

(Cross-Game compatible) Check if this has a specific Behavior

```csharp
public static bool HasBehavior<T>(this Assets.Scripts.Models.Towers.Projectiles.ProjectileModel model, out T behavior)
    where T : Assets.Scripts.Models.Model;
```
#### Type parameters

<a name='BTD_Mod_Helper.Extensions.ProjectileModelBehaviorExt.HasBehavior_T_(thisAssets.Scripts.Models.Towers.Projectiles.ProjectileModel,T).T'></a>

`T`

The Behavior you're checking for
#### Parameters

<a name='BTD_Mod_Helper.Extensions.ProjectileModelBehaviorExt.HasBehavior_T_(thisAssets.Scripts.Models.Towers.Projectiles.ProjectileModel,T).model'></a>

`model` [Assets.Scripts.Models.Towers.Projectiles.ProjectileModel](https://docs.microsoft.com/en-us/dotnet/api/Assets.Scripts.Models.Towers.Projectiles.ProjectileModel 'Assets.Scripts.Models.Towers.Projectiles.ProjectileModel')

<a name='BTD_Mod_Helper.Extensions.ProjectileModelBehaviorExt.HasBehavior_T_(thisAssets.Scripts.Models.Towers.Projectiles.ProjectileModel,T).behavior'></a>

`behavior` [T](BTD_Mod_Helper.Extensions.ProjectileModelBehaviorExt.md#BTD_Mod_Helper.Extensions.ProjectileModelBehaviorExt.HasBehavior_T_(thisAssets.Scripts.Models.Towers.Projectiles.ProjectileModel,T).T 'BTD_Mod_Helper.Extensions.ProjectileModelBehaviorExt.HasBehavior<T>(this Assets.Scripts.Models.Towers.Projectiles.ProjectileModel, T).T')

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

<a name='BTD_Mod_Helper.Extensions.ProjectileModelBehaviorExt.RemoveBehavior_T_(thisAssets.Scripts.Models.Towers.Projectiles.ProjectileModel)'></a>

## ProjectileModelBehaviorExt.RemoveBehavior<T>(this ProjectileModel) Method

(Cross-Game compatible) Remove the first Behavior of Type T

```csharp
public static void RemoveBehavior<T>(this Assets.Scripts.Models.Towers.Projectiles.ProjectileModel model)
    where T : Assets.Scripts.Models.Model;
```
#### Type parameters

<a name='BTD_Mod_Helper.Extensions.ProjectileModelBehaviorExt.RemoveBehavior_T_(thisAssets.Scripts.Models.Towers.Projectiles.ProjectileModel).T'></a>

`T`

The Behavior you want to remove
#### Parameters

<a name='BTD_Mod_Helper.Extensions.ProjectileModelBehaviorExt.RemoveBehavior_T_(thisAssets.Scripts.Models.Towers.Projectiles.ProjectileModel).model'></a>

`model` [Assets.Scripts.Models.Towers.Projectiles.ProjectileModel](https://docs.microsoft.com/en-us/dotnet/api/Assets.Scripts.Models.Towers.Projectiles.ProjectileModel 'Assets.Scripts.Models.Towers.Projectiles.ProjectileModel')

<a name='BTD_Mod_Helper.Extensions.ProjectileModelBehaviorExt.RemoveBehavior_T_(thisAssets.Scripts.Models.Towers.Projectiles.ProjectileModel,T)'></a>

## ProjectileModelBehaviorExt.RemoveBehavior<T>(this ProjectileModel, T) Method

(Cross-Game compatible) Remove the first Behavior of type T

```csharp
public static void RemoveBehavior<T>(this Assets.Scripts.Models.Towers.Projectiles.ProjectileModel model, T behavior)
    where T : Assets.Scripts.Models.Model;
```
#### Type parameters

<a name='BTD_Mod_Helper.Extensions.ProjectileModelBehaviorExt.RemoveBehavior_T_(thisAssets.Scripts.Models.Towers.Projectiles.ProjectileModel,T).T'></a>

`T`

The Behavior you want to remove
#### Parameters

<a name='BTD_Mod_Helper.Extensions.ProjectileModelBehaviorExt.RemoveBehavior_T_(thisAssets.Scripts.Models.Towers.Projectiles.ProjectileModel,T).model'></a>

`model` [Assets.Scripts.Models.Towers.Projectiles.ProjectileModel](https://docs.microsoft.com/en-us/dotnet/api/Assets.Scripts.Models.Towers.Projectiles.ProjectileModel 'Assets.Scripts.Models.Towers.Projectiles.ProjectileModel')

<a name='BTD_Mod_Helper.Extensions.ProjectileModelBehaviorExt.RemoveBehavior_T_(thisAssets.Scripts.Models.Towers.Projectiles.ProjectileModel,T).behavior'></a>

`behavior` [T](BTD_Mod_Helper.Extensions.ProjectileModelBehaviorExt.md#BTD_Mod_Helper.Extensions.ProjectileModelBehaviorExt.RemoveBehavior_T_(thisAssets.Scripts.Models.Towers.Projectiles.ProjectileModel,T).T 'BTD_Mod_Helper.Extensions.ProjectileModelBehaviorExt.RemoveBehavior<T>(this Assets.Scripts.Models.Towers.Projectiles.ProjectileModel, T).T')

<a name='BTD_Mod_Helper.Extensions.ProjectileModelBehaviorExt.RemoveBehaviors_T_(thisAssets.Scripts.Models.Towers.Projectiles.ProjectileModel)'></a>

## ProjectileModelBehaviorExt.RemoveBehaviors<T>(this ProjectileModel) Method

(Cross-Game compatible) Remove all Behaviors of type T

```csharp
public static void RemoveBehaviors<T>(this Assets.Scripts.Models.Towers.Projectiles.ProjectileModel model)
    where T : Assets.Scripts.Models.Model;
```
#### Type parameters

<a name='BTD_Mod_Helper.Extensions.ProjectileModelBehaviorExt.RemoveBehaviors_T_(thisAssets.Scripts.Models.Towers.Projectiles.ProjectileModel).T'></a>

`T`

The Behavior you want to remove
#### Parameters

<a name='BTD_Mod_Helper.Extensions.ProjectileModelBehaviorExt.RemoveBehaviors_T_(thisAssets.Scripts.Models.Towers.Projectiles.ProjectileModel).model'></a>

`model` [Assets.Scripts.Models.Towers.Projectiles.ProjectileModel](https://docs.microsoft.com/en-us/dotnet/api/Assets.Scripts.Models.Towers.Projectiles.ProjectileModel 'Assets.Scripts.Models.Towers.Projectiles.ProjectileModel')