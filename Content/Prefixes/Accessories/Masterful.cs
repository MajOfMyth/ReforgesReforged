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

            yield return new TooltipLine(Mod, "DamageTooltip", "1.02x " + DamageTooltip.Value)
            {
                IsModifier = true,
            };
            yield return new TooltipLine(Mod, "AttackSpeedTooltip", "1.02x " + AttackSpeedTooltip.Value)
            {
                IsModifier = true,
            };
            yield return new TooltipLine(Mod, "MoveSpeedTooltip", "+10% " + MoveSpeedTooltip.Value)
            {
                IsModifier = true,
            };
            yield return new TooltipLine(Mod, "EnduranceTooltip", "-10% " + EnduranceTooltip.Value)
            {
                IsModifier = true,
                IsModifierBad = true,
            };

        }

        public LocalizedText DamageTooltip => Mod.GetLocalization($"Damage");
        public LocalizedText AttackSpeedTooltip => Mod.GetLocalization($"AttackSpeed");
        public LocalizedText MoveSpeedTooltip => Mod.GetLocalization($"MovementSpeed");
        public LocalizedText EnduranceTooltip => Mod.GetLocalization($"Endurance");

    }
}
