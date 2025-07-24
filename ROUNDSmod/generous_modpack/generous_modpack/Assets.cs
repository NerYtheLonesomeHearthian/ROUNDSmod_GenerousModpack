using System;
using System.Collections.Generic;
using System.Text;
using BepInEx;
using UnboundLib;
using UnboundLib.Cards;
using HarmonyLib;
using CardChoiceSpawnUniqueCardPatch.CustomCategories;
using Jotunn.Utils;
using UnityEngine;

namespace GenerousModpack
{
    internal class Assets
    {
        private static readonly AssetBundle Bundle = Jotunn.Utils.AssetUtils.LoadAssetBundleFromResources("cardsimages_afterplus200dmg", typeof(GenerousModpack).Assembly);

        public static GameObject plus200damageArt = Bundle.LoadAsset<GameObject>("C_plus200damage");
        public static GameObject CancroMobileArt = Bundle.LoadAsset<GameObject>("C_CancroMobile");
        public static GameObject theOneWhoTricksTheWorldArt = Bundle.LoadAsset<GameObject>("C_theOneWhoTricksTheWorld");
        public static GameObject LavaRainArt = Bundle.LoadAsset<GameObject>("C_LavaRain");
        public static GameObject CuginosPowerArt = Bundle.LoadAsset<GameObject>("C_CuginosPower");
        public static GameObject GodOfBlockArt = Bundle.LoadAsset<GameObject>("C_GodOfBlocks");
        public static GameObject theHolyTrinityArt = Bundle.LoadAsset<GameObject>("C_theHolyTrinity");
        public static GameObject demigodOfBlocksArt = Bundle.LoadAsset<GameObject>("C_demigodOfBlocks");


    }
}