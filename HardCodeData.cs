using Observer_News.BL;
using Observer_News.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_News
{
    class HardCodeData
    {

        private List<UserDTO> allUsers;
        private List<NewsPublisher> allPublishers;
        private static HardCodeData hd;
        
        private HardCodeData()
        {

            allUsers = new List<UserDTO>();
            UserDTO ad = new UserDTO();
            ad.LgDTO.Username = "Admin";
            ad.LgDTO.Password = "Admin";
            ad.LgDTO.Role = "admin";

            UserDTO u1 = new UserDTO();
            u1.LgDTO.Username = "u1";
            u1.LgDTO.Password = "u1";
            u1.LgDTO.Role = "user";

            UserDTO u2 = new UserDTO();
            u2.LgDTO.Username = "u2";
            u2.LgDTO.Password = "u2";
            u2.LgDTO.Role = "user";

            UserDTO u3 = new UserDTO();
            u3.LgDTO.Username = "u3";
            u3.LgDTO.Password = "u3";
            u3.LgDTO.Role = "user";

            allUsers.Add(ad);
            allUsers.Add(u1);
            allUsers.Add(u2);
            allUsers.Add(u3);


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

        }

        public static HardCodeData getInstance()
        {
            if (hd == null)
            {
                hd = new HardCodeData();
                return hd;
            }
            else
                return hd;

        }

        public List<UserDTO> AllUsers { get => allUsers; set => allUsers = value; }
        internal List<NewsPublisher> AllPublishers { get => allPublishers; set => allPublishers = value; }
    }
}
