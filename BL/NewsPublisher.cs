using Observer_News.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_News.BL
{
    class NewsPublisher : Subject
    {
        private List<Observer> mySubscribers;
        private string publishType;
        private NewsDTO newsDTO;

        public NewsPublisher()
        {
            mySubscribers = new List<Observer>();
        }

        public string PublishType { get => publishType; set => publishType = value; }
        internal List<Observer> MySubscribers { get => mySubscribers; set => mySubscribers = value; }
        internal NewsDTO NewsDTO { get => newsDTO; set => newsDTO = value; }

        public void NotifyObserver()
        {
            foreach(Observer o in mySubscribers)
            {
                o.Update(this.newsDTO);
            }
        }

        public void RegisterObserver(Observer o)
        {
            mySubscribers.Add(o);
        }

        public void RemoveObeserver(Observer o)
        {
            mySubscribers.Remove(o);
        }
    }
}
