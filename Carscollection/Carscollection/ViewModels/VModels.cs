using Carscollection.Carscatalog;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carscollection.ViewModels
{
    class VModels
    {
        public ObservableCollection<Cars> Car { get; set; }
        public Cars SelectedCar { get; set; }
        public VModels()
        {
            Car = new ObservableCollection<Cars>(Cars.GetCars());
        }
    }
}
