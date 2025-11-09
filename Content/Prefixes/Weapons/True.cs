using Terraria;
using Terraria.ModLoader;

namespace ReforgesReforged.Content.Prefixes.Weapons
{
    [JITWhenModsEnabled("CalamityMod")]
    public class True : ModPrefix
    {

        public override PrefixCategory Category => PrefixCategory.Melee;

        public override float RollChance(Item item)
        {
            if(ModLoader.TryGetMod("CalamityMod", out Mod mod) && (item.DamageType == DamageClass.Melee || item.DamageType == DamageClass.MeleeNoSpeed)) return 1f;
            return 0f;
        }

        public override void SetStats(ref float damageMult, ref float knockbackMult, ref float useTimeMult, ref float scaleMult, ref float shootSpeedMult, ref float manaMult, ref int critBonus)
        {
            damageMult += 0.80f;
            useTimeMult -= 0.45f;
            scaleMult += 0.75f;
            critBonus += 8;
        }

        public override void Apply(Item item)
        {
            item.DamageType = ModContent.GetInstance<CalamityMod.TrueMeleeDamageClass>();
            item.noMelee = false;
            item.noUseGraphic = false;
            base.Apply(item);
        }

        public override void ModifyValue(ref float valueMult)
        {
            valueMult *= 2f;
        }

    }
}
