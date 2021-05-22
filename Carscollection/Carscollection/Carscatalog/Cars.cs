using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carscollection.Carscatalog
{
    class Cars
    { 
        public int Id { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public string Image { get; set; }
        
        
        public static IEnumerable<Cars>GetCars()
        {
            return new List<Cars>
            {
                new Cars
                {
                    Id=1,
                    Name="Kia Sportage",
                    Model="GDA",
                    Image="https://motor.ru/imgs/2021/01/15/15/4458019/091d5f45cfca72776a9893f2bd733ba9f7adf853.jpg"
                    

                },
                new Cars
                {
                    Id=2,
                    Name="Kia Ceed",
                    Model="GDA",
                    Image="https://auto.ironhorse.ru/wp-content/uploads/2018/04/ceed-hatch-31.jpg"
                    


                },
                new Cars
                {
                    Id=3,
                    Name="Hunday",
                    Model="Accent",
                    Image="https://www.hundaj.ru/wp-content/uploads/2020/04/Hyundai-Accent-2021-2.jpg"
                    

                },
                new Cars
                {
                    Id=4,
                    Name="Hunday",
                    Model="Santa fe",
                    Image="https://cdnimg.rg.ru/img/content/189/56/21/New_Hyundai_Santa_Fe_(19)_t_650x433.jpg"
                    

                },
                new Cars
                {
                    Id=5,
                    Name="Toyota",
                    Model="Prado",
                    Image="https://cdn.motor1.com/images/mgl/qzGyZ/s3/chernyy-toyota-land-cruiser-prado-2020-v-dinamike.jpg"
                    

                },
                new Cars
                {
                    Id=6,
                    Name="Tesla",
                    Model="234",
                    Image="https://grand.photo/wp-content/uploads/2020/05/tesla-autopilot-fiksiruet-samyj-bezopasnyj-kvartal-v-novom-otchete-o.jpg"
                    
                    

                }
            };
        }

    }
}
