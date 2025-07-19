using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnboundLib;
using UnboundLib.Cards;
using UnityEngine;

namespace GenerousModpack.Cards
{
    class theOneWhoTricks : CustomCard
    {
        public override void SetupCard(CardInfo cardInfo, Gun gun, ApplyCardStats cardStats, CharacterStatModifiers statModifiers, Block block)
        {
            //Edits values on card itself, which are then applied to the player in `ApplyCardStats`
        }
        public override void OnAddCard(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data, HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats)
        {
            gun.dmgMOnBounce *= 2.5f;
            gun.reflects += 5;
            gun.damage *= 1.2f;
            ObjectsToSpawn objectsToSpawn = ((GameObject)Resources.Load("0 cards/Mayhem")).GetComponent<Gun>().objectsToSpawn[0];

            List<ObjectsToSpawn> list = gun.objectsToSpawn.ToList();
            list.Add(
                objectsToSpawn
            );


            gun.objectsToSpawn = list.ToArray();
            //Edits values on player when card is selected
        }
        public override void OnRemoveCard(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data, HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats)
        {
            gun.dmgMOnBounce /= 2.5f;
            gun.reflects -= 5;
            gun.damage /= 1.2f;
            //Run when the card is removed from the player
        }


        protected override string GetTitle()
        {
            return "The One who Tricks the World";
        }
        protected override string GetDescription()
        {
            return "The master of Trickster.";
        }
        protected override GameObject GetCardArt()
        {
            return Assets.theOneWhoTricksTheWorldArt;
        }
        protected override CardInfo.Rarity GetRarity()
        {
            return RarityBundle.Rarities.Legendary;
        }
        protected override CardInfoStat[] GetStats()
        {
            return new CardInfoStat[]
            {
                new CardInfoStat()
                {
                    positive = true,
                    stat = "Damage per Bounce",
                    amount = "+150%",
                    simepleAmount = CardInfoStat.SimpleAmount.notAssigned
                },
                new CardInfoStat()
                {
                    positive = true,
                    stat = "Bounces",
                    amount = "+5",
                    simepleAmount = CardInfoStat.SimpleAmount.notAssigned
                },
            };
        }
        protected override CardThemeColor.CardThemeColorType GetTheme()
        {
            return CardThemeColor.CardThemeColorType.ColdBlue;
        }
        public override string GetModName()
        {
            return "GM";
        }
    }
}