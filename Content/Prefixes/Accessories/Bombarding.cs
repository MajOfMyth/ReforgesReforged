using ReforgesReforged.Common.ModPlayers;
using System.Collections.Generic;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace ReforgesReforged.Content.Prefixes.Accessories
{
    public class Bombarding : ModPrefix
    {

        public override PrefixCategory Category => PrefixCategory.Accessory;

        public override float RollChance(Item item)
        {
            return 1f;
        }

        public override void ApplyAccessoryEffects(Player player)
        {
            player.GetModPlayer<RRPlayer>().MinversionStack--;
        }

        public override void ModifyValue(ref float valueMult)
        {
            valueMult *= 1.25f;
        }

        public override IEnumerable<TooltipLine> GetTooltipLines(Item item)
        {

            yield return new TooltipLine(Mod, "MaxMinionsTooltip", "+1 " + MaxMinionsTooltip.Value)
            {
                IsModifier = true,
            };
            yield return new TooltipLine(Mod, "MaxSentriesTooltip", "-1 " + MaxSentriesTooltip.Value)
            {
                IsModifier = true,
                IsModifierBad = true,
            };

        }

        public LocalizedText MaxMinionsTooltip => Mod.GetLocalization($"MaxMinions");
        public LocalizedText MaxSentriesTooltip => Mod.GetLocalization($"MaxSentries");

    }
}
