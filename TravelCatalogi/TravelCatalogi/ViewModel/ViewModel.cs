using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using TravelCatalogi.Country;



namespace TravelCatalogi.ViewModel
{
    class ViewModel
    {
        

        public ObservableCollection<Country.Country> Countries { get; set; }
        public Country.Country SelectedCountry { get; set; }
        public ICommand ShowCommandTravel { get; private set; }
        
        

        public ViewModel()
        {
            Countries = new ObservableCollection<Country.Country>(Country.Country.GetCountries());
            ShowCommandTravel = new RelayCommand(ShowTravel);
            Initcomand(); 


        }
        

        private void ShowTravel(object parameter)
        {
            MessageBox.Show("Данний проєкт може містити аутентічні недоліки","My App", MessageBoxButton.YesNo, MessageBoxImage.Information, MessageBoxResult.No);
            

            


        }

        private void Initcomand()
        {
            AddTravel = new RelayCommand(x =>
              {
                  Countries.Add(new Country.Country
                  {
                      Id = 7,
                      TravelCountry = "Horvatia",
                      CountryImage = "https://upload.wikimedia.org/wikipedia/commons/thumb/1/1b/Flag_of_Croatia.svg/250px-Flag_of_Croatia.svg.png",
                      TravelCity = "Zagreb",
                      Image = "https://img.poehalisnami.ua/static/countries/c55/small/55_637145308051857359.jpg",
                      CityHotel = "Petrol",
                      Street = "st.Nabereshna, h.2",
                      HImage = "https://media-cdn.tripadvisor.com/media/photo-s/1a/c2/1a/f0/caption.jpg",
                      ImageRoom = "https://cf.bstatic.com/images/hotel/max1024x768/151/151854925.jpg"
                  });
              });
            RemoveTravel = new RelayCommand(x =>
              {
                  Countries.Remove(SelectedCountry);
              });
            Print = new RelayCommand(x =>
              {

                  
                  PrintDialog printDialog = new PrintDialog();
                  Run run = new Run(SelectedCountry.CountryImage);
                  Run image = new Run(SelectedCountry.Image);
                  Run strit = new Run(SelectedCountry.Street);
                  Run country = new Run(SelectedCountry.TravelCountry);
                  TextBlock visual = new TextBlock();
                  visual.Inlines.Add(run);
                  visual.Inlines.Add(image);
                  visual.Inlines.Add(strit);
                  visual.Inlines.Add(country);
                  visual.Margin = new Thickness(5);
                  visual.TextWrapping = TextWrapping.Wrap;
                  visual.LayoutTransform = new ScaleTransform(2, 2);
                  Size pageSize = new Size(printDialog.PrintableAreaWidth, printDialog.PrintableAreaHeight);
                  visual.Measure(pageSize);
                  visual.Arrange(new Rect(0, 0, pageSize.Width, pageSize.Height));
                  printDialog.PrintVisual(visual, "Country");


              });
            Save = new RelayCommand(x =>
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                if (saveFileDialog.ShowDialog() == true)
                    File.WriteAllText(saveFileDialog.FileName, SelectedCountry.TravelCountry);
                    
            });


        }
        public ICommand AddTravel { get; set; }
        public ICommand RemoveTravel { get; set; }
        public ICommand Print { get; set; }
        public ICommand Save { get; set; }
        


    }

}
