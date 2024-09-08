﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using BTD_Mod_Helper.Api.Data;
using BTD_Mod_Helper.Api.Internal;
using BTD_Mod_Helper.Api.ModOptions;
namespace BTD_Mod_Helper.Api;

/// <summary>
/// ModContent serves two major purposes:
/// <br />
/// 1. It is a base class for things that needs to be loaded via reflection from mods and given Ids,
///     such as ModTower and ModUpgrade
/// <br />
/// 2. It is a utility class with methods to access instances of those classes and other resources
/// </summary>
public abstract partial class ModContent : IModContent, IComparable<ModContent>
{
    private const BindingFlags ConstructorFlags = BindingFlags.Instance |
                                                  BindingFlags.Public |
                                                  BindingFlags.NonPublic;

    internal const string HijackSpriteAtlas = "Ui";


    internal readonly Stack<Action> rollbackActions = new();

    /// <summary>
    /// The BloonsTD6Mod that this content was added by
    /// </summary>
    public BloonsMod mod;

    /// <summary>
    /// The name that will be at the end of the ID for this ModContent, by default the class name
    /// </summary>
    public virtual string Name => GetType().Name;

    /// <summary>
    /// The id that this ModContent will be given; a combination of the Mod's prefix and the name
    /// </summary>
    public string Id => ID;

    /// <summary>
    /// Backing property for ID that's only able to be overriden internally
    /// </summary>
    private protected virtual string ID => GetId(mod, Name);

    /// <summary>
    /// Used to allow some ModContent to Register before or after others
    /// </summary>
    /// <exclude />
    protected virtual float RegistrationPriority => 5f;

    /// <summary>
    /// The order that this ModContent will be loaded/registered in by Mod Helper.
    /// Useful for changing the ordering that it will appear in in-game relative to other content of this type in your mod,
    /// or for making certain content load before others like may be necessary for sub-towers.
    /// Default/0 will use arbitrary ordering.
    /// </summary>
    protected virtual int Order => 0;

    /// <summary>
    /// How many of this ModContent should it try to register in each frame. Higher numbers could lead to faster but choppier
    /// loading.
    /// </summary>
    /// <exclude />
    public virtual int RegisterPerFrame => 20;

    #region IComparable<ModContent> Members

    /// <inheritdoc />
    public virtual int CompareTo(ModContent other)
    {
        var compareTo = Order.CompareTo(other.Order);
        if (compareTo == 0)
        {
            compareTo = mod.Priority.CompareTo(other.mod.Priority);
        }
        if (compareTo == 0)
        {
            compareTo = string.Compare(Id, other.Id, StringComparison.Ordinal);
        }
        if (compareTo == 0)
        {
            compareTo = GetHashCode().CompareTo(other.GetHashCode());
        }
        return compareTo;
    }

    #endregion

    /// <summary>
    /// Used for when you want to programmatically create multiple instances of a given ModContent
    /// </summary>
    /// <returns></returns>
    /// <exclude />
    public virtual IEnumerable<ModContent> Load()
    {
        yield return this;
    }

    /// <summary>
    /// Registers this ModContent into the game
    /// </summary>
    /// <exclude />
    public abstract void Register();


    internal static void LoadModContent(BloonsMod mod)
    {
        mod.Content = AccessTools.GetTypesFromAssembly(mod.GetAssembly())
            .Where(CanLoadType)
            .Select(type => CreateInstance(type, mod))
            .Where(content => content != null)
            .OrderBy(content => content.RegistrationPriority)
            .ThenBy(content => content.Order)
            .SelectMany(Load)
            .OrderBy(content => content.RegistrationPriority)
            .ThenBy(content => content.Order)
            .ToList();
    }

    private static bool CanLoadType(Type type) => !type.IsAbstract &&
                                                  !type.ContainsGenericParameters &&
                                                  typeof(ModContent).IsAssignableFrom(type) &&
                                                  type.GetConstructor(ConstructorFlags, null, Type.EmptyTypes, null) != null;

    private static ModContent CreateInstance(Type type, BloonsMod mod)
    {
        ModContent instance;
        try
        {
            instance = (ModContent) Activator.CreateInstance(type)!;
            instance.mod = mod;
            ModContentInstances.AddInstance(type, instance);
        }
        catch (Exception e)
        {
            ModHelper.Error($"Error creating default {type.Name}");
            ModHelper.Error("A zero argument constructor is REQUIRED for all ModContent classes");
            ModHelper.Error(e);
            return null;
        }

        return instance;
    }

    /// <summary>
    /// Creates the Instances of a ModContent type within a Mod and adds them to ModContentInstances
    /// </summary>
    private static IEnumerable<ModContent> Load(ModContent instance)
    {
        var type = instance.GetType();
        var content = new List<ModContent>();
        try
        {
            content.AddRange(instance.Load());
            var instances = new List<ModContent>();
            foreach (var modContent in content)
            {
                modContent.mod = instance.mod;
                if (instance.GetType().IsInstanceOfType(modContent))
                {
                    instances.Add(modContent);
                }

                if (modContent is IModSettings modSettings)
                {
                    ModSettingsHandler.CreateModSettings(modSettings, modContent.mod);
                }
            }

            ModContentInstances.AddInstances(type, instances);
        }
        catch (Exception e)
        {
            ModHelper.Error(
                $"Failed loading instances of type {type.Name} for mod {type.Assembly.GetName().Name}");
            ModHelper.Error(e);
        }

        return content;
    }



    /// <summary>
    /// Gets all loaded ModContent objects that are T or a subclass of T
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static List<T> GetContent<T>() where T : ModContent => ModHelper.Mods
        .SelectMany(bloonsMod => bloonsMod.Content)
        .OfType<T>()
        .ToList();

    /// <summary>
    /// Gets all loaded ModContent objects that are exactly of type T
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static List<T> GetInstances<T>() where T : ModContent => ModContentInstance<T>.Instances;

    /// <summary>
    /// Finds the loaded ModContent with the given Id and type T
    /// </summary>
    /// <param name="id"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static T Find<T>(string id) where T : ModContent => GetContent<T>().Find(content => content.Id == id);

    /// <inheritdoc cref="Find{T}(string)" />
    public static bool TryFind<T>(string id, out T result) where T : ModContent
    {
        result = Find<T>(id);
        return result != default;
    }

    internal int GetOrder() => Order;
}