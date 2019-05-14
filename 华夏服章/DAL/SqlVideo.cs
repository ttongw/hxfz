using IDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DAL
{
    public class SqlVideo : IVideo
    {
        HanFuEntities db = DbContextFactory.CreateDbContext();
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
            var hotvideo = from po in db.Video
                           orderby po.V_click
                           select po;
            return hotvideo;
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
            var video = db.Video.ToList();
            return video;
        }

        public IEnumerable<Video> GetVideoById(int? id)
        {
            var video = from v in db.Video
                        where v.VideoId == id
                        select v;
            return video;
        }

        //public IEnumerable<Video> GetVideoByVideoKId(int? id)
        //{
        //    throw new NotImplementedException();
        //}

        public IQueryable<Vcomment> GetVideoCommentByVideoId(int? id)
        {
            var VideoComment = db.Vcomment.Include("Video").Where(c => c.VideoId == id);
            return VideoComment;
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
            var video=db.Video.Where(c=>c.Title.Contains(search)).ToList();
            return video;
        }
    }
}
