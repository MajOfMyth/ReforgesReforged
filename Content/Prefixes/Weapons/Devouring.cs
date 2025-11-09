using System.Collections.Generic;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace ReforgesReforged.Content.Prefixes.Weapons
{
    public class Devouring : ModPrefix
    {

        public override PrefixCategory Category => PrefixCategory.Melee;

        public override float RollChance(Item item)
        {
            return 1f;
        }

        public override void SetStats(ref float damageMult, ref float knockbackMult, ref float useTimeMult, ref float scaleMult, ref float shootSpeedMult, ref float manaMult, ref int critBonus)
        {
            damageMult += 0.32f;
            useTimeMult -= 0.15f;
            critBonus += 5;
        }

        public override void ModifyValue(ref float valueMult)
        {
            valueMult *= 2f;
        }

        public override IEnumerable<TooltipLine> GetTooltipLines(Item item)
        {

            yield return new TooltipLine(Mod, "DevouringTooltip", DevouringTooltip.Value)
            {
                IsModifier = true,
                IsModifierBad = true,
            };

        }

        public LocalizedText DevouringTooltip => Mod.GetLocalization($"DevouringInfo");

    }
}
