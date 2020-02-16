using Terraria.ModLoader;
using Terraria.ID;

namespace GenesisZ.Items.MobLoot 
{
    public class Vein : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Vein");
            Tooltip.SetDefault("Cold and Squishy!");
        }

        public override void SetDefaults()
        {
            item.width = 6; // Hitbox Width
            item.height = 6; // Hitbox Height
            item.useTime = 0; // Speed before reuse
            item.useAnimation = 20; // Animation Speed
            item.useStyle = 1; // 1 = Broadsword 
            item.value = 50; // 10 | 00 | 00 | 00 : Platinum | Gold | Silver | Bronze
            item.rare = 2; // Item Tier
            item.UseSound = SoundID.Item1; // Sound effect of item on use 
            item.autoReuse = false; // Do you want to torture people with clicking? Set to false
            item.maxStack = 999; // The maximum number you can have of this item.
        }
    }
}
