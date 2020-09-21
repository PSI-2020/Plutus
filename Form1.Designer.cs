namespace SmartSaver
{
    partial class Form1
    {

        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        /// 

        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.nameP = new System.Windows.Forms.TextBox();
            this.priceP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.categoryP = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.showData = new System.Windows.Forms.Button();
            this.showStat = new System.Windows.Forms.Button();
            this.statScreen = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(732, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 27);
            this.button1.TabIndex = 0;
            this.button1.Text = "Enter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nameP
            // 
            this.nameP.Location = new System.Drawing.Point(159, 228);
            this.nameP.Name = "nameP";
            this.nameP.Size = new System.Drawing.Size(245, 27);
            this.nameP.TabIndex = 1;
            // 
            // priceP
            // 
            this.priceP.Location = new System.Drawing.Point(410, 228);
            this.priceP.Name = "priceP";
            this.priceP.Size = new System.Drawing.Size(159, 27);
            this.priceP.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(410, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Price";
            // 
            // categoryP
            // 
            this.categoryP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryP.FormattingEnabled = true;
            this.categoryP.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.categoryP.Items.AddRange(categories);
            this.categoryP.Location = new System.Drawing.Point(575, 228);
            this.categoryP.Name = "categoryP";
            this.categoryP.Size = new System.Drawing.Size(151, 28);
            this.categoryP.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(575, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Category";
            // 
            // showData
            // 
            this.showData.Location = new System.Drawing.Point(40, 335);
            this.showData.Name = "showData";
            this.showData.Size = new System.Drawing.Size(113, 35);
            this.showData.TabIndex = 6;
            this.showData.Text = "Show Data";
            this.showData.UseVisualStyleBackColor = true;
            this.showData.Click += new System.EventHandler(this.showData_Click);
            // 
            // showStat
            // 
            this.showStat.Location = new System.Drawing.Point(40, 376);
            this.showStat.Name = "showStat";
            this.showStat.Size = new System.Drawing.Size(113, 35);
            this.showStat.TabIndex = 6;
            this.showStat.Text = "Show Stats";
            this.showStat.UseVisualStyleBackColor = true;
            this.showStat.Click += new System.EventHandler(this.showStat_Click);
            // 
            // statScreen
            // 
            this.statScreen.Location = new System.Drawing.Point(159, 305);
            this.statScreen.Multiline = true;
            this.statScreen.Name = "statScreen";
            this.statScreen.ReadOnly = true;
            this.statScreen.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.statScreen.Size = new System.Drawing.Size(566, 197);
            this.statScreen.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 652);
            this.Controls.Add(this.statScreen);
            this.Controls.Add(this.showStat);
            this.Controls.Add(this.showData);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.categoryP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.priceP);
            this.Controls.Add(this.nameP);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox nameP;
        private System.Windows.Forms.TextBox priceP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox categoryP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button showData;
        private System.Windows.Forms.Button showStat;
        private System.Windows.Forms.TextBox statScreen;
    }
}

