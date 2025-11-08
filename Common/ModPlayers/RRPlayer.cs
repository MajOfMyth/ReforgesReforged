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
        //minion inversion :3
        public int MinversionStack;

        private void ResetAccEffects()
        {
            SpeedMult = 1f;
            MinversionStack = 0;
        }

        public override void Initialize()
        {
            player = this.Player;
            ResetAccEffects();
        }

        public override void UpdateDead()
        {
            ResetAccEffects();
        }

        public override void ResetEffects()
        {
            ResetAccEffects();
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


            //todo: make not bad
            int FinalStacks = MinversionStack;
            if (MinversionStack > 0 && player.maxMinions < MinversionStack) FinalStacks -= MinversionStack - player.maxMinions;
            if (MinversionStack < 0 && player.maxTurrets < MinversionStack) FinalStacks += MinversionStack - player.maxTurrets;

            player.maxMinions -= FinalStacks;
            player.maxTurrets += FinalStacks;


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
