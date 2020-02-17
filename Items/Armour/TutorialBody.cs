using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using System.Collections.Generic;
 
namespace GenesisZ.Items.Armour
{
    [AutoloadEquip(EquipType.Body)]
    public class TutorialBody : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Flesh ChestPlate");
            Tooltip.SetDefault("The Head Of Scamming");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 1000;
            item.rare = 2;
            item.defense = 5; // The Defence value for this piece of armour.
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return head.type == mod.ItemType("TutorialHead") && legs.type == mod.ItemType("TutorialLegs");
        }

        public override void UpdateArmorSet(Player player)
        {
            player.AddBuff(BuffID.Archery, 300);
            player.AddBuff(BuffID.Mining, 300);
            player.AddBuff(BuffID.Ironskin, 300);

        }


    
        }
    }

