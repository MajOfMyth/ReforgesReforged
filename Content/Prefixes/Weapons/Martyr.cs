using System.Collections.Generic;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace ReforgesReforged.Content.Prefixes.Weapons
{
    public class Martyr : ModPrefix
    {

        public override PrefixCategory Category => PrefixCategory.Magic;

        public override float RollChance(Item item)
        {
            return 1f;
        }

        public override bool CanRoll(Item item)
        {
            if (item.DamageType == DamageClass.Summon) return false;
            return true;
        }

        public override void SetStats(ref float damageMult, ref float knockbackMult, ref float useTimeMult, ref float scaleMult, ref float shootSpeedMult, ref float manaMult, ref int critBonus)
        {
            damageMult += 0.99f;
            critBonus += 25;

            if (Main.hardMode) damageMult += 9f;
            if (NPC.downedMoonlord) damageMult += 90f;
        }

        public override void ModifyValue(ref float valueMult)
        {
            valueMult *= 4f;
        }

        public override IEnumerable<TooltipLine> GetTooltipLines(Item item)
        {

            yield return new TooltipLine(Mod, "MartyrTooltip", MartyrTooltip.Value)
            {
                IsModifier = true,
                IsModifierBad = true,
            };

        }

        public LocalizedText MartyrTooltip => Mod.GetLocalization($"MartyrInfo");

    }
}
