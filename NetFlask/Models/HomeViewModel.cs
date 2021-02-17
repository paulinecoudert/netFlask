using NetFlask.Repositories;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace NetFlask.Models
{//Frozen = 330457
    public class HomeViewModel
    {
        private DataContext ctx = new DataContext(ConfigurationManager.ConnectionStrings["Cnstr"].ConnectionString);

        private string _title;
        private string _videoHome;
        
        private HeaderMovie _headerMovie;
        private List<NewsModel> _news;
        private List<SliderModel> _slider1;
        private List<SliderModel> _slider2;

        public HomeViewModel()
        {
            //Variables primitives
            Title = "Movie Theater";
            VideoHome = "https://www.youtube.com/embed/bwzLiQZDw2I";

            //Section Header
 
            FrontMovie = ctx.GetHeaderMovie();


            //Section Slider1
            Slider1 = new List<SliderModel>();
            SliderModel toAdd = new SliderModel() { Link = "#", Picture = "r1.jpg" };
            Slider1.Add(toAdd);
            Slider1.Add(new SliderModel() { Link = "#", Picture = "r2.jpg" });
            Slider1.Add(new SliderModel() { Link = "#", Picture = "r3.jpg" });
            Slider1.Add(new SliderModel() { Link = "#", Picture = "r4.jpg" });
            Slider1.Add(new SliderModel() { Link = "#", Picture = "r5.jpg" });
            Slider1.Add(new SliderModel() { Link = "#", Picture = "r6.jpg" });

            //Section News
            News = new List<NewsModel>();
            News.Add(new NewsModel() {  Title= "L'Art du mensonge",  Description= "Escroc professionnel, Roy Courtnay n’en croit pas sa chance ! Alors qu’il surfe sur un site de rencontre, il fait la connaissance d’une riche veuve, Betty McLeish, qui lui ouvre sa porte... et son cœur. Rien de plus facile que de la dépouiller ! ", TheDate=new DateTime(2020, 1,1) });
            News.Add(new NewsModel() { Title = "Underwater", Description = "Une équipe scientifique sous-marine fait face à un tremblement de terre. Sous l'eau, ils vont devoir essayer de survivre.", TheDate = new DateTime(2020, 1, 8) });
            News.Add(new NewsModel() { Title = "OSS 117 : Alerte rouge en Afrique Noire", Description = "1981. Hubert Bonisseur de La Bath, alias OSS 117, est de retour. Pour cette nouvelle mission, plus délicate, plus périlleuse et plus torride que jamais, il est contraint de faire équipe avec un jeune collègue, le prometteur OSS 1001.", TheDate = new DateTime(2020, 4, 14) });


            //Section Slider2
            Slider2 = new List<SliderModel>();
            Slider2.Add(new SliderModel() { Link = "#", Picture = "m1.jpg" });
            Slider2.Add(new SliderModel() { Link = "#", Picture = "m2.jpg" });
            Slider2.Add(new SliderModel() { Link = "#", Picture = "m3.jpg" });
            Slider2.Add(new SliderModel() { Link = "#", Picture = "m4.jpg" }); 
             

        }

        public HeaderMovie FrontMovie
        {
            get
            {
                return _headerMovie;
            }

            set
            {
                _headerMovie = value;
            }
        }

        public string Title
        {
            get
            {
                return _title;
            }

            set
            {
                _title = value;
            }
        }

        public string VideoHome
        {
            get
            {
                return _videoHome;
            }

            set
            {
                _videoHome = value;
            }
        }

        public List<SliderModel> Slider1
        {
            get
            {
                return _slider1;
            }

            set
            {
                _slider1 = value;
            }
        }

        public List<NewsModel> News
        {
            get
            {
                return _news;
            }

            set
            {
                _news = value;
            }
        }

        public List<SliderModel> Slider2
        {
            get
            {
                return _slider2;
            }

            set
            {
                _slider2 = value;
            }
        }
    }
}