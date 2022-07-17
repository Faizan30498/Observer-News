namespace Observer_News.GUI
{
    partial class UserGUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lb_Welcome = new System.Windows.Forms.Label();
            this.lb_NewsCat = new System.Windows.Forms.Label();
            this.txt_Subscriptions = new System.Windows.Forms.RichTextBox();
            this.txt_News = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_Subscribe = new System.Windows.Forms.ComboBox();
            this.btn_Subscribe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(328, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to User Panel";
            // 
            // lb_Welcome
            // 
            this.lb_Welcome.AutoSize = true;
            this.lb_Welcome.Location = new System.Drawing.Point(600, 36);
            this.lb_Welcome.Name = "lb_Welcome";
            this.lb_Welcome.Size = new System.Drawing.Size(55, 13);
            this.lb_Welcome.TabIndex = 1;
            this.lb_Welcome.Text = "Welcome ";
            // 
            // lb_NewsCat
            // 
            this.lb_NewsCat.AutoSize = true;
            this.lb_NewsCat.Location = new System.Drawing.Point(515, 207);
            this.lb_NewsCat.Name = "lb_NewsCat";
            this.lb_NewsCat.Size = new System.Drawing.Size(87, 13);
            this.lb_NewsCat.TabIndex = 2;
            this.lb_NewsCat.Text = "My Subscriptions";
            // 
            // txt_Subscriptions
            // 
            this.txt_Subscriptions.Enabled = false;
            this.txt_Subscriptions.Location = new System.Drawing.Point(518, 233);
            this.txt_Subscriptions.Name = "txt_Subscriptions";
            this.txt_Subscriptions.Size = new System.Drawing.Size(113, 69);
            this.txt_Subscriptions.TabIndex = 3;
            this.txt_Subscriptions.Text = "";
            // 
            // txt_News
            // 
            this.txt_News.Enabled = false;
            this.txt_News.Location = new System.Drawing.Point(197, 135);
            this.txt_News.Name = "txt_News";
            this.txt_News.Size = new System.Drawing.Size(299, 170);
            this.txt_News.TabIndex = 4;
            this.txt_News.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Latest News";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(515, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Subscribe from list";
            // 
            // cmb_Subscribe
            // 
            this.cmb_Subscribe.FormattingEnabled = true;
            this.cmb_Subscribe.Items.AddRange(new object[] {
            "Politics News",
            "Sports News",
            "Entertainment News"});
            this.cmb_Subscribe.Location = new System.Drawing.Point(518, 135);
            this.cmb_Subscribe.Name = "cmb_Subscribe";
            this.cmb_Subscribe.Size = new System.Drawing.Size(121, 21);
            this.cmb_Subscribe.TabIndex = 7;
            this.cmb_Subscribe.Text = "Politics News";
            // 
            // btn_Subscribe
            // 
            this.btn_Subscribe.Location = new System.Drawing.Point(645, 133);
            this.btn_Subscribe.Name = "btn_Subscribe";
            this.btn_Subscribe.Size = new System.Drawing.Size(75, 23);
            this.btn_Subscribe.TabIndex = 8;
            this.btn_Subscribe.Text = "Subscribe";
            this.btn_Subscribe.UseVisualStyleBackColor = true;
            this.btn_Subscribe.Click += new System.EventHandler(this.btn_Subscribe_Click);
            // 
            // UserGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Subscribe);
            this.Controls.Add(this.cmb_Subscribe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_News);
            this.Controls.Add(this.txt_Subscriptions);
            this.Controls.Add(this.lb_NewsCat);
            this.Controls.Add(this.lb_Welcome);
            this.Controls.Add(this.label1);
            this.Name = "UserGUI";
            this.Text = "UserGUI";
            this.Load += new System.EventHandler(this.UserGUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_Welcome;
        private System.Windows.Forms.Label lb_NewsCat;
        private System.Windows.Forms.RichTextBox txt_Subscriptions;
        private System.Windows.Forms.RichTextBox txt_News;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_Subscribe;
        private System.Windows.Forms.Button btn_Subscribe;
    }
}