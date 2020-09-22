using System.Collections.Generic;
using System.Linq;
using QuizAPI.Models;

namespace QuizAPI.Data
{
    public class SqlFotballKampRepo : IFotballKampRepo
    {
        private readonly FotballLagContext _context;

        public SqlFotballKampRepo(FotballLagContext context)
        {
            _context = context;
        }
        
        public IEnumerable<FotballKamp> GetAllFotballKamp()
        {
            return _context.AlleFotballKamper.ToList();
        }

        public FotballKamp GetFotballKampById(int id)
        {
            return _context.AlleFotballKamper.FirstOrDefault(f => f.Id == id);
        }

        /*
        public int GetFotballKampLength()
        { 
            int length = _context.AlleFotballKamper.ToList().Count;
            return length;
        }
        */
    }
}