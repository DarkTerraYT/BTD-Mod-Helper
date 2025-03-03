﻿using System;
using Il2CppAssets.Scripts.Models;
using Il2CppAssets.Scripts.Models.Gameplay.Mods;
using Il2CppAssets.Scripts.Unity.UI_New.InGame;
using Il2CppSystem.Collections.Generic;
namespace BTD_Mod_Helper.Api.Helpers;

/// <summary>
/// Helper for scaling costs to difficulties
/// </summary>
public static class CostHelper
{
    /// <summary>
    /// Gets a modified cost for a given set of ModModels that are used to setup a match
    /// Somewhere deep within those mods is likely to be a Cost modifier, and this will find and apply that
    /// </summary>
    /// <param name="cost">The default cost</param>
    /// <param name="mods">The mods that the match is using</param>
    /// <returns>The modified cost</returns>
    public static int CostForDifficulty(int cost, List<ModModel> mods)
    {
        var mult = 1f;
        foreach (var gameModelMod in mods)
        {
            if (gameModelMod.mutatorMods != null)
            {
                foreach (var mutatorModModel in gameModelMod.mutatorMods)
                {
                    if (mutatorModModel != null && mutatorModModel.IsType<GlobalCostModModel>())
                    {
                        var mod = mutatorModModel.Cast<GlobalCostModModel>();
                        mult = mod.multiplier;
                    }
                }
            }
        }

        return CostForDifficulty(cost, mult);
    }

    /// <summary>
    /// Gets a modified cost for a given GameModel's difficulty
    /// </summary>
    /// <param name="cost">The default cost</param>
    /// <param name="gameModel">The current GameModel</param>
    /// <returns>The modified cost</returns>
    public static int CostForDifficulty(int cost, GameModel gameModel)
    {
        var difficulty = $"{gameModel.difficultyId}";
        if (string.IsNullOrEmpty(difficulty))
        {
            ModHelper.Warning("Difficulty cannot be determined at this stage of creating the GameModel");
            ModHelper.Warning("Use the list of ModModels to find the difficulty instead");
        }

        return CostForDifficulty(cost, gameModel.difficultyId);
    }

    /// <summary>
    /// Gets a modified cost for a given instance of InGame
    /// </summary>
    /// <param name="cost">The default cost</param>
    /// <param name="inGame">Current instance of InGame</param>
    /// <returns>The modified cost</returns>
    public static int CostForDifficulty(int cost, InGame inGame) => CostForDifficulty(cost, inGame.SelectedDifficulty);

    /// <summary>
    /// Scales a base (medium) cost to the given difficulty
    /// </summary>
    public static int CostForDifficulty(int cost, string difficulty)
    {
        switch (difficulty)
        {
            case "Easy":
                return CostForDifficulty(cost, .85f);
            case "Hard":
                return CostForDifficulty(cost, 1.08f);
            case "Impoppable":
                return CostForDifficulty(cost, 1.2f);
            default:
                return cost;
        }
    }

    /// <summary>
    /// Applies a multiplier to a cost and rounds it
    /// </summary>
    public static int CostForDifficulty(int cost, float multiplier)
    {
        var price = cost * multiplier;
        return (int) (5 * Math.Round(price / 5));
    }
}