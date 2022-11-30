using GameProject.Abstracts;
using GameProject.Adapter;
using GameProject.Concretes;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer = new Gamer();
            gamer.Id = 5485;
            gamer.NationalityId = "29221334770";
            gamer.FirstName = "Burcu";
            gamer.LastName = "Bayık";
            gamer.BirthDate = 1998;

            Game game = new Game(1,"Valorant",170); 
            Sales sales = new Sales(1,"2656484",game,gamer);
            Campaign campaign = new Campaign(1, "Yılbaşı Kampanyası",0.5);
            IGamerService gamerService = new GamerManager(new MernisServiceAdapter());
            gamerService.Add(gamer);
            ISalesService salesService = new SalesManager();
            salesService.Add(sales);
            salesService.AddWithCampaign(sales, campaign);
            
            Console.ReadLine();
        }
    }
}
