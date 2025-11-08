using ReforgesReforged.Common.ModPlayers;
using System.Collections.Generic;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace ReforgesReforged.Content.Prefixes.Accessories
{
    public class Masterful : ModPrefix
    {

        public override PrefixCategory Category => PrefixCategory.Accessory;

        public override float RollChance(Item item)
        {
            return 1f;
        }

        public override bool CanRoll(Item item)
        {
            if (item.expert) return true;
            return false;
        }

        public override void ApplyAccessoryEffects(Player player)
        {
            player.GetDamage(DamageClass.Generic) *= 1.02f;
            player.GetAttackSpeed(DamageClass.Generic) *= 1.02f;
            player.endurance -= 0.10f;
            player.GetModPlayer<RRPlayer>().SpeedMult += 1.1f;
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

        }

        public LocalizedText MaxManaTooltip => Mod.GetLocalization($"MaxMana");

    }
}
