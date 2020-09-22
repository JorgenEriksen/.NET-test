using System.Collections.Generic;
using QuizAPI.Models;

namespace QuizAPI.Data
{
    public interface IFotballKampRepo
    {
        IEnumerable<FotballKamp> GetAllFotballKamp(); 
        FotballKamp GetFotballKampById(int id);
        //int GetFotballKampLength();
    }
}