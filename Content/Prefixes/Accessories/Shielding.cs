using System.Collections.Generic;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace ReforgesReforged.Content.Prefixes.Accessories
{
    public class Shielding : ModPrefix
    {

        public override PrefixCategory Category => PrefixCategory.Accessory;

        public override float RollChance(Item item)
        {
            return 1f;
        }

        public override bool CanRoll(Item item)
        {
            if (item.shieldSlot > -1) return true;
            return false;
        }

        public override void ApplyAccessoryEffects(Player player)
        {
            player.statDefense += 4;
            player.endurance += 0.04f;
        }

        public override void ModifyValue(ref float valueMult)
        {
            valueMult *= 1.25f;
        }

        public override IEnumerable<TooltipLine> GetTooltipLines(Item item)
        {

            yield return new TooltipLine(Mod, "Defense", "+4 " + DefenseTooltip.Value)
            {
                IsModifier = true,
            };
            yield return new TooltipLine(Mod, "Endurance", "+4% " + EnduranceTooltip.Value)
            {
                IsModifier = true,
            };

        }

        public LocalizedText DefenseTooltip => Mod.GetLocalization($"Defense");
        public LocalizedText EnduranceTooltip => Mod.GetLocalization($"Endurance");

    }
}
