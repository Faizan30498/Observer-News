namespace Observer_News.GUI
{
    partial class AdminGUI
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
            this.cmb_newsType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_News = new System.Windows.Forms.RichTextBox();
            this.btn_Post = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(335, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to AdminPanel";
            // 
            // cmb_newsType
            // 
            this.cmb_newsType.FormattingEnabled = true;
            this.cmb_newsType.Items.AddRange(new object[] {
            "Politics News",
            "Sports News",
            "Entertainment News"});
            this.cmb_newsType.Location = new System.Drawing.Point(265, 123);
            this.cmb_newsType.Name = "cmb_newsType";
            this.cmb_newsType.Size = new System.Drawing.Size(121, 21);
            this.cmb_newsType.TabIndex = 1;
            this.cmb_newsType.Text = "Politics News";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select news type";
            // 
            // txt_News
            // 
            this.txt_News.Location = new System.Drawing.Point(414, 123);
            this.txt_News.Name = "txt_News";
            this.txt_News.Size = new System.Drawing.Size(294, 96);
            this.txt_News.TabIndex = 3;
            this.txt_News.Text = "";
            // 
            // btn_Post
            // 
            this.btn_Post.Location = new System.Drawing.Point(633, 225);
            this.btn_Post.Name = "btn_Post";
            this.btn_Post.Size = new System.Drawing.Size(75, 23);
            this.btn_Post.TabIndex = 4;
            this.btn_Post.Text = "Post";
            this.btn_Post.UseVisualStyleBackColor = true;
            this.btn_Post.Click += new System.EventHandler(this.btn_Post_Click);
            // 
            // AdminGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Post);
            this.Controls.Add(this.txt_News);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_newsType);
            this.Controls.Add(this.label1);
            this.Name = "AdminGUI";
            this.Text = "AdminGUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_newsType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txt_News;
        private System.Windows.Forms.Button btn_Post;
    }
}