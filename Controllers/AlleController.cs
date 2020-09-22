using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using QuizAPI.Data;
using QuizAPI.Models;

namespace QuizAPI.Controllers
{
    [ApiController]
    [Route("api/alle")]
    public class AlleController : ControllerBase
    {
        private readonly IFotballLagRepo _lagRepo;
        private readonly IFotballKampRepo _kampRepo;

        public AlleController(IFotballLagRepo lagRepo, IFotballKampRepo kampRepo)
        {
            _lagRepo = lagRepo;
            _kampRepo = kampRepo;
        }
        
        //public ActionResult <IEnumerable<FotballKamp>> GetAllFotballKamp() 
        [HttpGet]
         public ActionResult GetAllFotballKamp() 
        {
     
            var fotballKampItems = _kampRepo.GetAllFotballKamp();
            var fotballLagItems = _lagRepo.GetAllFotballLag();

            var result = new { Kamp = fotballKampItems, Lag = fotballLagItems };
            
            return Ok(result);   
            
        }

        [HttpGet("{kampid}")]
        public ActionResult test(int kampid) 
        {
            var fotballKampItem = _kampRepo.GetFotballKampById(kampid);
            var lag1 = _lagRepo.GetFotballLagById(fotballKampItem.Lag1id);
            var lag2 = _lagRepo.GetFotballLagById(fotballKampItem.Lag2id);

            string sporsmal = lag1.Land + " spilte mot " + lag2.Land + ". Hvem vant?";

            string svar = _lagRepo.GetFotballLagById(fotballKampItem.VinnerLagId).Land;

            var result = new { Sporsmal = sporsmal, Svar = svar };
         
            return Ok(result);
        }

        
        [HttpGet("sporsmal")]
        public ActionResult GetQuiz(int kampid) 
        {
            var fotballKampItem = _kampRepo.GetAllFotballKamp();

            //int len =  _kampRepo.GetFotballKampLength();
         
         
            return Ok(fotballKampItem);
        }

    }
}