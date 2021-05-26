using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using System;
using System.IO;
using System.Collections.Generic;
using Terraria.ID;
using Terraria;
using Terraria.GameContent.UI;
using Terraria.UI;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace CelestialMusic
{
    public class CelestialMusic : Mod
    {
        public override void UpdateMusic(ref int music, ref MusicPriority priority)
        {
            Mod CelestialMod = ModLoader.GetMod("Celestial");
            if (CelestialMod != null)
            {
                if (NPC.AnyNPCs(NPCID.EyeofCthulhu) && Main.expertMode)
                {
                    music = GetSoundSlot(SoundType.Music, "Sounds/Music/Boss1");
                    priority = MusicPriority.BossMedium;
                }

                if (NPC.AnyNPCs(NPCID.KingSlime) && Main.expertMode)
                {
                    music = GetSoundSlot(SoundType.Music, "Sounds/Music/Gelatine Revenge");
                    priority = MusicPriority.BossMedium;
                }

                if (NPC.AnyNPCs(CelestialMod.NPCType("MagnetiteMistress")))
                {
                    music = GetSoundSlot(SoundType.Music, "Sounds/Music/MagneticMagnitude");
                    priority = MusicPriority.BossMedium;
                }
            }
        }

        public override void Load()
        {
            if (!Main.dedServ)
            {
                AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/The Great Beyond"), ItemType("TheGreatBeyondMusicBox"), TileType("TheGreatBeyondMusicBoxTile"));
            }
        }
    }
}