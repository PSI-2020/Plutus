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
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.addCartButton = new System.Windows.Forms.Button();
            this.cartPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cartElemEditPanel = new System.Windows.Forms.Panel();
            this.cartCloseElemChange = new System.Windows.Forms.Button();
            this.cartElemChangeErorr = new System.Windows.Forms.Label();
            this.elemChangeSave = new System.Windows.Forms.Button();
            this.cartElemChangeCat = new System.Windows.Forms.ComboBox();
            this.cartElemChangePri = new System.Windows.Forms.TextBox();
            this.cartElemChangeName = new System.Windows.Forms.TextBox();
            this.cartNewElemControlPanel = new System.Windows.Forms.Panel();
            this.cartCloseElemAddition = new System.Windows.Forms.Button();
            this.cartAddErrorField = new System.Windows.Forms.Label();
            this.cartElemAddBut = new System.Windows.Forms.Button();
            this.cartElemCategoryBox = new System.Windows.Forms.ComboBox();
            this.cartElemPriceBox = new System.Windows.Forms.TextBox();
            this.cartElemNameBox = new System.Windows.Forms.TextBox();
            this.cartInfoPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cartChargeBut = new System.Windows.Forms.Button();
            this.cartName = new System.Windows.Forms.TextBox();
            this.cartExpCount = new System.Windows.Forms.Label();
            this.cartInfoCartName = new System.Windows.Forms.Label();
            this.cartInfoName = new System.Windows.Forms.Label();
            this.addExpenseBut = new System.Windows.Forms.Button();
            this.delCartButton = new System.Windows.Forms.Button();
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
            this.tabPage6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.cartElemEditPanel.SuspendLayout();
            this.cartNewElemControlPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // enterExpensesButton
            // 
            this.enterExpensesButton.Location = new System.Drawing.Point(715, 115);
            this.enterExpensesButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.enterExpensesButton.Name = "enterExpensesButton";
            this.enterExpensesButton.Size = new System.Drawing.Size(113, 35);
            this.enterExpensesButton.TabIndex = 6;
            this.enterExpensesButton.Text = "Enter";
            this.enterExpensesButton.UseVisualStyleBackColor = true;
            this.enterExpensesButton.Click += new System.EventHandler(this.inputExpense);
            // 
            // nameP
            // 
            this.nameP.Location = new System.Drawing.Point(142, 117);
            this.nameP.Name = "nameP";
            this.nameP.Size = new System.Drawing.Size(245, 27);
            this.nameP.TabIndex = 1;
            // 
            // priceP
            // 
            this.priceP.Location = new System.Drawing.Point(393, 117);
            this.priceP.Name = "priceP";
            this.priceP.Size = new System.Drawing.Size(159, 27);
            this.priceP.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(393, 95);
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
            this.categoryP.Items.AddRange(new object[] {
            "Food",
            "Clothes",
            "Bills",
            "Other"});
            this.categoryP.Location = new System.Drawing.Point(558, 117);
            this.categoryP.Name = "categoryP";
            this.categoryP.Size = new System.Drawing.Size(151, 28);
            this.categoryP.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(558, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Category";
            // 
            // showExpensesButton
            // 
            this.showExpensesButton.Location = new System.Drawing.Point(93, 35);
            this.showExpensesButton.Name = "showExpensesButton";
            this.showExpensesButton.Size = new System.Drawing.Size(113, 37);
            this.showExpensesButton.TabIndex = 6;
            this.showExpensesButton.Text = "Show Expenses";
            this.showExpensesButton.UseVisualStyleBackColor = true;
            this.showExpensesButton.Click += new System.EventHandler(this.showExpenses);
            // 
            // showStat
            // 
            this.showStat.Location = new System.Drawing.Point(93, 196);
            this.showStat.Name = "showStat";
            this.showStat.Size = new System.Drawing.Size(113, 37);
            this.showStat.TabIndex = 6;
            this.showStat.Text = "Show Stats";
            this.showStat.UseVisualStyleBackColor = true;
            this.showStat.Click += new System.EventHandler(this.showStatistics);
            // 
            // statScreen
            // 
            this.statScreen.Location = new System.Drawing.Point(270, 35);
            this.statScreen.Multiline = true;
            this.statScreen.Name = "statScreen";
            this.statScreen.ReadOnly = true;
            this.statScreen.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.statScreen.Size = new System.Drawing.Size(566, 197);
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
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 6;
            this.tabControl1.Size = new System.Drawing.Size(984, 567);
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
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(976, 534);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Data";
            // 
            // incomeShow
            // 
            this.incomeShow.Location = new System.Drawing.Point(93, 113);
            this.incomeShow.Name = "incomeShow";
            this.incomeShow.Size = new System.Drawing.Size(113, 37);
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
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(976, 534);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "Add Income";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // errorField2
            // 
            this.errorField2.AutoSize = true;
            this.errorField2.Location = new System.Drawing.Point(459, 179);
            this.errorField2.Name = "errorField2";
            this.errorField2.Size = new System.Drawing.Size(0, 20);
            this.errorField2.TabIndex = 6;
            // 
            // incomeAdd
            // 
            this.incomeAdd.Location = new System.Drawing.Point(729, 116);
            this.incomeAdd.Name = "incomeAdd";
            this.incomeAdd.Size = new System.Drawing.Size(113, 31);
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
            this.incomeCat.Location = new System.Drawing.Point(485, 116);
            this.incomeCat.Name = "incomeCat";
            this.incomeCat.Size = new System.Drawing.Size(214, 28);
            this.incomeCat.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(485, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Source of income";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(194, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Enter sum";
            // 
            // incomeSum
            // 
            this.incomeSum.Location = new System.Drawing.Point(194, 116);
            this.incomeSum.Name = "incomeSum";
            this.incomeSum.Size = new System.Drawing.Size(269, 27);
            this.incomeSum.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(377, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 25);
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
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(976, 534);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "Add Expense";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(378, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(215, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Enter your expenses";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // errorField
            // 
            this.errorField.AutoSize = true;
            this.errorField.Location = new System.Drawing.Point(432, 175);
            this.errorField.Name = "errorField";
            this.errorField.Size = new System.Drawing.Size(0, 20);
            this.errorField.TabIndex = 5;
            this.errorField.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.splitContainer1);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage4.Size = new System.Drawing.Size(976, 534);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Edit Income";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 4);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
            this.splitContainer1.Size = new System.Drawing.Size(970, 526);
            this.splitContainer1.SplitterDistance = 322;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.Text = "splitContainer1";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(13, 15);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(281, 28);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.onEditIncomeChange);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(77, 168);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 20);
            this.label8.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(77, 60);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(269, 27);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(473, 168);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 36);
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
            this.comboBox2.Location = new System.Drawing.Point(367, 60);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(214, 28);
            this.comboBox2.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(339, 168);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 36);
            this.button2.TabIndex = 2;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.splitContainer2);
            this.tabPage5.Location = new System.Drawing.Point(4, 29);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage5.Size = new System.Drawing.Size(976, 534);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Edit Expenses";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 4);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
            this.splitContainer2.Size = new System.Drawing.Size(970, 526);
            this.splitContainer2.SplitterDistance = 322;
            this.splitContainer2.SplitterWidth = 5;
            this.splitContainer2.TabIndex = 0;
            this.splitContainer2.Text = "splitContainer2";
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(13, 15);
            this.comboBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(281, 28);
            this.comboBox5.TabIndex = 0;
            this.comboBox5.SelectedIndexChanged += new System.EventHandler(this.onEditExpenseChange);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 167);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 20);
            this.label9.TabIndex = 5;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(357, 159);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(109, 36);
            this.button4.TabIndex = 2;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(31, 55);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(245, 27);
            this.textBox3.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(490, 159);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 36);
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
            this.comboBox3.Location = new System.Drawing.Point(447, 55);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(151, 28);
            this.comboBox3.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(282, 55);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(159, 27);
            this.textBox2.TabIndex = 2;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.tabControl2);
            this.tabPage7.Location = new System.Drawing.Point(4, 29);
            this.tabPage7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage7.Size = new System.Drawing.Size(976, 534);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Scheduler";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage8);
            this.tabControl2.Controls.Add(this.tabPage9);
            this.tabControl2.Location = new System.Drawing.Point(56, 44);
            this.tabControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(858, 449);
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
            this.tabPage8.Location = new System.Drawing.Point(4, 29);
            this.tabPage8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage8.Size = new System.Drawing.Size(850, 416);
            this.tabPage8.TabIndex = 0;
            this.tabPage8.Text = "Income";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(377, 265);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 20);
            this.errorLabel.TabIndex = 7;
            // 
            // buttonAddMonthlyIncome
            // 
            this.buttonAddMonthlyIncome.Location = new System.Drawing.Point(360, 324);
            this.buttonAddMonthlyIncome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAddMonthlyIncome.Name = "buttonAddMonthlyIncome";
            this.buttonAddMonthlyIncome.Size = new System.Drawing.Size(138, 31);
            this.buttonAddMonthlyIncome.TabIndex = 6;
            this.buttonAddMonthlyIncome.Text = "Add";
            this.buttonAddMonthlyIncome.UseVisualStyleBackColor = true;
            this.buttonAddMonthlyIncome.Click += new System.EventHandler(this.buttonAddMonthlyIncome_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(24, 161);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(49, 20);
            this.label19.TabIndex = 0;
            this.label19.Text = "Name";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(337, 49);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(174, 25);
            this.label18.TabIndex = 0;
            this.label18.Text = "Monthly income";
            this.label18.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // monthlyIncomeName
            // 
            this.monthlyIncomeName.Location = new System.Drawing.Point(24, 184);
            this.monthlyIncomeName.Name = "monthlyIncomeName";
            this.monthlyIncomeName.Size = new System.Drawing.Size(154, 27);
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
            this.monthlyIncomeCategory.Location = new System.Drawing.Point(377, 184);
            this.monthlyIncomeCategory.Name = "monthlyIncomeCategory";
            this.monthlyIncomeCategory.Size = new System.Drawing.Size(187, 28);
            this.monthlyIncomeCategory.TabIndex = 4;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(377, 161);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(69, 20);
            this.label17.TabIndex = 0;
            this.label17.Text = "Category";
            // 
            // monthlyIncomeAmount
            // 
            this.monthlyIncomeAmount.Location = new System.Drawing.Point(213, 184);
            this.monthlyIncomeAmount.Name = "monthlyIncomeAmount";
            this.monthlyIncomeAmount.Size = new System.Drawing.Size(140, 27);
            this.monthlyIncomeAmount.TabIndex = 2;
            // 
            // monthlyIncomeDate
            // 
            this.monthlyIncomeDate.Location = new System.Drawing.Point(587, 184);
            this.monthlyIncomeDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.monthlyIncomeDate.Name = "monthlyIncomeDate";
            this.monthlyIncomeDate.Size = new System.Drawing.Size(236, 27);
            this.monthlyIncomeDate.TabIndex = 0;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(213, 161);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(62, 20);
            this.label16.TabIndex = 0;
            this.label16.Text = "Amount";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(587, 161);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(98, 20);
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
            this.tabPage9.Location = new System.Drawing.Point(4, 29);
            this.tabPage9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage9.Size = new System.Drawing.Size(850, 416);
            this.tabPage9.TabIndex = 1;
            this.tabPage9.Text = "Expenses";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // errorLabel2
            // 
            this.errorLabel2.AutoSize = true;
            this.errorLabel2.Location = new System.Drawing.Point(360, 280);
            this.errorLabel2.Name = "errorLabel2";
            this.errorLabel2.Size = new System.Drawing.Size(0, 20);
            this.errorLabel2.TabIndex = 8;
            // 
            // buttonAddMonthlyExpenses
            // 
            this.buttonAddMonthlyExpenses.Location = new System.Drawing.Point(360, 324);
            this.buttonAddMonthlyExpenses.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAddMonthlyExpenses.Name = "buttonAddMonthlyExpenses";
            this.buttonAddMonthlyExpenses.Size = new System.Drawing.Size(138, 31);
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
            this.monthlyExpensesCategory.Location = new System.Drawing.Point(377, 184);
            this.monthlyExpensesCategory.Name = "monthlyExpensesCategory";
            this.monthlyExpensesCategory.Size = new System.Drawing.Size(187, 28);
            this.monthlyExpensesCategory.TabIndex = 4;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(587, 161);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(98, 20);
            this.label24.TabIndex = 0;
            this.label24.Text = "First payment";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(213, 161);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(62, 20);
            this.label23.TabIndex = 0;
            this.label23.Text = "Amount";
            // 
            // monthlyExpensesDate
            // 
            this.monthlyExpensesDate.Location = new System.Drawing.Point(587, 184);
            this.monthlyExpensesDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.monthlyExpensesDate.Name = "monthlyExpensesDate";
            this.monthlyExpensesDate.Size = new System.Drawing.Size(236, 27);
            this.monthlyExpensesDate.TabIndex = 0;
            // 
            // monthlyExpensesAmount
            // 
            this.monthlyExpensesAmount.Location = new System.Drawing.Point(213, 184);
            this.monthlyExpensesAmount.Name = "monthlyExpensesAmount";
            this.monthlyExpensesAmount.Size = new System.Drawing.Size(140, 27);
            this.monthlyExpensesAmount.TabIndex = 2;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(377, 161);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(69, 20);
            this.label22.TabIndex = 0;
            this.label22.Text = "Category";
            // 
            // monthlyExpensesName
            // 
            this.monthlyExpensesName.Location = new System.Drawing.Point(24, 184);
            this.monthlyExpensesName.Name = "monthlyExpensesName";
            this.monthlyExpensesName.Size = new System.Drawing.Size(154, 27);
            this.monthlyExpensesName.TabIndex = 1;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label21.Location = new System.Drawing.Point(337, 49);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(191, 25);
            this.label21.TabIndex = 0;
            this.label21.Text = "Monthly expenses";
            this.label21.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(24, 161);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(49, 20);
            this.label20.TabIndex = 0;
            this.label20.Text = "Name";
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.addCartButton);
            this.tabPage6.Controls.Add(this.cartPanel);
            this.tabPage6.Controls.Add(this.panel2);
            this.tabPage6.Location = new System.Drawing.Point(4, 29);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(976, 534);
            this.tabPage6.TabIndex = 7;
            this.tabPage6.Text = "Carts";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // addCartButton
            // 
            this.addCartButton.Location = new System.Drawing.Point(5, 3);
            this.addCartButton.Name = "addCartButton";
            this.addCartButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.addCartButton.Size = new System.Drawing.Size(210, 45);
            this.addCartButton.TabIndex = 3;
            this.addCartButton.Text = "Add A Cart";
            this.addCartButton.UseVisualStyleBackColor = true;
            this.addCartButton.Click += new System.EventHandler(this.addCartButton_Click);
            // 
            // cartPanel
            // 
            this.cartPanel.AutoScroll = true;
            this.cartPanel.Location = new System.Drawing.Point(5, 55);
            this.cartPanel.Name = "cartPanel";
            this.cartPanel.Size = new System.Drawing.Size(240, 467);
            this.cartPanel.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cartElemEditPanel);
            this.panel2.Controls.Add(this.cartNewElemControlPanel);
            this.panel2.Controls.Add(this.cartInfoPanel);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(263, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(697, 517);
            this.panel2.TabIndex = 1;
            // 
            // cartElemEditPanel
            // 
            this.cartElemEditPanel.Controls.Add(this.cartCloseElemChange);
            this.cartElemEditPanel.Controls.Add(this.cartElemChangeErorr);
            this.cartElemEditPanel.Controls.Add(this.elemChangeSave);
            this.cartElemEditPanel.Controls.Add(this.cartElemChangeCat);
            this.cartElemEditPanel.Controls.Add(this.cartElemChangePri);
            this.cartElemEditPanel.Controls.Add(this.cartElemChangeName);
            this.cartElemEditPanel.Location = new System.Drawing.Point(14, 460);
            this.cartElemEditPanel.Name = "cartElemEditPanel";
            this.cartElemEditPanel.Size = new System.Drawing.Size(657, 48);
            this.cartElemEditPanel.TabIndex = 4;
            this.cartElemEditPanel.Visible = false;
            // 
            // cartCloseElemChange
            // 
            this.cartCloseElemChange.Location = new System.Drawing.Point(620, 10);
            this.cartCloseElemChange.Name = "cartCloseElemChange";
            this.cartCloseElemChange.Size = new System.Drawing.Size(25, 27);
            this.cartCloseElemChange.TabIndex = 5;
            this.cartCloseElemChange.Text = "X";
            this.cartCloseElemChange.UseVisualStyleBackColor = true;
            this.cartCloseElemChange.Click += new System.EventHandler(this.cartCloseElemChange_Click);
            // 
            // cartElemChangeErorr
            // 
            this.cartElemChangeErorr.Location = new System.Drawing.Point(455, 10);
            this.cartElemChangeErorr.Name = "cartElemChangeErorr";
            this.cartElemChangeErorr.Size = new System.Drawing.Size(106, 27);
            this.cartElemChangeErorr.TabIndex = 4;
            // 
            // elemChangeSave
            // 
            this.elemChangeSave.Location = new System.Drawing.Point(570, 10);
            this.elemChangeSave.Name = "elemChangeSave";
            this.elemChangeSave.Size = new System.Drawing.Size(50, 27);
            this.elemChangeSave.TabIndex = 3;
            this.elemChangeSave.Text = "Save";
            this.elemChangeSave.UseVisualStyleBackColor = true;
            this.elemChangeSave.Click += new System.EventHandler(this.elemChangeSave_Click);
            // 
            // cartElemChangeCat
            // 
            this.cartElemChangeCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cartElemChangeCat.FormattingEnabled = true;
            this.cartElemChangeCat.Items.AddRange(new object[] {
            "Food",
            "Clothes",
            "Bills",
            "Other"});
            this.cartElemChangeCat.Location = new System.Drawing.Point(299, 10);
            this.cartElemChangeCat.Name = "cartElemChangeCat";
            this.cartElemChangeCat.Size = new System.Drawing.Size(150, 28);
            this.cartElemChangeCat.TabIndex = 2;
            // 
            // cartElemChangePri
            // 
            this.cartElemChangePri.Location = new System.Drawing.Point(175, 10);
            this.cartElemChangePri.Name = "cartElemChangePri";
            this.cartElemChangePri.Size = new System.Drawing.Size(109, 27);
            this.cartElemChangePri.TabIndex = 1;
            // 
            // cartElemChangeName
            // 
            this.cartElemChangeName.Location = new System.Drawing.Point(9, 10);
            this.cartElemChangeName.Name = "cartElemChangeName";
            this.cartElemChangeName.Size = new System.Drawing.Size(150, 27);
            this.cartElemChangeName.TabIndex = 0;
            // 
            // cartNewElemControlPanel
            // 
            this.cartNewElemControlPanel.Controls.Add(this.cartCloseElemAddition);
            this.cartNewElemControlPanel.Controls.Add(this.cartAddErrorField);
            this.cartNewElemControlPanel.Controls.Add(this.cartElemAddBut);
            this.cartNewElemControlPanel.Controls.Add(this.cartElemCategoryBox);
            this.cartNewElemControlPanel.Controls.Add(this.cartElemPriceBox);
            this.cartNewElemControlPanel.Controls.Add(this.cartElemNameBox);
            this.cartNewElemControlPanel.Location = new System.Drawing.Point(14, 97);
            this.cartNewElemControlPanel.Name = "cartNewElemControlPanel";
            this.cartNewElemControlPanel.Size = new System.Drawing.Size(658, 44);
            this.cartNewElemControlPanel.TabIndex = 2;
            this.cartNewElemControlPanel.Visible = false;
            // 
            // cartCloseElemAddition
            // 
            this.cartCloseElemAddition.Location = new System.Drawing.Point(620, 10);
            this.cartCloseElemAddition.Name = "cartCloseElemAddition";
            this.cartCloseElemAddition.Size = new System.Drawing.Size(25, 27);
            this.cartCloseElemAddition.TabIndex = 5;
            this.cartCloseElemAddition.Text = "X";
            this.cartCloseElemAddition.UseVisualStyleBackColor = true;
            this.cartCloseElemAddition.Click += new System.EventHandler(this.CartCloseElemAddition_Click);
            // 
            // cartAddErrorField
            // 
            this.cartAddErrorField.Location = new System.Drawing.Point(457, 10);
            this.cartAddErrorField.Name = "cartAddErrorField";
            this.cartAddErrorField.Size = new System.Drawing.Size(105, 27);
            this.cartAddErrorField.TabIndex = 4;
            // 
            // cartElemAddBut
            // 
            this.cartElemAddBut.Location = new System.Drawing.Point(570, 10);
            this.cartElemAddBut.Name = "cartElemAddBut";
            this.cartElemAddBut.Size = new System.Drawing.Size(50, 27);
            this.cartElemAddBut.TabIndex = 3;
            this.cartElemAddBut.Text = "Add";
            this.cartElemAddBut.UseVisualStyleBackColor = true;
            this.cartElemAddBut.Click += new System.EventHandler(this.CartElemAddBut_Click);
            // 
            // cartElemCategoryBox
            // 
            this.cartElemCategoryBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cartElemCategoryBox.FormattingEnabled = true;
            this.cartElemCategoryBox.Items.AddRange(new object[] {
            "Food",
            "Clothes",
            "Bills",
            "Other"});
            this.cartElemCategoryBox.Location = new System.Drawing.Point(300, 10);
            this.cartElemCategoryBox.Name = "cartElemCategoryBox";
            this.cartElemCategoryBox.Size = new System.Drawing.Size(151, 28);
            this.cartElemCategoryBox.TabIndex = 2;
            // 
            // cartElemPriceBox
            // 
            this.cartElemPriceBox.Location = new System.Drawing.Point(175, 10);
            this.cartElemPriceBox.Name = "cartElemPriceBox";
            this.cartElemPriceBox.Size = new System.Drawing.Size(110, 27);
            this.cartElemPriceBox.TabIndex = 1;
            // 
            // cartElemNameBox
            // 
            this.cartElemNameBox.Location = new System.Drawing.Point(10, 10);
            this.cartElemNameBox.Name = "cartElemNameBox";
            this.cartElemNameBox.Size = new System.Drawing.Size(150, 27);
            this.cartElemNameBox.TabIndex = 0;
            // 
            // cartInfoPanel
            // 
            this.cartInfoPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cartInfoPanel.AutoScroll = true;
            this.cartInfoPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cartInfoPanel.Location = new System.Drawing.Point(17, 100);
            this.cartInfoPanel.Name = "cartInfoPanel";
            this.cartInfoPanel.Size = new System.Drawing.Size(654, 400);
            this.cartInfoPanel.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cartChargeBut);
            this.panel1.Controls.Add(this.cartName);
            this.panel1.Controls.Add(this.cartExpCount);
            this.panel1.Controls.Add(this.cartInfoCartName);
            this.panel1.Controls.Add(this.cartInfoName);
            this.panel1.Controls.Add(this.addExpenseBut);
            this.panel1.Controls.Add(this.delCartButton);
            this.panel1.Location = new System.Drawing.Point(0, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(697, 69);
            this.panel1.TabIndex = 0;
            // 
            // cartChargeBut
            // 
            this.cartChargeBut.Location = new System.Drawing.Point(593, 14);
            this.cartChargeBut.Name = "cartChargeBut";
            this.cartChargeBut.Size = new System.Drawing.Size(94, 43);
            this.cartChargeBut.TabIndex = 6;
            this.cartChargeBut.Text = "Charge cart";
            this.cartChargeBut.UseVisualStyleBackColor = true;
            this.cartChargeBut.Click += new System.EventHandler(this.cartChargeBut_Click);
            // 
            // cartName
            // 
            this.cartName.Location = new System.Drawing.Point(16, 32);
            this.cartName.Name = "cartName";
            this.cartName.Size = new System.Drawing.Size(124, 27);
            this.cartName.TabIndex = 5;
            this.cartName.TextChanged += new System.EventHandler(this.CartName_TextChanged);
            // 
            // cartExpCount
            // 
            this.cartExpCount.AutoSize = true;
            this.cartExpCount.Location = new System.Drawing.Point(200, 35);
            this.cartExpCount.Name = "cartExpCount";
            this.cartExpCount.Size = new System.Drawing.Size(17, 20);
            this.cartExpCount.TabIndex = 4;
            this.cartExpCount.Text = "0";
            // 
            // cartInfoCartName
            // 
            this.cartInfoCartName.AutoSize = true;
            this.cartInfoCartName.Location = new System.Drawing.Point(40, 10);
            this.cartInfoCartName.Name = "cartInfoCartName";
            this.cartInfoCartName.Size = new System.Drawing.Size(75, 20);
            this.cartInfoCartName.TabIndex = 3;
            this.cartInfoCartName.Text = "cart name";
            // 
            // cartInfoName
            // 
            this.cartInfoName.AutoSize = true;
            this.cartInfoName.Location = new System.Drawing.Point(159, 10);
            this.cartInfoName.Name = "cartInfoName";
            this.cartInfoName.Size = new System.Drawing.Size(104, 20);
            this.cartInfoName.TabIndex = 2;
            this.cartInfoName.Text = "expense count";
            // 
            // addExpenseBut
            // 
            this.addExpenseBut.Location = new System.Drawing.Point(301, 14);
            this.addExpenseBut.Name = "addExpenseBut";
            this.addExpenseBut.Size = new System.Drawing.Size(148, 42);
            this.addExpenseBut.TabIndex = 1;
            this.addExpenseBut.Text = "Add new expense";
            this.addExpenseBut.UseVisualStyleBackColor = true;
            this.addExpenseBut.Click += new System.EventHandler(this.AddExpenseBut_Click);
            // 
            // delCartButton
            // 
            this.delCartButton.Location = new System.Drawing.Point(457, 14);
            this.delCartButton.Name = "delCartButton";
            this.delCartButton.Size = new System.Drawing.Size(130, 43);
            this.delCartButton.TabIndex = 0;
            this.delCartButton.Text = "Delete Cart";
            this.delCartButton.UseVisualStyleBackColor = true;
            this.delCartButton.Click += new System.EventHandler(this.delCartButton_Click);
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 585);
            this.Controls.Add(this.tabControl1);
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
            this.tabPage6.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.cartElemEditPanel.ResumeLayout(false);
            this.cartElemEditPanel.PerformLayout();
            this.cartNewElemControlPanel.ResumeLayout(false);
            this.cartNewElemControlPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private TabPage tabPage6;
        private Button addCartButton;
        private FlowLayoutPanel cartPanel;
        private Panel panel2;
        private Panel panel1;
        private Label cartInfoName;
        private Button addExpenseBut;
        private Button delCartButton;
        private Label cartInfoCartName;
        private TextBox cartName;
        private Label cartExpCount;
        private FlowLayoutPanel cartInfoPanel;
        private Panel cartNewElemControlPanel;
        private Button cartElemAddBut;
        private ComboBox cartElemCategoryBox;
        private TextBox cartElemPriceBox;
        private TextBox cartElemNameBox;
        private Label cartAddErrorField;
        private Button cartCloseElemAddition;
        private Button cartChargeBut;
        private Panel cartElemEditPanel;
        private Button cartCloseElemChange;
        private Label cartElemChangeErorr;
        private Button elemChangeSave;
        private ComboBox cartElemChangeCat;
        private TextBox cartElemChangePri;
        private TextBox cartElemChangeName;
    }
}

