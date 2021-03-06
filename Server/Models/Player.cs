using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable enable
namespace Server.Models
{
    public class Player
    {
        [Key] public ulong SteamId { get; set; }
        public string? Comment { get; set; }
        public IEnumerable<MatchPlayer> Matches { get; set; } = null!;
        public ushort PatreonLevel { get; set; }
        public DateTime? PatreonEndDate { get; set; }

        public bool? PatreonEmblemEnabled { get; set; }
        public string? PatreonEmblemColor { get; set; }
        public bool? PatreonBootsEnabled { get; set; }
        public List<int>? PatreonChatWheelFavorites { get; set; }
        [Column(TypeName = "jsonb")]
        public Dictionary<string, object>? PatreonCosmetics { get; set; }
    }
}
