namespace CourseProject
{
    partial class Form1
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
            this.btnCategories = new System.Windows.Forms.Button();
            this.btnArtist = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.mainpanel = new System.Windows.Forms.Panel();
            this.btnclose = new System.Windows.Forms.Button();
            this.panelheader = new System.Windows.Forms.Panel();
            this.panelheader.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCategories
            // 
            this.btnCategories.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnCategories.FlatAppearance.BorderSize = 0;
            this.btnCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategories.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCategories.ForeColor = System.Drawing.Color.White;
            this.btnCategories.Location = new System.Drawing.Point(766, 49);
            this.btnCategories.Name = "btnCategories";
            this.btnCategories.Size = new System.Drawing.Size(257, 56);
            this.btnCategories.TabIndex = 2;
            this.btnCategories.Text = "Пропозиції";
            this.btnCategories.UseVisualStyleBackColor = false;
            this.btnCategories.Click += new System.EventHandler(this.btnCategories_Click);
            // 
            // btnArtist
            // 
            this.btnArtist.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnArtist.FlatAppearance.BorderSize = 0;
            this.btnArtist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArtist.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnArtist.ForeColor = System.Drawing.Color.White;
            this.btnArtist.Location = new System.Drawing.Point(407, 49);
            this.btnArtist.Name = "btnArtist";
            this.btnArtist.Size = new System.Drawing.Size(257, 56);
            this.btnArtist.TabIndex = 0;
            this.btnArtist.Text = "Виконавці";
            this.btnArtist.UseVisualStyleBackColor = false;
            this.btnArtist.Click += new System.EventHandler(this.btnArtist_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(47, 49);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(257, 56);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Пошук";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.button2_Click);
            // 
            // mainpanel
            // 
            this.mainpanel.Location = new System.Drawing.Point(0, 123);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(1067, 544);
            this.mainpanel.TabIndex = 2;
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnclose.FlatAppearance.BorderSize = 0;
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclose.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnclose.ForeColor = System.Drawing.Color.White;
            this.btnclose.Location = new System.Drawing.Point(1006, -3);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(61, 46);
            this.btnclose.TabIndex = 1;
            this.btnclose.Text = "X";
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.button4_Click);
            // 
            // panelheader
            // 
            this.panelheader.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelheader.Controls.Add(this.btnSearch);
            this.panelheader.Controls.Add(this.btnclose);
            this.panelheader.Controls.Add(this.btnCategories);
            this.panelheader.Controls.Add(this.btnArtist);
            this.panelheader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelheader.Location = new System.Drawing.Point(0, 0);
            this.panelheader.Name = "panelheader";
            this.panelheader.Size = new System.Drawing.Size(1067, 123);
            this.panelheader.TabIndex = 1;
            this.panelheader.Paint += new System.Windows.Forms.PaintEventHandler(this.panelheader_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1067, 667);
            this.Controls.Add(this.mainpanel);
            this.Controls.Add(this.panelheader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelheader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnArtist;
        private System.Windows.Forms.Panel mainpanel;
        private System.Windows.Forms.Button btnCategories;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Panel panelheader;
    }
}

