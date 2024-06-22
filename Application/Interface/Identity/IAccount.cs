using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interface.Identity
{
    public  interface IAccount
    {

        Task<ServiceResponse> LoginAsync(LoginUserRequestDTO model);
        Task<ServiceResponse> CreateAsync(CreateUserRequestDTO model);

        Task<IEnumerable<GetUserWithClaimResponseDTO>> GetUserWithClaimAsync();

        Task SetupAsync ();

        Task<ServiceResponse> UpdateUserAsync(ChangeUserClaimRequestDTO model);

        Task SaveActivityAsync(ActivityTrackerRequestDTO model);
        Task<IEnumerable<ActivityTrackerResponseDTO>> GetActivitiesAsync();










    }
}
