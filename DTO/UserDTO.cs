using Observer_News.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_News.DTO
{
    public class UserDTO:Observer
    {
        private LoginDTO lgDTO;
        private List<NewsDTO> myNews;
        private List<Subject> myPublishers;
        public UserDTO()
        {
            myNews = new List<NewsDTO>();
            lgDTO = new LoginDTO();
            myPublishers = new List<Subject>();
           // this.myPublisher = publisher;
           // myPublisher.RegisterObserver(this);
        }
        internal LoginDTO LgDTO { get => lgDTO; set => lgDTO = value; }
        internal List<NewsDTO> MyNews { get => myNews; set => myNews = value; }
        internal List<Subject> MyPublishers { get => myPublishers; set => myPublishers = value; }

        public void Update(NewsDTO news)
        {
            news.IsUnread = true;
            myNews.Add(news);
            
        }
    }
}
