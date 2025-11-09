using System.Collections.Generic;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace ReforgesReforged.Content.Prefixes.Weapons
{
    public class Enormous : ModPrefix
    {

        public override PrefixCategory Category => PrefixCategory.Melee;

        public override float RollChance(Item item)
        {
            return 1f;
        }

        public override bool CanRoll(Item item)
        {
            return true;
        }

        public override void SetStats(ref float damageMult, ref float knockbackMult, ref float useTimeMult, ref float scaleMult, ref float shootSpeedMult, ref float manaMult, ref int critBonus)
        {
            damageMult += 0.15f;
            useTimeMult += 0.5f;
            scaleMult += 1f;
            critBonus += 5;
        }

        public override void ModifyValue(ref float valueMult)
        {
            valueMult *= 1.15f;
        }

        public override IEnumerable<TooltipLine> GetTooltipLines(Item item)
        {

            yield return new TooltipLine(Mod, "WhipRangeTooltip", "+100% " + WhipRangeTooltip.Value)
            {
                IsModifier = true,
            };

        }

        public LocalizedText WhipRangeTooltip => Mod.GetLocalization($"WhipRange");

    }
}
