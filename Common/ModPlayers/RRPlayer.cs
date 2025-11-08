using ReforgesReforged.Content.Prefixes.Weapons;
using System;
using Terraria;
using Terraria.ModLoader;

namespace ReforgesReforged.Common.ModPlayers
{
    internal class RRPlayer : ModPlayer
    {

        public Player player;
        public float SpeedMult;
        //minion inversion :3
        public int MinversionStack;
        public int SacrificialStack;

        private void ResetAccEffects()
        {
            SpeedMult = 1f;
            MinversionStack = 0;
            SacrificialStack = 0;
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

            //Vitrified
            if (player.HeldItem.prefix == ModContent.PrefixType<Vitrified>())
            {
                player.statDefense *= 0.8f;
            }


            //share the same variable for final values
            int FinalStacks = 0;

            //Sacrificial
            FinalStacks = SacrificialStack;
            if (player.maxMinions < SacrificialStack) FinalStacks -= SacrificialStack - player.maxMinions;

            player.GetDamage(DamageClass.Summon) *= 1f + (FinalStacks * 0.02f);
            player.maxMinions -= FinalStacks;


            //Bastion / Bombarding
            //todo: make not bad
            FinalStacks = MinversionStack;

            if (MinversionStack > 0 && player.maxMinions < MinversionStack) FinalStacks -= MinversionStack - player.maxMinions;
            if (MinversionStack < 0 && player.maxTurrets < Math.Abs(MinversionStack)) FinalStacks -= MinversionStack + player.maxTurrets;

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
