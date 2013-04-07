using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using AutoProxy.Annotations;
using AutoProxyDemo.Models;

namespace AutoProxyDemo.Controllers
{
    public class PersonsController : ApiController
    {
        private readonly static List<Person> Crew = new List<Person>()
        {
            new Person { PersonId = 1, Name = "Diego", Sex = Sex.Male, Comment = "This is my second name" },
            new Person { PersonId = 2, Name = "Luis", Sex =  Sex.Male, Comment = "Luis is my fisrt name" },
            new Person { PersonId = 3, Name = "Sabrina", Sex =  Sex.Female, Comment = "My mom's name" },
            new Person { PersonId = 4, Name = "Carmen", Sex =  Sex.Female, Comment = "My mom's best friend name" }
        };

        public IEnumerable<Person> GetAll()
        {
            return Crew;
        }

        public IEnumerable<Person> GetMen()
        {
            return Crew.Where(p => p.Sex == Sex.Male);
        }

        [AutoProxyAlias("GetLadies")]
        public IEnumerable<Person> GetWomen()
        {
            return Crew.Where(p => p.Sex == Sex.Female);
        }
    }
}
