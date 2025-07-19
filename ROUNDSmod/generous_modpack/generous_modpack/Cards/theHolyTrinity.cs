using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Photon.Pun.Simple;
using UnboundLib;
using UnboundLib.Cards;
using UnityEngine;
using static CardInfoStat;
using static UnityEngine.Random;

namespace GenerousModpack.Cards
{
    class theHolyTrinity : CustomCard
    {
        public override void SetupCard(CardInfo cardInfo, Gun gun, ApplyCardStats cardStats, CharacterStatModifiers statModifiers, Block block)
        {
            gun.projectileColor = Color.magenta;
            block.cdAdd = -3f;
            gun.damage = 3f;
            //Edits values on card itself, which are then applied to the player in `ApplyCardStats`
        }
        public override void OnAddCard(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data, HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats)
        {
            gun.reflects += 12;
            gun.projectielSimulatonSpeed *= 1.4f;
            gunAmmo.reloadTime -= 1f;
            gun.gravity *= 0.5f;
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
            gun.reflects -= 12;
            gun.projectielSimulatonSpeed /= 1.4f;
            gunAmmo.reloadTime += 1f;
            gun.gravity /= 0.5f;
            //Run when the card is removed from the player
        }


        protected override string GetTitle()
        {
            return "The Holy Trinity";
        }
        protected override string GetDescription()
        {
            return "You receive the powers of the Holy Trinity: Nery, Marco and Guglielmo.";
        }
        protected override GameObject GetCardArt()
        {
            return Assets.theHolyTrinityArt;
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
                    stat = "Bounces",
                    amount = "+12",
                    simepleAmount = CardInfoStat.SimpleAmount.notAssigned
                },
                new CardInfoStat()
                {
                    positive = true,
                    stat = "Projectile Speed",
                    amount = "+40%",
                    simepleAmount = CardInfoStat.SimpleAmount.notAssigned
                },
                new CardInfoStat()
                {
                    positive = true,
                    stat = "Reload Time",
                    amount = "-1 second",
                    simepleAmount = CardInfoStat.SimpleAmount.notAssigned
                },
                new CardInfoStat()
                {
                    positive = true,
                    stat = "Block Cooldown",
                    amount = "-3 seconds",
                    simepleAmount = CardInfoStat.SimpleAmount.notAssigned
                },
                new CardInfoStat()
                {
                    positive = true,
                    stat = "Damage",
                    amount = "+200%",
                    simepleAmount = CardInfoStat.SimpleAmount.notAssigned
                }
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
