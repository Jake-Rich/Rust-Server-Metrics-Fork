﻿using Harmony;
using Network;

namespace RustServerMetrics.HarmonyPatches
{
    [HarmonyPatch(typeof(NetWrite), nameof(NetWrite.PacketID))]
    public class NetWrite_PacketID_Patch
    {
        [HarmonyPostfix]
        public static void Postfix(Message.Type val)
        {
            MetricsLogger.Instance.OnNetWritePacketID(val);
        }
    }
}