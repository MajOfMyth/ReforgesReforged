using System.Collections.Generic;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace ReforgesReforged.Content.Prefixes.Weapons
{
    public class Vitrified : ModPrefix
    {

        public override PrefixCategory Category => PrefixCategory.AnyWeapon;

        public override float RollChance(Item item)
        {
            if (item.DamageType == DamageClass.Summon) return 0f;
            return 1f;
        }

        public override void SetStats(ref float damageMult, ref float knockbackMult, ref float useTimeMult, ref float scaleMult, ref float shootSpeedMult, ref float manaMult, ref int critBonus)
        {
            damageMult += 0.25f;
            useTimeMult -= 0.15f;
            critBonus += 5;
        }

        public override void ModifyValue(ref float valueMult)
        {
            valueMult *= 1.2f;
        }

        public override IEnumerable<TooltipLine> GetTooltipLines(Item item)
        {

            yield return new TooltipLine(Mod, "DefenseTooltip", "-20% " + DefenseTooltip.Value)
            {
                IsModifier = true,
                IsModifierBad = true,
            };

        }

        public LocalizedText DefenseTooltip => Mod.GetLocalization($"Defense");

    }
}
