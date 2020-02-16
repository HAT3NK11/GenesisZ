using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using GenesisZ.Items.MobLoot;

namespace GenesisZ.Items.Armour
{
    public class GoldCharm : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Gold Charm");
            Tooltip.SetDefault("Increases Melee Speed, Movement Speed and Melee Damage");
        }

        public override void SetDefaults()
        {
            item.width = 10;
            item.height = 14;
            item.value = 10000;
            item.rare = 4;
            item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.meleeSpeed += 0.15f;
            player.moveSpeed += 2.15f;
            player.meleeDamage += 0.22f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.GoldBar, 15);
            recipe.AddIngredient(ItemID.Aglet, 1);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}