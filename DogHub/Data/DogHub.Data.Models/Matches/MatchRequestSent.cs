﻿namespace DogHub.Data.Models.Matches
{
    using DogHub.Data.Common.Models;

    public class MatchRequestSent : BaseDeletableModel<int>
    {
        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }

        public int SenderDogId { get; set; }

        public virtual Dog SenderDog { get; set; }

        public int ReceiverDogId { get; set; }

        public virtual Dog ReceiverDog { get; set; }

        public bool IsUnderReview { get; set; }

        public bool IsApproved { get; set; }

        public bool IsRejected { get; set; }
    }
}
