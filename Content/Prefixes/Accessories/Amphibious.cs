using System.Collections.Generic;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace ReforgesReforged.Content.Prefixes.Accessories
{
    public class Amphibious : ModPrefix
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
            player.breathMax += 20;
        }

        public override void ModifyValue(ref float valueMult)
        {
            valueMult *= 1.25f;
        }

        public override IEnumerable<TooltipLine> GetTooltipLines(Item item)
        {

            yield return new TooltipLine(Mod, "BreathTooltip", "+10% " + BreathTooltip.Value)
            {
                IsModifier = true,
            };

        }

        public LocalizedText BreathTooltip => Mod.GetLocalization($"BreathMax");
        
    }
}
