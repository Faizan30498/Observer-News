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
    public partial class AdminGUI : Form
    {
        private AdminBL adBL;
        public AdminGUI(UserDTO ud)
        {
            InitializeComponent();
            adBL = new AdminBL();
        }

        private void btn_Post_Click(object sender, EventArgs e)
        {
            // all game here
            NewsDTO news = new NewsDTO(); ;
            if(!txt_News.Equals(""))
            {
                news.NewsTitle = txt_News.Text;
                news.NewsCat = cmb_newsType.Text;
                adBL.PostNews(news);

            }

        }
    }
}
