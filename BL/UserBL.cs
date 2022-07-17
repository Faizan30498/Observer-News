using Observer_News.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_News.BL
{
    public class UserBL
    {
        public UserBL()
        {

        }
        public void SubscribeUser(UserDTO ud, string publishType)
        {
            foreach (NewsPublisher publisher in HardCodeData.getInstance().AllPublishers)
            {
                if (publisher.PublishType.Equals(publishType))
                {
                    publisher.RegisterObserver(ud);
                    // use exception handling to determine pblisher
                    // already added or not
                    ud.MyPublishers.Add(publisher);

                }

            }

        }

    }
}
