﻿using System.Text.Json.Serialization;

namespace Smitenight.Infrastructure.SmiteClient.Contracts.MatchInfoResponses
{
    public record class MatchDetailsResponseDto
    {
        [JsonPropertyName("Account_Level")]
        public int AccountLevel { get; init; }
        [JsonPropertyName("ActiveId1")]
        public int ActiveId1 { get; init; }
        [JsonPropertyName("ActiveId2")]
        public int ActiveId2 { get; init; }
        [JsonPropertyName("ActiveId3")]
        public int ActiveId3 { get; init; }
        [JsonPropertyName("ActiveId4")]
        public int ActiveId4 { get; init; }
        [JsonPropertyName("ActivePlayerId")]
        public string? ActivePlayerId { get; init; }
        [JsonPropertyName("Assists")]
        public int Assists { get; init; }
        [JsonPropertyName("Ban1")]
        public string? Ban1 { get; init; }
        [JsonPropertyName("Ban10")]
        public string? Ban10 { get; init; }
        [JsonPropertyName("Ban10Id")]
        public int Ban10Id { get; init; }
        [JsonPropertyName("Ban11")]
        public string? Ban11 { get; init; }
        [JsonPropertyName("Ban11Id")]
        public int Ban11Id { get; init; }
        [JsonPropertyName("Ban12")]
        public string? Ban12 { get; init; }
        [JsonPropertyName("Ban12Id")]
        public int Ban12Id { get; init; }
        [JsonPropertyName("Ban1Id")]
        public int Ban1Id { get; init; }
        [JsonPropertyName("Ban2")]
        public string? Ban2 { get; init; }
        [JsonPropertyName("Ban2Id")]
        public int Ban2Id { get; init; }
        [JsonPropertyName("Ban3")]
        public string? Ban3 { get; init; }
        [JsonPropertyName("Ban3Id")]
        public int Ban3Id { get; init; }
        [JsonPropertyName("Ban4")]
        public string? Ban4 { get; init; }
        [JsonPropertyName("Ban4Id")]
        public int Ban4Id { get; init; }
        [JsonPropertyName("Ban5")]
        public string? Ban5 { get; init; }
        [JsonPropertyName("Ban5Id")]
        public int Ban5Id { get; init; }
        [JsonPropertyName("Ban6")]
        public string? Ban6 { get; init; }
        [JsonPropertyName("Ban6Id")]
        public int Ban6Id { get; init; }
        [JsonPropertyName("Ban7")]
        public string? Ban7 { get; init; }
        [JsonPropertyName("Ban7Id")]
        public int Ban7Id { get; init; }
        [JsonPropertyName("Ban8")]
        public string? Ban8 { get; init; }
        [JsonPropertyName("Ban8Id")]
        public int Ban8Id { get; init; }
        [JsonPropertyName("Ban9")]
        public string? Ban9 { get; init; }
        [JsonPropertyName("Ban9Id")]
        public int Ban9Id { get; init; }
        [JsonPropertyName("Camps_Cleared")]
        public int CampsCleared { get; init; }
        [JsonPropertyName("Conquest_Losses")]
        public int ConquestLosses { get; init; }
        [JsonPropertyName("Conquest_Points")]
        public int ConquestPoints { get; init; }
        [JsonPropertyName("Conquest_Tier")]
        public int ConquestTier { get; init; }
        [JsonPropertyName("Conquest_Wins")]
        public int ConquestWins { get; init; }
        [JsonPropertyName("Damage_Bot")]
        public int DamageBot { get; init; }
        [JsonPropertyName("Damage_Done_In_Hand")]
        public int DamageDoneInHand { get; init; }
        [JsonPropertyName("Damage_Done_Magical")]
        public int DamageDoneMagical { get; init; }
        [JsonPropertyName("Damage_Done_Physical")]
        public int DamageDonePhysical { get; init; }
        [JsonPropertyName("Damage_Mitigated")]
        public int DamageMitigated { get; init; }
        [JsonPropertyName("Damage_Player")]
        public int DamagePlayer { get; init; }
        [JsonPropertyName("Damage_Taken")]
        public int DamageTaken { get; init; }
        [JsonPropertyName("Damage_Taken_Magical")]
        public int DamageTakenMagical { get; init; }
        [JsonPropertyName("Damage_Taken_Physical")]
        public int DamageTakenPhysical { get; init; }
        [JsonPropertyName("Deaths")]
        public int Deaths { get; init; }
        [JsonPropertyName("Distance_Traveled")]
        public int DistanceTraveled { get; init; }
        [JsonPropertyName("Duel_Losses")]
        public int DuelLosses { get; init; }
        [JsonPropertyName("Duel_Points")]
        public int DuelPoints { get; init; }
        [JsonPropertyName("Duel_Tier")]
        public int DuelTier { get; init; }
        [JsonPropertyName("Duel_Wins")]
        public int DuelWins { get; init; }
        [JsonPropertyName("Entry_Datetime")]
        public string? EntryDatetime { get; init; }
        [JsonPropertyName("Final_Match_Level")]
        public int FinalMatchLevel { get; init; }
        [JsonPropertyName("First_Ban_Side")]
        public string? FirstBanSide { get; init; }
        [JsonPropertyName("GodId")]
        public int GodId { get; init; }
        [JsonPropertyName("Gold_Earned")]
        public int GoldEarned { get; init; }
        [JsonPropertyName("Gold_Per_Minute")]
        public int GoldPerMinute { get; init; }
        [JsonPropertyName("Healing")]
        public int Healing { get; init; }
        [JsonPropertyName("Healing_Bot")]
        public int HealingBot { get; init; }
        [JsonPropertyName("Healing_Player_Self")]
        public int HealingPlayerSelf { get; init; }
        [JsonPropertyName("ItemId1")]
        public int ItemId1 { get; init; }
        [JsonPropertyName("ItemId2")]
        public int ItemId2 { get; init; }
        [JsonPropertyName("ItemId3")]
        public int ItemId3 { get; init; }
        [JsonPropertyName("ItemId4")]
        public int ItemId4 { get; init; }
        [JsonPropertyName("ItemId5")]
        public int ItemId5 { get; init; }
        [JsonPropertyName("ItemId6")]
        public int ItemId6 { get; init; }
        [JsonPropertyName("Item_Active_1")]
        public string? ItemActive1 { get; init; }
        [JsonPropertyName("Item_Active_2")]
        public string? ItemActive2 { get; init; }
        [JsonPropertyName("Item_Active_3")]
        public string? ItemActive3 { get; init; }
        [JsonPropertyName("Item_Active_4")]
        public string? ItemActive4 { get; init; }
        [JsonPropertyName("Item_Purch_1")]
        public string? ItemPurch1 { get; init; }
        [JsonPropertyName("Item_Purch_2")]
        public string? ItemPurch2 { get; init; }
        [JsonPropertyName("Item_Purch_3")]
        public string? ItemPurch3 { get; init; }
        [JsonPropertyName("Item_Purch_4")]
        public string? ItemPurch4 { get; init; }
        [JsonPropertyName("Item_Purch_5")]
        public string? ItemPurch5 { get; init; }
        [JsonPropertyName("Item_Purch_6")]
        public string? ItemPurch6 { get; init; }
        [JsonPropertyName("Joust_Losses")]
        public int JoustLosses { get; init; }
        [JsonPropertyName("Joust_Points")]
        public int JoustPoints { get; init; }
        [JsonPropertyName("Joust_Tier")]
        public int JoustTier { get; init; }
        [JsonPropertyName("Joust_Wins")]
        public int JoustWins { get; init; }
        [JsonPropertyName("Killing_Spree")]
        public int KillingSpree { get; init; }
        [JsonPropertyName("Kills_Bot")]
        public int KillsBot { get; init; }
        [JsonPropertyName("Kills_Double")]
        public int KillsDouble { get; init; }
        [JsonPropertyName("Kills_Fire_Giant")]
        public int KillsFireGiant { get; init; }
        [JsonPropertyName("Kills_First_Blood")]
        public int KillsFirstBlood { get; init; }
        [JsonPropertyName("Kills_Gold_Fury")]
        public int KillsGoldFury { get; init; }
        [JsonPropertyName("Kills_Penta")]
        public int KillsPenta { get; init; }
        [JsonPropertyName("Kills_Phoenix")]
        public int KillsPhoenix { get; init; }
        [JsonPropertyName("Kills_Player")]
        public int KillsPlayer { get; init; }
        [JsonPropertyName("Kills_Quadra")]
        public int KillsQuadra { get; init; }
        [JsonPropertyName("Kills_Siege_Juggernaut")]
        public int KillsSiegeJuggernaut { get; init; }
        [JsonPropertyName("Kills_Single")]
        public int KillsSingle { get; init; }
        [JsonPropertyName("Kills_Triple")]
        public int KillsTriple { get; init; }
        [JsonPropertyName("Kills_Wild_Juggernaut")]
        public int KillsWildJuggernaut { get; init; }
        [JsonPropertyName("Map_Game")]
        public string? MapGame { get; init; }
        [JsonPropertyName("Mastery_Level")]
        public int MasteryLevel { get; init; }
        [JsonPropertyName("Match")]
        public int Match { get; init; }
        [JsonPropertyName("Match_Duration")]
        public int MatchDuration { get; init; }
        [JsonPropertyName("MergedPlayers")]
        public object? MergedPlayers { get; init; } // No clue what this is/does so keep it a object
        [JsonPropertyName("Minutes")]
        public int Minutes { get; init; }
        [JsonPropertyName("Multi_kill_Max")]
        public int MultiKillMax { get; init; }
        [JsonPropertyName("Objective_Assists")]
        public int ObjectiveAssists { get; init; }
        [JsonPropertyName("PartyId")]
        public int PartyId { get; init; }
        [JsonPropertyName("Rank_Stat_Conquest")]
        public float RankStatConquest { get; init; }
        [JsonPropertyName("Rank_Stat_Duel")]
        public int RankStatDuel { get; init; }
        [JsonPropertyName("Rank_Stat_Joust")]
        public int RankStatJoust { get; init; }
        [JsonPropertyName("Reference_Name")]
        public string? Reference_Name { get; init; }
        [JsonPropertyName("Region")]
        public string? Region { get; init; }
        [JsonPropertyName("Role")]
        public string? Role { get; init; }
        [JsonPropertyName("Skin")]
        public string? Skin { get; init; }
        [JsonPropertyName("SkinId")]
        public int SkinId { get; init; }
        [JsonPropertyName("Structure_Damage")]
        public int StructureDamage { get; init; }
        [JsonPropertyName("Surrendered")]
        public int Surrendered { get; init; }
        [JsonPropertyName("TaskForce")]
        public int TaskForce { get; init; }
        [JsonPropertyName("Team1Score")]
        public int Team1Score { get; init; }
        [JsonPropertyName("Team2Score")]
        public int Team2Score { get; init; }
        [JsonPropertyName("TeamId")]
        public int TeamId { get; init; }
        [JsonPropertyName("Team_Name")]
        public string? TeamName { get; init; }
        [JsonPropertyName("Time_Dead_Seconds")]
        public int TimeDeadSeconds { get; init; }
        [JsonPropertyName("Time_In_Match_Seconds")]
        public int TimeInMatchSeconds { get; init; }
        [JsonPropertyName("Towers_Destroyed")]
        public int TowersDestroyed { get; init; }
        [JsonPropertyName("Wards_Placed")]
        public int WardsPlaced { get; init; }
        [JsonPropertyName("Win_Status")]
        public string? WinStatus { get; init; }
        [JsonPropertyName("Winning_TaskForce")]
        public int WinningTaskForce { get; init; }
        [JsonPropertyName("hasReplay")]
        public string? HasReplay { get; init; }
        [JsonPropertyName("hz_gamer_tag")]
        public string? HzGamerTag { get; init; }
        [JsonPropertyName("hz_player_name")]
        public string? HzPlayerName { get; init; }
        [JsonPropertyName("match_queue_id")]
        public int MatchQueueId { get; init; }
        [JsonPropertyName("name")]
        public string? Name { get; init; }
        [JsonPropertyName("playerId")]
        public string? PlayerId { get; init; }
        [JsonPropertyName("playerName")]
        public string? PlayerName { get; init; }
        [JsonPropertyName("playerPortalId")]
        public string? PlayerPortalId { get; init; }
        [JsonPropertyName("playerPortalUserId")]
        public string? PlayerPortalUserId { get; init; }
        [JsonPropertyName("ret_msg")]
        public object? RetMsg { get; init; }
    }
}
