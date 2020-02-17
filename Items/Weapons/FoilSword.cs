using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace GenesisZ.Items.Weapons  
{
	public class FoilSword : ModItem 
	{

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Foil Sword");
            Tooltip.SetDefault(" Its actually Aluminium oxide.");
        }

        public override void SetDefaults()
		{
			
			item.damage = 13; // Base Damage of the Weapon
			item.melee = true; // Weapon Class Type
			item.width = 40; // Hitbox Width
			item.height = 40; // Hitbox Height
			item.useTime = 12; // Speed before reuse
			item.useAnimation = 12; // Animation Speed
			item.useStyle = 1; // 1 = Broadsword 
			item.knockBack = 4.5f; // Weapon Knockbase: Higher means greater "launch" distance
			item.value = 5000; // 10 | 00 | 00 | 00 : Platinum | Gold | Silver | Bronze
			item.rare = 2; // Item Tier
			item.UseSound = SoundID.Item1; // Sound effect of item on use 
			item.autoReuse = true; // Do you want to torture people with clicking? Set to false 
			
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);

			recipe.AddIngredient(null, "AluminiumBar", 5); // Ingredient for crafing
            recipe.AddIngredient(ItemID.Wood, 10);
            //recipe.AddIngredient(null, "TutorialItem", 1);
            recipe.AddTile(TileID.Anvils); // Tile / Workstation
            recipe.SetResult(this);
			recipe.AddRecipe();
		}


        
    }
}
