﻿namespace DogHub.Services.Data
{
    using DogHub.Web.ViewModels.Competitions;
    using DogHub.Web.ViewModels.Dashboards;
    using DogHub.Web.ViewModels.DogMatches;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IOwnerDashboardsService
    {
        IEnumerable<T> GetAllDogsOwned<T>(string userId);

        DashboardIndexViewModel DashboardData(string userId);

        T GetById<T>(int id);

        Task UpdateAsync(int id, EditDogDataInputModel input);

        Task DeleteAsync(int id);

        IEnumerable<DogsInCompetitionsViewModel> DogsInCompetitions(string userId);

        IEnumerable<CompetitionDetailsViewModel> VoteInCompetitionDetails(string userId);

        IEnumerable<DogPartnershipReguestsViewModel> GetPartnershipRequestsSent(string userId);

        IEnumerable<DogPartnershipReguestsViewModel> GetPartnershipRequestsReceived(string userId);
    }
}
