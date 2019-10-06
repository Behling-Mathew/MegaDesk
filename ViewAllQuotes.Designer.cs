namespace MegaDesk_Behling
{
    partial class ViewAllQuotes
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
            this.ViewAllQuotesCancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ViewAllQuotesCancelBtn
            // 
            this.ViewAllQuotesCancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ViewAllQuotesCancelBtn.Location = new System.Drawing.Point(713, 415);
            this.ViewAllQuotesCancelBtn.Name = "ViewAllQuotesCancelBtn";
            this.ViewAllQuotesCancelBtn.Size = new System.Drawing.Size(75, 23);
            this.ViewAllQuotesCancelBtn.TabIndex = 2;
            this.ViewAllQuotesCancelBtn.Text = "Cancel";
            this.ViewAllQuotesCancelBtn.UseVisualStyleBackColor = true;
            this.ViewAllQuotesCancelBtn.Click += new System.EventHandler(this.ViewAllQuotesCancelBtn_Click);
            // 
            // ViewAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ViewAllQuotesCancelBtn);
            this.Name = "ViewAllQuotes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View All Quotes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ViewAllQuotesCancelBtn;
    }
}