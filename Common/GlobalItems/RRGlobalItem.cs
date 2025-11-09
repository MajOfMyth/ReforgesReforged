using ReforgesReforged.Content.Prefixes.Weapons;
using System.Linq;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ReforgesReforged.Common.GlobalItems
{
    internal class RRGlobalItem : GlobalItem
    {

        public static int[] IllegalPrefixes = [
            PrefixID.Hard,
            PrefixID.Guarding,
            PrefixID.Armored,

            PrefixID.Precise,

            PrefixID.Jagged,
            PrefixID.Spiked,
            PrefixID.Angry,

            PrefixID.Brisk,
            PrefixID.Fleeting,
            PrefixID.Hasty2,

            PrefixID.Wild,
            PrefixID.Rash,
            PrefixID.Intrepid,


            PrefixID.Keen,
            PrefixID.Superior,
            PrefixID.Forceful,
            PrefixID.Damaged,
            PrefixID.Shoddy,
            PrefixID.Hurtful,
            PrefixID.Strong,
            PrefixID.Unpleasant,

            PrefixID.Quick,
            PrefixID.Nimble,
            PrefixID.Murderous,
            PrefixID.Slow,
            PrefixID.Lazy,
            PrefixID.Annoying,

            PrefixID.Large,
            PrefixID.Dangerous,
            PrefixID.Savage,
            PrefixID.Sharp,
            PrefixID.Pointy,
            PrefixID.Terrible,
            PrefixID.Small,
            PrefixID.Unhappy,
            PrefixID.Bulky,
            PrefixID.Shameful,

            PrefixID.Hasty,
            PrefixID.Intimidating,
            PrefixID.Staunch,
            PrefixID.Lethargic,
            PrefixID.Awkward,

            PrefixID.Mystic,
            PrefixID.Adept,
            PrefixID.Inept,
            PrefixID.Deranged,
            PrefixID.Intense,
            PrefixID.Taboo,
        ];

        public override bool AllowPrefix(Item item, int pre)
        {
            if (RRConfig.Instance.RemoveRedundant && IllegalPrefixes.Contains(pre)) return false;
            return true;
        }


        public override void ModifyWeaponDamage(Item item, Player player, ref StatModifier damage)
        {

            //todo: add tooltip
            if (item.prefix == ModContent.PrefixType<Solitary>())
            {
                float multiplier = 1f;
                float unusedSlots = player.maxMinions - player.slotsMinions;
                multiplier += unusedSlots * 0.05f;
                damage += multiplier;
            }

            if (item.prefix == ModContent.PrefixType<Automatic>())
            {
                item.autoReuse = true;
            }

            if(item.prefix == ModContent.PrefixType<Martyr>())
            {
                if (Main.hardMode) damage += 9f;
                if (NPC.downedMoonlord) damage += 90f;
            }
        }
        
    }
}
