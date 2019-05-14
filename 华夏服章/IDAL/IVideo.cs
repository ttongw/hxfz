using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDAL
{
    public interface IVideo
    {
        IEnumerable<Video> GetVideo();
        IEnumerable<Video> GetVideoById(int? id);
        IQueryable<Vcomment> GetVideoCommentByVideoId(int? id);
        void RemoveVideo(Video video);
        void AddVideo(Video video);
        void EditVideo(Video video);
        void RemoveRangeVideoComment(IQueryable<Vcomment> VideoComment);
        IEnumerable<Video> GetHotVideo();
        //IEnumerable<Video> GetRecommend();
        //IEnumerable<Video> GetVideoByVideoKId(int? id);
        IEnumerable<Video> Search(string search);
    }
}
