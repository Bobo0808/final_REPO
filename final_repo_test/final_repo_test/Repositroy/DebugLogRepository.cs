using final_repo_test.Data;
using final_repo_test.Interfaces;
using final_repo_test.Models;
using Microsoft.EntityFrameworkCore;

namespace final_repo_test.Repositroy
{
    public class DebugLogRepository:IDebugLogRepository
    {
        private readonly ApplicationDbContext _context;
        public DebugLogRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Task<IEnumerable<DebugLog>> DeleteIsSolved()
        {
            throw new NotImplementedException();
        }

        public async Task<DebugLog> Edit(int id)
        {
            if (_context.DebugLogs.First(s => s.D_ID == id).D_isSolved==true)
            {
                _context.DebugLogs.First(s => s.D_ID == id).D_isSolved = false;
            }
            else
            {
                _context.DebugLogs.First(s => s.D_ID == id).D_isSolved= true;
            }
            return await _context.DebugLogs.FirstAsync(s => s.D_ID == id);
        }

        public async Task<IEnumerable<DebugLog>> GetAll()
        {
            return await _context.DebugLogs.ToListAsync();
        }


        public bool Save(DebugLog DebugLog)
        {
            var saved = _context.SaveChanges();
            return saved > 0;
        }

        public bool Save()
        {
            throw new NotImplementedException();
        }

        public bool Update(DebugLog DebugLog)
        {
            return Save(DebugLog);
        }

        async Task<DebugLog> IDebugLogRepository.GetIdAsync(int id)
        {
            return await _context.DebugLogs.FirstAsync(s => s.D_ID == id);
        }
    }
}
