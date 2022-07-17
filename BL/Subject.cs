using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_News.BL
{
    interface Subject
    {
        void RegisterObserver(Observer o);
        void RemoveObeserver(Observer o);
        void NotifyObserver();
        
    
    
    }
}
