using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using QuizAPI.Data;
using QuizAPI.Models;

namespace QuizAPI.Controllers
{
    [ApiController]
    [Route("api/fotballkamp")]

    public class FotballKampController : ControllerBase
    {
        
        private readonly IFotballKampRepo _repository;

        public FotballKampController(IFotballKampRepo repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public ActionResult <IEnumerable<FotballKamp>> GetAllFotballKamp() // <FotballKamp> navn på model
        {
     
            var fotballKampItems = _repository.GetAllFotballKamp();

            return Ok(fotballKampItems);   
        }

        //GET api/fotballkamp/{id}
        [HttpGet("{id}")]
        public ActionResult <FotballKamp> GetFotballKampById(int id)
        {
            
            var fotballKampItem = _repository.GetFotballKampById(id);

            return Ok(fotballKampItem);
            
        }
    }
}