using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using GenesisZ.Items.MobLoot;

namespace GenesisZ.Items.Armour 
{
    [AutoloadEquip(EquipType.Wings)]
    public class TutorialWing : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Flesh Wings");
        }

        public override void SetDefaults()
        {
            item.width = 22;
            item.height = 22;
            item.value = 10000;
            item.rare = 4;
            item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.wingTimeMax = 30;
        }

        public override void VerticalWingSpeeds(Player player, ref float ascentWhenFalling, ref float ascentWhenRising, ref float maxCanAscendMultiplier, ref float maxAscentMultiplier, ref float constantAscend)
        {
            ascentWhenFalling = 1.0f;
            ascentWhenRising = 1.0f;
            maxCanAscendMultiplier = 1.2f;
            maxAscentMultiplier = 1.5f;
            constantAscend = 0.125f;
        }

        public override void HorizontalWingSpeeds(Player player, ref float speed, ref float acceleration)
        {
            speed = 4.5f;
            acceleration *= 2f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "Vein", 10);
            recipe.AddIngredient(null, "FleshChunk", 6);
            recipe.AddIngredient(null, "Artery", 8);
            recipe.AddIngredient(ItemID.Feather , 5);
            recipe.AddTile(TileID.Sawmill);
            recipe.SetResult(this);
            recipe.AddRecipe();

        }


    }
}
