using System.Collections.Generic;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace ReforgesReforged.Content.Prefixes.Accessories
{
    public class CloudBorn : ModPrefix
    {

        public override PrefixCategory Category => PrefixCategory.Accessory;

        public override float RollChance(Item item)
        {
            if (item.wingSlot > -1) return 1f;
            return 0f;
        }

        public override void ApplyAccessoryEffects(Player player)
        {
            player.wingTime += 0.1f;
        }

        public override void ModifyValue(ref float valueMult)
        {
            valueMult *= 1.25f;
        }

        public override IEnumerable<TooltipLine> GetTooltipLines(Item item)
        {

            yield return new TooltipLine(Mod, "FlightTime", "+10% " + FlightTimeTooltip.Value)
            {
                IsModifier = true,
            };

        }

        public LocalizedText FlightTimeTooltip => Mod.GetLocalization($"FlightTime");

    }
}
