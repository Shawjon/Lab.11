using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab._11
{
    class Movie
    {
        
        private string Title { get; set;  }
        private string Category { get; set; } 
        public Movie(string title, string category)
        {
            Title = title;
            Category = category;
        }
        

        public  String ReturnTitle(Movie movie)
        {
            return movie.Title;
        }
        public  String ReturnCategory(Movie movie)
        {
            return movie.Category;
        }

    }
    

}

