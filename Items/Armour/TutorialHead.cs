using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using System.Collections.Generic;
 
namespace GenesisZ.Items.Armour
{
    [AutoloadEquip(EquipType.Head)]
    public class TutorialHead : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Test Head");
            Tooltip.SetDefault("The Head Of Scamming");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 1000;
            item.rare = 2;
            item.defense = 4; // The Defence value for this piece of armour.
        }

        
       


    
        }
    }

