using System.Collections.Generic;
using System.Linq;
using QuizAPI.Models;

namespace QuizAPI.Data
{
    public class SqlFotballLagRepo : IFotballLagRepo
    {
        private readonly FotballLagContext _context;

        public SqlFotballLagRepo(FotballLagContext context)
        {
            _context = context;
        }
        
        public IEnumerable<FotballLag> GetAllFotballLag()
        {
            return _context.AlleFotballLag.ToList();
        }

        public FotballLag GetFotballLagById(int id)
        {
            return _context.AlleFotballLag.FirstOrDefault(f => f.Id == id);
        }
    }
}