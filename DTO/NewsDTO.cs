using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_News.DTO
{
    public class NewsDTO
    {
        private string _newsTitle;
        private string _newsCat;
        private Boolean isUnread;

        public string NewsTitle { get => _newsTitle; set => _newsTitle = value; }
        public string NewsCat { get => _newsCat; set => _newsCat = value; }
        public bool IsUnread { get => isUnread; set => isUnread = value; }
    }
}
