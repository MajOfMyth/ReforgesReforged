using System.Collections.Generic;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace ReforgesReforged.Content.Prefixes.Accessories
{
    public class Floaty : ModPrefix
    {

        public override PrefixCategory Category => PrefixCategory.Accessory;

        public override float RollChance(Item item)
        {
            return 1f;
        }

        public override bool CanRoll(Item item)
        {
            if (item.balloonSlot > -1) return true;
            return false;
        }

        public override void ApplyAccessoryEffects(Player player)
        {
            player.jumpSpeedBoost += 0.1f;
        }

        public override void ModifyValue(ref float valueMult)
        {
            valueMult *= 1.25f;
        }

        public override IEnumerable<TooltipLine> GetTooltipLines(Item item)
        {

            yield return new TooltipLine(Mod, "JumpBoost", "+10% " + JumpBoostTooltip.Value)
            {
                IsModifier = true,
            };

        }

        public LocalizedText JumpBoostTooltip => Mod.GetLocalization($"JumpBoost");

    }
}
