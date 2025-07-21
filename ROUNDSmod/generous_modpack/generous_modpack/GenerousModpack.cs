using BepInEx;
using UnboundLib;
using UnboundLib.Cards;
using GenerousModpack.Cards;
using HarmonyLib;
using CardChoiceSpawnUniqueCardPatch.CustomCategories;


namespace GenerousModpack
{
    // These are the mods required for our mod to work
    [BepInDependency("com.willis.rounds.unbound", BepInDependency.DependencyFlags.HardDependency)]
    [BepInDependency("pykess.rounds.plugins.moddingutils", BepInDependency.DependencyFlags.HardDependency)]
    [BepInDependency("pykess.rounds.plugins.cardchoicespawnuniquecardpatch", BepInDependency.DependencyFlags.HardDependency)]
    // Declares our mod to Bepin
    [BepInPlugin("com.NerYtheLonesomeHearthian.GenerousModpack", "Generous Modpack", "1.0.0")]
    // The game our mod is associated with
    [BepInProcess("Rounds.exe")]
    public class GenerousModpack : BaseUnityPlugin
    {
        private const string ModId = "com.NerYtheLonesomeHearthian.GenerousModpack";
        private const string ModName = "Generous Modpack";
        public const string Version = "1.6.0"; // What version are we on (major.minor.patch)?
        public const string ModInitials = "GM";


        void Awake()
        {
            // Use this to call any harmony patch files your mod may have
            var harmony = new Harmony(ModId);
            harmony.PatchAll();
        }
        void Start()
        {
            CustomCard.BuildCard<plus200damage>();
            CustomCard.BuildCard<gino>();
            CustomCard.BuildCard<GodOfBlocks>();
            CustomCard.BuildCard<joe>();
            CustomCard.BuildCard<slowestDeath>();
            CustomCard.BuildCard<superSpray>();
            CustomCard.BuildCard<lavaRain>();
            CustomCard.BuildCard<invertedShower>();
            CustomCard.BuildCard<theOneWhoTricks>();
            CustomCard.BuildCard<CancroMobile>();
            CustomCard.BuildCard<theHolyTrinity>();
            CustomCard.BuildCard<DemigodOfBlocks>();
        }
    }
}