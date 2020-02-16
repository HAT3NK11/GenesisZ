using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using GenesisZ.Items.Ammo;

namespace GenesisZ.Items.Weapons
{
    public class AdSlinger : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ad Slinger");
            Tooltip.SetDefault("Have you ever heard of targeted ads?");
        }

        public override void SetDefaults()
        {
            item.damage = 16;
            item.width = 16;
            item.height = 32;
            item.useTime = 23;
            item.useAnimation = 16;
            item.useStyle = 5; // Bow Use Style
            item.noMelee = true; // Doesn't deal damage if an enemy touches at melee range.
            item.value = Item.buyPrice(0, 0, 10, 0); // Another way to handle value of item.
            item.rare = 2;
            item.UseSound = SoundID.Item5; // Sound for Bows
            item.useAmmo = AmmoID.Arrow; // The ammo used with this weapon
            item.shoot = 1;
            item.shootSpeed = 22f;
            item.ranged = true; // For Ranged Weapon
            item.autoReuse = true;
        }

        
    }
}
