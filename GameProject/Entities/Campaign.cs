using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    internal class Campaign
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double DiscountRatio { get; set; }

        public Campaign(int id, string name, double discountRatio)
        {
            Id = id;
            Name = name;
            DiscountRatio = discountRatio;
        }   
    }
}
