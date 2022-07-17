using Observer_News.BL;
using Observer_News.DTO;
using Observer_News.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Observer_News
{
    public partial class Login_GUI : Form
    {
        private LoginDTO lgDTO;
        private LoginBL lgBL;

        public Login_GUI()
        {
            InitializeComponent();
            lgDTO = new LoginDTO();
            lgBL = new LoginBL();
        }

        private void label3_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            lgDTO.Username = txt_Username.Text;
            lgDTO.Password = txt_Password.Text;
            UserDTO ud = lgBL.VerifyUser(lgDTO);
            if(ud!=null)
            {
                if(ud.LgDTO.Role.Equals("admin"))
                {
                    Form f = new AdminGUI(ud);
                    f.ShowDialog();
                }
                else if(ud.LgDTO.Role.Equals("user"))
                {
                    Form f = new UserGUI(ud);
                    f.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Wrong username and password");
            }


        }
    }
}
