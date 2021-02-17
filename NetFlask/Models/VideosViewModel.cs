using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NetFlask.Models
{
    public class VideosViewModel
    {
        private List<VideoTileModel> _tiles;
 
        

        public List<VideoTileModel> Tiles
        {
            get
            {
                return _tiles;
            }

            set
            {
                _tiles = value;
            }
        }

        public VideosViewModel()
        {
            Tiles = new List<VideoTileModel>();

             


            Tiles.Add(new VideoTileModel() { Video= "https://www.youtube.com/embed/2LqzF5WauAw", Name="A1", Picture = "gridallbum1.jpg", Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit.", IsLastCol = false });
            Tiles.Add(new VideoTileModel() { Video = "https://www.youtube.com/embed/2LqzF8WauAw", Name = "A2", Picture = "gridallbum2.jpg", Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit.", IsLastCol = false });
            Tiles.Add(new VideoTileModel() { Video = "https://www.youtube.com/embed/2LlzF5WauAw", Name = "A3", Picture = "gridallbum3.jpg", Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit.", IsLastCol = false });
            Tiles.Add(new VideoTileModel() { Video = "https://www.youtube.com/embed/2LazF5WauAw", Name = "A4", Picture = "gridallbum4.jpg", Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit.", IsLastCol = true });
            Tiles.Add(new VideoTileModel() { Video = "https://www.youtube.com/embed/2LqzF5WauAw", Name = "A5", Picture = "gridallbum5.jpg", Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit.", IsLastCol = false });
            Tiles.Add(new VideoTileModel() { Video = "https://www.youtube.com/embed/2LqzF5WauAw", Name = "A6", Picture = "gridallbum6.jpg", Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit.", IsLastCol = false });
            Tiles.Add(new VideoTileModel() { Video = "https://www.youtube.com/embed/2LqzF5WauAw", Name = "A7", Picture = "gridallbum7.jpg", Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit.", IsLastCol = false });
            Tiles.Add(new VideoTileModel() { Video = "https://www.youtube.com/embed/2LqzF5WauAw", Name = "A8", Picture = "gridallbum8.jpg", Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit.", IsLastCol = true });
            Tiles.Add(new VideoTileModel() { Video = "https://www.youtube.com/embed/2LqzF5WauAw", Name = "A9", Picture = "gridallbum9.jpg", Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit.", IsLastCol = false });
            Tiles.Add(new VideoTileModel() { Video = "https://www.youtube.com/embed/2LqzF5WauAw", Name = "A10", Picture = "gridallbum10.jpg", Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit.", IsLastCol = false });
            Tiles.Add(new VideoTileModel() { Video = "https://www.youtube.com/embed/2LqzF5WauAw", Name = "A11", Picture = "gridallbum11.jpg", Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit.", IsLastCol = false });
            Tiles.Add(new VideoTileModel() { Video = "https://www.youtube.com/embed/2LqzF5WauAw", Name = "A12", Picture = "gridallbum1.jpg", Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit.", IsLastCol = true });




        }
    }
}