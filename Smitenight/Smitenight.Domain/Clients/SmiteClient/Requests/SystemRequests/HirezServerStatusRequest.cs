﻿using Smitenight.Domain.Constants.SmiteClient;

namespace Smitenight.Domain.Clients.SmiteClient.Requests.SystemRequests
{
    public record class HirezServerStatusRequest(string SessionId) 
        : SmiteClientRequest(MethodNameConstants.HirezServerStatusMethod, SessionId);
}
