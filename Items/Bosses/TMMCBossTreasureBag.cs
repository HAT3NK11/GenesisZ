using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using GenesisZ.Items.MobLoot;

namespace GenesisZ.Items.Bosses
{
    public class TMMCBossTreasureBag : ModItem
    {
        public override int BossBagNPC => mod.NPCType("TMMCBoss");

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Marketron Treasure Bag");
            Tooltip.SetDefault("<right> to open");
        }

        public override void SetDefaults()
        {
            item.width = 36;
            item.height = 32;
            item.maxStack = 999;
            item.consumable = true;
            item.rare = 9;
            item.expert = true;
        }

       

            public override void OpenBossBag(Player player)
        {
            player.QuickSpawnItem(ItemID.GoldCoin, 10);
            player.QuickSpawnItem(ItemID.HealingPotion, Main.rand.Next(5, 10));
            player.QuickSpawnItem(ItemID.ManaPotion, Main.rand.Next(3, 7));
            if (Main.rand.Next(45) == 0)
            {
                player.QuickSpawnItem(mod.ItemType("TutorialHelmet"));
            }
            if (Main.rand.Next(100) == 0)
            {
                player.QuickSpawnItem(mod.ItemType("TMMCBossTreasureBag"));
            }
            if (Main.rand.Next(2) == 0)
            {
                player.QuickSpawnItem(mod.ItemType("AdSlinger"));
            }
            if (Main.rand.Next(2) == 0)
            {
                player.QuickSpawnItem(mod.ItemType("ScamSpinner"));
            }



            }

    }
}   



