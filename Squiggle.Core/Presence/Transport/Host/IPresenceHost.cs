﻿using System.Net;
using System.ServiceModel;
using Squiggle.Core.Chat;

namespace Squiggle.Core.Presence.Transport.Host
{
    [ServiceContract]
    public interface IPresenceHost
    {
        [OperationContract]
        void ReceivePresenceMessage(SquiggleEndPoint sender, SquiggleEndPoint recepient, byte[] message);
    }
}