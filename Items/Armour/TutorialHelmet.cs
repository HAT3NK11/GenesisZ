using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using System.Collections.Generic;
 
namespace GenesisZ.Items.Armour
{
    [AutoloadEquip(EquipType.Head)]
    public class TutorialHelmet : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Marketon Head");
            Tooltip.SetDefault("The Head Of Scamming");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 1000;
            item.rare = 2;
            item.defense = 0; // The Defence value for this piece of armour.
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == mod.ItemType("TutorialBreastplate") && legs.type == mod.ItemType("TutorialLeggings");
        }

        public override void UpdateArmorSet(Player player)
        {
            player.AddBuff(BuffID.Archery, 300);
        }


    
        }
    }

