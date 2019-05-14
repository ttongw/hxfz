using DALFactory;
using IDAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class VideoManager
    {
        IVideo ivideo = DataAccess.CreateVideo();
        public void AddVideo(Video video)
        {
            throw new NotImplementedException();
        }

        public void EditVideo(Video video)
        {
            throw new NotImplementedException();
        }
        //热门
        public IEnumerable<Video> GetHotVideo()
        {
            var video = ivideo.GetHotVideo();
            return video;
        }
        //获得推荐视频
        //public IEnumerable<Video> GetRecommend()
        //{
        //    var recommend = from po in db.Video
        //                    where po.Video_recommend == 1
        //                    orderby po.AddTime descending
        //                    select po;
        //    return recommend;
        //}

        public IEnumerable<Video> GetVideo()
        {
            var video = ivideo.GetVideo();
            return video;
        }

        public IEnumerable<Video> GetVideoById(int? id)
        {
            var video = ivideo.GetVideoById(id);
            return video;
        }

        //public IEnumerable<Video> GetVideoByVideoKId(int? id)
        //{
        //    throw new NotImplementedException();
        //}

        public IQueryable<Vcomment> GetVideoCommentByVideoId(int? id)
        {
            var vcomment = ivideo.GetVideoCommentByVideoId(id);
            return vcomment;
        }

        public void RemoveRangeVideoComment(IQueryable<Vcomment> VideoComment)
        {
            throw new NotImplementedException();
        }

        public void RemoveVideo(Video video)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Video> Search(string search)
        {
            var video = ivideo.Search(search);
            return video;
        }
    }
}
