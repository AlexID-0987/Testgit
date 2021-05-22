using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace TravelCatalogi.Country
{
     
    class Country
    {
        public int Id { get; set; }
        public string TravelCountry { get; set; }
        public string CountryImage { get; set; }
        public string TravelCity { get; set; }
        public string Image { get; set; }
        public string CityHotel { get; set; }
        public string Street { get; set; }
        public string HImage { get; set; }
        public string ImageRoom { get; set; }
        


        public static IEnumerable<Country> GetCountries()
        {
            return new List<Country>
            {
                new Country
                {
                    Id=1,
                    TravelCountry="Bulgaria",
                    CountryImage="https://blazon.ru/wp-content/uploads/2019/03/286.jpg",
                    TravelCity="Sozopol",
                    Image="https://kidpassage.com/images/resorts/images/Sozopol-03.jpg",
                    CityHotel="Bagira",
                    Street="st.See, h.7 ",
                    HImage="https://kitt.ru/item_photos/t_big/545_0.jpg",
                    ImageRoom="https://i.pinimg.com/originals/99/96/f7/9996f730686e597f150eb6c77aed521b.jpg",
                    

                },
                new Country
                {
                    Id=2,
                    TravelCountry="Turkeu",
                    CountryImage="https://static7.depositphotos.com/1004841/738/i/600/depositphotos_7381965-stock-photo-turkey-flag.jpg",
                    TravelCity="Varna",
                    Image="https://kidpassage.com/images/publications/images/varna-sentyabre-otdyh-pogoda-photo1.jpg",
                    CityHotel="Delfin",
                    Street="st.Sea, h.745 ",
                    HImage="https://i.pinimg.com/originals/bc/79/e6/bc79e69bfb3c06ffa97e49e1d5fc7210.jpg",
                    ImageRoom="https://www.galoresort.com/Sentido-Hotel-Galomar/media/hotel-galomar-room-galomar_seaview_1.jpg"


                },
                new Country
                {
                    Id=3,
                    TravelCountry="Greece",
                    CountryImage="http://www.ilovegreece.ru/mediaResource/00/016/841.jpg",
                    TravelCity="Vlas",
                    Image="https://media-cdn.tripadvisor.com/media/photo-s/12/fb/b0/c9/saint-vlas.jpg",
                    CityHotel="Vlas",
                    Street="st.s.Mary, h.2",
                    HImage="https://lux-trip.ru/wp-content/uploads/2017/10/Royal_Palace_Helena_Sands-720x340.jpg",
                    ImageRoom="https://casinossale.com/wp-content/uploads/2019/09/IMG_0073.jpg"
                },
                new Country
                {
                    Id=4,
                    TravelCountry="Bagamy",
                    CountryImage="https://flagi.in.ua/images/tovari/498/flag-bagamskih-ostrovov_b1.jpg",
                    TravelCity="Nassau",
                    Image="https://stupiddope.com/wp-content/uploads/2021/02/b70cb1ac04da42e8bddde3bb4137a606_LARGE.jpg",
                    CityHotel="Sea",
                    Street="st.s.Mary, h.2",
                    HImage="https://7beregov.ru/wp-content/uploads/2014/08/%D0%9B%D1%83%D1%87%D1%88%D0%B8%D0%B5-%D0%BE%D1%82%D0%B5%D0%BB%D0%B8-%D0%91%D0%B0%D0%B3%D0%B0%D0%BC%D1%81%D0%BA%D0%B8%D1%85-%D0%BE%D1%81%D1%82%D1%80%D0%BE%D0%B2%D0%BE%D0%B2.jpg",
                    ImageRoom="https://q-xx.bstatic.com/xdata/images/hotel/840x460/193654828.jpg?k=79ebcf44c9415b9511a3f2eb42489071e6b24c95550896011545ba99abb49a45&o="
                },
                new Country
                {
                    Id=5,
                    TravelCountry="Horvatia",
                    CountryImage="https://www.kartinki24.ru/uploads/gallery/main/83/kartinki24_ru_country_flags_200.jpg",
                    TravelCity="Zagreb",
                    Image="https://www.votpusk.ru/country/ctimages/new/HR24.jpg",
                    CityHotel="Zagreb Sea",
                    Street="st.s.Teodora, h.2",
                    HImage="https://p.bookcdn.com/data/Photos/380x200/567/56736/56736790/Hotel-Calypso-photos-Exterior.JPEG",
                    ImageRoom="https://p.bookcdn.com/data/Photos/320x200/8324/832486/832486196/Panorama-Zagreb-Hotel-photos-Exterior.JPEG"
                },
                new Country
                {
                    Id=6,
                    TravelCountry="Ukraine",
                    CountryImage="https://enginform.com/application/files/illustrations/articles/400x132/e12911dd1bd39fa588ef7ad92659dbbb.jpg",
                    TravelCity="Odessa",
                    Image="https://kievtourguide.com/wp-content/uploads/2018/04/Odessa-Port-Top-Must-Visit-Places-in-Ukraine-Odessa-City-Kiev-Tour-Guide.jpg",
                    CityHotel="Petrol",
                    Street="st.Nabereshna, h.2",
                    HImage="https://media-cdn.tripadvisor.com/media/photo-s/1a/c2/1a/f0/caption.jpg",
                    ImageRoom="https://cf.bstatic.com/images/hotel/max1024x768/151/151854925.jpg"
                }
            };
        }
    }
}
