using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Entities
{
    internal class Sales
    {
        public Sales(int id, string salesId, Game game, Gamer gamer)
        {
            Id = id;
            SalesId = salesId;
            Game = game;
            Gamer = gamer;
        }

        public int Id { get; set; }
        public string SalesId { get; set; }
        public Game Game{ get; set; }
        public Gamer Gamer { get; set; }
    }
}
