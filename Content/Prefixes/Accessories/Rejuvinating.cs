using ReforgesReforged.Common.ModPlayers;
using System.Collections.Generic;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace ReforgesReforged.Content.Prefixes.Accessories
{
    public class Rejuvenating : ModPrefix
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
            player.lifeRegen += 2;
        }

        public override void ModifyValue(ref float valueMult)
        {
            valueMult *= 1.25f;
        }

        public override IEnumerable<TooltipLine> GetTooltipLines(Item item)
        {

            yield return new TooltipLine(Mod, "LifeRegenTooltip", "2 " + LifeRegenTooltip.Value)
            {
                IsModifier = true,
            };

        }

        public LocalizedText LifeRegenTooltip => Mod.GetLocalization($"LifeRegen");
    }
}
