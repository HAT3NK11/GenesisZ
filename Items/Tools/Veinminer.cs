using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace GenesisZ.Items.Tools
{
    public class Veinminer : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Veinminer");
            Tooltip.SetDefault("It Bloody.");
        }

        public override void SetDefaults()
        {
            
            item.damage = 15; // Base Damage of the Weapon
            item.width = 24; // Hitbox Width
            item.height = 24; // Hitbox Height
            
            item.useTime = 8; // Speed before reuse
            item.useAnimation = 8; // Animation Speed
            item.useStyle = 1; // 1 = Broadsword 
            item.knockBack = 1.5f; // Weapon Knockbase: Higher means greater "launch" distance
            item.value = 5500; // 10 | 00 | 00 | 00 : Platinum | Gold | Silver | Bronze
            item.rare = 2; // Item Tier
            item.UseSound = SoundID.Item1; // Sound effect of item on use 
            item.autoReuse = true; // Do you want to torture people with clicking? Set to false

            item.pick = 59; // Pick Power - Higher Value = Better
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "Vein", 12);
            recipe.AddIngredient(null, "FleshChunk", 15);
            recipe.AddIngredient(null, "Artery", 10);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
