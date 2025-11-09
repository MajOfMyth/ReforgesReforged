using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader.Config;

namespace ReforgesReforged
{
    public class RRConfig : ModConfig
    {
        public static RRConfig Instance;

        public override ConfigScope Mode => ConfigScope.ServerSide;
        //public override bool AcceptClientChanges(ModConfig pendingConfig, int whoAmI, ref string message) => true;

        [DefaultValue(true)]
        public bool RemoveRedundant { get; set; }
    }
}
