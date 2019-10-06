namespace MegaDesk_Behling
{
    partial class MainMenu
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
            this.NewQuoteBtn = new System.Windows.Forms.Button();
            this.ViewQuotesBtn = new System.Windows.Forms.Button();
            this.SearchQuotesBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Version = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // NewQuoteBtn
            // 
            this.NewQuoteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewQuoteBtn.Location = new System.Drawing.Point(42, 51);
            this.NewQuoteBtn.Name = "NewQuoteBtn";
            this.NewQuoteBtn.Size = new System.Drawing.Size(247, 73);
            this.NewQuoteBtn.TabIndex = 0;
            this.NewQuoteBtn.Text = "&Add New Quote ";
            this.NewQuoteBtn.UseVisualStyleBackColor = true;
            this.NewQuoteBtn.Click += new System.EventHandler(this.NewQuoteBtn_Click);
            // 
            // ViewQuotesBtn
            // 
            this.ViewQuotesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewQuotesBtn.Location = new System.Drawing.Point(42, 140);
            this.ViewQuotesBtn.Name = "ViewQuotesBtn";
            this.ViewQuotesBtn.Size = new System.Drawing.Size(247, 73);
            this.ViewQuotesBtn.TabIndex = 1;
            this.ViewQuotesBtn.Text = "&View Quotes";
            this.ViewQuotesBtn.UseVisualStyleBackColor = true;
            this.ViewQuotesBtn.Click += new System.EventHandler(this.ViewQuotesBtn_Click);
            // 
            // SearchQuotesBtn
            // 
            this.SearchQuotesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchQuotesBtn.Location = new System.Drawing.Point(42, 229);
            this.SearchQuotesBtn.Name = "SearchQuotesBtn";
            this.SearchQuotesBtn.Size = new System.Drawing.Size(247, 73);
            this.SearchQuotesBtn.TabIndex = 2;
            this.SearchQuotesBtn.Text = "&Search Quotes";
            this.SearchQuotesBtn.UseVisualStyleBackColor = true;
            this.SearchQuotesBtn.Click += new System.EventHandler(this.SearchQuotesBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.Location = new System.Drawing.Point(42, 319);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(247, 73);
            this.ExitBtn.TabIndex = 3;
            this.ExitBtn.Text = "E&xit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MegaDesk_Behling.Properties.Resources.desk;
            this.pictureBox1.Location = new System.Drawing.Point(361, 97);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(270, 241);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Version
            // 
            this.Version.AutoSize = true;
            this.Version.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Version.Location = new System.Drawing.Point(416, 86);
            this.Version.Name = "Version";
            this.Version.Size = new System.Drawing.Size(167, 29);
            this.Version.TabIndex = 5;
            this.Version.Text = "MegaDesk 1.0";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 450);
            this.Controls.Add(this.Version);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.SearchQuotesBtn);
            this.Controls.Add(this.ViewQuotesBtn);
            this.Controls.Add(this.NewQuoteBtn);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NewQuoteBtn;
        private System.Windows.Forms.Button ViewQuotesBtn;
        private System.Windows.Forms.Button SearchQuotesBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Version;
    }
}

