using System.Collections.Generic;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace ReforgesReforged.Content.Prefixes.Accessories
{
    public class Cursed : ModPrefix
    {

        public override PrefixCategory Category => PrefixCategory.Accessory;

        public override float RollChance(Item item)
        {
            return 1f;
        }

        public override void ApplyAccessoryEffects(Player player)
        {
            player.GetDamage(DamageClass.Generic) += 0.05f;
            player.GetAttackSpeed(DamageClass.Generic) += 0.05f;
            player.GetCritChance(DamageClass.Generic) += 5;
            player.lifeRegen -= 2;
        }

        public override void ModifyValue(ref float valueMult)
        {
            valueMult *= 1.25f;
        }

        public override IEnumerable<TooltipLine> GetTooltipLines(Item item)
        {

            yield return new TooltipLine(Mod, "DamageTooltip", "+5% " + DamageTooltip.Value)
            {
                IsModifier = true,
            };
            yield return new TooltipLine(Mod, "AttackSpeedTooltip", "+5% " + AttackSpeedTooltip.Value)
            {
                IsModifier = true,
            };
            yield return new TooltipLine(Mod, "CritChanceTooltip", "+5% " + CritChanceTooltip.Value)
            {
                IsModifier = true,
            };
            yield return new TooltipLine(Mod, "LifeRegenTooltip", "-2 " + LifeRegenTooltip.Value)
            {
                IsModifier = true,
                IsModifierBad = true,
            };

        }

        public LocalizedText DamageTooltip => Mod.GetLocalization($"Damage");
        public LocalizedText AttackSpeedTooltip => Mod.GetLocalization($"AttackSpeed");
        public LocalizedText CritChanceTooltip => Mod.GetLocalization($"CritChance");
        public LocalizedText LifeRegenTooltip => Mod.GetLocalization($"LifeRegen");

    }
}
