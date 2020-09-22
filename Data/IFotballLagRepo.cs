using System.Collections.Generic;
using QuizAPI.Models;

namespace QuizAPI.Data
{
    public interface IFotballLagRepo
    {
        IEnumerable<FotballLag> GetAllFotballLag(); 
        FotballLag GetFotballLagById(int id);
    }
}