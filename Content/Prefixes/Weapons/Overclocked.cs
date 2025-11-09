using Terraria;
using Terraria.ModLoader;

namespace ReforgesReforged.Content.Prefixes.Weapons
{
    public class Overclocked : ModPrefix
    {

        public override PrefixCategory Category => PrefixCategory.Magic;

        public override float RollChance(Item item)
        {
            if (item.DamageType == DamageClass.Summon) return 0f;
            return 1f;
        }

        public override void SetStats(ref float damageMult, ref float knockbackMult, ref float useTimeMult, ref float scaleMult, ref float shootSpeedMult, ref float manaMult, ref int critBonus)
        {
            damageMult += 0.5f;
            useTimeMult -= 0.15f;
            manaMult += 1f;
            critBonus += 15;
        }

        public override void ModifyValue(ref float valueMult)
        {
            valueMult *= 8f;
        }

    }
}
