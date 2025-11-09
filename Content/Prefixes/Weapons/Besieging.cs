using Terraria;
using Terraria.ModLoader;

namespace ReforgesReforged.Content.Prefixes.Weapons
{
    public class Besieging : ModPrefix
    {

        public override PrefixCategory Category => PrefixCategory.AnyWeapon;

        public override float RollChance(Item item)
        {
            if (item.DamageType == DamageClass.Summon) return 0f;
            return 1f;
        }

        public override void SetStats(ref float damageMult, ref float knockbackMult, ref float useTimeMult, ref float scaleMult, ref float shootSpeedMult, ref float manaMult, ref int critBonus)
        {
            damageMult += 1f;
            useTimeMult += 0.9f;
        }

        public override void ModifyValue(ref float valueMult)
        {
            valueMult *= 7f;
        }

    }
}
