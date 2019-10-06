namespace MegaDesk_Behling
{
    partial class AddQuote
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
            this.AddQuoteCancelBtn = new System.Windows.Forms.Button();
            this.widthInput = new System.Windows.Forms.NumericUpDown();
            this.depthInput = new System.Windows.Forms.NumericUpDown();
            this.getQuoteBtn = new System.Windows.Forms.Button();
            this.OakRadioBtn = new System.Windows.Forms.RadioButton();
            this.ShippingBox = new System.Windows.Forms.ComboBox();
            this.Drawers = new System.Windows.Forms.NumericUpDown();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.LaminateRadioBtn = new System.Windows.Forms.RadioButton();
            this.PineRadioBtn = new System.Windows.Forms.RadioButton();
            this.RosewoodRadioBtn = new System.Windows.Forms.RadioButton();
            this.VeneerRadioBtn = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.FullName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CurrentDate = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.widthInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depthInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Drawers)).BeginInit();
            this.SuspendLayout();
            // 
            // AddQuoteCancelBtn
            // 
            this.AddQuoteCancelBtn.BackColor = System.Drawing.Color.PeachPuff;
            this.AddQuoteCancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.AddQuoteCancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddQuoteCancelBtn.Location = new System.Drawing.Point(402, 385);
            this.AddQuoteCancelBtn.Name = "AddQuoteCancelBtn";
            this.AddQuoteCancelBtn.Size = new System.Drawing.Size(75, 53);
            this.AddQuoteCancelBtn.TabIndex = 0;
            this.AddQuoteCancelBtn.Text = "Cancel";
            this.AddQuoteCancelBtn.UseVisualStyleBackColor = false;
            this.AddQuoteCancelBtn.Click += new System.EventHandler(this.AddQuoteCancelBtn_Click);
            // 
            // widthInput
            // 
            this.widthInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.widthInput.ForeColor = System.Drawing.Color.Teal;
            this.widthInput.Location = new System.Drawing.Point(90, 165);
            this.widthInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.widthInput.Name = "widthInput";
            this.widthInput.Size = new System.Drawing.Size(115, 20);
            this.widthInput.TabIndex = 1;
            this.widthInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.widthInput.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.widthInput.ValueChanged += new System.EventHandler(this.WidthInput_ValueChanged);
            // 
            // depthInput
            // 
            this.depthInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depthInput.ForeColor = System.Drawing.Color.Teal;
            this.depthInput.Location = new System.Drawing.Point(90, 212);
            this.depthInput.Margin = new System.Windows.Forms.Padding(5);
            this.depthInput.Maximum = new decimal(new int[] {
            48,
            0,
            0,
            0});
            this.depthInput.Name = "depthInput";
            this.depthInput.Size = new System.Drawing.Size(115, 20);
            this.depthInput.TabIndex = 2;
            this.depthInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.depthInput.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.depthInput.ValueChanged += new System.EventHandler(this.DepthInput_ValueChanged);
            // 
            // getQuoteBtn
            // 
            this.getQuoteBtn.BackColor = System.Drawing.Color.Teal;
            this.getQuoteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getQuoteBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.getQuoteBtn.Location = new System.Drawing.Point(283, 385);
            this.getQuoteBtn.Name = "getQuoteBtn";
            this.getQuoteBtn.Size = new System.Drawing.Size(113, 53);
            this.getQuoteBtn.TabIndex = 3;
            this.getQuoteBtn.Text = "Get Quote";
            this.getQuoteBtn.UseVisualStyleBackColor = false;
            this.getQuoteBtn.Click += new System.EventHandler(this.GetQuoteBtn_Click);
            // 
            // OakRadioBtn
            // 
            this.OakRadioBtn.AutoSize = true;
            this.OakRadioBtn.Location = new System.Drawing.Point(297, 109);
            this.OakRadioBtn.Name = "OakRadioBtn";
            this.OakRadioBtn.Size = new System.Drawing.Size(45, 17);
            this.OakRadioBtn.TabIndex = 4;
            this.OakRadioBtn.TabStop = true;
            this.OakRadioBtn.Text = "Oak";
            this.OakRadioBtn.UseVisualStyleBackColor = true;
            // 
            // ShippingBox
            // 
            this.ShippingBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShippingBox.FormattingEnabled = true;
            this.ShippingBox.ItemHeight = 13;
            this.ShippingBox.Items.AddRange(new object[] {
            "Standard (14 days)",
            "7-Day",
            "5-Day",
            "3-Day"});
            this.ShippingBox.Location = new System.Drawing.Point(291, 280);
            this.ShippingBox.Name = "ShippingBox";
            this.ShippingBox.Size = new System.Drawing.Size(117, 21);
            this.ShippingBox.TabIndex = 6;
            this.ShippingBox.Text = "Select Shipping";
            this.ShippingBox.SelectedIndexChanged += new System.EventHandler(this.ShippingBox_SelectedIndexChanged);
            // 
            // Drawers
            // 
            this.Drawers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Drawers.ForeColor = System.Drawing.Color.Teal;
            this.Drawers.Location = new System.Drawing.Point(93, 275);
            this.Drawers.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.Drawers.Name = "Drawers";
            this.Drawers.Size = new System.Drawing.Size(47, 20);
            this.Drawers.TabIndex = 7;
            this.Drawers.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LaminateRadioBtn
            // 
            this.LaminateRadioBtn.AutoSize = true;
            this.LaminateRadioBtn.Location = new System.Drawing.Point(297, 132);
            this.LaminateRadioBtn.Name = "LaminateRadioBtn";
            this.LaminateRadioBtn.Size = new System.Drawing.Size(68, 17);
            this.LaminateRadioBtn.TabIndex = 9;
            this.LaminateRadioBtn.TabStop = true;
            this.LaminateRadioBtn.Text = "Laminate";
            this.LaminateRadioBtn.UseVisualStyleBackColor = true;
            // 
            // PineRadioBtn
            // 
            this.PineRadioBtn.AutoSize = true;
            this.PineRadioBtn.Location = new System.Drawing.Point(297, 155);
            this.PineRadioBtn.Name = "PineRadioBtn";
            this.PineRadioBtn.Size = new System.Drawing.Size(46, 17);
            this.PineRadioBtn.TabIndex = 10;
            this.PineRadioBtn.TabStop = true;
            this.PineRadioBtn.Text = "Pine";
            this.PineRadioBtn.UseVisualStyleBackColor = true;
            // 
            // RosewoodRadioBtn
            // 
            this.RosewoodRadioBtn.AutoSize = true;
            this.RosewoodRadioBtn.Location = new System.Drawing.Point(297, 178);
            this.RosewoodRadioBtn.Name = "RosewoodRadioBtn";
            this.RosewoodRadioBtn.Size = new System.Drawing.Size(76, 17);
            this.RosewoodRadioBtn.TabIndex = 11;
            this.RosewoodRadioBtn.TabStop = true;
            this.RosewoodRadioBtn.Text = "Rosewood";
            this.RosewoodRadioBtn.UseVisualStyleBackColor = true;
            // 
            // VeneerRadioBtn
            // 
            this.VeneerRadioBtn.AutoSize = true;
            this.VeneerRadioBtn.Location = new System.Drawing.Point(297, 201);
            this.VeneerRadioBtn.Name = "VeneerRadioBtn";
            this.VeneerRadioBtn.Size = new System.Drawing.Size(59, 17);
            this.VeneerRadioBtn.TabIndex = 12;
            this.VeneerRadioBtn.TabStop = true;
            this.VeneerRadioBtn.Text = "Veneer";
            this.VeneerRadioBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Enter Desk Width";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(90, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Enter Desk Depth";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(90, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "# of drawers";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(284, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Choose Material";
            // 
            // FullName
            // 
            this.FullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullName.Location = new System.Drawing.Point(90, 106);
            this.FullName.Name = "FullName";
            this.FullName.Size = new System.Drawing.Size(120, 20);
            this.FullName.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(87, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "Full Name";
            // 
            // CurrentDate
            // 
            this.CurrentDate.AutoSize = true;
            this.CurrentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentDate.Location = new System.Drawing.Point(363, 248);
            this.CurrentDate.Name = "CurrentDate";
            this.CurrentDate.Size = new System.Drawing.Size(41, 15);
            this.CurrentDate.TabIndex = 19;
            this.CurrentDate.Text = "label6";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(284, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 15);
            this.label6.TabIndex = 20;
            this.label6.Text = "Today\'s Date:";
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.AddQuoteCancelBtn;
            this.ClientSize = new System.Drawing.Size(489, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CurrentDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.FullName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.VeneerRadioBtn);
            this.Controls.Add(this.RosewoodRadioBtn);
            this.Controls.Add(this.PineRadioBtn);
            this.Controls.Add(this.LaminateRadioBtn);
            this.Controls.Add(this.Drawers);
            this.Controls.Add(this.ShippingBox);
            this.Controls.Add(this.OakRadioBtn);
            this.Controls.Add(this.getQuoteBtn);
            this.Controls.Add(this.depthInput);
            this.Controls.Add(this.widthInput);
            this.Controls.Add(this.AddQuoteCancelBtn);
            this.Name = "AddQuote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Quote";
            ((System.ComponentModel.ISupportInitialize)(this.widthInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depthInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Drawers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddQuoteCancelBtn;
        private System.Windows.Forms.NumericUpDown widthInput;
        private System.Windows.Forms.NumericUpDown depthInput;
        private System.Windows.Forms.Button getQuoteBtn;
        private System.Windows.Forms.RadioButton OakRadioBtn;
        private System.Windows.Forms.ComboBox ShippingBox;
        private System.Windows.Forms.NumericUpDown Drawers;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.RadioButton LaminateRadioBtn;
        private System.Windows.Forms.RadioButton PineRadioBtn;
        private System.Windows.Forms.RadioButton RosewoodRadioBtn;
        private System.Windows.Forms.RadioButton VeneerRadioBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox FullName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label CurrentDate;
        private System.Windows.Forms.Label label6;
    }
}