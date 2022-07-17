using Observer_News.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_News.BL
{
    class AdminBL
    {

        //private List<NewsPublisher> allPublishers;
        public AdminBL()
        {
            
            /*
            allPublishers = new List<NewsPublisher>();
            // add hardcoded publishers in the start

            NewsPublisher sportsPublisher = new NewsPublisher();
            NewsPublisher politicsPublisher = new NewsPublisher();
            NewsPublisher entertainmentPublisher = new NewsPublisher();
            
            sportsPublisher.PublishType = "Sports News";
            politicsPublisher.PublishType = "Politics News";
            entertainmentPublisher.PublishType = "Entertainment News";

            allPublishers.Add(sportsPublisher);
            allPublishers.Add(politicsPublisher);
            allPublishers.Add(entertainmentPublisher);
            */


        }

        public void PostNews(NewsDTO news)
        {
            foreach(NewsPublisher publisher in HardCodeData.getInstance().AllPublishers)
            {
                if(publisher.PublishType.Equals(news.NewsCat))
                {
                    publisher.NewsDTO = news;
                    publisher.NotifyObserver();
                    break;
                }
            }
        }
        /*
        public void SubscribeUser(UserDTO ud, string publishType)
        { 
            foreach(NewsPublisher publisher in HardCodeData.getInstance().AllPublishers)
            {
                if(publisher.PublishType.Equals(publishType))
                {
                    publisher.RegisterObserver(ud);
                    // use exception handling to determine pblisher
                    // already added or not
                    ud.MyPublishers.Add(publisher);
                    
                }

            }
        
        }
        */
    }
}
