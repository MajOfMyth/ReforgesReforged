using System.Collections.Generic;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace ReforgesReforged.Content.Prefixes.Accessories
{
    public class Soaring : ModPrefix
    {

        public override PrefixCategory Category => PrefixCategory.Accessory;

        public override float RollChance(Item item)
        {
            return 1f;
        }

        public override bool CanRoll(Item item)
        {
            if (item.wingSlot > -1 && NPC.downedEmpressOfLight) return true;
            return false;
        }

        public override void ApplyAccessoryEffects(Player player)
        {
            player.empressBrooch = true;
            player.GetDamage(DamageClass.Generic) *= 0f;
        }

        public override void ModifyValue(ref float valueMult)
        {
            valueMult *= 1.25f;
        }

        public override IEnumerable<TooltipLine> GetTooltipLines(Item item)
        {

            yield return new TooltipLine(Mod, "InfiniteFlight", InfiniteFlightTooltip.Value)
            {
                IsModifier = true,
            };
            yield return new TooltipLine(Mod, "NoDamage", NoDamageTooltip.Value)
            {
                IsModifier = true,
                IsModifierBad = true,
            };

        }
        public LocalizedText InfiniteFlightTooltip => Mod.GetLocalization($"InfiniteFlight");
        public LocalizedText NoDamageTooltip => Mod.GetLocalization($"NoDamage");

    }
}
