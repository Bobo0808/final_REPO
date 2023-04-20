using final_repo_test.Models;
using final_repo_test.ViewModels.LoginStatus;

namespace final_repo_test.Interfaces
{
    public interface ILoginStatusRepository
    {
        Task<GetTotalCountViewModel> GetTotalCount();
        Task<GetAverageViewModel> GetAverage();
        Task<GetDayViewModel> GetDay(string Chart);
        Task<GetTimeViewModel> GetTime();

    }
}
