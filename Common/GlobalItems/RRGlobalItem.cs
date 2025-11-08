using ReforgesReforged.Content.Prefixes.Weapons;
using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;

namespace ReforgesReforged.Common.GlobalItems
{
    internal class RRGlobalItem : GlobalItem
    {

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

        }
        
    }
}
