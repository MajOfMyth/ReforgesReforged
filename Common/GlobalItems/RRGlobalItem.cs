using ReforgesReforged.Content.Prefixes.Weapons;
using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;

namespace ReforgesReforged.Common.GlobalItems
{
    internal class RRGlobalItem : GlobalItem
    {

        //todo: add tooltip
        public override void ModifyWeaponDamage(Item item, Player player, ref StatModifier damage)
        {
            if(item.prefix == ModContent.PrefixType<Solitary>())
            {
                float multiplier = 1f;
                float unusedSlots = player.maxMinions - player.slotsMinions;
                multiplier += unusedSlots * 0.05f;
                damage += multiplier;
            }
        }
        
    }
}
