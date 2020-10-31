﻿using System;
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
            this.showExpensesButton = new System.Windows.Forms.Button();
            this.showStat = new System.Windows.Forms.Button();
            this.output = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.dataTab = new System.Windows.Forms.TabPage();
            this.enableDatePickerTo = new System.Windows.Forms.CheckBox();
            this.enableDatePickerFrom = new System.Windows.Forms.CheckBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label27 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.searchDatePickerTo = new System.Windows.Forms.DateTimePicker();
            this.searchDatePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.label26 = new System.Windows.Forms.Label();
            this.searchNumberToText = new System.Windows.Forms.TextBox();
            this.dataTypeBox = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.searchCategoryBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.searchNumberFromText = new System.Windows.Forms.TextBox();
            this.searchNameText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.incomeShow = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.tabPage10 = new System.Windows.Forms.TabPage();
            this.incomeStatusField = new System.Windows.Forms.Label();
            this.incomeAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.incomeCategory = new System.Windows.Forms.ComboBox();
            this.incomeSum = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage11 = new System.Windows.Forms.TabPage();
            this.expenseStatusField = new System.Windows.Forms.Label();
            this.enterExpensesButton = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.expenseCategorySelection = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.expensePriceText = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.expenseNameText = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.incomeEditSelection = new System.Windows.Forms.ComboBox();
            this.incomeStatusMessage = new System.Windows.Forms.Label();
            this.incomeEditSum = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.incomeEditCategory = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.expenseEditSelection = new System.Windows.Forms.ComboBox();
            this.expenseStatusMessage = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.expenseEditName = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.expenseEditCategory = new System.Windows.Forms.ComboBox();
            this.expenseEditPrice = new System.Windows.Forms.TextBox();
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
            this.CurrentCartCountNum = new System.Windows.Forms.Label();
            this.CartCountLabel = new System.Windows.Forms.Label();
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
            this.CartNameSetter = new System.Windows.Forms.Button();
            this.cartChargeBut = new System.Windows.Forms.Button();
            this.cartName = new System.Windows.Forms.TextBox();
            this.cartExpCount = new System.Windows.Forms.Label();
            this.cartInfoCartName = new System.Windows.Forms.Label();
            this.cartInfoName = new System.Windows.Forms.Label();
            this.addExpenseBut = new System.Windows.Forms.Button();
            this.delCartButton = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.addBudget = new System.Windows.Forms.Button();
            this.budgetControl = new System.Windows.Forms.Panel();
            this.dateTo = new System.Windows.Forms.DateTimePicker();
            this.dateFrom = new System.Windows.Forms.DateTimePicker();
            this.toLbl = new System.Windows.Forms.Label();
            this.fromLbl = new System.Windows.Forms.Label();
            this.budgetAdd = new System.Windows.Forms.Button();
            this.setPeriodLbl = new System.Windows.Forms.Label();
            this.budgetSum = new System.Windows.Forms.TextBox();
            this.setBud = new System.Windows.Forms.Label();
            this.budgetCat = new System.Windows.Forms.ComboBox();
            this.selectCat = new System.Windows.Forms.Label();
            this.budgetsFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.dataTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl3.SuspendLayout();
            this.tabPage10.SuspendLayout();
            this.tabPage11.SuspendLayout();
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
            this.tabPage2.SuspendLayout();
            this.budgetControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // showExpensesButton
            // 
            this.showExpensesButton.Location = new System.Drawing.Point(93, 35);
            this.showExpensesButton.Name = "showExpensesButton";
            this.showExpensesButton.Size = new System.Drawing.Size(113, 37);
            this.showExpensesButton.TabIndex = 6;
            this.showExpensesButton.Text = "Show Expenses";
            this.showExpensesButton.UseVisualStyleBackColor = true;
            this.showExpensesButton.Click += new System.EventHandler(this.ShowExpensesButton);
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
            // output
            // 
            this.output.Location = new System.Drawing.Point(270, 35);
            this.output.Multiline = true;
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.output.Size = new System.Drawing.Size(566, 197);
            this.output.TabIndex = 7;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.dataTab);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(15, 17);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 7;
            this.tabControl1.Size = new System.Drawing.Size(984, 571);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 8;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.TabChange);
            // 
            // dataTab
            // 
            this.dataTab.BackColor = System.Drawing.Color.White;
            this.dataTab.Controls.Add(this.enableDatePickerTo);
            this.dataTab.Controls.Add(this.enableDatePickerFrom);
            this.dataTab.Controls.Add(this.button5);
            this.dataTab.Controls.Add(this.label27);
            this.dataTab.Controls.Add(this.label25);
            this.dataTab.Controls.Add(this.searchDatePickerTo);
            this.dataTab.Controls.Add(this.searchDatePickerFrom);
            this.dataTab.Controls.Add(this.label26);
            this.dataTab.Controls.Add(this.searchNumberToText);
            this.dataTab.Controls.Add(this.dataTypeBox);
            this.dataTab.Controls.Add(this.label14);
            this.dataTab.Controls.Add(this.searchCategoryBox);
            this.dataTab.Controls.Add(this.label7);
            this.dataTab.Controls.Add(this.label3);
            this.dataTab.Controls.Add(this.searchNumberFromText);
            this.dataTab.Controls.Add(this.searchNameText);
            this.dataTab.Controls.Add(this.label2);
            this.dataTab.Controls.Add(this.label1);
            this.dataTab.Controls.Add(this.incomeShow);
            this.dataTab.Controls.Add(this.showExpensesButton);
            this.dataTab.Controls.Add(this.output);
            this.dataTab.Controls.Add(this.showStat);
            this.dataTab.Location = new System.Drawing.Point(4, 29);
            this.dataTab.Name = "dataTab";
            this.dataTab.Size = new System.Drawing.Size(976, 538);
            this.dataTab.TabIndex = 0;
            this.dataTab.Text = "Data";
            // 
            // enableDatePickerTo
            // 
            this.enableDatePickerTo.AutoSize = true;
            this.enableDatePickerTo.Location = new System.Drawing.Point(867, 447);
            this.enableDatePickerTo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.enableDatePickerTo.Name = "enableDatePickerTo";
            this.enableDatePickerTo.Size = new System.Drawing.Size(18, 17);
            this.enableDatePickerTo.TabIndex = 13;
            this.enableDatePickerTo.UseVisualStyleBackColor = true;
            this.enableDatePickerTo.CheckedChanged += new System.EventHandler(this.EnableSearchDataPicker);
            // 
            // enableDatePickerFrom
            // 
            this.enableDatePickerFrom.AutoSize = true;
            this.enableDatePickerFrom.Location = new System.Drawing.Point(867, 359);
            this.enableDatePickerFrom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.enableDatePickerFrom.Name = "enableDatePickerFrom";
            this.enableDatePickerFrom.Size = new System.Drawing.Size(18, 17);
            this.enableDatePickerFrom.TabIndex = 13;
            this.enableDatePickerFrom.UseVisualStyleBackColor = true;
            this.enableDatePickerFrom.CheckedChanged += new System.EventHandler(this.EnableSearchDataPicker);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(93, 435);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(154, 37);
            this.button5.TabIndex = 6;
            this.button5.Text = "Search";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Search);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(673, 417);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(59, 20);
            this.label27.TabIndex = 0;
            this.label27.Text = "Date to";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(673, 329);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(77, 20);
            this.label25.TabIndex = 0;
            this.label25.Text = "Date from";
            // 
            // searchDatePickerTo
            // 
            this.searchDatePickerTo.CustomFormat = "yyyy-MM-dd";
            this.searchDatePickerTo.Enabled = false;
            this.searchDatePickerTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.searchDatePickerTo.Location = new System.Drawing.Point(673, 441);
            this.searchDatePickerTo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchDatePickerTo.Name = "searchDatePickerTo";
            this.searchDatePickerTo.Size = new System.Drawing.Size(187, 27);
            this.searchDatePickerTo.TabIndex = 12;
            // 
            // searchDatePickerFrom
            // 
            this.searchDatePickerFrom.CustomFormat = "yyyy-MM-dd";
            this.searchDatePickerFrom.Enabled = false;
            this.searchDatePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.searchDatePickerFrom.Location = new System.Drawing.Point(673, 353);
            this.searchDatePickerFrom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchDatePickerFrom.Name = "searchDatePickerFrom";
            this.searchDatePickerFrom.Size = new System.Drawing.Size(187, 27);
            this.searchDatePickerFrom.TabIndex = 12;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(280, 419);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(130, 20);
            this.label26.TabIndex = 0;
            this.label26.Text = "Maximum amount";
            // 
            // searchNumberToText
            // 
            this.searchNumberToText.Location = new System.Drawing.Point(280, 441);
            this.searchNumberToText.Name = "searchNumberToText";
            this.searchNumberToText.Size = new System.Drawing.Size(140, 27);
            this.searchNumberToText.TabIndex = 2;
            // 
            // dataTypeBox
            // 
            this.dataTypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dataTypeBox.FormattingEnabled = true;
            this.dataTypeBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dataTypeBox.Items.AddRange(new object[] {
            "",
            "Expense",
            "Income"});
            this.dataTypeBox.Location = new System.Drawing.Point(445, 441);
            this.dataTypeBox.Name = "dataTypeBox";
            this.dataTypeBox.Size = new System.Drawing.Size(187, 28);
            this.dataTypeBox.TabIndex = 4;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(445, 419);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 20);
            this.label14.TabIndex = 0;
            this.label14.Text = "Data type";
            // 
            // searchCategoryBox
            // 
            this.searchCategoryBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchCategoryBox.FormattingEnabled = true;
            this.searchCategoryBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.searchCategoryBox.Items.AddRange(new object[] {
            "",
            "Food",
            "Clothes",
            "Bills",
            "Salary",
            "Other"});
            this.searchCategoryBox.Location = new System.Drawing.Point(445, 353);
            this.searchCategoryBox.Name = "searchCategoryBox";
            this.searchCategoryBox.Size = new System.Drawing.Size(187, 28);
            this.searchCategoryBox.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(445, 331);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 331);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Name";
            // 
            // searchNumberFromText
            // 
            this.searchNumberFromText.Location = new System.Drawing.Point(280, 353);
            this.searchNumberFromText.Name = "searchNumberFromText";
            this.searchNumberFromText.Size = new System.Drawing.Size(140, 27);
            this.searchNumberFromText.TabIndex = 2;
            // 
            // searchNameText
            // 
            this.searchNameText.Location = new System.Drawing.Point(93, 353);
            this.searchNameText.Name = "searchNameText";
            this.searchNameText.Size = new System.Drawing.Size(154, 27);
            this.searchNameText.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(280, 331);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Minimum amount";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Search";
            // 
            // incomeShow
            // 
            this.incomeShow.Location = new System.Drawing.Point(93, 113);
            this.incomeShow.Name = "incomeShow";
            this.incomeShow.Size = new System.Drawing.Size(113, 37);
            this.incomeShow.TabIndex = 8;
            this.incomeShow.Text = "Show Income";
            this.incomeShow.UseVisualStyleBackColor = true;
            this.incomeShow.Click += new System.EventHandler(this.ShowIncomeButton);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tabControl3);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(976, 538);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "Income/Expense";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabControl3
            // 
            this.tabControl3.Controls.Add(this.tabPage10);
            this.tabControl3.Controls.Add(this.tabPage11);
            this.tabControl3.Location = new System.Drawing.Point(5, 4);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(969, 527);
            this.tabControl3.TabIndex = 0;
            // 
            // tabPage10
            // 
            this.tabPage10.Controls.Add(this.incomeStatusField);
            this.tabPage10.Controls.Add(this.incomeAdd);
            this.tabPage10.Controls.Add(this.label4);
            this.tabPage10.Controls.Add(this.label5);
            this.tabPage10.Controls.Add(this.incomeCategory);
            this.tabPage10.Controls.Add(this.incomeSum);
            this.tabPage10.Controls.Add(this.label6);
            this.tabPage10.Location = new System.Drawing.Point(4, 29);
            this.tabPage10.Name = "tabPage10";
            this.tabPage10.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage10.Size = new System.Drawing.Size(961, 494);
            this.tabPage10.TabIndex = 0;
            this.tabPage10.Text = "Add Income";
            this.tabPage10.UseVisualStyleBackColor = true;
            // 
            // incomeStatusField
            // 
            this.incomeStatusField.AutoSize = true;
            this.incomeStatusField.Location = new System.Drawing.Point(439, 137);
            this.incomeStatusField.Name = "incomeStatusField";
            this.incomeStatusField.Size = new System.Drawing.Size(0, 20);
            this.incomeStatusField.TabIndex = 6;
            // 
            // incomeAdd
            // 
            this.incomeAdd.Location = new System.Drawing.Point(659, 73);
            this.incomeAdd.Name = "incomeAdd";
            this.incomeAdd.Size = new System.Drawing.Size(113, 31);
            this.incomeAdd.TabIndex = 5;
            this.incomeAdd.Text = "Add";
            this.incomeAdd.UseVisualStyleBackColor = true;
            this.incomeAdd.Click += new System.EventHandler(this.InputIncomeButton);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(381, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Enter your income";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(165, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Enter sum";
            // 
            // incomeCategory
            // 
            this.incomeCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.incomeCategory.FormattingEnabled = true;
            this.incomeCategory.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.incomeCategory.Items.AddRange(new object[] {
            "Salary",
            "Other"});
            this.incomeCategory.Location = new System.Drawing.Point(439, 75);
            this.incomeCategory.Name = "incomeCategory";
            this.incomeCategory.Size = new System.Drawing.Size(214, 28);
            this.incomeCategory.TabIndex = 4;
            // 
            // incomeSum
            // 
            this.incomeSum.Location = new System.Drawing.Point(165, 75);
            this.incomeSum.Name = "incomeSum";
            this.incomeSum.Size = new System.Drawing.Size(269, 27);
            this.incomeSum.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(439, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Source of income";
            // 
            // tabPage11
            // 
            this.tabPage11.Controls.Add(this.expenseStatusField);
            this.tabPage11.Controls.Add(this.enterExpensesButton);
            this.tabPage11.Controls.Add(this.label13);
            this.tabPage11.Controls.Add(this.expenseCategorySelection);
            this.tabPage11.Controls.Add(this.label12);
            this.tabPage11.Controls.Add(this.expensePriceText);
            this.tabPage11.Controls.Add(this.label11);
            this.tabPage11.Controls.Add(this.expenseNameText);
            this.tabPage11.Controls.Add(this.label10);
            this.tabPage11.Location = new System.Drawing.Point(4, 29);
            this.tabPage11.Name = "tabPage11";
            this.tabPage11.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage11.Size = new System.Drawing.Size(961, 494);
            this.tabPage11.TabIndex = 1;
            this.tabPage11.Text = "Add Expense";
            this.tabPage11.UseVisualStyleBackColor = true;
            // 
            // expenseStatusField
            // 
            this.expenseStatusField.AutoSize = true;
            this.expenseStatusField.Location = new System.Drawing.Point(451, 124);
            this.expenseStatusField.Name = "expenseStatusField";
            this.expenseStatusField.Size = new System.Drawing.Size(0, 20);
            this.expenseStatusField.TabIndex = 5;
            this.expenseStatusField.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // enterExpensesButton
            // 
            this.enterExpensesButton.Location = new System.Drawing.Point(720, 65);
            this.enterExpensesButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.enterExpensesButton.Name = "enterExpensesButton";
            this.enterExpensesButton.Size = new System.Drawing.Size(113, 35);
            this.enterExpensesButton.TabIndex = 6;
            this.enterExpensesButton.Text = "Enter";
            this.enterExpensesButton.UseVisualStyleBackColor = true;
            this.enterExpensesButton.Click += new System.EventHandler(this.InputExpenseButton);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(563, 45);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 20);
            this.label13.TabIndex = 3;
            this.label13.Text = "Category";
            // 
            // expenseCategorySelection
            // 
            this.expenseCategorySelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.expenseCategorySelection.FormattingEnabled = true;
            this.expenseCategorySelection.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.expenseCategorySelection.Items.AddRange(new object[] {
            "Food",
            "Clothes",
            "Bills",
            "Other"});
            this.expenseCategorySelection.Location = new System.Drawing.Point(563, 69);
            this.expenseCategorySelection.Name = "expenseCategorySelection";
            this.expenseCategorySelection.Size = new System.Drawing.Size(151, 28);
            this.expenseCategorySelection.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(398, 45);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 20);
            this.label12.TabIndex = 3;
            this.label12.Text = "Price";
            // 
            // expensePriceText
            // 
            this.expensePriceText.Location = new System.Drawing.Point(398, 69);
            this.expensePriceText.Name = "expensePriceText";
            this.expensePriceText.Size = new System.Drawing.Size(159, 27);
            this.expensePriceText.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(147, 45);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 20);
            this.label11.TabIndex = 3;
            this.label11.Text = "Name";
            // 
            // expenseNameText
            // 
            this.expenseNameText.Location = new System.Drawing.Point(147, 69);
            this.expenseNameText.Name = "expenseNameText";
            this.expenseNameText.Size = new System.Drawing.Size(245, 27);
            this.expenseNameText.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(363, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(215, 25);
            this.label10.TabIndex = 6;
            this.label10.Text = "Enter your expenses";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.splitContainer1);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage4.Size = new System.Drawing.Size(976, 538);
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
            this.splitContainer1.Panel1.Controls.Add(this.incomeEditSelection);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.incomeStatusMessage);
            this.splitContainer1.Panel2.Controls.Add(this.incomeEditSum);
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Panel2.Controls.Add(this.incomeEditCategory);
            this.splitContainer1.Panel2.Controls.Add(this.button2);
            this.splitContainer1.Size = new System.Drawing.Size(970, 530);
            this.splitContainer1.SplitterDistance = 321;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.Text = "splitContainer1";
            // 
            // incomeEditSelection
            // 
            this.incomeEditSelection.FormattingEnabled = true;
            this.incomeEditSelection.Location = new System.Drawing.Point(13, 15);
            this.incomeEditSelection.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.incomeEditSelection.Name = "incomeEditSelection";
            this.incomeEditSelection.Size = new System.Drawing.Size(281, 28);
            this.incomeEditSelection.TabIndex = 0;
            this.incomeEditSelection.SelectedIndexChanged += new System.EventHandler(this.OnIncomeSelect);
            // 
            // incomeStatusMessage
            // 
            this.incomeStatusMessage.AutoSize = true;
            this.incomeStatusMessage.Location = new System.Drawing.Point(77, 168);
            this.incomeStatusMessage.Name = "incomeStatusMessage";
            this.incomeStatusMessage.Size = new System.Drawing.Size(0, 20);
            this.incomeStatusMessage.TabIndex = 5;
            // 
            // incomeEditSum
            // 
            this.incomeEditSum.Location = new System.Drawing.Point(77, 60);
            this.incomeEditSum.Name = "incomeEditSum";
            this.incomeEditSum.Size = new System.Drawing.Size(269, 27);
            this.incomeEditSum.TabIndex = 1;
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
            this.button1.Click += new System.EventHandler(this.EditIncomeButton);
            // 
            // incomeEditCategory
            // 
            this.incomeEditCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.incomeEditCategory.FormattingEnabled = true;
            this.incomeEditCategory.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.incomeEditCategory.Items.AddRange(new object[] {
            "Salary",
            "Other"});
            this.incomeEditCategory.Location = new System.Drawing.Point(367, 60);
            this.incomeEditCategory.Name = "incomeEditCategory";
            this.incomeEditCategory.Size = new System.Drawing.Size(214, 28);
            this.incomeEditCategory.TabIndex = 4;
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
            this.button2.Click += new System.EventHandler(this.DeleteIncomeButton);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.splitContainer2);
            this.tabPage5.Location = new System.Drawing.Point(4, 29);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage5.Size = new System.Drawing.Size(976, 538);
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
            this.splitContainer2.Panel1.Controls.Add(this.expenseEditSelection);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.expenseStatusMessage);
            this.splitContainer2.Panel2.Controls.Add(this.button4);
            this.splitContainer2.Panel2.Controls.Add(this.expenseEditName);
            this.splitContainer2.Panel2.Controls.Add(this.button3);
            this.splitContainer2.Panel2.Controls.Add(this.expenseEditCategory);
            this.splitContainer2.Panel2.Controls.Add(this.expenseEditPrice);
            this.splitContainer2.Size = new System.Drawing.Size(970, 530);
            this.splitContainer2.SplitterDistance = 321;
            this.splitContainer2.SplitterWidth = 5;
            this.splitContainer2.TabIndex = 0;
            this.splitContainer2.Text = "splitContainer2";
            // 
            // expenseEditSelection
            // 
            this.expenseEditSelection.FormattingEnabled = true;
            this.expenseEditSelection.Location = new System.Drawing.Point(13, 15);
            this.expenseEditSelection.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.expenseEditSelection.Name = "expenseEditSelection";
            this.expenseEditSelection.Size = new System.Drawing.Size(281, 28);
            this.expenseEditSelection.TabIndex = 0;
            this.expenseEditSelection.SelectedIndexChanged += new System.EventHandler(this.OnExpenseSelect);
            // 
            // expenseStatusMessage
            // 
            this.expenseStatusMessage.AutoSize = true;
            this.expenseStatusMessage.Location = new System.Drawing.Point(31, 167);
            this.expenseStatusMessage.Name = "expenseStatusMessage";
            this.expenseStatusMessage.Size = new System.Drawing.Size(0, 20);
            this.expenseStatusMessage.TabIndex = 5;
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
            this.button4.Click += new System.EventHandler(this.DeleteExpenseButton);
            // 
            // expenseEditName
            // 
            this.expenseEditName.Location = new System.Drawing.Point(31, 55);
            this.expenseEditName.Name = "expenseEditName";
            this.expenseEditName.Size = new System.Drawing.Size(245, 27);
            this.expenseEditName.TabIndex = 1;
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
            this.button3.Click += new System.EventHandler(this.EditExpenseButton);
            // 
            // expenseEditCategory
            // 
            this.expenseEditCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.expenseEditCategory.FormattingEnabled = true;
            this.expenseEditCategory.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.expenseEditCategory.Items.AddRange(new object[] {
            "Food",
            "Clothes",
            "Bills",
            "Other"});
            this.expenseEditCategory.Location = new System.Drawing.Point(447, 55);
            this.expenseEditCategory.Name = "expenseEditCategory";
            this.expenseEditCategory.Size = new System.Drawing.Size(151, 28);
            this.expenseEditCategory.TabIndex = 4;
            // 
            // expenseEditPrice
            // 
            this.expenseEditPrice.Location = new System.Drawing.Point(282, 55);
            this.expenseEditPrice.Name = "expenseEditPrice";
            this.expenseEditPrice.Size = new System.Drawing.Size(159, 27);
            this.expenseEditPrice.TabIndex = 2;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.tabControl2);
            this.tabPage7.Location = new System.Drawing.Point(4, 29);
            this.tabPage7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage7.Size = new System.Drawing.Size(976, 538);
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
            this.tabPage6.Controls.Add(this.CurrentCartCountNum);
            this.tabPage6.Controls.Add(this.CartCountLabel);
            this.tabPage6.Controls.Add(this.addCartButton);
            this.tabPage6.Controls.Add(this.cartPanel);
            this.tabPage6.Controls.Add(this.panel2);
            this.tabPage6.Location = new System.Drawing.Point(4, 29);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(976, 538);
            this.tabPage6.TabIndex = 7;
            this.tabPage6.Text = "Carts";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // CurrentCartCountNum
            // 
            this.CurrentCartCountNum.AutoSize = true;
            this.CurrentCartCountNum.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CurrentCartCountNum.Location = new System.Drawing.Point(197, 485);
            this.CurrentCartCountNum.Name = "CurrentCartCountNum";
            this.CurrentCartCountNum.Size = new System.Drawing.Size(0, 23);
            this.CurrentCartCountNum.TabIndex = 5;
            // 
            // CartCountLabel
            // 
            this.CartCountLabel.AutoSize = true;
            this.CartCountLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CartCountLabel.Location = new System.Drawing.Point(17, 483);
            this.CartCountLabel.Name = "CartCountLabel";
            this.CartCountLabel.Size = new System.Drawing.Size(174, 23);
            this.CartCountLabel.TabIndex = 4;
            this.CartCountLabel.Text = "Current Cart amount:";
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
            this.cartPanel.Size = new System.Drawing.Size(240, 411);
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
            this.cartCloseElemChange.Location = new System.Drawing.Point(619, 11);
            this.cartCloseElemChange.Name = "cartCloseElemChange";
            this.cartCloseElemChange.Size = new System.Drawing.Size(25, 27);
            this.cartCloseElemChange.TabIndex = 5;
            this.cartCloseElemChange.Text = "X";
            this.cartCloseElemChange.UseVisualStyleBackColor = true;
            this.cartCloseElemChange.Click += new System.EventHandler(this.cartCloseElemChange_Click);
            // 
            // cartElemChangeErorr
            // 
            this.cartElemChangeErorr.Location = new System.Drawing.Point(455, 11);
            this.cartElemChangeErorr.Name = "cartElemChangeErorr";
            this.cartElemChangeErorr.Size = new System.Drawing.Size(106, 27);
            this.cartElemChangeErorr.TabIndex = 4;
            // 
            // elemChangeSave
            // 
            this.elemChangeSave.Location = new System.Drawing.Point(570, 11);
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
            this.cartElemChangeCat.Location = new System.Drawing.Point(299, 11);
            this.cartElemChangeCat.Name = "cartElemChangeCat";
            this.cartElemChangeCat.Size = new System.Drawing.Size(150, 28);
            this.cartElemChangeCat.TabIndex = 2;
            // 
            // cartElemChangePri
            // 
            this.cartElemChangePri.Location = new System.Drawing.Point(175, 11);
            this.cartElemChangePri.Name = "cartElemChangePri";
            this.cartElemChangePri.Size = new System.Drawing.Size(109, 27);
            this.cartElemChangePri.TabIndex = 1;
            // 
            // cartElemChangeName
            // 
            this.cartElemChangeName.Location = new System.Drawing.Point(9, 11);
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
            this.cartCloseElemAddition.Location = new System.Drawing.Point(619, 11);
            this.cartCloseElemAddition.Name = "cartCloseElemAddition";
            this.cartCloseElemAddition.Size = new System.Drawing.Size(25, 27);
            this.cartCloseElemAddition.TabIndex = 5;
            this.cartCloseElemAddition.Text = "X";
            this.cartCloseElemAddition.UseVisualStyleBackColor = true;
            this.cartCloseElemAddition.Click += new System.EventHandler(this.CartCloseElemAddition_Click);
            // 
            // cartAddErrorField
            // 
            this.cartAddErrorField.Location = new System.Drawing.Point(457, 11);
            this.cartAddErrorField.Name = "cartAddErrorField";
            this.cartAddErrorField.Size = new System.Drawing.Size(105, 27);
            this.cartAddErrorField.TabIndex = 4;
            // 
            // cartElemAddBut
            // 
            this.cartElemAddBut.Location = new System.Drawing.Point(570, 11);
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
            this.cartElemCategoryBox.Location = new System.Drawing.Point(299, 11);
            this.cartElemCategoryBox.Name = "cartElemCategoryBox";
            this.cartElemCategoryBox.Size = new System.Drawing.Size(151, 28);
            this.cartElemCategoryBox.TabIndex = 2;
            // 
            // cartElemPriceBox
            // 
            this.cartElemPriceBox.Location = new System.Drawing.Point(175, 11);
            this.cartElemPriceBox.Name = "cartElemPriceBox";
            this.cartElemPriceBox.Size = new System.Drawing.Size(110, 27);
            this.cartElemPriceBox.TabIndex = 1;
            // 
            // cartElemNameBox
            // 
            this.cartElemNameBox.Location = new System.Drawing.Point(10, 11);
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
            this.panel1.Controls.Add(this.CartNameSetter);
            this.panel1.Controls.Add(this.cartChargeBut);
            this.panel1.Controls.Add(this.cartName);
            this.panel1.Controls.Add(this.cartExpCount);
            this.panel1.Controls.Add(this.cartInfoCartName);
            this.panel1.Controls.Add(this.cartInfoName);
            this.panel1.Controls.Add(this.addExpenseBut);
            this.panel1.Controls.Add(this.delCartButton);
            this.panel1.Location = new System.Drawing.Point(0, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(697, 69);
            this.panel1.TabIndex = 0;
            // 
            // CartNameSetter
            // 
            this.CartNameSetter.Location = new System.Drawing.Point(112, 32);
            this.CartNameSetter.Name = "CartNameSetter";
            this.CartNameSetter.Size = new System.Drawing.Size(47, 27);
            this.CartNameSetter.TabIndex = 7;
            this.CartNameSetter.Text = "set";
            this.CartNameSetter.UseVisualStyleBackColor = true;
            this.CartNameSetter.Click += new System.EventHandler(this.CartNameSetter_Click);
            // 
            // cartChargeBut
            // 
            this.cartChargeBut.Location = new System.Drawing.Point(593, 13);
            this.cartChargeBut.Name = "cartChargeBut";
            this.cartChargeBut.Size = new System.Drawing.Size(94, 43);
            this.cartChargeBut.TabIndex = 6;
            this.cartChargeBut.Text = "Charge cart";
            this.cartChargeBut.UseVisualStyleBackColor = true;
            this.cartChargeBut.Click += new System.EventHandler(this.cartChargeBut_Click);
            // 
            // cartName
            // 
            this.cartName.Location = new System.Drawing.Point(0, 32);
            this.cartName.Name = "cartName";
            this.cartName.Size = new System.Drawing.Size(115, 27);
            this.cartName.TabIndex = 5;
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
            this.cartInfoCartName.Location = new System.Drawing.Point(40, 11);
            this.cartInfoCartName.Name = "cartInfoCartName";
            this.cartInfoCartName.Size = new System.Drawing.Size(75, 20);
            this.cartInfoCartName.TabIndex = 3;
            this.cartInfoCartName.Text = "cart name";
            // 
            // cartInfoName
            // 
            this.cartInfoName.AutoSize = true;
            this.cartInfoName.Location = new System.Drawing.Point(159, 11);
            this.cartInfoName.Name = "cartInfoName";
            this.cartInfoName.Size = new System.Drawing.Size(104, 20);
            this.cartInfoName.TabIndex = 2;
            this.cartInfoName.Text = "expense count";
            // 
            // addExpenseBut
            // 
            this.addExpenseBut.Location = new System.Drawing.Point(301, 13);
            this.addExpenseBut.Name = "addExpenseBut";
            this.addExpenseBut.Size = new System.Drawing.Size(149, 43);
            this.addExpenseBut.TabIndex = 1;
            this.addExpenseBut.Text = "Add new expense";
            this.addExpenseBut.UseVisualStyleBackColor = true;
            this.addExpenseBut.Click += new System.EventHandler(this.AddExpenseBut_Click);
            // 
            // delCartButton
            // 
            this.delCartButton.Location = new System.Drawing.Point(457, 13);
            this.delCartButton.Name = "delCartButton";
            this.delCartButton.Size = new System.Drawing.Size(130, 43);
            this.delCartButton.TabIndex = 0;
            this.delCartButton.Text = "Delete Cart";
            this.delCartButton.UseVisualStyleBackColor = true;
            this.delCartButton.Click += new System.EventHandler(this.delCartButton_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.addBudget);
            this.tabPage2.Controls.Add(this.budgetControl);
            this.tabPage2.Controls.Add(this.budgetsFlow);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(976, 538);
            this.tabPage2.TabIndex = 8;
            this.tabPage2.Text = "Budgets";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // addBudget
            // 
            this.addBudget.Location = new System.Drawing.Point(93, 94);
            this.addBudget.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addBudget.Name = "addBudget";
            this.addBudget.Size = new System.Drawing.Size(142, 63);
            this.addBudget.TabIndex = 1;
            this.addBudget.Text = "Create New Budget";
            this.addBudget.UseVisualStyleBackColor = true;
            this.addBudget.Click += new System.EventHandler(this.AddBudget_Click);
            // 
            // budgetControl
            // 
            this.budgetControl.Controls.Add(this.dateTo);
            this.budgetControl.Controls.Add(this.dateFrom);
            this.budgetControl.Controls.Add(this.toLbl);
            this.budgetControl.Controls.Add(this.fromLbl);
            this.budgetControl.Controls.Add(this.budgetAdd);
            this.budgetControl.Controls.Add(this.setPeriodLbl);
            this.budgetControl.Controls.Add(this.budgetSum);
            this.budgetControl.Controls.Add(this.setBud);
            this.budgetControl.Controls.Add(this.budgetCat);
            this.budgetControl.Controls.Add(this.selectCat);
            this.budgetControl.Location = new System.Drawing.Point(17, 33);
            this.budgetControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.budgetControl.Name = "budgetControl";
            this.budgetControl.Size = new System.Drawing.Size(303, 467);
            this.budgetControl.TabIndex = 0;
            this.budgetControl.Visible = false;
            // 
            // dateTo
            // 
            this.dateTo.Location = new System.Drawing.Point(13, 360);
            this.dateTo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(259, 27);
            this.dateTo.TabIndex = 6;
            // 
            // dateFrom
            // 
            this.dateFrom.Location = new System.Drawing.Point(13, 284);
            this.dateFrom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(259, 27);
            this.dateFrom.TabIndex = 6;
            // 
            // toLbl
            // 
            this.toLbl.AutoSize = true;
            this.toLbl.Location = new System.Drawing.Point(13, 329);
            this.toLbl.Name = "toLbl";
            this.toLbl.Size = new System.Drawing.Size(25, 20);
            this.toLbl.TabIndex = 2;
            this.toLbl.Text = "To";
            // 
            // fromLbl
            // 
            this.fromLbl.AutoSize = true;
            this.fromLbl.Location = new System.Drawing.Point(13, 253);
            this.fromLbl.Name = "fromLbl";
            this.fromLbl.Size = new System.Drawing.Size(43, 20);
            this.fromLbl.TabIndex = 2;
            this.fromLbl.Text = "From";
            // 
            // budgetAdd
            // 
            this.budgetAdd.Location = new System.Drawing.Point(75, 395);
            this.budgetAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.budgetAdd.Name = "budgetAdd";
            this.budgetAdd.Size = new System.Drawing.Size(142, 39);
            this.budgetAdd.TabIndex = 4;
            this.budgetAdd.Text = "Create Budget";
            this.budgetAdd.UseVisualStyleBackColor = true;
            this.budgetAdd.Click += new System.EventHandler(this.BudgetAdd_Click);
            // 
            // setPeriodLbl
            // 
            this.setPeriodLbl.AutoSize = true;
            this.setPeriodLbl.Location = new System.Drawing.Point(13, 227);
            this.setPeriodLbl.Name = "setPeriodLbl";
            this.setPeriodLbl.Size = new System.Drawing.Size(79, 20);
            this.setPeriodLbl.TabIndex = 2;
            this.setPeriodLbl.Text = "Set Period:";
            // 
            // budgetSum
            // 
            this.budgetSum.Location = new System.Drawing.Point(13, 148);
            this.budgetSum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.budgetSum.Name = "budgetSum";
            this.budgetSum.Size = new System.Drawing.Size(259, 27);
            this.budgetSum.TabIndex = 3;
            // 
            // setBud
            // 
            this.setBud.AutoSize = true;
            this.setBud.Location = new System.Drawing.Point(13, 116);
            this.setBud.Name = "setBud";
            this.setBud.Size = new System.Drawing.Size(82, 20);
            this.setBud.TabIndex = 2;
            this.setBud.Text = "Set Budget";
            // 
            // budgetCat
            // 
            this.budgetCat.FormattingEnabled = true;
            this.budgetCat.Items.AddRange(new object[] {
            "Food",
            "Clothes",
            "Bills",
            "Other"});
            this.budgetCat.Location = new System.Drawing.Point(13, 44);
            this.budgetCat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.budgetCat.Name = "budgetCat";
            this.budgetCat.Size = new System.Drawing.Size(259, 28);
            this.budgetCat.TabIndex = 1;
            // 
            // selectCat
            // 
            this.selectCat.AutoSize = true;
            this.selectCat.Location = new System.Drawing.Point(13, 12);
            this.selectCat.Name = "selectCat";
            this.selectCat.Size = new System.Drawing.Size(113, 20);
            this.selectCat.TabIndex = 0;
            this.selectCat.Text = "Select Category";
            // 
            // budgetsFlow
            // 
            this.budgetsFlow.Location = new System.Drawing.Point(344, 9);
            this.budgetsFlow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.budgetsFlow.Name = "budgetsFlow";
            this.budgetsFlow.Size = new System.Drawing.Size(629, 517);
            this.budgetsFlow.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 0;
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
            this.dataTab.ResumeLayout(false);
            this.dataTab.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabControl3.ResumeLayout(false);
            this.tabPage10.ResumeLayout(false);
            this.tabPage10.PerformLayout();
            this.tabPage11.ResumeLayout(false);
            this.tabPage11.PerformLayout();
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
            this.tabPage6.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.cartElemEditPanel.ResumeLayout(false);
            this.cartElemEditPanel.PerformLayout();
            this.cartNewElemControlPanel.ResumeLayout(false);
            this.cartNewElemControlPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.budgetControl.ResumeLayout(false);
            this.budgetControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button showExpensesButton;
        private System.Windows.Forms.Button showStat;
        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage dataTab;
        private System.Windows.Forms.ComboBox incomeCategory;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox incomeSum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button incomeAdd;
        private System.Windows.Forms.Label incomeStatusField;
        private System.Windows.Forms.Button incomeShow;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ComboBox incomeEditSelection;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox incomeEditSum;
        private System.Windows.Forms.ComboBox incomeEditCategory;
        private Label incomeStatusMessage;
        private SplitContainer splitContainer2;
        private ComboBox expenseEditSelection;
        private Button button4;
        private TextBox expenseEditName;
        private Button button3;
        private ComboBox expenseEditCategory;
        private TextBox expenseEditPrice;
        private Label expenseStatusMessage;
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
        private Label CurrentCartCountNum;
        private Label CartCountLabel;
        private Button CartNameSetter;
        private TabControl tabControl3;
        private TabPage tabPage10;
        private TabPage tabPage11;
        private Label label10;
        private TextBox expenseNameText;
        private Label expenseStatusField;
        private Button enterExpensesButton;
        private Label label13;
        private ComboBox expenseCategorySelection;
        private Label label12;
        private TextBox expensePriceText;
        private Label label11;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dataGridView1;
        private ComboBox searchCategoryBox;
        private Label label7;
        private Label label3;
        private TextBox searchNumberFromText;
        private TextBox searchNameText;
        private Label label2;
        private Label label1;
        private Label label26;
        private TextBox searchNumberToText;
        private ComboBox dataTypeBox;
        private Label label14;
        private Button button5;
        private Label label27;
        private Label label25;
        private DateTimePicker searchDatePickerTo;
        private DateTimePicker searchDatePickerFrom;
        private CheckBox enableDatePickerTo;
        private CheckBox enableDatePickerFrom;
        private TabPage tabPage2;
        private Button addBudget;
        private Panel budgetControl;
        private Label selectCat;
        private ComboBox budgetCat;
        private TextBox budgetSum;
        private Label setBud;
        private Button budgetAdd;
        private Label setPeriodLbl;
        private DateTimePicker dateTo;
        private DateTimePicker dateFrom;
        private Label toLbl;
        private Label fromLbl;
        private FlowLayoutPanel budgetsFlow;
    }
}

