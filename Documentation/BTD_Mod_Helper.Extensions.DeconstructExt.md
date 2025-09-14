#### [BloonsTD6 Mod Helper](README.md 'README')
### [BTD_Mod_Helper.Extensions](README.md#BTD_Mod_Helper.Extensions 'BTD_Mod_Helper.Extensions')

## DeconstructExt Class

Adding more deconstruct methods to things

```csharp
public static class DeconstructExt
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; DeconstructExt
### Methods

<a name='BTD_Mod_Helper.Extensions.DeconstructExt.Deconstruct(thisRect,float,float,float,float)'></a>

## DeconstructExt.Deconstruct(this Rect, float, float, float, float) Method

Deconstruct a rectangle

```csharp
public static void Deconstruct(this Rect rect, out float x, out float y, out float width, out float height);
```
#### Parameters

<a name='BTD_Mod_Helper.Extensions.DeconstructExt.Deconstruct(thisRect,float,float,float,float).rect'></a>

`rect` [UnityEngine.Rect](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Rect 'UnityEngine.Rect')

<a name='BTD_Mod_Helper.Extensions.DeconstructExt.Deconstruct(thisRect,float,float,float,float).x'></a>

`x` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')

<a name='BTD_Mod_Helper.Extensions.DeconstructExt.Deconstruct(thisRect,float,float,float,float).y'></a>

`y` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')

<a name='BTD_Mod_Helper.Extensions.DeconstructExt.Deconstruct(thisRect,float,float,float,float).width'></a>

`width` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')

<a name='BTD_Mod_Helper.Extensions.DeconstructExt.Deconstruct(thisRect,float,float,float,float).height'></a>

`height` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')

<a name='BTD_Mod_Helper.Extensions.DeconstructExt.Deconstruct(thisVector2,float,float)'></a>

## DeconstructExt.Deconstruct(this Vector2, float, float) Method

For some reason the normal deconstruct isn't accessible in all places?

```csharp
public static void Deconstruct(this Vector2 vector2, out float x, out float y);
```
#### Parameters

<a name='BTD_Mod_Helper.Extensions.DeconstructExt.Deconstruct(thisVector2,float,float).vector2'></a>

`vector2` [UnityEngine.Vector2](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Vector2 'UnityEngine.Vector2')

<a name='BTD_Mod_Helper.Extensions.DeconstructExt.Deconstruct(thisVector2,float,float).x'></a>

`x` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')

<a name='BTD_Mod_Helper.Extensions.DeconstructExt.Deconstruct(thisVector2,float,float).y'></a>

`y` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')

<a name='BTD_Mod_Helper.Extensions.DeconstructExt.Deconstruct_T_(thisT[],T,T)'></a>

## DeconstructExt.Deconstruct<T>(this T[], T, T) Method

Deconstruct arrays

```csharp
public static void Deconstruct<T>(this T[] array, out T first, out T second);
```
#### Type parameters

<a name='BTD_Mod_Helper.Extensions.DeconstructExt.Deconstruct_T_(thisT[],T,T).T'></a>

`T`
#### Parameters

<a name='BTD_Mod_Helper.Extensions.DeconstructExt.Deconstruct_T_(thisT[],T,T).array'></a>

`array` [T](BTD_Mod_Helper.Extensions.DeconstructExt.md#BTD_Mod_Helper.Extensions.DeconstructExt.Deconstruct_T_(thisT[],T,T).T 'BTD_Mod_Helper.Extensions.DeconstructExt.Deconstruct<T>(this T[], T, T).T')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')

<a name='BTD_Mod_Helper.Extensions.DeconstructExt.Deconstruct_T_(thisT[],T,T).first'></a>

`first` [T](BTD_Mod_Helper.Extensions.DeconstructExt.md#BTD_Mod_Helper.Extensions.DeconstructExt.Deconstruct_T_(thisT[],T,T).T 'BTD_Mod_Helper.Extensions.DeconstructExt.Deconstruct<T>(this T[], T, T).T')

<a name='BTD_Mod_Helper.Extensions.DeconstructExt.Deconstruct_T_(thisT[],T,T).second'></a>

`second` [T](BTD_Mod_Helper.Extensions.DeconstructExt.md#BTD_Mod_Helper.Extensions.DeconstructExt.Deconstruct_T_(thisT[],T,T).T 'BTD_Mod_Helper.Extensions.DeconstructExt.Deconstruct<T>(this T[], T, T).T')

<a name='BTD_Mod_Helper.Extensions.DeconstructExt.Deconstruct_T_(thisT[],T,T,T)'></a>

## DeconstructExt.Deconstruct<T>(this T[], T, T, T) Method

Deconstruct arrays

```csharp
public static void Deconstruct<T>(this T[] array, out T first, out T second, out T third);
```
#### Type parameters

<a name='BTD_Mod_Helper.Extensions.DeconstructExt.Deconstruct_T_(thisT[],T,T,T).T'></a>

`T`
#### Parameters

<a name='BTD_Mod_Helper.Extensions.DeconstructExt.Deconstruct_T_(thisT[],T,T,T).array'></a>

`array` [T](BTD_Mod_Helper.Extensions.DeconstructExt.md#BTD_Mod_Helper.Extensions.DeconstructExt.Deconstruct_T_(thisT[],T,T,T).T 'BTD_Mod_Helper.Extensions.DeconstructExt.Deconstruct<T>(this T[], T, T, T).T')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')

<a name='BTD_Mod_Helper.Extensions.DeconstructExt.Deconstruct_T_(thisT[],T,T,T).first'></a>

`first` [T](BTD_Mod_Helper.Extensions.DeconstructExt.md#BTD_Mod_Helper.Extensions.DeconstructExt.Deconstruct_T_(thisT[],T,T,T).T 'BTD_Mod_Helper.Extensions.DeconstructExt.Deconstruct<T>(this T[], T, T, T).T')

<a name='BTD_Mod_Helper.Extensions.DeconstructExt.Deconstruct_T_(thisT[],T,T,T).second'></a>

`second` [T](BTD_Mod_Helper.Extensions.DeconstructExt.md#BTD_Mod_Helper.Extensions.DeconstructExt.Deconstruct_T_(thisT[],T,T,T).T 'BTD_Mod_Helper.Extensions.DeconstructExt.Deconstruct<T>(this T[], T, T, T).T')

<a name='BTD_Mod_Helper.Extensions.DeconstructExt.Deconstruct_T_(thisT[],T,T,T).third'></a>

`third` [T](BTD_Mod_Helper.Extensions.DeconstructExt.md#BTD_Mod_Helper.Extensions.DeconstructExt.Deconstruct_T_(thisT[],T,T,T).T 'BTD_Mod_Helper.Extensions.DeconstructExt.Deconstruct<T>(this T[], T, T, T).T')

<a name='BTD_Mod_Helper.Extensions.DeconstructExt.Deconstruct_T_(thisT[],T,T,T,T)'></a>

## DeconstructExt.Deconstruct<T>(this T[], T, T, T, T) Method

Deconstruct arrays

```csharp
public static void Deconstruct<T>(this T[] array, out T first, out T second, out T third, out T fourth);
```
#### Type parameters

<a name='BTD_Mod_Helper.Extensions.DeconstructExt.Deconstruct_T_(thisT[],T,T,T,T).T'></a>

`T`
#### Parameters

<a name='BTD_Mod_Helper.Extensions.DeconstructExt.Deconstruct_T_(thisT[],T,T,T,T).array'></a>

`array` [T](BTD_Mod_Helper.Extensions.DeconstructExt.md#BTD_Mod_Helper.Extensions.DeconstructExt.Deconstruct_T_(thisT[],T,T,T,T).T 'BTD_Mod_Helper.Extensions.DeconstructExt.Deconstruct<T>(this T[], T, T, T, T).T')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')

<a name='BTD_Mod_Helper.Extensions.DeconstructExt.Deconstruct_T_(thisT[],T,T,T,T).first'></a>

`first` [T](BTD_Mod_Helper.Extensions.DeconstructExt.md#BTD_Mod_Helper.Extensions.DeconstructExt.Deconstruct_T_(thisT[],T,T,T,T).T 'BTD_Mod_Helper.Extensions.DeconstructExt.Deconstruct<T>(this T[], T, T, T, T).T')

<a name='BTD_Mod_Helper.Extensions.DeconstructExt.Deconstruct_T_(thisT[],T,T,T,T).second'></a>

`second` [T](BTD_Mod_Helper.Extensions.DeconstructExt.md#BTD_Mod_Helper.Extensions.DeconstructExt.Deconstruct_T_(thisT[],T,T,T,T).T 'BTD_Mod_Helper.Extensions.DeconstructExt.Deconstruct<T>(this T[], T, T, T, T).T')

<a name='BTD_Mod_Helper.Extensions.DeconstructExt.Deconstruct_T_(thisT[],T,T,T,T).third'></a>

`third` [T](BTD_Mod_Helper.Extensions.DeconstructExt.md#BTD_Mod_Helper.Extensions.DeconstructExt.Deconstruct_T_(thisT[],T,T,T,T).T 'BTD_Mod_Helper.Extensions.DeconstructExt.Deconstruct<T>(this T[], T, T, T, T).T')

<a name='BTD_Mod_Helper.Extensions.DeconstructExt.Deconstruct_T_(thisT[],T,T,T,T).fourth'></a>

`fourth` [T](BTD_Mod_Helper.Extensions.DeconstructExt.md#BTD_Mod_Helper.Extensions.DeconstructExt.Deconstruct_T_(thisT[],T,T,T,T).T 'BTD_Mod_Helper.Extensions.DeconstructExt.Deconstruct<T>(this T[], T, T, T, T).T')

<a name='BTD_Mod_Helper.Extensions.DeconstructExt.Deconstruct_T1,T2_(thisSystem.Collections.Generic.KeyValuePair_T1,T2_,T1,T2)'></a>

## DeconstructExt.Deconstruct<T1,T2>(this KeyValuePair<T1,T2>, T1, T2) Method

For some reason the normal deconstruct isn't accessible in all places?

```csharp
public static void Deconstruct<T1,T2>(this System.Collections.Generic.KeyValuePair<T1,T2> kvp, out T1 t1, out T2 t2);
```
#### Type parameters

<a name='BTD_Mod_Helper.Extensions.DeconstructExt.Deconstruct_T1,T2_(thisSystem.Collections.Generic.KeyValuePair_T1,T2_,T1,T2).T1'></a>

`T1`

<a name='BTD_Mod_Helper.Extensions.DeconstructExt.Deconstruct_T1,T2_(thisSystem.Collections.Generic.KeyValuePair_T1,T2_,T1,T2).T2'></a>

`T2`
#### Parameters

<a name='BTD_Mod_Helper.Extensions.DeconstructExt.Deconstruct_T1,T2_(thisSystem.Collections.Generic.KeyValuePair_T1,T2_,T1,T2).kvp'></a>

`kvp` [System.Collections.Generic.KeyValuePair&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')[T1](BTD_Mod_Helper.Extensions.DeconstructExt.md#BTD_Mod_Helper.Extensions.DeconstructExt.Deconstruct_T1,T2_(thisSystem.Collections.Generic.KeyValuePair_T1,T2_,T1,T2).T1 'BTD_Mod_Helper.Extensions.DeconstructExt.Deconstruct<T1,T2>(this System.Collections.Generic.KeyValuePair<T1,T2>, T1, T2).T1')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')[T2](BTD_Mod_Helper.Extensions.DeconstructExt.md#BTD_Mod_Helper.Extensions.DeconstructExt.Deconstruct_T1,T2_(thisSystem.Collections.Generic.KeyValuePair_T1,T2_,T1,T2).T2 'BTD_Mod_Helper.Extensions.DeconstructExt.Deconstruct<T1,T2>(this System.Collections.Generic.KeyValuePair<T1,T2>, T1, T2).T2')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')

<a name='BTD_Mod_Helper.Extensions.DeconstructExt.Deconstruct_T1,T2_(thisSystem.Collections.Generic.KeyValuePair_T1,T2_,T1,T2).t1'></a>

`t1` [T1](BTD_Mod_Helper.Extensions.DeconstructExt.md#BTD_Mod_Helper.Extensions.DeconstructExt.Deconstruct_T1,T2_(thisSystem.Collections.Generic.KeyValuePair_T1,T2_,T1,T2).T1 'BTD_Mod_Helper.Extensions.DeconstructExt.Deconstruct<T1,T2>(this System.Collections.Generic.KeyValuePair<T1,T2>, T1, T2).T1')

<a name='BTD_Mod_Helper.Extensions.DeconstructExt.Deconstruct_T1,T2_(thisSystem.Collections.Generic.KeyValuePair_T1,T2_,T1,T2).t2'></a>

`t2` [T2](BTD_Mod_Helper.Extensions.DeconstructExt.md#BTD_Mod_Helper.Extensions.DeconstructExt.Deconstruct_T1,T2_(thisSystem.Collections.Generic.KeyValuePair_T1,T2_,T1,T2).T2 'BTD_Mod_Helper.Extensions.DeconstructExt.Deconstruct<T1,T2>(this System.Collections.Generic.KeyValuePair<T1,T2>, T1, T2).T2')