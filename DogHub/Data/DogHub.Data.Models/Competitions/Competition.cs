﻿namespace DogHub.Data.Models.Competitions
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using DogHub.Common;
    using DogHub.Data.Common.Models;
    using DogHub.Data.Models.Dogs;
    using DogHub.Data.Models.EvaluationForms;

    public class Competition : BaseDeletableModel<int>
    {
        public Competition()
        {
            this.DogsCompetitions = new HashSet<DogCompetition>();
            this.EvaluationForms = new HashSet<EvaluationForm>();
        }

        [Required]
        [MaxLength(GlobalConstants.CompetitionNameMaxLength)]
        public string Name { get; set; }

        public virtual CompetitionImage CompetitionImage { get; set; }

        public DateTime CompetitionStart { get; set; }

        public DateTime CompetitionEnd { get; set; }

        [MaxLength(GlobalConstants.OrganisedByMaxLength)]
        public int OrganiserId { get; set; }

        public virtual Organiser Organiser { get; set; }

        public int BreedId { get; set; }

        public virtual Breed Breed { get; set; }

        public virtual ICollection<DogCompetition> DogsCompetitions { get; set; }

        public virtual ICollection<EvaluationForm> EvaluationForms { get; set; }
    }
}
