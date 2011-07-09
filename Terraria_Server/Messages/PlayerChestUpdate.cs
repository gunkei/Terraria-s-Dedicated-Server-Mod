﻿using System;

namespace Terraria_Server.Messages
{
    public class PlayerChestUpdate : IMessage
    {
        public Packet GetPacket()
        {
            return Packet.PLAYER_CHEST_UPDATE;
        }

        public int? GetRequiredNetMode()
        {
            return null;
        }

        public void Process(int start, int length, int num, int whoAmI, byte[] readBuffer, byte bufferData)
        {
            int inventoryIndex = BitConverter.ToInt32(readBuffer, num);
            num += 2;
            int x = BitConverter.ToInt32(readBuffer, num);
            num += 4;
            int y = BitConverter.ToInt32(readBuffer, num);

            Main.players[whoAmI].chest = inventoryIndex;
        }
    }
}
