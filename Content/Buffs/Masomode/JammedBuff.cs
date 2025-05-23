﻿using Terraria;
using Terraria.ModLoader;

namespace FargowiltasSouls.Content.Buffs.Masomode
{
    public class JammedBuff : ModBuff
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Jammed");
            // Description.SetDefault("Your ranged weapons are faulty");
            Main.debuff[Type] = true;
            Main.pvpBuff[Type] = true;
            //DisplayName.AddTranslation((int)GameCulture.CultureName.Chinese, "卡壳");
            //Description.AddTranslation((int)GameCulture.CultureName.Chinese, "你的远程武器出故障了");
        }

        public override void Update(Player player, ref int buffIndex)
        {
            //all ranged weapons shoot confetti 
            player.FargoSouls().Jammed = true;

            player.GetDamage(DamageClass.Ranged) *= 0.6f;
        }
    }
}