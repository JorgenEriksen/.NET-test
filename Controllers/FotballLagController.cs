using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using QuizAPI.Data;
using QuizAPI.Models;

namespace QuizAPI.Controllers
{
    [ApiController]
    [Route("api/fotballlag")]
    public class FotballLagController : ControllerBase
    {
        private readonly IFotballLagRepo _repository;

        public FotballLagController(IFotballLagRepo repository)
        {
            _repository = repository;
        }

        // private readonly MockFotballLagRepo _repository = new MockFotballLagRepo();
        //GET api/FotballLag
        [HttpGet]
        public ActionResult <IEnumerable<FotballLag>> GetAllFotballLag() // <FotballLag> navn på model
        {
     
            var fotballLagItems = _repository.GetAllFotballLag();

            return Ok(fotballLagItems);   
        }

        //GET api/FotballLag/{id}
        [HttpGet("{id}")]
        public ActionResult <FotballLag> GetFotballLagById(int id)
        {
            
            var fotballLagItem = _repository.GetFotballLagById(id);

            return Ok(fotballLagItem);
            
        }
    }
}