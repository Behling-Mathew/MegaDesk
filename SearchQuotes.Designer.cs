﻿namespace MegaDesk_Behling
{
    partial class SearchQuotes
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
            this.SearchQuotesCancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SearchQuotesCancelBtn
            // 
            this.SearchQuotesCancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.SearchQuotesCancelBtn.Location = new System.Drawing.Point(713, 415);
            this.SearchQuotesCancelBtn.Name = "SearchQuotesCancelBtn";
            this.SearchQuotesCancelBtn.Size = new System.Drawing.Size(75, 23);
            this.SearchQuotesCancelBtn.TabIndex = 2;
            this.SearchQuotesCancelBtn.Text = "Cancel";
            this.SearchQuotesCancelBtn.UseVisualStyleBackColor = true;
            this.SearchQuotesCancelBtn.Click += new System.EventHandler(this.SearchQuotesCancelBtn_Click);
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SearchQuotesCancelBtn);
            this.Name = "SearchQuotes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchQuotes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SearchQuotesCancelBtn;
    }
}