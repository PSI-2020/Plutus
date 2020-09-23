using System;

namespace Plutus
{
    partial class GUI
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
            button1 = new System.Windows.Forms.Button();
            nameP = new System.Windows.Forms.TextBox();
            priceP = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            categoryP = new System.Windows.Forms.ComboBox();
            label3 = new System.Windows.Forms.Label();
            showData = new System.Windows.Forms.Button();
            showStat = new System.Windows.Forms.Button();
            statScreen = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(732, 229);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(111, 27);
            button1.TabIndex = 0;
            button1.Text = "Enter";
            button1.UseVisualStyleBackColor = true;
            button1.Click += new System.EventHandler(Button1_Click);
            // 
            // nameP
            // 
            nameP.Location = new System.Drawing.Point(159, 228);
            nameP.Name = "nameP";
            nameP.Size = new System.Drawing.Size(245, 27);
            nameP.TabIndex = 1;
            // 
            // priceP
            // 
            priceP.Location = new System.Drawing.Point(410, 228);
            priceP.Name = "priceP";
            priceP.Size = new System.Drawing.Size(159, 27);
            priceP.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(159, 193);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(49, 20);
            label1.TabIndex = 3;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(410, 193);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(41, 20);
            label2.TabIndex = 3;
            label2.Text = "Price";
            // 
            // categoryP
            // 
            categoryP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            categoryP.FormattingEnabled = true;
            categoryP.ImeMode = System.Windows.Forms.ImeMode.Off;
            categoryP.Items.AddRange(Enum.GetNames(typeof(Categories)));
            categoryP.Location = new System.Drawing.Point(575, 228);
            categoryP.Name = "categoryP";
            categoryP.Size = new System.Drawing.Size(151, 28);
            categoryP.TabIndex = 4;
            categoryP.Text = null;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(575, 193);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(69, 20);
            label3.TabIndex = 3;
            label3.Text = "Category";
            // 
            // showData
            // 
            showData.Location = new System.Drawing.Point(40, 335);
            showData.Name = "showData";
            showData.Size = new System.Drawing.Size(113, 35);
            showData.TabIndex = 6;
            showData.Text = "Show Data";
            showData.UseVisualStyleBackColor = true;
            showData.Click += new System.EventHandler(showData_Click);
            // 
            // showStat
            // 
            showStat.Location = new System.Drawing.Point(40, 376);
            showStat.Name = "showStat";
            showStat.Size = new System.Drawing.Size(113, 35);
            showStat.TabIndex = 6;
            showStat.Text = "Show Stats";
            showStat.UseVisualStyleBackColor = true;
            showStat.Click += new System.EventHandler(ShowStat_Click);
            // 
            // statScreen
            // 
            statScreen.Location = new System.Drawing.Point(159, 305);
            statScreen.Multiline = true;
            statScreen.Name = "statScreen";
            statScreen.ReadOnly = true;
            statScreen.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            statScreen.Size = new System.Drawing.Size(566, 197);
            statScreen.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1009, 652);
            Controls.Add(statScreen);
            Controls.Add(showStat);
            Controls.Add(showData);
            Controls.Add(label3);
            Controls.Add(categoryP);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(priceP);
            Controls.Add(nameP);
            Controls.Add(button1);
            Name = "Plutus";
            Text = "Plutus";
            ResumeLayout(false);
            PerformLayout();

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

