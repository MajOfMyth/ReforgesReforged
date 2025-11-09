using System.Collections.Generic;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using ThoriumMod;

namespace ReforgesReforged.Content.Prefixes.Accessories
{
    [JITWhenModsEnabled("ThoriumMod")]
    public class Hydrating : ModPrefix
    {

        public override PrefixCategory Category => PrefixCategory.Accessory;

        public override float RollChance(Item item)
        {
            if (ModLoader.TryGetMod("ThoriumMod", out Mod mod)) return 1f;
            return 0f;
        }

        public override void ApplyAccessoryEffects(Player player)
        {
            player.GetModPlayer<ThoriumPlayer>().throwerExhaustionMax += 120;
            player.GetModPlayer<ThoriumPlayer>().throwerExhaustionRegenBonus += 0.1f;
        }

        public override void ModifyValue(ref float valueMult)
        {
            valueMult *= 1.25f;
        }

        public override IEnumerable<TooltipLine> GetTooltipLines(Item item)
        {

            yield return new TooltipLine(Mod, "MaxExhaustionTooltip", "+10% " + MaxExhaustionTooltip.Value)
            {
                IsModifier = true,
            };
            yield return new TooltipLine(Mod, "ExhaustionRegenTooltip", "+10% " + ExhaustionRegenTooltip.Value)
            {
                IsModifier = true,
            };

        }

        public LocalizedText MaxExhaustionTooltip => Mod.GetLocalization($"MaxExhaustion");
        public LocalizedText ExhaustionRegenTooltip => Mod.GetLocalization($"ExhaustionRegen");

    }
}
