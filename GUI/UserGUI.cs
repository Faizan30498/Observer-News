using Observer_News.BL;
using Observer_News.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Observer_News.GUI
{
    public partial class UserGUI : Form
    {
        private UserDTO udto;
        private UserBL uBL;
        public UserGUI(UserDTO ud)
        {
            InitializeComponent();
            this.udto = ud;
            uBL = new UserBL();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_Subscribe_Click(object sender, EventArgs e)
        {
            uBL.SubscribeUser(udto, cmb_Subscribe.Text);
        }

        private void UserGUI_Load(object sender, EventArgs e)
        {
            foreach(NewsDTO news in udto.MyNews)
            {
                    txt_News.Text += news.NewsCat;
                    txt_News.Text += "-----";
                    txt_News.Text += news.NewsTitle;
                    txt_News.Text += "\n";

               
            }
            foreach(NewsPublisher publisher in udto.MyPublishers)
            {
                txt_Subscriptions.Text += publisher.PublishType;
                txt_Subscriptions.Text += "\n";
            }
          
        }
    }
}
