using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace GenesisZ.Items.Tools
{
    public class TheFleshecutioner : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Fleshcutioner");
            Tooltip.SetDefault("It smells!.");
        }

        public override void SetDefaults()
        {
            
            item.damage = 12; // Base Damage of the Weapon
            item.width = 24; // Hitbox Width
            item.height = 24; // Hitbox Height
            
            item.useTime = 16; // Speed before reuse
            item.useAnimation = 16; // Animation Speed
            item.useStyle = 1; // 1 = Broadsword 
            item.knockBack = 1f; // Weapon Knockbase: Higher means greater "launch" distance
            item.value = 5500; // 10 | 00 | 00 | 00 : Platinum | Gold | Silver | Bronze
            item.rare = 2; // Item Tier
            item.UseSound = SoundID.Item1; // Sound effect of item on use 
            item.autoReuse = true; // Do you want to torture people with clicking? Set to false

            item.axe = 10; // Axe Power - Higher Value = Better
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "Vein", 12);
            recipe.AddIngredient(null, "Artery", 15);
            recipe.AddIngredient(null, "FleshChunk",12);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
