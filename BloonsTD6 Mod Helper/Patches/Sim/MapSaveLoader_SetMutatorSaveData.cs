using System;
using System.Collections.Generic;
using BTD_Mod_Helper.Api.Towers;
using Il2CppAssets.Scripts.Models.Profile;
using Il2CppAssets.Scripts.Simulation;
using Il2CppAssets.Scripts.Simulation.Objects;
using Il2CppAssets.Scripts.Utils;
using Il2CppSystem.Linq;

namespace BTD_Mod_Helper.Patches.Sim;

[HarmonyPatch(typeof(MapSaveLoader), nameof(MapSaveLoader.SetMutatorSaveData))]
internal static class MapSaveLoader_SetMutatorSaveData
{
    [HarmonyPostfix]
    internal static void Postfix(Simulation sim, MapSaveDataModel mapSaveDataModel)
    {
        Dictionary<uint, Mutable> mutables = null;

        foreach (var (id, mutators) in mapSaveDataModel.activeMutators)
        {
            if (!ModMutator.Cache.TryGetValue(id, out var modMutator) || !modMutator.Saved) continue;

            mutables ??= GetMutablesById(sim);

            foreach (var mutatorSaveDataModel in mutators)
            {
                try
                {
                    if (!mutables.TryGetValue(mutatorSaveDataModel.towerId.data, out var mutable))
                    {
                        ModHelper.Warning(
                            $"Couldn't find entity {mutatorSaveDataModel.towerId} to load ModMutator {modMutator.Id} onto");
                        continue;
                    }

                    modMutator.LoadMutator(mutable, mutatorSaveDataModel);
                }
                catch (Exception e)
                {
                    ModHelper.Warning($"Failed to load ModMutator {modMutator.Id}");
                    ModHelper.Warning(e);
                }
            }
        }
    }

    private static Dictionary<uint, Mutable> GetMutablesById(Simulation sim)
    {
        var mutables = new Dictionary<uint, Mutable>();
        foreach (var mutable in sim.factory.Get<Mutable>().ToArray())
        {
            mutables[mutable.Id.data] = mutable;
        }
        return mutables;
    }
}
