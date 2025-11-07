using ReforgesReforged.Content.Prefixes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.WorldBuilding;

namespace ReforgesReforged.Common.ModPlayers
{
    internal class RRPlayer : ModPlayer
    {
        public Player player;
        public float SpeedMult;


        public override void Initialize()
        {
            player = this.Player;
            SpeedMult = 1f;
        }

        public override void UpdateDead()
        {
            SpeedMult = 1f;
        }

        public override void ResetEffects()
        {
            SpeedMult = 1f;
            base.ResetEffects();
        }

        public override void PostUpdateRunSpeeds()
        {
            player.accRunSpeed *= SpeedMult;
            base.PostUpdateRunSpeeds();
        }

        public override void PostUpdateEquips()
        {
            if (player.HeldItem.prefix == ModContent.PrefixType<Vitrified>())
            {
                player.statDefense *= 0.8f;
            }
            base.PostUpdateEquips();
        }

        public override void ModifyHitNPC(NPC target, ref NPC.HitModifiers modifiers)
        {
            /*
            if (player.HeldItem.prefix == ModContent.PrefixType<whateverprefix>())
            {
                modifiers.CritDamage += 10.0f;
            }
            */
        }
    }
}
