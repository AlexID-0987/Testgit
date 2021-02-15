using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestOil
{
    class Toplivo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        
        public override string ToString()
        {
            return $"{ Name}";
        }
        
        public static List<Toplivo> GetToplivos()
        {
            return new List<Toplivo>
            {
                new Toplivo
                {
                    Id=1,
                    Name="A-92",
                    Price=23.00,
                    
                   
                    
                },
                new Toplivo
                {
                    Id=2,
                    Name="A-95",
                    Price=25.54,


                },
                new Toplivo
                {
                    Id=3,
                    Name="Premium-95",
                    Price=27.89,



                },
                new Toplivo
                {
                    Id=4,
                    Name="A-100",
                    Price=30.12,



                }

        };
            
            
            
        }

    }
}
