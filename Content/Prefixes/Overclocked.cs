using Terraria;
using Terraria.ModLoader;

namespace ReforgesReforged.Content.Prefixes
{
    public class Overclocked : ModPrefix
    {

        public override PrefixCategory Category => PrefixCategory.Magic;

        public override float RollChance(Item item)
        {
            return 1f;
        }

        public override bool CanRoll(Item item)
        {
            return true;
        }

        public override void SetStats(ref float damageMult, ref float knockbackMult, ref float useTimeMult, ref float scaleMult, ref float shootSpeedMult, ref float manaMult, ref int critBonus)
        {
            damageMult += 0.5f;
            critBonus += 15;
            useTimeMult -= 0.15f;
            manaMult += 1f;
        }

        public override void ModifyValue(ref float valueMult)
        {
            valueMult *= 4f;
        }

    }
}
