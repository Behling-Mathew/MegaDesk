namespace MegaDesk_Behling
{
    partial class DisplayQuote
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
            this.DisplayQuoteCancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DisplayQuoteCancelBtn
            // 
            this.DisplayQuoteCancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.DisplayQuoteCancelBtn.Location = new System.Drawing.Point(713, 415);
            this.DisplayQuoteCancelBtn.Name = "DisplayQuoteCancelBtn";
            this.DisplayQuoteCancelBtn.Size = new System.Drawing.Size(75, 23);
            this.DisplayQuoteCancelBtn.TabIndex = 1;
            this.DisplayQuoteCancelBtn.Text = "Cancel";
            this.DisplayQuoteCancelBtn.UseVisualStyleBackColor = true;
            this.DisplayQuoteCancelBtn.Click += new System.EventHandler(this.DisplayQuoteCancelBtn_Click);
            // 
            // DisplayQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DisplayQuoteCancelBtn);
            this.Name = "DisplayQuote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Display Quote";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DisplayQuoteCancelBtn;
    }
}