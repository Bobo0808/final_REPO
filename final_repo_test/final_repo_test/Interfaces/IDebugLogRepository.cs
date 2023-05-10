using ClassLibrary.Models;

namespace final_repo_test.Interfaces
{
    public interface IDebugLogRepository
    {
        Task<IEnumerable<DebugLog>> GetAll();
        Task<DebugLog> GetIdAsync(int id);
        Task<DebugLog> Edit(int id);
        Task<IEnumerable<DebugLog>> DeleteIsSolved();
        bool Update(DebugLog DebugLog);
        bool Save();
    }
}
