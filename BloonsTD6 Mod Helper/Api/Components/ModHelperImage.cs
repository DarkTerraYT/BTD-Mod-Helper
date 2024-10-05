﻿using System;
using UnityEngine;
using UnityEngine.UI;
namespace BTD_Mod_Helper.Api.Components;

/// <summary>
/// ModHelperComponent for an image element
/// </summary>
[RegisterTypeInIl2Cpp(false)]
public class ModHelperImage : ModHelperComponent
{

    /// <inheritdoc />
    public ModHelperImage(IntPtr ptr) : base(ptr)
    {
    }

    /// <summary>
    /// The Image being displayed
    /// </summary>
    public Image Image => GetComponent<Image>();


    /// <summary>
    /// Creates a new ModHelperImage
    /// </summary>
    /// <param name="info">The name/position/size info</param>
    /// <param name="sprite">The sprite to display</param>
    /// <returns>The created ModHelperImage</returns>
    public static ModHelperImage Create(Info info, string sprite)
    {
        var modHelperImage = Create<ModHelperImage>(info);

        var image = modHelperImage.AddComponent<Image>();
        if (sprite != null)
        {
            image.SetSprite(sprite);
        }
        else
        {
            image.enabled = false;
        }

        return modHelperImage;
    }

    /// <summary>
    /// Creates a new ModHelperImage
    /// </summary>
    /// <param name="info">The name/position/size info</param>
    /// <param name="sprite">The sprite to display</param>
    /// <returns>The created ModHelperImage</returns>
    public static ModHelperImage Create(Info info, Sprite sprite)
    {
        var modHelperImage = Create<ModHelperImage>(info);

        var image = modHelperImage.AddComponent<Image>();
        if (sprite != null)
        {
            image.SetSprite(sprite);
        }

        return modHelperImage;
    }
}