using System.Collections.Generic;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace ReforgesReforged.Content.Prefixes.Weapons
{
    public class Automatic : ModPrefix
    {

        public override PrefixCategory Category => PrefixCategory.Ranged;

        public override float RollChance(Item item)
        {
            return 1f;
        }

        public override bool CanRoll(Item item)
        {
            if (item.autoReuse == false) return true;
            return false;
        }

        public override void SetStats(ref float damageMult, ref float knockbackMult, ref float useTimeMult, ref float scaleMult, ref float shootSpeedMult, ref float manaMult, ref int critBonus)
        {
            useTimeMult -= 0.1f;
        }

        public override void ModifyValue(ref float valueMult)
        {
            valueMult *= 2f;
        }
        public override IEnumerable<TooltipLine> GetTooltipLines(Item item)
        {

            yield return new TooltipLine(Mod, "AutomaticTooltip", AutomaticTooltip.Value)
            {
                IsModifier = true,
            };

        }

        public LocalizedText AutomaticTooltip => Mod.GetLocalization($"AutomaticInfo");
    }
}
