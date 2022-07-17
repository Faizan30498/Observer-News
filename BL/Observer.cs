using Observer_News.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_News.BL
{
    interface Observer
    {
        void Update(NewsDTO news);
    
    }
}
