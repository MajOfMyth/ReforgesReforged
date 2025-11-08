using System.Collections.Generic;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace ReforgesReforged.Content.Prefixes.Weapons
{
    public class Solitary : ModPrefix
    {

        public override PrefixCategory Category => PrefixCategory.Melee;

        public override float RollChance(Item item)
        {
            return 1f;
        }

        public override bool CanRoll(Item item)
        {
            if (item.DamageType == DamageClass.Melee) return false;
            return true;
        }

        public override void SetStats(ref float damageMult, ref float knockbackMult, ref float useTimeMult, ref float scaleMult, ref float shootSpeedMult, ref float manaMult, ref int critBonus)
        {
            useTimeMult -= 0.15f;
        }

        public override void ModifyValue(ref float valueMult)
        {
            valueMult *= 2f;
        }

        public override IEnumerable<TooltipLine> GetTooltipLines(Item item)
        {

            yield return new TooltipLine(Mod, "SolitaryInfoTooltip", SolitaryInfoTooltip.Value)
            {
                IsModifier = true,
            };

        }

        public LocalizedText SolitaryInfoTooltip => Mod.GetLocalization($"SolitaryInfo");

    }
}
