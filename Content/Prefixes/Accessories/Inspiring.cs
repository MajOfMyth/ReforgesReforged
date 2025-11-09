using System.Collections.Generic;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using ThoriumMod;

namespace ReforgesReforged.Content.Prefixes.Accessories
{
    [JITWhenModsEnabled("ThoriumMod")]
    public class Inspiring : ModPrefix
    {

        public override PrefixCategory Category => PrefixCategory.Accessory;

        public override float RollChance(Item item)
        {
            return 1f;
        }

        public override bool CanRoll(Item item)
        {
            if (ModLoader.TryGetMod("ThoriumMod", out Mod mod)) return true;
            return false;
        }

        public override void ApplyAccessoryEffects(Player player)
        {
            player.GetModPlayer<ThoriumPlayer>().bardResourceMax2 += 1;
        }

        public override void ModifyValue(ref float valueMult)
        {
            valueMult *= 1.25f;
        }

        public override IEnumerable<TooltipLine> GetTooltipLines(Item item)
        {

            yield return new TooltipLine(Mod, "InspirationTooltip", "+1 " + InspirationTooltip.Value)
            {
                IsModifier = true,
            };

        }

        public LocalizedText InspirationTooltip => Mod.GetLocalization($"MaxInspiration");

    }
}
