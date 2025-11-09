using System.Collections.Generic;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace ReforgesReforged.Content.Prefixes.Accessories
{
    public class Attuned : ModPrefix
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
            player.statManaMax2 += 10;
            player.manaRegenBonus += 2;
        }

        public override void ModifyValue(ref float valueMult)
        {
            valueMult *= 1.25f;
        }

        public override IEnumerable<TooltipLine> GetTooltipLines(Item item)
        {

            yield return new TooltipLine(Mod, "MaxManaTooltip", "+10 " + MaxManaTooltip.Value)
            {
                IsModifier = true,
            };
            yield return new TooltipLine(Mod, "ManaRegenTooltip", "+5 " + ManaRegenTooltip.Value)
            {
                IsModifier = true,
            };

        }

        public LocalizedText MaxManaTooltip => Mod.GetLocalization($"MaxMana");
        public LocalizedText ManaRegenTooltip => Mod.GetLocalization($"ManaRegen");

    }
}
