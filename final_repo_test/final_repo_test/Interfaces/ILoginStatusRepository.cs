using ClassLibrary.ViewModels.LoginStatus;

namespace final_repo_test.Interfaces
{
    public interface ILoginStatusRepository
    {
        Task<GetDayViewModel> GetDay(string Chart);

    }
}
