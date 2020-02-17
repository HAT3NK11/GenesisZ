using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace GenesisZ.Items.Weapons  
{
	public class StaticScabbard: ModItem 
	{

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Static Scabbard");
            Tooltip.SetDefault(" More Painful to look at that be hit by.");
        }

        public override void SetDefaults()
		{
			
			item.damage = 24; // Base Damage of the Weapon
			item.melee = true; // Weapon Class Type
			item.width = 40; // Hitbox Width
			item.height = 40; // Hitbox Height
			item.useTime = 25; // Speed before reuse
			item.useAnimation = 25; // Animation Speed
			item.useStyle = 1; // 1 = Broadsword 
			item.knockBack = 4.5f; // Weapon Knockbase: Higher means greater "launch" distance
			item.value = 5000; // 10 | 00 | 00 | 00 : Platinum | Gold | Silver | Bronze
			item.rare = 2; // Item Tier
			item.UseSound = SoundID.Item1; // Sound effect of item on use 
			item.autoReuse = true; // Do you want to torture people with clicking? Set to false 
			item.shoot = ProjectileID.DiamondBolt;
			item.shootSpeed = 8f;
		}

		


        
    }
}
