using System.Collections.Generic;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace ReforgesReforged.Content.Prefixes.Accessories
{
    public class Hasted : ModPrefix
    {

        public override PrefixCategory Category => PrefixCategory.Accessory;

        public override float RollChance(Item item)
        {
            return 1f;
        }

        public override bool CanRoll(Item item)
        {
            return true;
        }

        public override void ApplyAccessoryEffects(Player player)
        {
            player.pickSpeed -= 0.05f;
        }

        public override void ModifyValue(ref float valueMult)
        {
            valueMult *= 1.25f;
        }

        public override IEnumerable<TooltipLine> GetTooltipLines(Item item)
        {

            yield return new TooltipLine(Mod, "MiningTooltip", "+5% " + MiningTooltip.Value)
            {
                IsModifier = true,
            };

        }

        public LocalizedText MiningTooltip => Mod.GetLocalization($"MiningSpeed");

    }
}
