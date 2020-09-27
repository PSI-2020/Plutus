using System;
using System.Windows.Forms;

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
            this.enterExpensesButton = new System.Windows.Forms.Button();
            this.nameP = new System.Windows.Forms.TextBox();
            this.priceP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.categoryP = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.showExpensesButton = new System.Windows.Forms.Button();
            this.showStat = new System.Windows.Forms.Button();
            this.statScreen = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.incomeShow = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.errorField2 = new System.Windows.Forms.Label();
            this.incomeAdd = new System.Windows.Forms.Button();
            this.incomeCat = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.incomeSum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.errorField = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.errorLabel = new System.Windows.Forms.Label();
            this.buttonAddMonthlyIncome = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.monthlyIncomeName = new System.Windows.Forms.TextBox();
            this.monthlyIncomeCategory = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.monthlyIncomeAmount = new System.Windows.Forms.TextBox();
            this.monthlyIncomeDate = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.errorLabel2 = new System.Windows.Forms.Label();
            this.buttonAddMonthlyExpenses = new System.Windows.Forms.Button();
            this.monthlyExpensesCategory = new System.Windows.Forms.ComboBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.monthlyExpensesDate = new System.Windows.Forms.DateTimePicker();
            this.monthlyExpensesAmount = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.monthlyExpensesName = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage8.SuspendLayout();
            this.tabPage9.SuspendLayout();
            this.SuspendLayout();
            // 
            // enterExpensesButton
            // 
            this.enterExpensesButton.Location = new System.Drawing.Point(626, 86);
            this.enterExpensesButton.Name = "enterExpensesButton";
            this.enterExpensesButton.Size = new System.Drawing.Size(99, 26);
            this.enterExpensesButton.TabIndex = 6;
            this.enterExpensesButton.Text = "Enter";
            this.enterExpensesButton.UseVisualStyleBackColor = true;
            this.enterExpensesButton.Click += new System.EventHandler(this.inputExpense);
            // 
            // nameP
            // 
            this.nameP.Location = new System.Drawing.Point(124, 88);
            this.nameP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nameP.Name = "nameP";
            this.nameP.Size = new System.Drawing.Size(215, 23);
            this.nameP.TabIndex = 1;
            // 
            // priceP
            // 
            this.priceP.Location = new System.Drawing.Point(344, 88);
            this.priceP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.priceP.Name = "priceP";
            this.priceP.Size = new System.Drawing.Size(140, 23);
            this.priceP.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(344, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Price";
            // 
            // categoryP
            // 
            this.categoryP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryP.FormattingEnabled = true;
            this.categoryP.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.categoryP.Items.AddRange(new object[] {
            "Food",
            "Clothes",
            "Bills",
            "Other"});
            this.categoryP.Location = new System.Drawing.Point(488, 88);
            this.categoryP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.categoryP.Name = "categoryP";
            this.categoryP.Size = new System.Drawing.Size(133, 23);
            this.categoryP.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(488, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Category";
            // 
            // showExpensesButton
            // 
            this.showExpensesButton.Location = new System.Drawing.Point(81, 26);
            this.showExpensesButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.showExpensesButton.Name = "showExpensesButton";
            this.showExpensesButton.Size = new System.Drawing.Size(99, 28);
            this.showExpensesButton.TabIndex = 6;
            this.showExpensesButton.Text = "Show Expenses";
            this.showExpensesButton.UseVisualStyleBackColor = true;
            this.showExpensesButton.Click += new System.EventHandler(this.showExpenses);
            // 
            // showStat
            // 
            this.showStat.Location = new System.Drawing.Point(81, 147);
            this.showStat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.showStat.Name = "showStat";
            this.showStat.Size = new System.Drawing.Size(99, 28);
            this.showStat.TabIndex = 6;
            this.showStat.Text = "Show Stats";
            this.showStat.UseVisualStyleBackColor = true;
            this.showStat.Click += new System.EventHandler(this.showStatistics);
            // 
            // statScreen
            // 
            this.statScreen.Location = new System.Drawing.Point(236, 26);
            this.statScreen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.statScreen.Multiline = true;
            this.statScreen.Name = "statScreen";
            this.statScreen.ReadOnly = true;
            this.statScreen.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.statScreen.Size = new System.Drawing.Size(496, 149);
            this.statScreen.TabIndex = 7;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Location = new System.Drawing.Point(11, 10);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 6;
            this.tabControl1.Size = new System.Drawing.Size(861, 425);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 8;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Controls.Add(this.incomeShow);
            this.tabPage3.Controls.Add(this.showExpensesButton);
            this.tabPage3.Controls.Add(this.statScreen);
            this.tabPage3.Controls.Add(this.showStat);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(853, 397);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Data";
            // 
            // incomeShow
            // 
            this.incomeShow.Location = new System.Drawing.Point(81, 85);
            this.incomeShow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.incomeShow.Name = "incomeShow";
            this.incomeShow.Size = new System.Drawing.Size(99, 28);
            this.incomeShow.TabIndex = 8;
            this.incomeShow.Text = "Show Income";
            this.incomeShow.UseVisualStyleBackColor = true;
            this.incomeShow.Click += new System.EventHandler(this.showIncome);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.errorField2);
            this.tabPage1.Controls.Add(this.incomeAdd);
            this.tabPage1.Controls.Add(this.incomeCat);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.incomeSum);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(853, 397);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "Add Income";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // errorField2
            // 
            this.errorField2.AutoSize = true;
            this.errorField2.Location = new System.Drawing.Point(402, 134);
            this.errorField2.Name = "errorField2";
            this.errorField2.Size = new System.Drawing.Size(0, 15);
            this.errorField2.TabIndex = 6;
            // 
            // incomeAdd
            // 
            this.incomeAdd.Location = new System.Drawing.Point(638, 87);
            this.incomeAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.incomeAdd.Name = "incomeAdd";
            this.incomeAdd.Size = new System.Drawing.Size(99, 23);
            this.incomeAdd.TabIndex = 5;
            this.incomeAdd.Text = "Add";
            this.incomeAdd.UseVisualStyleBackColor = true;
            this.incomeAdd.Click += new System.EventHandler(this.inputIncome);
            // 
            // incomeCat
            // 
            this.incomeCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.incomeCat.FormattingEnabled = true;
            this.incomeCat.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.incomeCat.Items.AddRange(new object[] {
            "Salary",
            "Other"});
            this.incomeCat.Location = new System.Drawing.Point(424, 87);
            this.incomeCat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.incomeCat.Name = "incomeCat";
            this.incomeCat.Size = new System.Drawing.Size(188, 23);
            this.incomeCat.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(424, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "Source of income";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(170, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Enter sum";
            // 
            // incomeSum
            // 
            this.incomeSum.Location = new System.Drawing.Point(170, 87);
            this.incomeSum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.incomeSum.Name = "incomeSum";
            this.incomeSum.Size = new System.Drawing.Size(236, 23);
            this.incomeSum.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(330, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Enter your income";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.errorField);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.nameP);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.priceP);
            this.tabPage2.Controls.Add(this.enterExpensesButton);
            this.tabPage2.Controls.Add(this.categoryP);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(853, 397);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "Add Expense";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(331, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(175, 22);
            this.label7.TabIndex = 6;
            this.label7.Text = "Enter your expenses";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // errorField
            // 
            this.errorField.AutoSize = true;
            this.errorField.Location = new System.Drawing.Point(378, 131);
            this.errorField.Name = "errorField";
            this.errorField.Size = new System.Drawing.Size(0, 15);
            this.errorField.TabIndex = 5;
            this.errorField.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.splitContainer1);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(853, 397);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Edit Income";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.comboBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label8);
            this.splitContainer1.Panel2.Controls.Add(this.textBox1);
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Panel2.Controls.Add(this.comboBox2);
            this.splitContainer1.Panel2.Controls.Add(this.button2);
            this.splitContainer1.Size = new System.Drawing.Size(847, 391);
            this.splitContainer1.SplitterDistance = 282;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.Text = "splitContainer1";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(11, 11);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(246, 23);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.onEditIncomeChange);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(67, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 15);
            this.label8.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(67, 45);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(236, 23);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(414, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 27);
            this.button1.TabIndex = 1;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.comboBox2.Items.AddRange(new object[] {
            "Salary",
            "Other"});
            this.comboBox2.Location = new System.Drawing.Point(321, 45);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(188, 23);
            this.comboBox2.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(297, 126);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 27);
            this.button2.TabIndex = 2;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.splitContainer2);
            this.tabPage5.Location = new System.Drawing.Point(4, 24);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(853, 397);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Edit Expenses";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.comboBox5);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.label9);
            this.splitContainer2.Panel2.Controls.Add(this.button4);
            this.splitContainer2.Panel2.Controls.Add(this.textBox3);
            this.splitContainer2.Panel2.Controls.Add(this.button3);
            this.splitContainer2.Panel2.Controls.Add(this.comboBox3);
            this.splitContainer2.Panel2.Controls.Add(this.textBox2);
            this.splitContainer2.Size = new System.Drawing.Size(847, 391);
            this.splitContainer2.SplitterDistance = 282;
            this.splitContainer2.TabIndex = 0;
            this.splitContainer2.Text = "splitContainer2";
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(11, 11);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(246, 23);
            this.comboBox5.TabIndex = 0;
            this.comboBox5.SelectedIndexChanged += new System.EventHandler(this.onEditExpenseChange);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 15);
            this.label9.TabIndex = 5;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(312, 119);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(95, 27);
            this.button4.TabIndex = 2;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(27, 41);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(215, 23);
            this.textBox3.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(429, 119);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 27);
            this.button3.TabIndex = 1;
            this.button3.Text = "Save";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button4_Click);
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.comboBox3.Items.AddRange(new object[] {
            "Food",
            "Clothes",
            "Bills",
            "Other"});
            this.comboBox3.Location = new System.Drawing.Point(391, 41);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(133, 23);
            this.comboBox3.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(247, 41);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(140, 23);
            this.textBox2.TabIndex = 2;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.tabControl2);
            this.tabPage7.Location = new System.Drawing.Point(4, 24);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(853, 397);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Scheduler";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage8);
            this.tabControl2.Controls.Add(this.tabPage9);
            this.tabControl2.Location = new System.Drawing.Point(49, 33);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(751, 337);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.errorLabel);
            this.tabPage8.Controls.Add(this.buttonAddMonthlyIncome);
            this.tabPage8.Controls.Add(this.label19);
            this.tabPage8.Controls.Add(this.label18);
            this.tabPage8.Controls.Add(this.monthlyIncomeName);
            this.tabPage8.Controls.Add(this.monthlyIncomeCategory);
            this.tabPage8.Controls.Add(this.label17);
            this.tabPage8.Controls.Add(this.monthlyIncomeAmount);
            this.tabPage8.Controls.Add(this.monthlyIncomeDate);
            this.tabPage8.Controls.Add(this.label16);
            this.tabPage8.Controls.Add(this.label15);
            this.tabPage8.Location = new System.Drawing.Point(4, 24);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(743, 309);
            this.tabPage8.TabIndex = 0;
            this.tabPage8.Text = "Income";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(330, 199);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 15);
            this.errorLabel.TabIndex = 7;
            // 
            // buttonAddMonthlyIncome
            // 
            this.buttonAddMonthlyIncome.Location = new System.Drawing.Point(315, 243);
            this.buttonAddMonthlyIncome.Name = "buttonAddMonthlyIncome";
            this.buttonAddMonthlyIncome.Size = new System.Drawing.Size(121, 23);
            this.buttonAddMonthlyIncome.TabIndex = 6;
            this.buttonAddMonthlyIncome.Text = "Add";
            this.buttonAddMonthlyIncome.UseVisualStyleBackColor = true;
            this.buttonAddMonthlyIncome.Click += new System.EventHandler(this.buttonAddMonthlyIncome_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(21, 121);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(39, 15);
            this.label19.TabIndex = 0;
            this.label19.Text = "Name";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(295, 37);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(141, 22);
            this.label18.TabIndex = 0;
            this.label18.Text = "Monthly income";
            this.label18.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // monthlyIncomeName
            // 
            this.monthlyIncomeName.Location = new System.Drawing.Point(21, 138);
            this.monthlyIncomeName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.monthlyIncomeName.Name = "monthlyIncomeName";
            this.monthlyIncomeName.Size = new System.Drawing.Size(135, 23);
            this.monthlyIncomeName.TabIndex = 1;
            // 
            // monthlyIncomeCategory
            // 
            this.monthlyIncomeCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.monthlyIncomeCategory.FormattingEnabled = true;
            this.monthlyIncomeCategory.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.monthlyIncomeCategory.Items.AddRange(new object[] {
            "Salary",
            "Other"});
            this.monthlyIncomeCategory.Location = new System.Drawing.Point(330, 138);
            this.monthlyIncomeCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.monthlyIncomeCategory.Name = "monthlyIncomeCategory";
            this.monthlyIncomeCategory.Size = new System.Drawing.Size(164, 23);
            this.monthlyIncomeCategory.TabIndex = 4;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(330, 121);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(55, 15);
            this.label17.TabIndex = 0;
            this.label17.Text = "Category";
            // 
            // monthlyIncomeAmount
            // 
            this.monthlyIncomeAmount.Location = new System.Drawing.Point(186, 138);
            this.monthlyIncomeAmount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.monthlyIncomeAmount.Name = "monthlyIncomeAmount";
            this.monthlyIncomeAmount.Size = new System.Drawing.Size(123, 23);
            this.monthlyIncomeAmount.TabIndex = 2;
            // 
            // monthlyIncomeDate
            // 
            this.monthlyIncomeDate.Location = new System.Drawing.Point(514, 138);
            this.monthlyIncomeDate.Name = "monthlyIncomeDate";
            this.monthlyIncomeDate.Size = new System.Drawing.Size(207, 23);
            this.monthlyIncomeDate.TabIndex = 0;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(186, 121);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(51, 15);
            this.label16.TabIndex = 0;
            this.label16.Text = "Amount";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(514, 121);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(79, 15);
            this.label15.TabIndex = 0;
            this.label15.Text = "First payment";
            // 
            // tabPage9
            // 
            this.tabPage9.Controls.Add(this.errorLabel2);
            this.tabPage9.Controls.Add(this.buttonAddMonthlyExpenses);
            this.tabPage9.Controls.Add(this.monthlyExpensesCategory);
            this.tabPage9.Controls.Add(this.label24);
            this.tabPage9.Controls.Add(this.label23);
            this.tabPage9.Controls.Add(this.monthlyExpensesDate);
            this.tabPage9.Controls.Add(this.monthlyExpensesAmount);
            this.tabPage9.Controls.Add(this.label22);
            this.tabPage9.Controls.Add(this.monthlyExpensesName);
            this.tabPage9.Controls.Add(this.label21);
            this.tabPage9.Controls.Add(this.label20);
            this.tabPage9.Location = new System.Drawing.Point(4, 24);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage9.Size = new System.Drawing.Size(743, 309);
            this.tabPage9.TabIndex = 1;
            this.tabPage9.Text = "Expenses";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // errorLabel2
            // 
            this.errorLabel2.AutoSize = true;
            this.errorLabel2.Location = new System.Drawing.Point(315, 210);
            this.errorLabel2.Name = "errorLabel2";
            this.errorLabel2.Size = new System.Drawing.Size(0, 15);
            this.errorLabel2.TabIndex = 8;
            // 
            // buttonAddMonthlyExpenses
            // 
            this.buttonAddMonthlyExpenses.Location = new System.Drawing.Point(315, 243);
            this.buttonAddMonthlyExpenses.Name = "buttonAddMonthlyExpenses";
            this.buttonAddMonthlyExpenses.Size = new System.Drawing.Size(121, 23);
            this.buttonAddMonthlyExpenses.TabIndex = 7;
            this.buttonAddMonthlyExpenses.Text = "Add";
            this.buttonAddMonthlyExpenses.UseVisualStyleBackColor = true;
            this.buttonAddMonthlyExpenses.Click += new System.EventHandler(this.buttonAddMonthlyExpenses_Click);
            // 
            // monthlyExpensesCategory
            // 
            this.monthlyExpensesCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.monthlyExpensesCategory.FormattingEnabled = true;
            this.monthlyExpensesCategory.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.monthlyExpensesCategory.Items.AddRange(new object[] {
            "Food",
            "Clothes",
            "Bills",
            "Other"});
            this.monthlyExpensesCategory.Location = new System.Drawing.Point(330, 138);
            this.monthlyExpensesCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.monthlyExpensesCategory.Name = "monthlyExpensesCategory";
            this.monthlyExpensesCategory.Size = new System.Drawing.Size(164, 23);
            this.monthlyExpensesCategory.TabIndex = 4;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(514, 121);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(79, 15);
            this.label24.TabIndex = 0;
            this.label24.Text = "First payment";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(186, 121);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(51, 15);
            this.label23.TabIndex = 0;
            this.label23.Text = "Amount";
            // 
            // monthlyExpensesDate
            // 
            this.monthlyExpensesDate.Location = new System.Drawing.Point(514, 138);
            this.monthlyExpensesDate.Name = "monthlyExpensesDate";
            this.monthlyExpensesDate.Size = new System.Drawing.Size(207, 23);
            this.monthlyExpensesDate.TabIndex = 0;
            // 
            // monthlyExpensesAmount
            // 
            this.monthlyExpensesAmount.Location = new System.Drawing.Point(186, 138);
            this.monthlyExpensesAmount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.monthlyExpensesAmount.Name = "monthlyExpensesAmount";
            this.monthlyExpensesAmount.Size = new System.Drawing.Size(123, 23);
            this.monthlyExpensesAmount.TabIndex = 2;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(330, 121);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(55, 15);
            this.label22.TabIndex = 0;
            this.label22.Text = "Category";
            // 
            // monthlyExpensesName
            // 
            this.monthlyExpensesName.Location = new System.Drawing.Point(21, 138);
            this.monthlyExpensesName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.monthlyExpensesName.Name = "monthlyExpensesName";
            this.monthlyExpensesName.Size = new System.Drawing.Size(135, 23);
            this.monthlyExpensesName.TabIndex = 1;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label21.Location = new System.Drawing.Point(295, 37);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(155, 22);
            this.label21.TabIndex = 0;
            this.label21.Text = "Monthly expenses";
            this.label21.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(21, 121);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(39, 15);
            this.label20.TabIndex = 0;
            this.label20.Text = "Name";
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 439);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GUI";
            this.Text = "Plutus";
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tabPage7.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage8.ResumeLayout(false);
            this.tabPage8.PerformLayout();
            this.tabPage9.ResumeLayout(false);
            this.tabPage9.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button enterExpensesButton;
        private System.Windows.Forms.TextBox nameP;
        private System.Windows.Forms.TextBox priceP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox categoryP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button showExpensesButton;
        private System.Windows.Forms.Button showStat;
        private System.Windows.Forms.TextBox statScreen;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label errorField;
        private System.Windows.Forms.ComboBox incomeCat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox incomeSum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button incomeAdd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label errorField2;
        private System.Windows.Forms.Button incomeShow;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private Label label8;
        private SplitContainer splitContainer2;
        private ComboBox comboBox5;
        private Button button4;
        private TextBox textBox3;
        private Button button3;
        private ComboBox comboBox3;
        private TextBox textBox2;
        private Label label9;
        private TabPage tabPage7;
        private TabControl tabControl2;
        private TabPage tabPage8;
        private TabPage tabPage9;
        private Label label19;
        private Label label18;
        private TextBox monthlyIncomeName;
        private ComboBox monthlyIncomeCategory;
        private Label label17;
        private TextBox monthlyIncomeAmount;
        private DateTimePicker monthlyIncomeDate;
        private Label label16;
        private Label label15;
        private Label label24;
        private Label label23;
        private DateTimePicker monthlyExpensesDate;
        private TextBox monthlyExpensesAmount;
        private Label label22;
        private TextBox monthlyExpensesName;
        private Label label21;
        private Label label20;
        private ComboBox monthlyExpensesCategory;
        private Button buttonAddMonthlyIncome;
        private Label errorLabel;
        private Button buttonAddMonthlyExpenses;
        private Label errorLabel2;
        private ComboBox t;
    }
}

