namespace CourseProject.Model
{
    partial class FormForAddingSSongs
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
            this.artistTextBox = new System.Windows.Forms.TextBox();
            this.albumTextBox = new System.Windows.Forms.TextBox();
            this.songTitleTextBox = new System.Windows.Forms.TextBox();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // artistTextBox
            // 
            this.artistTextBox.Location = new System.Drawing.Point(127, 126);
            this.artistTextBox.Name = "artistTextBox";
            this.artistTextBox.Size = new System.Drawing.Size(256, 22);
            this.artistTextBox.TabIndex = 1;
            this.artistTextBox.TextChanged += new System.EventHandler(this.artistTextBox_TextChanged);
            // 
            // albumTextBox
            // 
            this.albumTextBox.Location = new System.Drawing.Point(127, 173);
            this.albumTextBox.Name = "albumTextBox";
            this.albumTextBox.Size = new System.Drawing.Size(256, 22);
            this.albumTextBox.TabIndex = 2;
            // 
            // songTitleTextBox
            // 
            this.songTitleTextBox.Location = new System.Drawing.Point(127, 224);
            this.songTitleTextBox.Name = "songTitleTextBox";
            this.songTitleTextBox.Size = new System.Drawing.Size(256, 22);
            this.songTitleTextBox.TabIndex = 3;
            // 
            // yearTextBox
            // 
            this.yearTextBox.Location = new System.Drawing.Point(127, 272);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(256, 22);
            this.yearTextBox.TabIndex = 4;
            this.yearTextBox.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(479, 170);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(228, 93);
            this.addButton.TabIndex = 5;
            this.addButton.Text = "Додати";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(24, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ім\'я";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(24, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Альбом";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(24, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "Пісня";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(24, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 22);
            this.label4.TabIndex = 9;
            this.label4.Text = "Рік";
            // 
            // FormForAddingSSongs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.yearTextBox);
            this.Controls.Add(this.songTitleTextBox);
            this.Controls.Add(this.albumTextBox);
            this.Controls.Add(this.artistTextBox);
            this.MaximumSize = new System.Drawing.Size(818, 497);
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "FormForAddingSSongs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Додавання";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox artistTextBox;
        private System.Windows.Forms.TextBox albumTextBox;
        private System.Windows.Forms.TextBox songTitleTextBox;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}