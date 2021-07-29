using System;

using HarmonyLib;
using RimWorld;
using Verse;

namespace ReasonablePyromania
{
    public class ReasonablePyromania
    {
        public static JobDef RunRandom;
    }

    public class ReasonablePyromaniaPatcher
    {
        public static void DoPatching()
        {
            var harmony = new Harmony("theonly8z.reasonablepyromania");
            //harmony.PatchAll();
        }
    }
}