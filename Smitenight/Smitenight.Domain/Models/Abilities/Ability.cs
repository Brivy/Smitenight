﻿using Smitenight.Domain.Exceptions;
using Smitenight.Domain.Interfaces;
using Smitenight.Domain.Models.Gods;

namespace Smitenight.Domain.Models.Abilities
{
    public class Ability : IEntity
    {
        public int Id { get; set; }
        public int GodId { get; set; }

        public string Cooldown { get; set; } = null!;
        public string Cost { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string Summary { get; set; } = null!;
        public string Url { get; set; } = null!;

        #region Navigation

        private God? _god;

        public God God
        {
            get => _god ?? throw new NavigationPropertyNullException(nameof(God));
            set => _god = value;
        }

        public List<AbilityRank> AbilityRanks { get; set; }
        public List<AbilityTag> AbilityTags { get; set; }

        #endregion

        public Ability()
        {
            AbilityRanks = new List<AbilityRank>();
            AbilityTags = new List<AbilityTag>();
        }
    }
}
