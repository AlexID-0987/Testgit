using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Name_random_a
{
    class Student : INotifyPropertyChanged
    {
        private string name;
        private string lastname;
        private string color = "Green";

        public string Name
        {
            get => name; set
            {
                name = value;
                NotifyOfPropertyChanged();
            }

        }
        public string Lastname
        { 
            get => lastname; set
            { 
                  lastname = value;
                  NotifyOfPropertyChanged();
            }
        }
        public string Color 
        { 
            get => color; set
            {
                color = value;
                NotifyOfPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyOfPropertyChanged([CallerMemberName]string propertyName="")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName)); 
        }

        public override string ToString() => $"{Name} {Lastname}";
        
        
    }
}
