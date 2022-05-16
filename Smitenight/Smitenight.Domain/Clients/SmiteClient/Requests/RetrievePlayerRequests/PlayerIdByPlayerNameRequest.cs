﻿namespace Smitenight.Domain.Clients.SmiteClient.Requests.RetrievePlayerRequests
{
    public record class PlayerIdByPlayerNameRequest(
        int DeveloperId,
        string MethodName,
        string ResponseType,
        string Signature,
        string SessionId,
        string CurrentDate,
        string PlayerName) : SmiteClientRequest(DeveloperId, MethodName, ResponseType, Signature, SessionId, CurrentDate);
}
