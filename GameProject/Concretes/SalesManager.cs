using GameProject.Abstracts;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concretes
{
    internal class SalesManager : ISalesService
    {
        public void Add(Sales sales)
        {
            Console.WriteLine(sales.Game.Name + " adlı oyun " +sales.Gamer.Id+ " idli oyuncuya " + sales.Game.UnitPrice + " tl karşılığında satılmıştır." );
        }

        public void AddWithCampaign(Sales sales, Campaign campaign)
        {
           double priceWithCampaing= sales.Game.UnitPrice-sales.Game.UnitPrice*campaign.DiscountRatio;
            Console.WriteLine(sales.Game.Name + " adlı oyun " + sales.Gamer.Id + " idli oyuncuya " +campaign.Name+" kapsamında "+ priceWithCampaing + " tl karşılığında satılmıştır.");
        }
    }
}
