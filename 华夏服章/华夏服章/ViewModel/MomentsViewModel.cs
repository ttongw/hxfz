using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace 华夏服章.ViewModel
{
    public class MomentsViewModel
    {
        public IEnumerable<Answer> Answer1 { get; set; }
        public IEnumerable<Answer> Answer2 { get; set; }
        public IEnumerable<Answer> Answer3 { get; set; }

        public IEnumerable<Article> Article1 { get; set; }
        public IEnumerable<Article> Article2 { get; set; }
        public IEnumerable<Article> Article3 { get; set; }

        public IEnumerable<Video> GetHotVideo { get; set; }
        public IEnumerable<Video> Video1 { get; set; }
        public IEnumerable<Video> Video2 { get; set; }

        public IEnumerable<Photograph> Photograph1 { get; set; }
        public IEnumerable<Photograph> Photograph2 { get; set; }
        public IEnumerable<Photograph> Photograph3 { get; set; }

    }
}