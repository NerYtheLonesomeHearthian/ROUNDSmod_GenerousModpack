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
    class joe : CustomCard
    {
        public override void SetupCard(CardInfo cardInfo, Gun gun, ApplyCardStats cardStats, CharacterStatModifiers statModifiers, Block block)
        {
            block.cdMultiplier = 0.5f;
            block.additionalBlocks = 3;
            gun.ammo = 3;
            //Edits values on card itself, which are then applied to the player in `ApplyCardStats`
        }
        public override void OnAddCard(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data, HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats)
        {
            data.maxHealth *= 1.5f;
            characterStats.movementSpeed *= 1.5f;
            gun.gravity *= 0.5f;
            gun.projectileSpeed *= 1.5f;
            gun.projectielSimulatonSpeed *= 1.5f;
            if (gun.size <= 0f)
            {
                gun.size += 0.5f;
            }
            else
            {
                gun.size *= 1.5f;
            }
            gun.spread *= 0.5f;
            gun.evenSpread *= 0.85f;
            gun.damage *= 1.5f;
            gun.damageAfterDistanceMultiplier *= 1.5f;
            gun.dmgMOnBounce *= 1.5f;
            if (gun.slow <= 0f)
            {
                gun.slow += 0.5f;
            }
            else
            {
                gun.slow *= 1.5f;
            }
            gun.attackSpeed *= 0.5f;
            gun.knockback *= 1.5f;
            gun.destroyBulletAfter *= 1.5f;
            gravity.gravityForce *= 0.5f;
            if (characterStats.lifeSteal == 0f)
            {
                characterStats.lifeSteal += 0.5f;
            }
            else
            {
                characterStats.lifeSteal *= 1.5f;
            }
            gunAmmo.reloadTimeMultiplier *= 0.5f;
            //Edits values on player when card is selected
        }
        public override void OnRemoveCard(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data, HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats)
        {
            //Run when the card is removed from the player
        }


        protected override string GetTitle()
        {
            return "Clown God";
        }
        protected override string GetDescription()
        {
            return "Gabbo reference?";
        }
        protected override GameObject GetCardArt()
        {
            return null;
        }
        protected override CardInfo.Rarity GetRarity()
        {
            return RarityBundle.Rarities.Mythical;
        }
        protected override CardInfoStat[] GetStats()
        {
            return new CardInfoStat[]
            {
                new CardInfoStat()
                {
                    positive = true,
                    stat = "All positive stats",
                    amount = "+50%",
                    simepleAmount = CardInfoStat.SimpleAmount.notAssigned
                },
                new CardInfoStat()
                {
                    positive = true,
                    stat = "All negative stats",
                    amount = "-50%",
                    simepleAmount = CardInfoStat.SimpleAmount.notAssigned
                },
                new CardInfoStat()
                {
                    positive = true,
                    stat = "Bullets",
                    amount = "+3",
                    simepleAmount = CardInfoStat.SimpleAmount.notAssigned
                },new CardInfoStat()
                {
                    positive = true,
                    stat = "Blocks",
                    amount = "+3",
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
