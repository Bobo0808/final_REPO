using final_repo_test.Interfaces;
using ClassLibrary.Models;
using Microsoft.EntityFrameworkCore;
using ClassLibrary;

namespace final_repo_test.Repositroy
{
    public class DebugLogRepository:IDebugLogRepository
    {
        private readonly ChickenDbContext _context;
        public DebugLogRepository(ChickenDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<DebugLog>> DeleteIsSolved()
        {
            var temp = await _context.DebugLogs.Where(s=>s.D_isSolved==true).ToListAsync();
            foreach(var d in temp)
            {
                _context.DebugLogs.Remove(d);
            }
            return (IEnumerable<DebugLog>)temp;
        }

        public async Task<DebugLog> Edit(int id)
        {
            var temp = _context.DebugLogs.First(s => s.D_ID == id);
            if (temp.D_isSolved==true)
            {
                temp.D_isSolved = false;
            }
            else
            {
                temp.D_isSolved= true;
            }
            return temp;
        }

        public async Task<IEnumerable<DebugLog>> GetAll()
        {
            return await _context.DebugLogs.ToListAsync();
        }



        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0;
        }

        public bool Update(DebugLog DebugLog)
        {
            _context.Update(DebugLog);
            return Save();
        }

        async Task<DebugLog> IDebugLogRepository.GetIdAsync(int id)
        {
            return await _context.DebugLogs.FirstAsync(s => s.D_ID == id);
        }
    }
}
