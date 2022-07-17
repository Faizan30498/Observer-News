using Observer_News.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_News.BL
{
    class LoginBL
    {

        //private List<UserDTO> allUsers;
        public LoginBL()
        {
            // hardcoded users
            /*
            allUsers = new List<UserDTO>();
            UserDTO ad = new UserDTO();
            ad.LgDTO.Username = "Admin";
            ad.LgDTO.Password = "Admin";
            ad.LgDTO.Role = "admin";

            UserDTO u1 = new UserDTO();
            u1.LgDTO.Username = "u1";
            u1.LgDTO.Password= "u1";
            u1.LgDTO.Role= "user";

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
            */
        }
        public UserDTO VerifyUser(LoginDTO lg)
        {
            foreach(UserDTO u in HardCodeData.getInstance().AllUsers)
            {
                if (u.LgDTO.Username.Equals(lg.Username) &&
                    u.LgDTO.Password.Equals(lg.Password))
                    return u;

            }
            return null;
        }
    
    }
}
