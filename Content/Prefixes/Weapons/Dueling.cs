using Terraria;
using Terraria.ModLoader;

namespace ReforgesReforged.Content.Prefixes.Weapons
{
    public class Dueling : ModPrefix
    {

        public override PrefixCategory Category => PrefixCategory.Melee;

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
            damageMult += 0.15f;
            useTimeMult -= 0.15f;
            scaleMult -= 0.15f;
            critBonus += 15;
        }

        public override void ModifyValue(ref float valueMult)
        {
            valueMult *= 2f;
        }

    }
}
