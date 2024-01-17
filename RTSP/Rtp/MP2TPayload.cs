﻿using System;
using System.Collections.Generic;

namespace Rtsp.Rtp
{
    public class MP2TransportPayload : IPayloadProcessor
    {
        public List<ReadOnlyMemory<byte>> ProcessRTPPacket(RtpPacket packet)
        {
            // TODO check the RFC 2250
            return [packet.Payload];
        }
    }
}
