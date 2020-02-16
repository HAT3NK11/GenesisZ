using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace GenesisZ.Items.Enemies
{
    public class  RogueOrecorp : ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("OreCorp Drone");
        }

        public override void SetDefaults()
        {
            npc.width = 18;
            npc.height = 24;
            npc.damage = 8;
            npc.defense = 7;
            npc.lifeMax = 40;
            npc.HitSound = SoundID.NPCHit2;
            npc.DeathSound = SoundID.NPCDeath2;
            npc.value = 150f;
            npc.knockBackResist = 0.25f;
            npc.aiStyle = 2;
            Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.DemonEye]; //Main.npcFrameCount[2];
            aiType = NPCID.DemonEye; // aiType = 2;
            animationType = NPCID.DemonEye; // animationType = 2;aa
        }

        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            return SpawnCondition.OverworldNightMonster.Chance * 0.4f;
        }

        public override void NPCLoot()
        {
            Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("CryoliteOre"), Main.rand.Next(0, 2));
            Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("BauxiteOre"), Main.rand.Next(0, 2));
        }
    }
}
