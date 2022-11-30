using GameProject.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    internal class GamerManager : IGamerService
    {
        IGamerCheckService gamerCheckService;
       public GamerManager (IGamerCheckService gamerCheckService)
        {
            this.gamerCheckService = gamerCheckService; 
        }

        public void Add(Gamer gamer)
        {
            checkIfRealPerson(gamer);
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " kişisi eklendi");
            
            
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + "kişisi silindi");
            
        }

        public void Update(Gamer gamer)
        { Console.WriteLine(gamer.FirstName + " " + gamer.LastName + "kişisi güncellendi");
            
        }

        private void checkIfRealPerson(Gamer gamer)
        {
            if (!this.gamerCheckService.CheckIfRealPerson(gamer))
            {

                throw new Exception("COULD.NOT.INDIVIDUAL.CUSTOMER.ADDED");
            }
        }
    }
}
