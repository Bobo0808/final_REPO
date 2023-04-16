using final_repo_test.Models;
using final_repo_test.ViewModels.LoginStatus;

namespace final_repo_test.Interfaces
{
    public interface ILoginStatusRepository
    {
        Task<int> GetTotalCount();
        Task<int> GetAverage();
        Task<IEnumerable<LoginStaus>> GetWeek();
        Task<IEnumerable<LoginStaus>> GetMonth();
        Task<IEnumerable<LoginStaus>> GetYear();

        Task<GetTimeViewModel> GetTime();

    }
}
