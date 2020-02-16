using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;

namespace GenesisZ.Items.Weapons
{
    public class TutorialBow : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Can Cannon");

        }

        public override void SetDefaults()
        {
            item.ranged = true;
            item.width = 26;
            item.height = 26;
            item.damage = 106;
            item.useTime = 43;
            item.useAnimation = 43;
            item.UseSound = SoundID.Item5;
            item.useStyle = 5;
            item.knockBack = 2f;
            item.value = 100;
            item.useTurn = true;
            item.autoReuse = true;
            item.rare = -1;
            item.useTime = 43;
            item.useAnimation = 43;
            // Left Click has no projectile
            item.shootSpeed = 43f;
            item.shoot = 1;
            item.useAmmo = AmmoID.Arrow;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "AluminiumBar", 15);
            recipe.AddIngredient(ItemID.IronBar, 12);
            recipe.AddIngredient(ItemID.HellstoneBar, 5);
            recipe.AddIngredient(null, "Can", 3);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();




        }
    }
}