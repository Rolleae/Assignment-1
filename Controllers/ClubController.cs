using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Assignment_1.Model;

namespace Assignment_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClubController : ControllerBase
    {
        private List<FootballClubs> clubs;
        public ClubController()
        {
            clubs = new List<FootballClubs>()
            {
                new FootballClubs() {ID = 1, name = "Barcelona", country = "Spain", foundationDate = 1899 },
                new FootballClubs() {ID = 1, name = "Real Madrid", country = "Spain", foundationDate = 1901 },
                new FootballClubs() {ID = 1, name = "Munchester United", country = "England", foundationDate = 1878 },
                new FootballClubs() {ID = 1, name = "Bayern", country = "Germany", foundationDate = 1900 },
                new FootballClubs() {ID = 1, name = "Juventus", country = "Italy", foundationDate = 1897 },
                new FootballClubs() {ID = 1, name = "PSG", country = "France", foundationDate = 1970 },
               };
            
        }
        

        [HttpGet]
        public List<FootballClubs> GetAllFootballClubs()
        {
            return clubs;
        }
        [HttpGet("ID/{ID}")]
        public FootballClubs GetClubWithID(int ID)
        {
            return clubs.Where(club => club.ID == ID).FirstOrDefault();
        }
        [HttpGet("Country/{Country}")]
        public List<FootballClubs> GetClubswithCountry(string country)
        {
            return clubs.Where(club => club.country.ToLower() == country.ToLower()).ToList();
        }
        [HttpGet("Name/{Name}")]
        public List<FootballClubs> GetClubWithName( string name)
        {
            return clubs.Where(c => c.name == name).ToList();
        }
        [HttpGet("foundationDate/{foundationDate}")]
        public List<FootballClubs> GetClubWithDate(int foundationDate)
        {
            return clubs.Where(c => c.foundationDate == foundationDate).ToList();
        }
    }
}
