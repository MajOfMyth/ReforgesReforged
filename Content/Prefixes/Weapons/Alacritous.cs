using Terraria;
using Terraria.ModLoader;

namespace ReforgesReforged.Content.Prefixes.Weapons
{
    public class Alacritous : ModPrefix
    {

        public override PrefixCategory Category => PrefixCategory.Ranged;

        public override float RollChance(Item item)
        {
            return 1f;
        }

        public override void SetStats(ref float damageMult, ref float knockbackMult, ref float useTimeMult, ref float scaleMult, ref float shootSpeedMult, ref float manaMult, ref int critBonus)
        {
            damageMult -= 0.5f;
            useTimeMult -= 0.4f;
        }

        public override void ModifyValue(ref float valueMult)
        {
            valueMult *= 2f;
        }

    }
}
