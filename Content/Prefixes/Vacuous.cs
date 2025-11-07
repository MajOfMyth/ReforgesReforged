using Terraria;
using Terraria.ModLoader;

namespace ReforgesReforged.Content.Prefixes
{
    public class Vacuous : ModPrefix
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
            manaMult *= 0f;
            damageMult *= 0.5f;
        }

        public override void ModifyValue(ref float valueMult)
        {
            valueMult *= 1.25f;
        }

        public override void Apply(Item item)
        {

        }

    }
}
