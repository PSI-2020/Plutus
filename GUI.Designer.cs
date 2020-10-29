﻿using System.Windows.Forms;

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
            this.statScreen = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.incomeShow = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.tabPage10 = new System.Windows.Forms.TabPage();
            this.errorField2 = new System.Windows.Forms.Label();
            this.incomeAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.incomeCat = new System.Windows.Forms.ComboBox();
            this.incomeSum = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage11 = new System.Windows.Forms.TabPage();
            this.errorField = new System.Windows.Forms.Label();
            this.enterExpensesButton = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.categoryP = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.priceP = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.nameP = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
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
            this.buttonMyScheduledIncome = new System.Windows.Forms.Button();
            this.buttonAddNewScheduledIncome = new System.Windows.Forms.Button();
            this.panelMyScheduledIncome = new System.Windows.Forms.Panel();
            this.labelScheduledIncome = new System.Windows.Forms.Label();
            this.panelEditScheduledIncome = new System.Windows.Forms.Panel();
            this.panelChangeScheduledIncome = new System.Windows.Forms.Panel();
            this.buttonDeleteScheduledIncome = new System.Windows.Forms.Button();
            this.buttonChangeScheduledIncome = new System.Windows.Forms.Button();
            this.scheduledIncomeNewFirstPay = new System.Windows.Forms.DateTimePicker();
            this.labelScheduledIncomeNewFirstPay = new System.Windows.Forms.Label();
            this.scheduledIncomeNewCategory = new System.Windows.Forms.ComboBox();
            this.labelScheduledIncomeNewCat = new System.Windows.Forms.Label();
            this.scheduledIncomeNewAmount = new System.Windows.Forms.TextBox();
            this.labelScheduledIncomeNewAmount = new System.Windows.Forms.Label();
            this.labelScheduledIncomeNewName = new System.Windows.Forms.Label();
            this.scheduledIncomeNewName = new System.Windows.Forms.TextBox();
            this.panelScheduledIncomeComment = new System.Windows.Forms.Panel();
            this.scheduledIncomeComment = new System.Windows.Forms.Label();
            this.comboBoxScheduledIncome = new System.Windows.Forms.ComboBox();
            this.labelSelectScheduledIncome = new System.Windows.Forms.Label();
            this.panelShowScheduledIncome = new System.Windows.Forms.Panel();
            this.buttonEditScheduledIncome = new System.Windows.Forms.Button();
            this.textBoxScheduledIncome = new System.Windows.Forms.TextBox();
            this.panelAddMonthlyIncome = new System.Windows.Forms.Panel();
            this.monthlyIncomeStatusLabel = new System.Windows.Forms.Label();
            this.buttonAddMonthlyIncome = new System.Windows.Forms.Button();
            this.labelMonthlyIncomeName = new System.Windows.Forms.Label();
            this.monthlyIncomeName = new System.Windows.Forms.TextBox();
            this.monthlyIncomeCategory = new System.Windows.Forms.ComboBox();
            this.labelMonthlyIncomeCategory = new System.Windows.Forms.Label();
            this.monthlyIncomeAmount = new System.Windows.Forms.TextBox();
            this.monthlyIncomeDate = new System.Windows.Forms.DateTimePicker();
            this.labelMonthlyIncomeAmount = new System.Windows.Forms.Label();
            this.labelMonthlyIncomeFirstPay = new System.Windows.Forms.Label();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.panelMyScheduledExpenses = new System.Windows.Forms.Panel();
            this.panelEditScheduledExpenses = new System.Windows.Forms.Panel();
            this.panelScheduledExpensesComment = new System.Windows.Forms.Panel();
            this.scheduledExpensesComment = new System.Windows.Forms.Label();
            this.panelChangeScheduledExpense = new System.Windows.Forms.Panel();
            this.buttonDeleteScheduledExpense = new System.Windows.Forms.Button();
            this.buttonChangeScheduledExpense = new System.Windows.Forms.Button();
            this.scheduledExpenseNewFirstPay = new System.Windows.Forms.DateTimePicker();
            this.labelScheduledExpenseNewFirstPay = new System.Windows.Forms.Label();
            this.scheduledExpenseNewCategory = new System.Windows.Forms.ComboBox();
            this.labelScheduledExpenseNewCategory = new System.Windows.Forms.Label();
            this.scheduledExpenseNewAmount = new System.Windows.Forms.TextBox();
            this.labelScheduledExpenseNewAmount = new System.Windows.Forms.Label();
            this.labelScheduledExpenseNewName = new System.Windows.Forms.Label();
            this.scheduledExpenseNewName = new System.Windows.Forms.TextBox();
            this.comboBoxScheduledExpenses = new System.Windows.Forms.ComboBox();
            this.labelSelectMonthlyExpense = new System.Windows.Forms.Label();
            this.labelMyScheduledExpenses = new System.Windows.Forms.Label();
            this.panelShowScheduledExpenses = new System.Windows.Forms.Panel();
            this.buttonEditScheduledExpenses = new System.Windows.Forms.Button();
            this.textBoxScheduledExpenses = new System.Windows.Forms.TextBox();
            this.buttonMyScheduledExpenses = new System.Windows.Forms.Button();
            this.buttonAddNewScheduledExpense = new System.Windows.Forms.Button();
            this.panelAddMonthlyExpenses = new System.Windows.Forms.Panel();
            this.monthlyExpensesStatusLabel = new System.Windows.Forms.Label();
            this.buttonAddMonthlyExpenses = new System.Windows.Forms.Button();
            this.monthlyExpensesCategory = new System.Windows.Forms.ComboBox();
            this.labelMonthlyExpensesFirstPay = new System.Windows.Forms.Label();
            this.labelMonthlyExpensesAmount = new System.Windows.Forms.Label();
            this.monthlyExpensesDate = new System.Windows.Forms.DateTimePicker();
            this.monthlyExpensesAmount = new System.Windows.Forms.TextBox();
            this.labelMonthlyExpensesCategory = new System.Windows.Forms.Label();
            this.monthlyExpensesName = new System.Windows.Forms.TextBox();
            this.labelMonthlyExpensesName = new System.Windows.Forms.Label();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.CartNameSetter = new System.Windows.Forms.Button();
            this.cartChargeBut = new System.Windows.Forms.Button();
            this.cartName = new System.Windows.Forms.TextBox();
            this.cartExpCount = new System.Windows.Forms.Label();
            this.cartInfoCartName = new System.Windows.Forms.Label();
            this.cartInfoName = new System.Windows.Forms.Label();
            this.addExpenseBut = new System.Windows.Forms.Button();
            this.delCartButton = new System.Windows.Forms.Button();
            this.cartInfoPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.tabGoal = new System.Windows.Forms.TabPage();
            this.buttonInsights = new System.Windows.Forms.Button();
            this.buttonMyGoals = new System.Windows.Forms.Button();
            this.buttonAddGoal = new System.Windows.Forms.Button();
            this.panelMyGoals = new System.Windows.Forms.Panel();
            this.editGoalButton = new System.Windows.Forms.Button();
            this.labelNameAmountDueDate = new System.Windows.Forms.Label();
            this.labelYourGoals = new System.Windows.Forms.Label();
            this.textBoxMyGoals = new System.Windows.Forms.TextBox();
            this.panelEditGoal = new System.Windows.Forms.Panel();
            this.labelEditGoalSelect = new System.Windows.Forms.Label();
            this.comboBoxEditGoal = new System.Windows.Forms.ComboBox();
            this.labelEditGoal = new System.Windows.Forms.Label();
            this.panelChangeGoal = new System.Windows.Forms.Panel();
            this.buttonDeleteGoal = new System.Windows.Forms.Button();
            this.buttonChangeGoal = new System.Windows.Forms.Button();
            this.labelChangeGoalDueDate = new System.Windows.Forms.Label();
            this.dateTimePickerChangeGoal = new System.Windows.Forms.DateTimePicker();
            this.labelChangeGoalAmount = new System.Windows.Forms.Label();
            this.textBoxChangeGoalAmount = new System.Windows.Forms.TextBox();
            this.labelChangeGoalName = new System.Windows.Forms.Label();
            this.textBoxChangeGoalName = new System.Windows.Forms.TextBox();
            this.panelGoalComment = new System.Windows.Forms.Panel();
            this.labelErrorChangeGoal = new System.Windows.Forms.Label();
            this.panelAddGoal = new System.Windows.Forms.Panel();
            this.addGoalErrorLabel = new System.Windows.Forms.Label();
            this.buttonAddGoalCancel = new System.Windows.Forms.Button();
            this.buttonAddGoalEnter = new System.Windows.Forms.Button();
            this.dateTimePickerAddGoal = new System.Windows.Forms.DateTimePicker();
            this.labelDueDateAddGoal = new System.Windows.Forms.Label();
            this.labelAddGoalAmount = new System.Windows.Forms.Label();
            this.textBoxAddGoalAmount = new System.Windows.Forms.TextBox();
            this.labelAddGoalName = new System.Windows.Forms.Label();
            this.textBoxAddGoalName = new System.Windows.Forms.TextBox();
            this.panelInsights = new System.Windows.Forms.Panel();
            this.labelInsightsGoal = new System.Windows.Forms.Label();
            this.comboBoxInsights = new System.Windows.Forms.ComboBox();
            this.panelInsightsSpend = new System.Windows.Forms.Panel();
            this.daysLeft = new System.Windows.Forms.Label();
            this.labelDaysLeft = new System.Windows.Forms.Label();
            this.monthlySpend = new System.Windows.Forms.Label();
            this.dailySpend = new System.Windows.Forms.Label();
            this.labelThisMonthYouCanSpend = new System.Windows.Forms.Label();
            this.labelTodayYouCanSpend = new System.Windows.Forms.Label();
            this.labelInsights = new System.Windows.Forms.Label();
            this.panelGoal = new System.Windows.Forms.Panel();
            this.labelGoal = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
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
            this.panelMyScheduledIncome.SuspendLayout();
            this.panelEditScheduledIncome.SuspendLayout();
            this.panelChangeScheduledIncome.SuspendLayout();
            this.panelScheduledIncomeComment.SuspendLayout();
            this.panelShowScheduledIncome.SuspendLayout();
            this.panelAddMonthlyIncome.SuspendLayout();
            this.tabPage9.SuspendLayout();
            this.panelMyScheduledExpenses.SuspendLayout();
            this.panelEditScheduledExpenses.SuspendLayout();
            this.panelScheduledExpensesComment.SuspendLayout();
            this.panelChangeScheduledExpense.SuspendLayout();
            this.panelShowScheduledExpenses.SuspendLayout();
            this.panelAddMonthlyExpenses.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.cartElemEditPanel.SuspendLayout();
            this.cartNewElemControlPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabGoal.SuspendLayout();
            this.panelMyGoals.SuspendLayout();
            this.panelEditGoal.SuspendLayout();
            this.panelChangeGoal.SuspendLayout();
            this.panelGoalComment.SuspendLayout();
            this.panelAddGoal.SuspendLayout();
            this.panelInsights.SuspendLayout();
            this.panelInsightsSpend.SuspendLayout();
            this.panelGoal.SuspendLayout();
            this.SuspendLayout();
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
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabGoal);
            this.tabControl1.Location = new System.Drawing.Point(11, 11);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 6;
            this.tabControl1.Size = new System.Drawing.Size(861, 427);
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
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(853, 399);
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
            this.tabPage1.Controls.Add(this.tabControl3);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(853, 399);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "Income/Expense";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabControl3
            // 
            this.tabControl3.Controls.Add(this.tabPage10);
            this.tabControl3.Controls.Add(this.tabPage11);
            this.tabControl3.Location = new System.Drawing.Point(4, 3);
            this.tabControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(848, 395);
            this.tabControl3.TabIndex = 0;
            // 
            // tabPage10
            // 
            this.tabPage10.Controls.Add(this.errorField2);
            this.tabPage10.Controls.Add(this.incomeAdd);
            this.tabPage10.Controls.Add(this.label4);
            this.tabPage10.Controls.Add(this.label5);
            this.tabPage10.Controls.Add(this.incomeCat);
            this.tabPage10.Controls.Add(this.incomeSum);
            this.tabPage10.Controls.Add(this.label6);
            this.tabPage10.Location = new System.Drawing.Point(4, 24);
            this.tabPage10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage10.Name = "tabPage10";
            this.tabPage10.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage10.Size = new System.Drawing.Size(840, 367);
            this.tabPage10.TabIndex = 0;
            this.tabPage10.Text = "Add Income";
            this.tabPage10.UseVisualStyleBackColor = true;
            // 
            // errorField2
            // 
            this.errorField2.AutoSize = true;
            this.errorField2.Location = new System.Drawing.Point(384, 103);
            this.errorField2.Name = "errorField2";
            this.errorField2.Size = new System.Drawing.Size(0, 15);
            this.errorField2.TabIndex = 6;
            // 
            // incomeAdd
            // 
            this.incomeAdd.Location = new System.Drawing.Point(577, 55);
            this.incomeAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.incomeAdd.Name = "incomeAdd";
            this.incomeAdd.Size = new System.Drawing.Size(99, 23);
            this.incomeAdd.TabIndex = 5;
            this.incomeAdd.Text = "Add";
            this.incomeAdd.UseVisualStyleBackColor = true;
            this.incomeAdd.Click += new System.EventHandler(this.inputIncome);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(333, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Enter your income";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(144, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Enter sum";
            // 
            // incomeCat
            // 
            this.incomeCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.incomeCat.FormattingEnabled = true;
            this.incomeCat.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.incomeCat.Items.AddRange(new object[] {
            "Salary",
            "Other"});
            this.incomeCat.Location = new System.Drawing.Point(384, 56);
            this.incomeCat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.incomeCat.Name = "incomeCat";
            this.incomeCat.Size = new System.Drawing.Size(188, 23);
            this.incomeCat.TabIndex = 4;
            // 
            // incomeSum
            // 
            this.incomeSum.Location = new System.Drawing.Point(144, 56);
            this.incomeSum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.incomeSum.Name = "incomeSum";
            this.incomeSum.Size = new System.Drawing.Size(236, 23);
            this.incomeSum.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(384, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "Source of income";
            // 
            // tabPage11
            // 
            this.tabPage11.Controls.Add(this.errorField);
            this.tabPage11.Controls.Add(this.enterExpensesButton);
            this.tabPage11.Controls.Add(this.label13);
            this.tabPage11.Controls.Add(this.categoryP);
            this.tabPage11.Controls.Add(this.label12);
            this.tabPage11.Controls.Add(this.priceP);
            this.tabPage11.Controls.Add(this.label11);
            this.tabPage11.Controls.Add(this.nameP);
            this.tabPage11.Controls.Add(this.label10);
            this.tabPage11.Location = new System.Drawing.Point(4, 24);
            this.tabPage11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage11.Name = "tabPage11";
            this.tabPage11.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage11.Size = new System.Drawing.Size(840, 367);
            this.tabPage11.TabIndex = 1;
            this.tabPage11.Text = "Add Expense";
            this.tabPage11.UseVisualStyleBackColor = true;
            // 
            // errorField
            // 
            this.errorField.AutoSize = true;
            this.errorField.Location = new System.Drawing.Point(395, 93);
            this.errorField.Name = "errorField";
            this.errorField.Size = new System.Drawing.Size(0, 15);
            this.errorField.TabIndex = 5;
            this.errorField.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // enterExpensesButton
            // 
            this.enterExpensesButton.Location = new System.Drawing.Point(630, 49);
            this.enterExpensesButton.Name = "enterExpensesButton";
            this.enterExpensesButton.Size = new System.Drawing.Size(99, 26);
            this.enterExpensesButton.TabIndex = 6;
            this.enterExpensesButton.Text = "Enter";
            this.enterExpensesButton.UseVisualStyleBackColor = true;
            this.enterExpensesButton.Click += new System.EventHandler(this.inputExpense);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(493, 34);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 15);
            this.label13.TabIndex = 3;
            this.label13.Text = "Category";
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
            this.categoryP.Location = new System.Drawing.Point(493, 52);
            this.categoryP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.categoryP.Name = "categoryP";
            this.categoryP.Size = new System.Drawing.Size(133, 23);
            this.categoryP.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(348, 34);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 15);
            this.label12.TabIndex = 3;
            this.label12.Text = "Price";
            // 
            // priceP
            // 
            this.priceP.Location = new System.Drawing.Point(348, 52);
            this.priceP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.priceP.Name = "priceP";
            this.priceP.Size = new System.Drawing.Size(140, 23);
            this.priceP.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(129, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 15);
            this.label11.TabIndex = 3;
            this.label11.Text = "Name";
            // 
            // nameP
            // 
            this.nameP.Location = new System.Drawing.Point(129, 52);
            this.nameP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nameP.Name = "nameP";
            this.nameP.Size = new System.Drawing.Size(215, 23);
            this.nameP.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(318, 7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(175, 22);
            this.label10.TabIndex = 6;
            this.label10.Text = "Enter your expenses";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.splitContainer1);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage4.Size = new System.Drawing.Size(853, 399);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Edit Income";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 4);
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
            this.splitContainer1.SplitterDistance = 281;
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
            this.tabPage5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage5.Size = new System.Drawing.Size(853, 399);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Edit Expenses";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 4);
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
            this.splitContainer2.SplitterDistance = 281;
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
            this.tabPage7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage7.Size = new System.Drawing.Size(853, 399);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Scheduler";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage8);
            this.tabControl2.Controls.Add(this.tabPage9);
            this.tabControl2.Location = new System.Drawing.Point(49, 16);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 2;
            this.tabControl2.Size = new System.Drawing.Size(761, 354);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPage8
            // 
            this.tabPage8.BackColor = System.Drawing.Color.Honeydew;
            this.tabPage8.Controls.Add(this.buttonMyScheduledIncome);
            this.tabPage8.Controls.Add(this.buttonAddNewScheduledIncome);
            this.tabPage8.Controls.Add(this.panelMyScheduledIncome);
            this.tabPage8.Controls.Add(this.panelAddMonthlyIncome);
            this.tabPage8.Location = new System.Drawing.Point(4, 24);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(753, 326);
            this.tabPage8.TabIndex = 0;
            this.tabPage8.Text = "Monthly Income";
            // 
            // buttonMyScheduledIncome
            // 
            this.buttonMyScheduledIncome.Location = new System.Drawing.Point(56, 177);
            this.buttonMyScheduledIncome.Name = "buttonMyScheduledIncome";
            this.buttonMyScheduledIncome.Size = new System.Drawing.Size(161, 58);
            this.buttonMyScheduledIncome.TabIndex = 10;
            this.buttonMyScheduledIncome.Text = "MY SCHEDULED INCOME";
            this.buttonMyScheduledIncome.UseVisualStyleBackColor = true;
            this.buttonMyScheduledIncome.Click += new System.EventHandler(this.ButtonMyScheduledIncome_Click);
            // 
            // buttonAddNewScheduledIncome
            // 
            this.buttonAddNewScheduledIncome.Location = new System.Drawing.Point(56, 71);
            this.buttonAddNewScheduledIncome.Name = "buttonAddNewScheduledIncome";
            this.buttonAddNewScheduledIncome.Size = new System.Drawing.Size(161, 58);
            this.buttonAddNewScheduledIncome.TabIndex = 10;
            this.buttonAddNewScheduledIncome.Text = "ADD NEW";
            this.buttonAddNewScheduledIncome.UseVisualStyleBackColor = true;
            this.buttonAddNewScheduledIncome.Click += new System.EventHandler(this.ButtonAddNewScheduledIncome_Click);
            // 
            // panelMyScheduledIncome
            // 
            this.panelMyScheduledIncome.Controls.Add(this.labelScheduledIncome);
            this.panelMyScheduledIncome.Controls.Add(this.panelEditScheduledIncome);
            this.panelMyScheduledIncome.Controls.Add(this.panelShowScheduledIncome);
            this.panelMyScheduledIncome.Location = new System.Drawing.Point(286, 3);
            this.panelMyScheduledIncome.Name = "panelMyScheduledIncome";
            this.panelMyScheduledIncome.Size = new System.Drawing.Size(464, 318);
            this.panelMyScheduledIncome.TabIndex = 9;
            this.panelMyScheduledIncome.Visible = false;
            // 
            // labelScheduledIncome
            // 
            this.labelScheduledIncome.AutoSize = true;
            this.labelScheduledIncome.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelScheduledIncome.Location = new System.Drawing.Point(140, 14);
            this.labelScheduledIncome.Name = "labelScheduledIncome";
            this.labelScheduledIncome.Size = new System.Drawing.Size(198, 25);
            this.labelScheduledIncome.TabIndex = 0;
            this.labelScheduledIncome.Text = "My Scheduled Income";
            // 
            // panelEditScheduledIncome
            // 
            this.panelEditScheduledIncome.Controls.Add(this.panelChangeScheduledIncome);
            this.panelEditScheduledIncome.Controls.Add(this.panelScheduledIncomeComment);
            this.panelEditScheduledIncome.Controls.Add(this.comboBoxScheduledIncome);
            this.panelEditScheduledIncome.Controls.Add(this.labelSelectScheduledIncome);
            this.panelEditScheduledIncome.Location = new System.Drawing.Point(23, 48);
            this.panelEditScheduledIncome.Name = "panelEditScheduledIncome";
            this.panelEditScheduledIncome.Size = new System.Drawing.Size(412, 258);
            this.panelEditScheduledIncome.TabIndex = 16;
            this.panelEditScheduledIncome.Visible = false;
            // 
            // panelChangeScheduledIncome
            // 
            this.panelChangeScheduledIncome.Controls.Add(this.buttonDeleteScheduledIncome);
            this.panelChangeScheduledIncome.Controls.Add(this.buttonChangeScheduledIncome);
            this.panelChangeScheduledIncome.Controls.Add(this.scheduledIncomeNewFirstPay);
            this.panelChangeScheduledIncome.Controls.Add(this.labelScheduledIncomeNewFirstPay);
            this.panelChangeScheduledIncome.Controls.Add(this.scheduledIncomeNewCategory);
            this.panelChangeScheduledIncome.Controls.Add(this.labelScheduledIncomeNewCat);
            this.panelChangeScheduledIncome.Controls.Add(this.scheduledIncomeNewAmount);
            this.panelChangeScheduledIncome.Controls.Add(this.labelScheduledIncomeNewAmount);
            this.panelChangeScheduledIncome.Controls.Add(this.labelScheduledIncomeNewName);
            this.panelChangeScheduledIncome.Controls.Add(this.scheduledIncomeNewName);
            this.panelChangeScheduledIncome.Location = new System.Drawing.Point(83, 29);
            this.panelChangeScheduledIncome.Name = "panelChangeScheduledIncome";
            this.panelChangeScheduledIncome.Size = new System.Drawing.Size(291, 229);
            this.panelChangeScheduledIncome.TabIndex = 20;
            this.panelChangeScheduledIncome.Visible = false;
            // 
            // buttonDeleteScheduledIncome
            // 
            this.buttonDeleteScheduledIncome.Location = new System.Drawing.Point(159, 189);
            this.buttonDeleteScheduledIncome.Name = "buttonDeleteScheduledIncome";
            this.buttonDeleteScheduledIncome.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteScheduledIncome.TabIndex = 21;
            this.buttonDeleteScheduledIncome.Text = "delete";
            this.buttonDeleteScheduledIncome.UseVisualStyleBackColor = true;
            this.buttonDeleteScheduledIncome.Click += new System.EventHandler(this.ButtonDeleteScheduledIncome_Click);
            // 
            // buttonChangeScheduledIncome
            // 
            this.buttonChangeScheduledIncome.Location = new System.Drawing.Point(51, 189);
            this.buttonChangeScheduledIncome.Name = "buttonChangeScheduledIncome";
            this.buttonChangeScheduledIncome.Size = new System.Drawing.Size(75, 23);
            this.buttonChangeScheduledIncome.TabIndex = 20;
            this.buttonChangeScheduledIncome.Text = "change";
            this.buttonChangeScheduledIncome.UseVisualStyleBackColor = true;
            this.buttonChangeScheduledIncome.Click += new System.EventHandler(this.ButtonChangeScheduledIncome_Click);
            // 
            // scheduledIncomeNewFirstPay
            // 
            this.scheduledIncomeNewFirstPay.Location = new System.Drawing.Point(31, 156);
            this.scheduledIncomeNewFirstPay.Name = "scheduledIncomeNewFirstPay";
            this.scheduledIncomeNewFirstPay.Size = new System.Drawing.Size(217, 23);
            this.scheduledIncomeNewFirstPay.TabIndex = 19;
            // 
            // labelScheduledIncomeNewFirstPay
            // 
            this.labelScheduledIncomeNewFirstPay.AutoSize = true;
            this.labelScheduledIncomeNewFirstPay.Location = new System.Drawing.Point(31, 138);
            this.labelScheduledIncomeNewFirstPay.Name = "labelScheduledIncomeNewFirstPay";
            this.labelScheduledIncomeNewFirstPay.Size = new System.Drawing.Size(82, 15);
            this.labelScheduledIncomeNewFirstPay.TabIndex = 18;
            this.labelScheduledIncomeNewFirstPay.Text = "First payment:";
            // 
            // scheduledIncomeNewCategory
            // 
            this.scheduledIncomeNewCategory.FormattingEnabled = true;
            this.scheduledIncomeNewCategory.Items.AddRange(new object[] {
            "Salary",
            "Other"});
            this.scheduledIncomeNewCategory.Location = new System.Drawing.Point(31, 112);
            this.scheduledIncomeNewCategory.Name = "scheduledIncomeNewCategory";
            this.scheduledIncomeNewCategory.Size = new System.Drawing.Size(217, 23);
            this.scheduledIncomeNewCategory.TabIndex = 17;
            // 
            // labelScheduledIncomeNewCat
            // 
            this.labelScheduledIncomeNewCat.AutoSize = true;
            this.labelScheduledIncomeNewCat.Location = new System.Drawing.Point(31, 94);
            this.labelScheduledIncomeNewCat.Name = "labelScheduledIncomeNewCat";
            this.labelScheduledIncomeNewCat.Size = new System.Drawing.Size(58, 15);
            this.labelScheduledIncomeNewCat.TabIndex = 16;
            this.labelScheduledIncomeNewCat.Text = "Category:";
            // 
            // scheduledIncomeNewAmount
            // 
            this.scheduledIncomeNewAmount.Location = new System.Drawing.Point(31, 68);
            this.scheduledIncomeNewAmount.Name = "scheduledIncomeNewAmount";
            this.scheduledIncomeNewAmount.Size = new System.Drawing.Size(217, 23);
            this.scheduledIncomeNewAmount.TabIndex = 15;
            // 
            // labelScheduledIncomeNewAmount
            // 
            this.labelScheduledIncomeNewAmount.AutoSize = true;
            this.labelScheduledIncomeNewAmount.Location = new System.Drawing.Point(31, 50);
            this.labelScheduledIncomeNewAmount.Name = "labelScheduledIncomeNewAmount";
            this.labelScheduledIncomeNewAmount.Size = new System.Drawing.Size(54, 15);
            this.labelScheduledIncomeNewAmount.TabIndex = 14;
            this.labelScheduledIncomeNewAmount.Text = "Amount:";
            // 
            // labelScheduledIncomeNewName
            // 
            this.labelScheduledIncomeNewName.AutoSize = true;
            this.labelScheduledIncomeNewName.Location = new System.Drawing.Point(31, 7);
            this.labelScheduledIncomeNewName.Name = "labelScheduledIncomeNewName";
            this.labelScheduledIncomeNewName.Size = new System.Drawing.Size(42, 15);
            this.labelScheduledIncomeNewName.TabIndex = 12;
            this.labelScheduledIncomeNewName.Text = "Name:";
            this.labelScheduledIncomeNewName.Visible = false;
            // 
            // scheduledIncomeNewName
            // 
            this.scheduledIncomeNewName.Location = new System.Drawing.Point(31, 26);
            this.scheduledIncomeNewName.Name = "scheduledIncomeNewName";
            this.scheduledIncomeNewName.Size = new System.Drawing.Size(217, 23);
            this.scheduledIncomeNewName.TabIndex = 13;
            this.scheduledIncomeNewName.Visible = false;
            // 
            // panelScheduledIncomeComment
            // 
            this.panelScheduledIncomeComment.Controls.Add(this.scheduledIncomeComment);
            this.panelScheduledIncomeComment.Location = new System.Drawing.Point(50, 80);
            this.panelScheduledIncomeComment.Name = "panelScheduledIncomeComment";
            this.panelScheduledIncomeComment.Size = new System.Drawing.Size(360, 87);
            this.panelScheduledIncomeComment.TabIndex = 21;
            this.panelScheduledIncomeComment.Visible = false;
            // 
            // scheduledIncomeComment
            // 
            this.scheduledIncomeComment.AutoSize = true;
            this.scheduledIncomeComment.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.scheduledIncomeComment.Location = new System.Drawing.Point(33, 31);
            this.scheduledIncomeComment.Name = "scheduledIncomeComment";
            this.scheduledIncomeComment.Size = new System.Drawing.Size(17, 25);
            this.scheduledIncomeComment.TabIndex = 0;
            this.scheduledIncomeComment.Text = " ";
            // 
            // comboBoxScheduledIncome
            // 
            this.comboBoxScheduledIncome.FormattingEnabled = true;
            this.comboBoxScheduledIncome.Location = new System.Drawing.Point(165, 3);
            this.comboBoxScheduledIncome.Name = "comboBoxScheduledIncome";
            this.comboBoxScheduledIncome.Size = new System.Drawing.Size(141, 23);
            this.comboBoxScheduledIncome.TabIndex = 11;
            this.comboBoxScheduledIncome.SelectedIndexChanged += new System.EventHandler(this.ComboBoxScheduledIncome_SelectedIndexChanged);
            // 
            // labelSelectScheduledIncome
            // 
            this.labelSelectScheduledIncome.AutoSize = true;
            this.labelSelectScheduledIncome.Location = new System.Drawing.Point(118, 6);
            this.labelSelectScheduledIncome.Name = "labelSelectScheduledIncome";
            this.labelSelectScheduledIncome.Size = new System.Drawing.Size(41, 15);
            this.labelSelectScheduledIncome.TabIndex = 10;
            this.labelSelectScheduledIncome.Text = "Select:";
            // 
            // panelShowScheduledIncome
            // 
            this.panelShowScheduledIncome.Controls.Add(this.buttonEditScheduledIncome);
            this.panelShowScheduledIncome.Controls.Add(this.textBoxScheduledIncome);
            this.panelShowScheduledIncome.Location = new System.Drawing.Point(64, 11);
            this.panelShowScheduledIncome.Name = "panelShowScheduledIncome";
            this.panelShowScheduledIncome.Size = new System.Drawing.Size(371, 275);
            this.panelShowScheduledIncome.TabIndex = 9;
            // 
            // buttonEditScheduledIncome
            // 
            this.buttonEditScheduledIncome.Location = new System.Drawing.Point(289, 229);
            this.buttonEditScheduledIncome.Name = "buttonEditScheduledIncome";
            this.buttonEditScheduledIncome.Size = new System.Drawing.Size(62, 23);
            this.buttonEditScheduledIncome.TabIndex = 8;
            this.buttonEditScheduledIncome.Text = "edit";
            this.buttonEditScheduledIncome.UseVisualStyleBackColor = true;
            this.buttonEditScheduledIncome.Click += new System.EventHandler(this.ButtonEditScheduledIncome_Click);
            // 
            // textBoxScheduledIncome
            // 
            this.textBoxScheduledIncome.Location = new System.Drawing.Point(3, 40);
            this.textBoxScheduledIncome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxScheduledIncome.Multiline = true;
            this.textBoxScheduledIncome.Name = "textBoxScheduledIncome";
            this.textBoxScheduledIncome.ReadOnly = true;
            this.textBoxScheduledIncome.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxScheduledIncome.Size = new System.Drawing.Size(348, 187);
            this.textBoxScheduledIncome.TabIndex = 7;
            // 
            // panelAddMonthlyIncome
            // 
            this.panelAddMonthlyIncome.Controls.Add(this.monthlyIncomeStatusLabel);
            this.panelAddMonthlyIncome.Controls.Add(this.buttonAddMonthlyIncome);
            this.panelAddMonthlyIncome.Controls.Add(this.labelMonthlyIncomeName);
            this.panelAddMonthlyIncome.Controls.Add(this.monthlyIncomeName);
            this.panelAddMonthlyIncome.Controls.Add(this.monthlyIncomeCategory);
            this.panelAddMonthlyIncome.Controls.Add(this.labelMonthlyIncomeCategory);
            this.panelAddMonthlyIncome.Controls.Add(this.monthlyIncomeAmount);
            this.panelAddMonthlyIncome.Controls.Add(this.monthlyIncomeDate);
            this.panelAddMonthlyIncome.Controls.Add(this.labelMonthlyIncomeAmount);
            this.panelAddMonthlyIncome.Controls.Add(this.labelMonthlyIncomeFirstPay);
            this.panelAddMonthlyIncome.Location = new System.Drawing.Point(350, 14);
            this.panelAddMonthlyIncome.Name = "panelAddMonthlyIncome";
            this.panelAddMonthlyIncome.Size = new System.Drawing.Size(376, 303);
            this.panelAddMonthlyIncome.TabIndex = 8;
            this.panelAddMonthlyIncome.Visible = false;
            // 
            // monthlyIncomeStatusLabel
            // 
            this.monthlyIncomeStatusLabel.AutoSize = true;
            this.monthlyIncomeStatusLabel.Location = new System.Drawing.Point(87, 229);
            this.monthlyIncomeStatusLabel.Name = "monthlyIncomeStatusLabel";
            this.monthlyIncomeStatusLabel.Size = new System.Drawing.Size(0, 15);
            this.monthlyIncomeStatusLabel.TabIndex = 7;
            // 
            // buttonAddMonthlyIncome
            // 
            this.buttonAddMonthlyIncome.Location = new System.Drawing.Point(87, 252);
            this.buttonAddMonthlyIncome.Name = "buttonAddMonthlyIncome";
            this.buttonAddMonthlyIncome.Size = new System.Drawing.Size(121, 23);
            this.buttonAddMonthlyIncome.TabIndex = 6;
            this.buttonAddMonthlyIncome.Text = "Add";
            this.buttonAddMonthlyIncome.UseVisualStyleBackColor = true;
            this.buttonAddMonthlyIncome.Click += new System.EventHandler(this.ButtonAddMonthlyIncome_Click);
            // 
            // labelMonthlyIncomeName
            // 
            this.labelMonthlyIncomeName.AutoSize = true;
            this.labelMonthlyIncomeName.Location = new System.Drawing.Point(9, 34);
            this.labelMonthlyIncomeName.Name = "labelMonthlyIncomeName";
            this.labelMonthlyIncomeName.Size = new System.Drawing.Size(39, 15);
            this.labelMonthlyIncomeName.TabIndex = 0;
            this.labelMonthlyIncomeName.Text = "Name";
            // 
            // monthlyIncomeName
            // 
            this.monthlyIncomeName.Location = new System.Drawing.Point(9, 51);
            this.monthlyIncomeName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.monthlyIncomeName.Name = "monthlyIncomeName";
            this.monthlyIncomeName.Size = new System.Drawing.Size(130, 23);
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
            this.monthlyIncomeCategory.Location = new System.Drawing.Point(51, 110);
            this.monthlyIncomeCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.monthlyIncomeCategory.Name = "monthlyIncomeCategory";
            this.monthlyIncomeCategory.Size = new System.Drawing.Size(207, 23);
            this.monthlyIncomeCategory.TabIndex = 4;
            // 
            // labelMonthlyIncomeCategory
            // 
            this.labelMonthlyIncomeCategory.AutoSize = true;
            this.labelMonthlyIncomeCategory.Location = new System.Drawing.Point(46, 89);
            this.labelMonthlyIncomeCategory.Name = "labelMonthlyIncomeCategory";
            this.labelMonthlyIncomeCategory.Size = new System.Drawing.Size(55, 15);
            this.labelMonthlyIncomeCategory.TabIndex = 0;
            this.labelMonthlyIncomeCategory.Text = "Category";
            // 
            // monthlyIncomeAmount
            // 
            this.monthlyIncomeAmount.Location = new System.Drawing.Point(162, 52);
            this.monthlyIncomeAmount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.monthlyIncomeAmount.Name = "monthlyIncomeAmount";
            this.monthlyIncomeAmount.Size = new System.Drawing.Size(130, 23);
            this.monthlyIncomeAmount.TabIndex = 2;
            // 
            // monthlyIncomeDate
            // 
            this.monthlyIncomeDate.Location = new System.Drawing.Point(51, 190);
            this.monthlyIncomeDate.Name = "monthlyIncomeDate";
            this.monthlyIncomeDate.Size = new System.Drawing.Size(207, 23);
            this.monthlyIncomeDate.TabIndex = 0;
            // 
            // labelMonthlyIncomeAmount
            // 
            this.labelMonthlyIncomeAmount.AutoSize = true;
            this.labelMonthlyIncomeAmount.Location = new System.Drawing.Point(162, 34);
            this.labelMonthlyIncomeAmount.Name = "labelMonthlyIncomeAmount";
            this.labelMonthlyIncomeAmount.Size = new System.Drawing.Size(51, 15);
            this.labelMonthlyIncomeAmount.TabIndex = 0;
            this.labelMonthlyIncomeAmount.Text = "Amount";
            // 
            // labelMonthlyIncomeFirstPay
            // 
            this.labelMonthlyIncomeFirstPay.AutoSize = true;
            this.labelMonthlyIncomeFirstPay.Location = new System.Drawing.Point(46, 157);
            this.labelMonthlyIncomeFirstPay.Name = "labelMonthlyIncomeFirstPay";
            this.labelMonthlyIncomeFirstPay.Size = new System.Drawing.Size(79, 15);
            this.labelMonthlyIncomeFirstPay.TabIndex = 0;
            this.labelMonthlyIncomeFirstPay.Text = "First payment";
            // 
            // tabPage9
            // 
            this.tabPage9.BackColor = System.Drawing.Color.OldLace;
            this.tabPage9.Controls.Add(this.panelMyScheduledExpenses);
            this.tabPage9.Controls.Add(this.buttonMyScheduledExpenses);
            this.tabPage9.Controls.Add(this.buttonAddNewScheduledExpense);
            this.tabPage9.Controls.Add(this.panelAddMonthlyExpenses);
            this.tabPage9.Location = new System.Drawing.Point(4, 24);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage9.Size = new System.Drawing.Size(753, 326);
            this.tabPage9.TabIndex = 1;
            this.tabPage9.Text = "Monthly Expenses";
            // 
            // panelMyScheduledExpenses
            // 
            this.panelMyScheduledExpenses.Controls.Add(this.panelEditScheduledExpenses);
            this.panelMyScheduledExpenses.Controls.Add(this.labelMyScheduledExpenses);
            this.panelMyScheduledExpenses.Controls.Add(this.panelShowScheduledExpenses);
            this.panelMyScheduledExpenses.Location = new System.Drawing.Point(283, 3);
            this.panelMyScheduledExpenses.Name = "panelMyScheduledExpenses";
            this.panelMyScheduledExpenses.Size = new System.Drawing.Size(458, 308);
            this.panelMyScheduledExpenses.TabIndex = 9;
            this.panelMyScheduledExpenses.Visible = false;
            // 
            // panelEditScheduledExpenses
            // 
            this.panelEditScheduledExpenses.Controls.Add(this.panelScheduledExpensesComment);
            this.panelEditScheduledExpenses.Controls.Add(this.panelChangeScheduledExpense);
            this.panelEditScheduledExpenses.Controls.Add(this.comboBoxScheduledExpenses);
            this.panelEditScheduledExpenses.Controls.Add(this.labelSelectMonthlyExpense);
            this.panelEditScheduledExpenses.Location = new System.Drawing.Point(22, 42);
            this.panelEditScheduledExpenses.Name = "panelEditScheduledExpenses";
            this.panelEditScheduledExpenses.Size = new System.Drawing.Size(397, 254);
            this.panelEditScheduledExpenses.TabIndex = 16;
            // 
            // panelScheduledExpensesComment
            // 
            this.panelScheduledExpensesComment.Controls.Add(this.scheduledExpensesComment);
            this.panelScheduledExpensesComment.Location = new System.Drawing.Point(37, 84);
            this.panelScheduledExpensesComment.Name = "panelScheduledExpensesComment";
            this.panelScheduledExpensesComment.Size = new System.Drawing.Size(360, 87);
            this.panelScheduledExpensesComment.TabIndex = 21;
            this.panelScheduledExpensesComment.Visible = false;
            // 
            // scheduledExpensesComment
            // 
            this.scheduledExpensesComment.AutoSize = true;
            this.scheduledExpensesComment.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.scheduledExpensesComment.Location = new System.Drawing.Point(33, 31);
            this.scheduledExpensesComment.Name = "scheduledExpensesComment";
            this.scheduledExpensesComment.Size = new System.Drawing.Size(17, 25);
            this.scheduledExpensesComment.TabIndex = 0;
            this.scheduledExpensesComment.Text = " ";
            // 
            // panelChangeScheduledExpense
            // 
            this.panelChangeScheduledExpense.Controls.Add(this.buttonDeleteScheduledExpense);
            this.panelChangeScheduledExpense.Controls.Add(this.buttonChangeScheduledExpense);
            this.panelChangeScheduledExpense.Controls.Add(this.scheduledExpenseNewFirstPay);
            this.panelChangeScheduledExpense.Controls.Add(this.labelScheduledExpenseNewFirstPay);
            this.panelChangeScheduledExpense.Controls.Add(this.scheduledExpenseNewCategory);
            this.panelChangeScheduledExpense.Controls.Add(this.labelScheduledExpenseNewCategory);
            this.panelChangeScheduledExpense.Controls.Add(this.scheduledExpenseNewAmount);
            this.panelChangeScheduledExpense.Controls.Add(this.labelScheduledExpenseNewAmount);
            this.panelChangeScheduledExpense.Controls.Add(this.labelScheduledExpenseNewName);
            this.panelChangeScheduledExpense.Controls.Add(this.scheduledExpenseNewName);
            this.panelChangeScheduledExpense.Location = new System.Drawing.Point(80, 36);
            this.panelChangeScheduledExpense.Name = "panelChangeScheduledExpense";
            this.panelChangeScheduledExpense.Size = new System.Drawing.Size(291, 217);
            this.panelChangeScheduledExpense.TabIndex = 20;
            this.panelChangeScheduledExpense.Visible = false;
            // 
            // buttonDeleteScheduledExpense
            // 
            this.buttonDeleteScheduledExpense.Location = new System.Drawing.Point(159, 189);
            this.buttonDeleteScheduledExpense.Name = "buttonDeleteScheduledExpense";
            this.buttonDeleteScheduledExpense.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteScheduledExpense.TabIndex = 21;
            this.buttonDeleteScheduledExpense.Text = "delete";
            this.buttonDeleteScheduledExpense.UseVisualStyleBackColor = true;
            this.buttonDeleteScheduledExpense.Click += new System.EventHandler(this.ButtonDeleteScheduledExpense_Click);
            // 
            // buttonChangeScheduledExpense
            // 
            this.buttonChangeScheduledExpense.Location = new System.Drawing.Point(44, 189);
            this.buttonChangeScheduledExpense.Name = "buttonChangeScheduledExpense";
            this.buttonChangeScheduledExpense.Size = new System.Drawing.Size(75, 23);
            this.buttonChangeScheduledExpense.TabIndex = 20;
            this.buttonChangeScheduledExpense.Text = "change";
            this.buttonChangeScheduledExpense.UseVisualStyleBackColor = true;
            this.buttonChangeScheduledExpense.Click += new System.EventHandler(this.ButtonChangeScheduledExpense_Click);
            // 
            // scheduledExpenseNewFirstPay
            // 
            this.scheduledExpenseNewFirstPay.Location = new System.Drawing.Point(31, 156);
            this.scheduledExpenseNewFirstPay.Name = "scheduledExpenseNewFirstPay";
            this.scheduledExpenseNewFirstPay.Size = new System.Drawing.Size(213, 23);
            this.scheduledExpenseNewFirstPay.TabIndex = 19;
            // 
            // labelScheduledExpenseNewFirstPay
            // 
            this.labelScheduledExpenseNewFirstPay.AutoSize = true;
            this.labelScheduledExpenseNewFirstPay.Location = new System.Drawing.Point(31, 138);
            this.labelScheduledExpenseNewFirstPay.Name = "labelScheduledExpenseNewFirstPay";
            this.labelScheduledExpenseNewFirstPay.Size = new System.Drawing.Size(82, 15);
            this.labelScheduledExpenseNewFirstPay.TabIndex = 18;
            this.labelScheduledExpenseNewFirstPay.Text = "First payment:";
            // 
            // scheduledExpenseNewCategory
            // 
            this.scheduledExpenseNewCategory.FormattingEnabled = true;
            this.scheduledExpenseNewCategory.Items.AddRange(new object[] {
            "Food",
            "Clothes",
            "Bills",
            "Other"});
            this.scheduledExpenseNewCategory.Location = new System.Drawing.Point(31, 112);
            this.scheduledExpenseNewCategory.Name = "scheduledExpenseNewCategory";
            this.scheduledExpenseNewCategory.Size = new System.Drawing.Size(213, 23);
            this.scheduledExpenseNewCategory.TabIndex = 17;
            // 
            // labelScheduledExpenseNewCategory
            // 
            this.labelScheduledExpenseNewCategory.AutoSize = true;
            this.labelScheduledExpenseNewCategory.Location = new System.Drawing.Point(31, 94);
            this.labelScheduledExpenseNewCategory.Name = "labelScheduledExpenseNewCategory";
            this.labelScheduledExpenseNewCategory.Size = new System.Drawing.Size(58, 15);
            this.labelScheduledExpenseNewCategory.TabIndex = 16;
            this.labelScheduledExpenseNewCategory.Text = "Category:";
            // 
            // scheduledExpenseNewAmount
            // 
            this.scheduledExpenseNewAmount.Location = new System.Drawing.Point(31, 68);
            this.scheduledExpenseNewAmount.Name = "scheduledExpenseNewAmount";
            this.scheduledExpenseNewAmount.Size = new System.Drawing.Size(213, 23);
            this.scheduledExpenseNewAmount.TabIndex = 15;
            // 
            // labelScheduledExpenseNewAmount
            // 
            this.labelScheduledExpenseNewAmount.AutoSize = true;
            this.labelScheduledExpenseNewAmount.Location = new System.Drawing.Point(31, 50);
            this.labelScheduledExpenseNewAmount.Name = "labelScheduledExpenseNewAmount";
            this.labelScheduledExpenseNewAmount.Size = new System.Drawing.Size(54, 15);
            this.labelScheduledExpenseNewAmount.TabIndex = 14;
            this.labelScheduledExpenseNewAmount.Text = "Amount:";
            // 
            // labelScheduledExpenseNewName
            // 
            this.labelScheduledExpenseNewName.AutoSize = true;
            this.labelScheduledExpenseNewName.Location = new System.Drawing.Point(31, 7);
            this.labelScheduledExpenseNewName.Name = "labelScheduledExpenseNewName";
            this.labelScheduledExpenseNewName.Size = new System.Drawing.Size(42, 15);
            this.labelScheduledExpenseNewName.TabIndex = 12;
            this.labelScheduledExpenseNewName.Text = "Name:";
            // 
            // scheduledExpenseNewName
            // 
            this.scheduledExpenseNewName.Location = new System.Drawing.Point(31, 26);
            this.scheduledExpenseNewName.Name = "scheduledExpenseNewName";
            this.scheduledExpenseNewName.Size = new System.Drawing.Size(213, 23);
            this.scheduledExpenseNewName.TabIndex = 13;
            // 
            // comboBoxScheduledExpenses
            // 
            this.comboBoxScheduledExpenses.FormattingEnabled = true;
            this.comboBoxScheduledExpenses.Location = new System.Drawing.Point(173, 7);
            this.comboBoxScheduledExpenses.Name = "comboBoxScheduledExpenses";
            this.comboBoxScheduledExpenses.Size = new System.Drawing.Size(141, 23);
            this.comboBoxScheduledExpenses.TabIndex = 11;
            this.comboBoxScheduledExpenses.SelectedIndexChanged += new System.EventHandler(this.ComboBoxScheduledExpenses_SelectedIndexChanged);
            // 
            // labelSelectMonthlyExpense
            // 
            this.labelSelectMonthlyExpense.AutoSize = true;
            this.labelSelectMonthlyExpense.Location = new System.Drawing.Point(124, 10);
            this.labelSelectMonthlyExpense.Name = "labelSelectMonthlyExpense";
            this.labelSelectMonthlyExpense.Size = new System.Drawing.Size(41, 15);
            this.labelSelectMonthlyExpense.TabIndex = 10;
            this.labelSelectMonthlyExpense.Text = "Select:";
            // 
            // labelMyScheduledExpenses
            // 
            this.labelMyScheduledExpenses.AutoSize = true;
            this.labelMyScheduledExpenses.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMyScheduledExpenses.Location = new System.Drawing.Point(133, 11);
            this.labelMyScheduledExpenses.Name = "labelMyScheduledExpenses";
            this.labelMyScheduledExpenses.Size = new System.Drawing.Size(213, 25);
            this.labelMyScheduledExpenses.TabIndex = 0;
            this.labelMyScheduledExpenses.Text = "My Scheduled Expenses";
            // 
            // panelShowScheduledExpenses
            // 
            this.panelShowScheduledExpenses.Controls.Add(this.buttonEditScheduledExpenses);
            this.panelShowScheduledExpenses.Controls.Add(this.textBoxScheduledExpenses);
            this.panelShowScheduledExpenses.Location = new System.Drawing.Point(10, 52);
            this.panelShowScheduledExpenses.Name = "panelShowScheduledExpenses";
            this.panelShowScheduledExpenses.Size = new System.Drawing.Size(433, 230);
            this.panelShowScheduledExpenses.TabIndex = 9;
            // 
            // buttonEditScheduledExpenses
            // 
            this.buttonEditScheduledExpenses.Location = new System.Drawing.Point(347, 202);
            this.buttonEditScheduledExpenses.Name = "buttonEditScheduledExpenses";
            this.buttonEditScheduledExpenses.Size = new System.Drawing.Size(62, 23);
            this.buttonEditScheduledExpenses.TabIndex = 8;
            this.buttonEditScheduledExpenses.Text = "edit";
            this.buttonEditScheduledExpenses.UseVisualStyleBackColor = true;
            this.buttonEditScheduledExpenses.Click += new System.EventHandler(this.ButtonEditScheduledExpenses_Click);
            // 
            // textBoxScheduledExpenses
            // 
            this.textBoxScheduledExpenses.Location = new System.Drawing.Point(61, 10);
            this.textBoxScheduledExpenses.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxScheduledExpenses.Multiline = true;
            this.textBoxScheduledExpenses.Name = "textBoxScheduledExpenses";
            this.textBoxScheduledExpenses.ReadOnly = true;
            this.textBoxScheduledExpenses.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxScheduledExpenses.Size = new System.Drawing.Size(348, 187);
            this.textBoxScheduledExpenses.TabIndex = 7;
            // 
            // buttonMyScheduledExpenses
            // 
            this.buttonMyScheduledExpenses.Location = new System.Drawing.Point(56, 177);
            this.buttonMyScheduledExpenses.Name = "buttonMyScheduledExpenses";
            this.buttonMyScheduledExpenses.Size = new System.Drawing.Size(161, 58);
            this.buttonMyScheduledExpenses.TabIndex = 10;
            this.buttonMyScheduledExpenses.Text = "MY SCHEDULED EXPENSES";
            this.buttonMyScheduledExpenses.UseVisualStyleBackColor = true;
            this.buttonMyScheduledExpenses.Click += new System.EventHandler(this.ButtonMyScheduledExpenses_Click);
            // 
            // buttonAddNewScheduledExpense
            // 
            this.buttonAddNewScheduledExpense.Location = new System.Drawing.Point(56, 71);
            this.buttonAddNewScheduledExpense.Name = "buttonAddNewScheduledExpense";
            this.buttonAddNewScheduledExpense.Size = new System.Drawing.Size(161, 58);
            this.buttonAddNewScheduledExpense.TabIndex = 10;
            this.buttonAddNewScheduledExpense.Text = "ADD NEW";
            this.buttonAddNewScheduledExpense.UseVisualStyleBackColor = true;
            this.buttonAddNewScheduledExpense.Click += new System.EventHandler(this.ButtonAddNewScheduledExpense_Click);
            // 
            // panelAddMonthlyExpenses
            // 
            this.panelAddMonthlyExpenses.Controls.Add(this.monthlyExpensesStatusLabel);
            this.panelAddMonthlyExpenses.Controls.Add(this.buttonAddMonthlyExpenses);
            this.panelAddMonthlyExpenses.Controls.Add(this.monthlyExpensesCategory);
            this.panelAddMonthlyExpenses.Controls.Add(this.labelMonthlyExpensesFirstPay);
            this.panelAddMonthlyExpenses.Controls.Add(this.labelMonthlyExpensesAmount);
            this.panelAddMonthlyExpenses.Controls.Add(this.monthlyExpensesDate);
            this.panelAddMonthlyExpenses.Controls.Add(this.monthlyExpensesAmount);
            this.panelAddMonthlyExpenses.Controls.Add(this.labelMonthlyExpensesCategory);
            this.panelAddMonthlyExpenses.Controls.Add(this.monthlyExpensesName);
            this.panelAddMonthlyExpenses.Controls.Add(this.labelMonthlyExpensesName);
            this.panelAddMonthlyExpenses.Location = new System.Drawing.Point(350, 14);
            this.panelAddMonthlyExpenses.Name = "panelAddMonthlyExpenses";
            this.panelAddMonthlyExpenses.Size = new System.Drawing.Size(330, 303);
            this.panelAddMonthlyExpenses.TabIndex = 9;
            this.panelAddMonthlyExpenses.Visible = false;
            // 
            // monthlyExpensesStatusLabel
            // 
            this.monthlyExpensesStatusLabel.AutoSize = true;
            this.monthlyExpensesStatusLabel.Location = new System.Drawing.Point(0, 0);
            this.monthlyExpensesStatusLabel.Name = "monthlyExpensesStatusLabel";
            this.monthlyExpensesStatusLabel.Size = new System.Drawing.Size(0, 15);
            this.monthlyExpensesStatusLabel.TabIndex = 8;
            // 
            // buttonAddMonthlyExpenses
            // 
            this.buttonAddMonthlyExpenses.Location = new System.Drawing.Point(87, 252);
            this.buttonAddMonthlyExpenses.Name = "buttonAddMonthlyExpenses";
            this.buttonAddMonthlyExpenses.Size = new System.Drawing.Size(121, 23);
            this.buttonAddMonthlyExpenses.TabIndex = 7;
            this.buttonAddMonthlyExpenses.Text = "Add";
            this.buttonAddMonthlyExpenses.UseVisualStyleBackColor = true;
            this.buttonAddMonthlyExpenses.Click += new System.EventHandler(this.ButtonAddMonthlyExpenses_Click);
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
            this.monthlyExpensesCategory.Location = new System.Drawing.Point(51, 110);
            this.monthlyExpensesCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.monthlyExpensesCategory.Name = "monthlyExpensesCategory";
            this.monthlyExpensesCategory.Size = new System.Drawing.Size(207, 23);
            this.monthlyExpensesCategory.TabIndex = 4;
            // 
            // labelMonthlyExpensesFirstPay
            // 
            this.labelMonthlyExpensesFirstPay.AutoSize = true;
            this.labelMonthlyExpensesFirstPay.Location = new System.Drawing.Point(46, 157);
            this.labelMonthlyExpensesFirstPay.Name = "labelMonthlyExpensesFirstPay";
            this.labelMonthlyExpensesFirstPay.Size = new System.Drawing.Size(79, 15);
            this.labelMonthlyExpensesFirstPay.TabIndex = 0;
            this.labelMonthlyExpensesFirstPay.Text = "First payment";
            // 
            // labelMonthlyExpensesAmount
            // 
            this.labelMonthlyExpensesAmount.AutoSize = true;
            this.labelMonthlyExpensesAmount.Location = new System.Drawing.Point(162, 34);
            this.labelMonthlyExpensesAmount.Name = "labelMonthlyExpensesAmount";
            this.labelMonthlyExpensesAmount.Size = new System.Drawing.Size(51, 15);
            this.labelMonthlyExpensesAmount.TabIndex = 0;
            this.labelMonthlyExpensesAmount.Text = "Amount";
            // 
            // monthlyExpensesDate
            // 
            this.monthlyExpensesDate.Location = new System.Drawing.Point(51, 190);
            this.monthlyExpensesDate.Name = "monthlyExpensesDate";
            this.monthlyExpensesDate.Size = new System.Drawing.Size(207, 23);
            this.monthlyExpensesDate.TabIndex = 0;
            // 
            // monthlyExpensesAmount
            // 
            this.monthlyExpensesAmount.Location = new System.Drawing.Point(162, 52);
            this.monthlyExpensesAmount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.monthlyExpensesAmount.Name = "monthlyExpensesAmount";
            this.monthlyExpensesAmount.Size = new System.Drawing.Size(130, 23);
            this.monthlyExpensesAmount.TabIndex = 2;
            // 
            // labelMonthlyExpensesCategory
            // 
            this.labelMonthlyExpensesCategory.AutoSize = true;
            this.labelMonthlyExpensesCategory.Location = new System.Drawing.Point(46, 89);
            this.labelMonthlyExpensesCategory.Name = "labelMonthlyExpensesCategory";
            this.labelMonthlyExpensesCategory.Size = new System.Drawing.Size(55, 15);
            this.labelMonthlyExpensesCategory.TabIndex = 0;
            this.labelMonthlyExpensesCategory.Text = "Category";
            // 
            // monthlyExpensesName
            // 
            this.monthlyExpensesName.Location = new System.Drawing.Point(9, 51);
            this.monthlyExpensesName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.monthlyExpensesName.Name = "monthlyExpensesName";
            this.monthlyExpensesName.Size = new System.Drawing.Size(130, 23);
            this.monthlyExpensesName.TabIndex = 1;
            // 
            // labelMonthlyExpensesName
            // 
            this.labelMonthlyExpensesName.AutoSize = true;
            this.labelMonthlyExpensesName.Location = new System.Drawing.Point(9, 34);
            this.labelMonthlyExpensesName.Name = "labelMonthlyExpensesName";
            this.labelMonthlyExpensesName.Size = new System.Drawing.Size(39, 15);
            this.labelMonthlyExpensesName.TabIndex = 0;
            this.labelMonthlyExpensesName.Text = "Name";
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.CurrentCartCountNum);
            this.tabPage6.Controls.Add(this.CartCountLabel);
            this.tabPage6.Controls.Add(this.addCartButton);
            this.tabPage6.Controls.Add(this.cartPanel);
            this.tabPage6.Controls.Add(this.panel2);
            this.tabPage6.Location = new System.Drawing.Point(4, 24);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(853, 399);
            this.tabPage6.TabIndex = 7;
            this.tabPage6.Text = "Carts";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // CurrentCartCountNum
            // 
            this.CurrentCartCountNum.AutoSize = true;
            this.CurrentCartCountNum.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CurrentCartCountNum.Location = new System.Drawing.Point(172, 364);
            this.CurrentCartCountNum.Name = "CurrentCartCountNum";
            this.CurrentCartCountNum.Size = new System.Drawing.Size(0, 19);
            this.CurrentCartCountNum.TabIndex = 5;
            // 
            // CartCountLabel
            // 
            this.CartCountLabel.AutoSize = true;
            this.CartCountLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CartCountLabel.Location = new System.Drawing.Point(15, 362);
            this.CartCountLabel.Name = "CartCountLabel";
            this.CartCountLabel.Size = new System.Drawing.Size(141, 19);
            this.CartCountLabel.TabIndex = 4;
            this.CartCountLabel.Text = "Current Cart amount:";
            // 
            // addCartButton
            // 
            this.addCartButton.Location = new System.Drawing.Point(4, 2);
            this.addCartButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addCartButton.Name = "addCartButton";
            this.addCartButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.addCartButton.Size = new System.Drawing.Size(184, 34);
            this.addCartButton.TabIndex = 3;
            this.addCartButton.Text = "Add A Cart";
            this.addCartButton.UseVisualStyleBackColor = true;
            this.addCartButton.Click += new System.EventHandler(this.addCartButton_Click);
            // 
            // cartPanel
            // 
            this.cartPanel.AutoScroll = true;
            this.cartPanel.Location = new System.Drawing.Point(4, 41);
            this.cartPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cartPanel.Name = "cartPanel";
            this.cartPanel.Size = new System.Drawing.Size(210, 308);
            this.cartPanel.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cartElemEditPanel);
            this.panel2.Controls.Add(this.cartNewElemControlPanel);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.cartInfoPanel);
            this.panel2.Location = new System.Drawing.Point(230, 4);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(610, 388);
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
            this.cartElemEditPanel.Location = new System.Drawing.Point(12, 345);
            this.cartElemEditPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cartElemEditPanel.Name = "cartElemEditPanel";
            this.cartElemEditPanel.Size = new System.Drawing.Size(575, 36);
            this.cartElemEditPanel.TabIndex = 4;
            this.cartElemEditPanel.Visible = false;
            // 
            // cartCloseElemChange
            // 
            this.cartCloseElemChange.Location = new System.Drawing.Point(542, 8);
            this.cartCloseElemChange.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cartCloseElemChange.Name = "cartCloseElemChange";
            this.cartCloseElemChange.Size = new System.Drawing.Size(22, 20);
            this.cartCloseElemChange.TabIndex = 5;
            this.cartCloseElemChange.Text = "X";
            this.cartCloseElemChange.UseVisualStyleBackColor = true;
            this.cartCloseElemChange.Click += new System.EventHandler(this.cartCloseElemChange_Click);
            // 
            // cartElemChangeErorr
            // 
            this.cartElemChangeErorr.Location = new System.Drawing.Point(398, 8);
            this.cartElemChangeErorr.Name = "cartElemChangeErorr";
            this.cartElemChangeErorr.Size = new System.Drawing.Size(93, 20);
            this.cartElemChangeErorr.TabIndex = 4;
            // 
            // elemChangeSave
            // 
            this.elemChangeSave.Location = new System.Drawing.Point(499, 8);
            this.elemChangeSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.elemChangeSave.Name = "elemChangeSave";
            this.elemChangeSave.Size = new System.Drawing.Size(44, 20);
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
            this.cartElemChangeCat.Location = new System.Drawing.Point(262, 8);
            this.cartElemChangeCat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cartElemChangeCat.Name = "cartElemChangeCat";
            this.cartElemChangeCat.Size = new System.Drawing.Size(132, 23);
            this.cartElemChangeCat.TabIndex = 2;
            // 
            // cartElemChangePri
            // 
            this.cartElemChangePri.Location = new System.Drawing.Point(153, 8);
            this.cartElemChangePri.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cartElemChangePri.Name = "cartElemChangePri";
            this.cartElemChangePri.Size = new System.Drawing.Size(96, 23);
            this.cartElemChangePri.TabIndex = 1;
            // 
            // cartElemChangeName
            // 
            this.cartElemChangeName.Location = new System.Drawing.Point(8, 8);
            this.cartElemChangeName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cartElemChangeName.Name = "cartElemChangeName";
            this.cartElemChangeName.Size = new System.Drawing.Size(132, 23);
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
            this.cartNewElemControlPanel.Location = new System.Drawing.Point(12, 73);
            this.cartNewElemControlPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cartNewElemControlPanel.Name = "cartNewElemControlPanel";
            this.cartNewElemControlPanel.Size = new System.Drawing.Size(576, 33);
            this.cartNewElemControlPanel.TabIndex = 2;
            this.cartNewElemControlPanel.Visible = false;
            // 
            // cartCloseElemAddition
            // 
            this.cartCloseElemAddition.Location = new System.Drawing.Point(542, 8);
            this.cartCloseElemAddition.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cartCloseElemAddition.Name = "cartCloseElemAddition";
            this.cartCloseElemAddition.Size = new System.Drawing.Size(22, 20);
            this.cartCloseElemAddition.TabIndex = 5;
            this.cartCloseElemAddition.Text = "X";
            this.cartCloseElemAddition.UseVisualStyleBackColor = true;
            this.cartCloseElemAddition.Click += new System.EventHandler(this.CartCloseElemAddition_Click);
            // 
            // cartAddErrorField
            // 
            this.cartAddErrorField.Location = new System.Drawing.Point(400, 8);
            this.cartAddErrorField.Name = "cartAddErrorField";
            this.cartAddErrorField.Size = new System.Drawing.Size(92, 20);
            this.cartAddErrorField.TabIndex = 4;
            // 
            // cartElemAddBut
            // 
            this.cartElemAddBut.Location = new System.Drawing.Point(499, 8);
            this.cartElemAddBut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cartElemAddBut.Name = "cartElemAddBut";
            this.cartElemAddBut.Size = new System.Drawing.Size(44, 20);
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
            this.cartElemCategoryBox.Location = new System.Drawing.Point(262, 8);
            this.cartElemCategoryBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cartElemCategoryBox.Name = "cartElemCategoryBox";
            this.cartElemCategoryBox.Size = new System.Drawing.Size(133, 23);
            this.cartElemCategoryBox.TabIndex = 2;
            // 
            // cartElemPriceBox
            // 
            this.cartElemPriceBox.Location = new System.Drawing.Point(153, 8);
            this.cartElemPriceBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cartElemPriceBox.Name = "cartElemPriceBox";
            this.cartElemPriceBox.Size = new System.Drawing.Size(97, 23);
            this.cartElemPriceBox.TabIndex = 1;
            // 
            // cartElemNameBox
            // 
            this.cartElemNameBox.Location = new System.Drawing.Point(9, 8);
            this.cartElemNameBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cartElemNameBox.Name = "cartElemNameBox";
            this.cartElemNameBox.Size = new System.Drawing.Size(132, 23);
            this.cartElemNameBox.TabIndex = 0;
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
            this.panel1.Location = new System.Drawing.Point(0, 14);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(610, 52);
            this.panel1.TabIndex = 0;
            // 
            // CartNameSetter
            // 
            this.CartNameSetter.Location = new System.Drawing.Point(98, 24);
            this.CartNameSetter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CartNameSetter.Name = "CartNameSetter";
            this.CartNameSetter.Size = new System.Drawing.Size(41, 20);
            this.CartNameSetter.TabIndex = 7;
            this.CartNameSetter.Text = "set";
            this.CartNameSetter.UseVisualStyleBackColor = true;
            this.CartNameSetter.Click += new System.EventHandler(this.CartNameSetter_Click);
            // 
            // cartChargeBut
            // 
            this.cartChargeBut.Location = new System.Drawing.Point(519, 10);
            this.cartChargeBut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cartChargeBut.Name = "cartChargeBut";
            this.cartChargeBut.Size = new System.Drawing.Size(82, 32);
            this.cartChargeBut.TabIndex = 6;
            this.cartChargeBut.Text = "Charge cart";
            this.cartChargeBut.UseVisualStyleBackColor = true;
            this.cartChargeBut.Click += new System.EventHandler(this.cartChargeBut_Click);
            // 
            // cartName
            // 
            this.cartName.Location = new System.Drawing.Point(0, 24);
            this.cartName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cartName.Name = "cartName";
            this.cartName.Size = new System.Drawing.Size(101, 23);
            this.cartName.TabIndex = 5;
            // 
            // cartExpCount
            // 
            this.cartExpCount.AutoSize = true;
            this.cartExpCount.Location = new System.Drawing.Point(175, 26);
            this.cartExpCount.Name = "cartExpCount";
            this.cartExpCount.Size = new System.Drawing.Size(13, 15);
            this.cartExpCount.TabIndex = 4;
            this.cartExpCount.Text = "0";
            // 
            // cartInfoCartName
            // 
            this.cartInfoCartName.AutoSize = true;
            this.cartInfoCartName.Location = new System.Drawing.Point(35, 8);
            this.cartInfoCartName.Name = "cartInfoCartName";
            this.cartInfoCartName.Size = new System.Drawing.Size(60, 15);
            this.cartInfoCartName.TabIndex = 3;
            this.cartInfoCartName.Text = "cart name";
            // 
            // cartInfoName
            // 
            this.cartInfoName.AutoSize = true;
            this.cartInfoName.Location = new System.Drawing.Point(139, 8);
            this.cartInfoName.Name = "cartInfoName";
            this.cartInfoName.Size = new System.Drawing.Size(84, 15);
            this.cartInfoName.TabIndex = 2;
            this.cartInfoName.Text = "expense count";
            // 
            // addExpenseBut
            // 
            this.addExpenseBut.Location = new System.Drawing.Point(263, 10);
            this.addExpenseBut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addExpenseBut.Name = "addExpenseBut";
            this.addExpenseBut.Size = new System.Drawing.Size(130, 32);
            this.addExpenseBut.TabIndex = 1;
            this.addExpenseBut.Text = "Add new expense";
            this.addExpenseBut.UseVisualStyleBackColor = true;
            this.addExpenseBut.Click += new System.EventHandler(this.AddExpenseBut_Click);
            // 
            // delCartButton
            // 
            this.delCartButton.Location = new System.Drawing.Point(400, 10);
            this.delCartButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.delCartButton.Name = "delCartButton";
            this.delCartButton.Size = new System.Drawing.Size(114, 32);
            this.delCartButton.TabIndex = 0;
            this.delCartButton.Text = "Delete Cart";
            this.delCartButton.UseVisualStyleBackColor = true;
            this.delCartButton.Click += new System.EventHandler(this.delCartButton_Click);
            // 
            // cartInfoPanel
            // 
            this.cartInfoPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cartInfoPanel.AutoScroll = true;
            this.cartInfoPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cartInfoPanel.Location = new System.Drawing.Point(15, 75);
            this.cartInfoPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cartInfoPanel.Name = "cartInfoPanel";
            this.cartInfoPanel.Size = new System.Drawing.Size(573, 301);
            this.cartInfoPanel.TabIndex = 3;
            // 
            // tabGoal
            // 
            this.tabGoal.Controls.Add(this.buttonInsights);
            this.tabGoal.Controls.Add(this.buttonMyGoals);
            this.tabGoal.Controls.Add(this.buttonAddGoal);
            this.tabGoal.Controls.Add(this.panelMyGoals);
            this.tabGoal.Controls.Add(this.panelEditGoal);
            this.tabGoal.Controls.Add(this.panelAddGoal);
            this.tabGoal.Controls.Add(this.panelInsights);
            this.tabGoal.Controls.Add(this.panelGoal);
            this.tabGoal.Location = new System.Drawing.Point(4, 24);
            this.tabGoal.Name = "tabGoal";
            this.tabGoal.Padding = new System.Windows.Forms.Padding(3);
            this.tabGoal.Size = new System.Drawing.Size(853, 399);
            this.tabGoal.TabIndex = 8;
            this.tabGoal.Text = "Goal";
            this.tabGoal.UseVisualStyleBackColor = true;
            // 
            // buttonInsights
            // 
            this.buttonInsights.Location = new System.Drawing.Point(71, 76);
            this.buttonInsights.Name = "buttonInsights";
            this.buttonInsights.Size = new System.Drawing.Size(200, 45);
            this.buttonInsights.TabIndex = 0;
            this.buttonInsights.Text = "Insights";
            this.buttonInsights.UseVisualStyleBackColor = true;
            this.buttonInsights.Click += new System.EventHandler(this.ButtonInsights_Click);
            // 
            // buttonMyGoals
            // 
            this.buttonMyGoals.Location = new System.Drawing.Point(71, 270);
            this.buttonMyGoals.Name = "buttonMyGoals";
            this.buttonMyGoals.Size = new System.Drawing.Size(200, 45);
            this.buttonMyGoals.TabIndex = 0;
            this.buttonMyGoals.Text = "My Goals";
            this.buttonMyGoals.UseVisualStyleBackColor = true;
            this.buttonMyGoals.Click += new System.EventHandler(this.ButtonMyGoals_Click);
            // 
            // buttonAddGoal
            // 
            this.buttonAddGoal.Location = new System.Drawing.Point(71, 172);
            this.buttonAddGoal.Name = "buttonAddGoal";
            this.buttonAddGoal.Size = new System.Drawing.Size(200, 45);
            this.buttonAddGoal.TabIndex = 0;
            this.buttonAddGoal.Text = "Add Goal";
            this.buttonAddGoal.UseVisualStyleBackColor = true;
            this.buttonAddGoal.Click += new System.EventHandler(this.ButtonAddGoal_Click);
            // 
            // panelMyGoals
            // 
            this.panelMyGoals.Controls.Add(this.editGoalButton);
            this.panelMyGoals.Controls.Add(this.labelNameAmountDueDate);
            this.panelMyGoals.Controls.Add(this.labelYourGoals);
            this.panelMyGoals.Controls.Add(this.textBoxMyGoals);
            this.panelMyGoals.Location = new System.Drawing.Point(341, 21);
            this.panelMyGoals.Name = "panelMyGoals";
            this.panelMyGoals.Size = new System.Drawing.Size(483, 360);
            this.panelMyGoals.TabIndex = 2;
            this.panelMyGoals.Visible = false;
            // 
            // editGoalButton
            // 
            this.editGoalButton.Location = new System.Drawing.Point(399, 270);
            this.editGoalButton.Name = "editGoalButton";
            this.editGoalButton.Size = new System.Drawing.Size(53, 21);
            this.editGoalButton.TabIndex = 9;
            this.editGoalButton.Text = "edit";
            this.editGoalButton.UseVisualStyleBackColor = true;
            this.editGoalButton.Click += new System.EventHandler(this.EditGoalButton_Click);
            // 
            // labelNameAmountDueDate
            // 
            this.labelNameAmountDueDate.AutoSize = true;
            this.labelNameAmountDueDate.Location = new System.Drawing.Point(20, 52);
            this.labelNameAmountDueDate.Name = "labelNameAmountDueDate";
            this.labelNameAmountDueDate.Size = new System.Drawing.Size(162, 15);
            this.labelNameAmountDueDate.TabIndex = 5;
            this.labelNameAmountDueDate.Text = "NAME | AMOUNT | DUE DATE";
            // 
            // labelYourGoals
            // 
            this.labelYourGoals.AutoSize = true;
            this.labelYourGoals.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelYourGoals.Location = new System.Drawing.Point(182, 9);
            this.labelYourGoals.Name = "labelYourGoals";
            this.labelYourGoals.Size = new System.Drawing.Size(109, 28);
            this.labelYourGoals.TabIndex = 8;
            this.labelYourGoals.Text = "Your Goals:";
            // 
            // textBoxMyGoals
            // 
            this.textBoxMyGoals.Location = new System.Drawing.Point(20, 78);
            this.textBoxMyGoals.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxMyGoals.Multiline = true;
            this.textBoxMyGoals.Name = "textBoxMyGoals";
            this.textBoxMyGoals.ReadOnly = true;
            this.textBoxMyGoals.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxMyGoals.Size = new System.Drawing.Size(432, 187);
            this.textBoxMyGoals.TabIndex = 7;
            // 
            // panelEditGoal
            // 
            this.panelEditGoal.Controls.Add(this.labelEditGoalSelect);
            this.panelEditGoal.Controls.Add(this.comboBoxEditGoal);
            this.panelEditGoal.Controls.Add(this.labelEditGoal);
            this.panelEditGoal.Controls.Add(this.panelChangeGoal);
            this.panelEditGoal.Controls.Add(this.panelGoalComment);
            this.panelEditGoal.Location = new System.Drawing.Point(292, 34);
            this.panelEditGoal.Name = "panelEditGoal";
            this.panelEditGoal.Size = new System.Drawing.Size(532, 356);
            this.panelEditGoal.TabIndex = 4;
            this.panelEditGoal.Visible = false;
            // 
            // labelEditGoalSelect
            // 
            this.labelEditGoalSelect.AutoSize = true;
            this.labelEditGoalSelect.Location = new System.Drawing.Point(250, 83);
            this.labelEditGoalSelect.Name = "labelEditGoalSelect";
            this.labelEditGoalSelect.Size = new System.Drawing.Size(41, 15);
            this.labelEditGoalSelect.TabIndex = 2;
            this.labelEditGoalSelect.Text = "Select:";
            // 
            // comboBoxEditGoal
            // 
            this.comboBoxEditGoal.FormattingEnabled = true;
            this.comboBoxEditGoal.Location = new System.Drawing.Point(204, 101);
            this.comboBoxEditGoal.Name = "comboBoxEditGoal";
            this.comboBoxEditGoal.Size = new System.Drawing.Size(142, 23);
            this.comboBoxEditGoal.TabIndex = 1;
            this.comboBoxEditGoal.SelectedIndexChanged += new System.EventHandler(this.ComboBoxEditGoal_SelectedIndexChanged);
            // 
            // labelEditGoal
            // 
            this.labelEditGoal.AutoSize = true;
            this.labelEditGoal.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEditGoal.Location = new System.Drawing.Point(226, 38);
            this.labelEditGoal.Name = "labelEditGoal";
            this.labelEditGoal.Size = new System.Drawing.Size(88, 25);
            this.labelEditGoal.TabIndex = 0;
            this.labelEditGoal.Text = "Edit Goal";
            // 
            // panelChangeGoal
            // 
            this.panelChangeGoal.Controls.Add(this.buttonDeleteGoal);
            this.panelChangeGoal.Controls.Add(this.buttonChangeGoal);
            this.panelChangeGoal.Controls.Add(this.labelChangeGoalDueDate);
            this.panelChangeGoal.Controls.Add(this.dateTimePickerChangeGoal);
            this.panelChangeGoal.Controls.Add(this.labelChangeGoalAmount);
            this.panelChangeGoal.Controls.Add(this.textBoxChangeGoalAmount);
            this.panelChangeGoal.Controls.Add(this.labelChangeGoalName);
            this.panelChangeGoal.Controls.Add(this.textBoxChangeGoalName);
            this.panelChangeGoal.Location = new System.Drawing.Point(54, 145);
            this.panelChangeGoal.Name = "panelChangeGoal";
            this.panelChangeGoal.Size = new System.Drawing.Size(442, 113);
            this.panelChangeGoal.TabIndex = 3;
            this.panelChangeGoal.Visible = false;
            // 
            // buttonDeleteGoal
            // 
            this.buttonDeleteGoal.Location = new System.Drawing.Point(236, 84);
            this.buttonDeleteGoal.Name = "buttonDeleteGoal";
            this.buttonDeleteGoal.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteGoal.TabIndex = 7;
            this.buttonDeleteGoal.Text = "delete";
            this.buttonDeleteGoal.UseVisualStyleBackColor = true;
            this.buttonDeleteGoal.Click += new System.EventHandler(this.ButtonDeleteGoal_Click);
            // 
            // buttonChangeGoal
            // 
            this.buttonChangeGoal.Location = new System.Drawing.Point(146, 84);
            this.buttonChangeGoal.Name = "buttonChangeGoal";
            this.buttonChangeGoal.Size = new System.Drawing.Size(75, 23);
            this.buttonChangeGoal.TabIndex = 6;
            this.buttonChangeGoal.Text = "change";
            this.buttonChangeGoal.UseVisualStyleBackColor = true;
            this.buttonChangeGoal.Click += new System.EventHandler(this.ButtonChangeGoal_Click);
            // 
            // labelChangeGoalDueDate
            // 
            this.labelChangeGoalDueDate.AutoSize = true;
            this.labelChangeGoalDueDate.Location = new System.Drawing.Point(253, 18);
            this.labelChangeGoalDueDate.Name = "labelChangeGoalDueDate";
            this.labelChangeGoalDueDate.Size = new System.Drawing.Size(58, 15);
            this.labelChangeGoalDueDate.TabIndex = 5;
            this.labelChangeGoalDueDate.Text = "Due Date:";
            // 
            // dateTimePickerChangeGoal
            // 
            this.dateTimePickerChangeGoal.Location = new System.Drawing.Point(253, 37);
            this.dateTimePickerChangeGoal.Name = "dateTimePickerChangeGoal";
            this.dateTimePickerChangeGoal.Size = new System.Drawing.Size(180, 23);
            this.dateTimePickerChangeGoal.TabIndex = 4;
            // 
            // labelChangeGoalAmount
            // 
            this.labelChangeGoalAmount.AutoSize = true;
            this.labelChangeGoalAmount.Location = new System.Drawing.Point(137, 19);
            this.labelChangeGoalAmount.Name = "labelChangeGoalAmount";
            this.labelChangeGoalAmount.Size = new System.Drawing.Size(54, 15);
            this.labelChangeGoalAmount.TabIndex = 3;
            this.labelChangeGoalAmount.Text = "Amount:";
            // 
            // textBoxChangeGoalAmount
            // 
            this.textBoxChangeGoalAmount.Location = new System.Drawing.Point(137, 37);
            this.textBoxChangeGoalAmount.Name = "textBoxChangeGoalAmount";
            this.textBoxChangeGoalAmount.Size = new System.Drawing.Size(100, 23);
            this.textBoxChangeGoalAmount.TabIndex = 2;
            // 
            // labelChangeGoalName
            // 
            this.labelChangeGoalName.AutoSize = true;
            this.labelChangeGoalName.Location = new System.Drawing.Point(17, 18);
            this.labelChangeGoalName.Name = "labelChangeGoalName";
            this.labelChangeGoalName.Size = new System.Drawing.Size(42, 15);
            this.labelChangeGoalName.TabIndex = 1;
            this.labelChangeGoalName.Text = "Name:";
            // 
            // textBoxChangeGoalName
            // 
            this.textBoxChangeGoalName.Location = new System.Drawing.Point(17, 37);
            this.textBoxChangeGoalName.Name = "textBoxChangeGoalName";
            this.textBoxChangeGoalName.Size = new System.Drawing.Size(92, 23);
            this.textBoxChangeGoalName.TabIndex = 0;
            // 
            // panelGoalComment
            // 
            this.panelGoalComment.Controls.Add(this.labelErrorChangeGoal);
            this.panelGoalComment.Location = new System.Drawing.Point(180, 128);
            this.panelGoalComment.Name = "panelGoalComment";
            this.panelGoalComment.Size = new System.Drawing.Size(177, 77);
            this.panelGoalComment.TabIndex = 4;
            this.panelGoalComment.Visible = false;
            // 
            // labelErrorChangeGoal
            // 
            this.labelErrorChangeGoal.AutoSize = true;
            this.labelErrorChangeGoal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelErrorChangeGoal.Location = new System.Drawing.Point(17, 31);
            this.labelErrorChangeGoal.Name = "labelErrorChangeGoal";
            this.labelErrorChangeGoal.Size = new System.Drawing.Size(151, 21);
            this.labelErrorChangeGoal.TabIndex = 4;
            this.labelErrorChangeGoal.Text = "Changed succesfully";
            // 
            // panelAddGoal
            // 
            this.panelAddGoal.Controls.Add(this.addGoalErrorLabel);
            this.panelAddGoal.Controls.Add(this.buttonAddGoalCancel);
            this.panelAddGoal.Controls.Add(this.buttonAddGoalEnter);
            this.panelAddGoal.Controls.Add(this.dateTimePickerAddGoal);
            this.panelAddGoal.Controls.Add(this.labelDueDateAddGoal);
            this.panelAddGoal.Controls.Add(this.labelAddGoalAmount);
            this.panelAddGoal.Controls.Add(this.textBoxAddGoalAmount);
            this.panelAddGoal.Controls.Add(this.labelAddGoalName);
            this.panelAddGoal.Controls.Add(this.textBoxAddGoalName);
            this.panelAddGoal.Location = new System.Drawing.Point(334, 61);
            this.panelAddGoal.Name = "panelAddGoal";
            this.panelAddGoal.Size = new System.Drawing.Size(465, 297);
            this.panelAddGoal.TabIndex = 1;
            this.panelAddGoal.Visible = false;
            // 
            // addGoalErrorLabel
            // 
            this.addGoalErrorLabel.AutoSize = true;
            this.addGoalErrorLabel.Location = new System.Drawing.Point(195, 267);
            this.addGoalErrorLabel.Name = "addGoalErrorLabel";
            this.addGoalErrorLabel.Size = new System.Drawing.Size(0, 15);
            this.addGoalErrorLabel.TabIndex = 4;
            // 
            // buttonAddGoalCancel
            // 
            this.buttonAddGoalCancel.Location = new System.Drawing.Point(252, 235);
            this.buttonAddGoalCancel.Name = "buttonAddGoalCancel";
            this.buttonAddGoalCancel.Size = new System.Drawing.Size(74, 22);
            this.buttonAddGoalCancel.TabIndex = 3;
            this.buttonAddGoalCancel.Text = "cancel";
            this.buttonAddGoalCancel.UseVisualStyleBackColor = true;
            this.buttonAddGoalCancel.Click += new System.EventHandler(this.ButtonAddGoalCancel_Click);
            // 
            // buttonAddGoalEnter
            // 
            this.buttonAddGoalEnter.Location = new System.Drawing.Point(127, 235);
            this.buttonAddGoalEnter.Name = "buttonAddGoalEnter";
            this.buttonAddGoalEnter.Size = new System.Drawing.Size(110, 22);
            this.buttonAddGoalEnter.TabIndex = 3;
            this.buttonAddGoalEnter.Text = "enter";
            this.buttonAddGoalEnter.UseVisualStyleBackColor = true;
            this.buttonAddGoalEnter.Click += new System.EventHandler(this.ButtonAddGoalEnter_Click);
            // 
            // dateTimePickerAddGoal
            // 
            this.dateTimePickerAddGoal.Location = new System.Drawing.Point(106, 181);
            this.dateTimePickerAddGoal.Name = "dateTimePickerAddGoal";
            this.dateTimePickerAddGoal.Size = new System.Drawing.Size(257, 23);
            this.dateTimePickerAddGoal.TabIndex = 2;
            // 
            // labelDueDateAddGoal
            // 
            this.labelDueDateAddGoal.AutoSize = true;
            this.labelDueDateAddGoal.Location = new System.Drawing.Point(105, 150);
            this.labelDueDateAddGoal.Name = "labelDueDateAddGoal";
            this.labelDueDateAddGoal.Size = new System.Drawing.Size(128, 15);
            this.labelDueDateAddGoal.TabIndex = 1;
            this.labelDueDateAddGoal.Text = "Due date for your goal:";
            // 
            // labelAddGoalAmount
            // 
            this.labelAddGoalAmount.AutoSize = true;
            this.labelAddGoalAmount.Location = new System.Drawing.Point(105, 89);
            this.labelAddGoalAmount.Name = "labelAddGoalAmount";
            this.labelAddGoalAmount.Size = new System.Drawing.Size(146, 15);
            this.labelAddGoalAmount.TabIndex = 1;
            this.labelAddGoalAmount.Text = "Amount you want to save:";
            // 
            // textBoxAddGoalAmount
            // 
            this.textBoxAddGoalAmount.Location = new System.Drawing.Point(105, 115);
            this.textBoxAddGoalAmount.Name = "textBoxAddGoalAmount";
            this.textBoxAddGoalAmount.Size = new System.Drawing.Size(258, 23);
            this.textBoxAddGoalAmount.TabIndex = 0;
            // 
            // labelAddGoalName
            // 
            this.labelAddGoalName.AutoSize = true;
            this.labelAddGoalName.Location = new System.Drawing.Point(104, 22);
            this.labelAddGoalName.Name = "labelAddGoalName";
            this.labelAddGoalName.Size = new System.Drawing.Size(93, 15);
            this.labelAddGoalName.TabIndex = 1;
            this.labelAddGoalName.Text = "New goal name:";
            // 
            // textBoxAddGoalName
            // 
            this.textBoxAddGoalName.Location = new System.Drawing.Point(104, 52);
            this.textBoxAddGoalName.Name = "textBoxAddGoalName";
            this.textBoxAddGoalName.Size = new System.Drawing.Size(258, 23);
            this.textBoxAddGoalName.TabIndex = 0;
            // 
            // panelInsights
            // 
            this.panelInsights.Controls.Add(this.labelInsightsGoal);
            this.panelInsights.Controls.Add(this.comboBoxInsights);
            this.panelInsights.Controls.Add(this.panelInsightsSpend);
            this.panelInsights.Controls.Add(this.labelInsights);
            this.panelInsights.Location = new System.Drawing.Point(292, 34);
            this.panelInsights.Name = "panelInsights";
            this.panelInsights.Size = new System.Drawing.Size(558, 331);
            this.panelInsights.TabIndex = 6;
            this.panelInsights.Visible = false;
            // 
            // labelInsightsGoal
            // 
            this.labelInsightsGoal.AutoSize = true;
            this.labelInsightsGoal.Location = new System.Drawing.Point(168, 46);
            this.labelInsightsGoal.Name = "labelInsightsGoal";
            this.labelInsightsGoal.Size = new System.Drawing.Size(34, 15);
            this.labelInsightsGoal.TabIndex = 7;
            this.labelInsightsGoal.Text = "Goal:";
            // 
            // comboBoxInsights
            // 
            this.comboBoxInsights.FormattingEnabled = true;
            this.comboBoxInsights.Location = new System.Drawing.Point(208, 41);
            this.comboBoxInsights.Name = "comboBoxInsights";
            this.comboBoxInsights.Size = new System.Drawing.Size(140, 23);
            this.comboBoxInsights.TabIndex = 6;
            this.comboBoxInsights.SelectedIndexChanged += new System.EventHandler(this.ComboBoxInsights_SelectedIndexChanged);
            // 
            // panelInsightsSpend
            // 
            this.panelInsightsSpend.BackColor = System.Drawing.Color.PapayaWhip;
            this.panelInsightsSpend.Controls.Add(this.daysLeft);
            this.panelInsightsSpend.Controls.Add(this.labelDaysLeft);
            this.panelInsightsSpend.Controls.Add(this.monthlySpend);
            this.panelInsightsSpend.Controls.Add(this.dailySpend);
            this.panelInsightsSpend.Controls.Add(this.labelThisMonthYouCanSpend);
            this.panelInsightsSpend.Controls.Add(this.labelTodayYouCanSpend);
            this.panelInsightsSpend.Location = new System.Drawing.Point(71, 83);
            this.panelInsightsSpend.Name = "panelInsightsSpend";
            this.panelInsightsSpend.Size = new System.Drawing.Size(401, 214);
            this.panelInsightsSpend.TabIndex = 5;
            // 
            // daysLeft
            // 
            this.daysLeft.AutoSize = true;
            this.daysLeft.BackColor = System.Drawing.Color.WhiteSmoke;
            this.daysLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.daysLeft.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.daysLeft.Location = new System.Drawing.Point(213, 146);
            this.daysLeft.Name = "daysLeft";
            this.daysLeft.Size = new System.Drawing.Size(19, 27);
            this.daysLeft.TabIndex = 4;
            this.daysLeft.Text = " ";
            // 
            // labelDaysLeft
            // 
            this.labelDaysLeft.AutoSize = true;
            this.labelDaysLeft.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDaysLeft.Location = new System.Drawing.Point(134, 153);
            this.labelDaysLeft.Name = "labelDaysLeft";
            this.labelDaysLeft.Size = new System.Drawing.Size(70, 20);
            this.labelDaysLeft.TabIndex = 2;
            this.labelDaysLeft.Text = "Days left:";
            // 
            // monthlySpend
            // 
            this.monthlySpend.AutoSize = true;
            this.monthlySpend.BackColor = System.Drawing.Color.WhiteSmoke;
            this.monthlySpend.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.monthlySpend.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.monthlySpend.Location = new System.Drawing.Point(213, 92);
            this.monthlySpend.Name = "monthlySpend";
            this.monthlySpend.Size = new System.Drawing.Size(19, 27);
            this.monthlySpend.TabIndex = 4;
            this.monthlySpend.Text = " ";
            // 
            // dailySpend
            // 
            this.dailySpend.AutoSize = true;
            this.dailySpend.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dailySpend.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dailySpend.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dailySpend.Location = new System.Drawing.Point(213, 30);
            this.dailySpend.Name = "dailySpend";
            this.dailySpend.Size = new System.Drawing.Size(19, 27);
            this.dailySpend.TabIndex = 3;
            this.dailySpend.Text = " ";
            // 
            // labelThisMonthYouCanSpend
            // 
            this.labelThisMonthYouCanSpend.AutoSize = true;
            this.labelThisMonthYouCanSpend.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelThisMonthYouCanSpend.Location = new System.Drawing.Point(23, 95);
            this.labelThisMonthYouCanSpend.Name = "labelThisMonthYouCanSpend";
            this.labelThisMonthYouCanSpend.Size = new System.Drawing.Size(184, 20);
            this.labelThisMonthYouCanSpend.TabIndex = 2;
            this.labelThisMonthYouCanSpend.Text = "This month you can spend:";
            // 
            // labelTodayYouCanSpend
            // 
            this.labelTodayYouCanSpend.AutoSize = true;
            this.labelTodayYouCanSpend.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTodayYouCanSpend.Location = new System.Drawing.Point(53, 33);
            this.labelTodayYouCanSpend.Name = "labelTodayYouCanSpend";
            this.labelTodayYouCanSpend.Size = new System.Drawing.Size(151, 20);
            this.labelTodayYouCanSpend.TabIndex = 1;
            this.labelTodayYouCanSpend.Text = "Today you can spend:";
            // 
            // labelInsights
            // 
            this.labelInsights.AutoSize = true;
            this.labelInsights.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelInsights.Location = new System.Drawing.Point(233, 11);
            this.labelInsights.Name = "labelInsights";
            this.labelInsights.Size = new System.Drawing.Size(92, 25);
            this.labelInsights.TabIndex = 0;
            this.labelInsights.Text = "INSIGHTS";
            // 
            // panelGoal
            // 
            this.panelGoal.Controls.Add(this.labelGoal);
            this.panelGoal.Location = new System.Drawing.Point(303, 150);
            this.panelGoal.Name = "panelGoal";
            this.panelGoal.Size = new System.Drawing.Size(547, 95);
            this.panelGoal.TabIndex = 3;
            this.panelGoal.Visible = false;
            // 
            // labelGoal
            // 
            this.labelGoal.AutoSize = true;
            this.labelGoal.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelGoal.Location = new System.Drawing.Point(168, 29);
            this.labelGoal.Name = "labelGoal";
            this.labelGoal.Size = new System.Drawing.Size(0, 25);
            this.labelGoal.TabIndex = 0;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(236, 84);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 7;
            this.button5.Text = "delete";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(146, 84);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 6;
            this.button6.Text = "change";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(253, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Due Date:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(253, 37);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(180, 23);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(137, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 15);
            this.label7.TabIndex = 3;
            this.label7.Text = "Amount:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(137, 37);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 23);
            this.textBox4.TabIndex = 2;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(17, 18);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 15);
            this.label14.TabIndex = 1;
            this.label14.Text = "Name:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(17, 37);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(92, 23);
            this.textBox5.TabIndex = 0;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(17, 31);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(151, 21);
            this.label15.TabIndex = 4;
            this.label15.Text = "Changed succesfully";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(326, 88);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 21;
            this.button7.Text = "delete";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(225, 88);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 20;
            this.button8.Text = "change";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(434, 36);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker2.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(433, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "First payment:";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(296, 37);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 23);
            this.comboBox4.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(296, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "Category:";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(165, 37);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(113, 23);
            this.textBox6.TabIndex = 15;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(165, 16);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(54, 15);
            this.label16.TabIndex = 14;
            this.label16.Text = "Amount:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(9, 16);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(42, 15);
            this.label17.TabIndex = 12;
            this.label17.Text = "Name:";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(9, 37);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(141, 23);
            this.textBox7.TabIndex = 13;
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 439);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GUI";
            this.Text = "Plutus";
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
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
            this.panelMyScheduledIncome.ResumeLayout(false);
            this.panelMyScheduledIncome.PerformLayout();
            this.panelEditScheduledIncome.ResumeLayout(false);
            this.panelEditScheduledIncome.PerformLayout();
            this.panelChangeScheduledIncome.ResumeLayout(false);
            this.panelChangeScheduledIncome.PerformLayout();
            this.panelScheduledIncomeComment.ResumeLayout(false);
            this.panelScheduledIncomeComment.PerformLayout();
            this.panelShowScheduledIncome.ResumeLayout(false);
            this.panelShowScheduledIncome.PerformLayout();
            this.panelAddMonthlyIncome.ResumeLayout(false);
            this.panelAddMonthlyIncome.PerformLayout();
            this.tabPage9.ResumeLayout(false);
            this.panelMyScheduledExpenses.ResumeLayout(false);
            this.panelMyScheduledExpenses.PerformLayout();
            this.panelEditScheduledExpenses.ResumeLayout(false);
            this.panelEditScheduledExpenses.PerformLayout();
            this.panelScheduledExpensesComment.ResumeLayout(false);
            this.panelScheduledExpensesComment.PerformLayout();
            this.panelChangeScheduledExpense.ResumeLayout(false);
            this.panelChangeScheduledExpense.PerformLayout();
            this.panelShowScheduledExpenses.ResumeLayout(false);
            this.panelShowScheduledExpenses.PerformLayout();
            this.panelAddMonthlyExpenses.ResumeLayout(false);
            this.panelAddMonthlyExpenses.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.cartElemEditPanel.ResumeLayout(false);
            this.cartElemEditPanel.PerformLayout();
            this.cartNewElemControlPanel.ResumeLayout(false);
            this.cartNewElemControlPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabGoal.ResumeLayout(false);
            this.panelMyGoals.ResumeLayout(false);
            this.panelMyGoals.PerformLayout();
            this.panelEditGoal.ResumeLayout(false);
            this.panelEditGoal.PerformLayout();
            this.panelChangeGoal.ResumeLayout(false);
            this.panelChangeGoal.PerformLayout();
            this.panelGoalComment.ResumeLayout(false);
            this.panelGoalComment.PerformLayout();
            this.panelAddGoal.ResumeLayout(false);
            this.panelAddGoal.PerformLayout();
            this.panelInsights.ResumeLayout(false);
            this.panelInsights.PerformLayout();
            this.panelInsightsSpend.ResumeLayout(false);
            this.panelInsightsSpend.PerformLayout();
            this.panelGoal.ResumeLayout(false);
            this.panelGoal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button showExpensesButton;
        private System.Windows.Forms.Button showStat;
        private System.Windows.Forms.TextBox statScreen;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ComboBox incomeCat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox incomeSum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button incomeAdd;
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
        private Label labelMonthlyIncomeName;
        private TextBox monthlyIncomeName;
        private ComboBox monthlyIncomeCategory;
        private Label labelMonthlyIncomeCategory;
        private TextBox monthlyIncomeAmount;
        private DateTimePicker monthlyIncomeDate;
        private Label labelMonthlyIncomeAmount;
        private Label labelMonthlyIncomeFirstPay;
        private Label labelMonthlyExpensesFirstPay;
        private Label labelMonthlyExpensesAmount;
        private DateTimePicker monthlyExpensesDate;
        private TextBox monthlyExpensesAmount;
        private Label labelMonthlyExpensesCategory;
        private TextBox monthlyExpensesName;
        private Label labelMonthlyExpensesName;
        private ComboBox monthlyExpensesCategory;
        private Button buttonAddMonthlyIncome;
        private Label monthlyIncomeStatusLabel;
        private Button buttonAddMonthlyExpenses;
        private Label monthlyExpensesStatusLabel;
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
        private TextBox nameP;
        private Label errorField;
        private Button enterExpensesButton;
        private Label label13;
        private ComboBox categoryP;
        private Label label12;
        private TextBox priceP;
        private Label label11;
        private TabPage tabGoal;
        private Button buttonAddGoal;
        private Button buttonMyGoals;
        private Panel panelAddGoal;
        private Label labelAddGoalAmount;
        private TextBox textBoxAddGoalAmount;
        private Label labelAddGoalName;
        private TextBox textBoxAddGoalName;
        private Button buttonAddGoalCancel;
        private Button buttonAddGoalEnter;
        private DateTimePicker dateTimePickerAddGoal;
        private Label labelDueDateAddGoal;
        private Panel panelMyGoals;
        private Label labelYourGoals;
        private TextBox textBoxMyGoals;
        private Label addGoalErrorLabel;
        private Panel panelGoal;
        private Label labelGoal;
        private Label labelNameAmountDueDate;
        private Button editGoalButton;
        private Panel panelEditGoal;
        private ComboBox comboBoxEditGoal;
        private Label labelEditGoal;
        private Label labelEditGoalSelect;
        private Panel panelChangeGoal;
        private TextBox textBoxChangeGoalName;
        private DateTimePicker dateTimePickerChangeGoal;
        private Label labelChangeGoalAmount;
        private TextBox textBoxChangeGoalAmount;
        private Label labelChangeGoalName;
        private Button buttonChangeGoal;
        private Label labelChangeGoalDueDate;
        private Label labelErrorChangeGoal;
        private Panel panelGoalComment;
        private Button buttonInsights;
        private Panel panelInsights;
        private Label monthlySpend;
        private Label dailySpend;
        private Label labelThisMonthYouCanSpend;
        private Label labelTodayYouCanSpend;
        private Label labelInsights;
        private Panel panelInsightsSpend;
        private ComboBox comboBoxInsights;
        private Button buttonDeleteGoal;
        private Label labelInsightsGoal;
        private Label daysLeft;
        private Label labelDaysLeft;
        private Button button5;
        private Button button6;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private Label label7;
        private TextBox textBox4;
        private Label label14;
        private TextBox textBox5;
        private Label label15;
        private Panel panelMyScheduledIncome;
        private Label labelScheduledIncome;
        private Panel panelAddMonthlyIncome;
        private Button buttonEditScheduledIncome;
        private TextBox textBoxScheduledIncome;
        private Panel panelMyScheduledExpenses;
        private Button buttonEditScheduledExpenses;
        private TextBox textBoxScheduledExpenses;
        private Label labelMyScheduledExpenses;
        private Panel panelAddMonthlyExpenses;
        private Panel panelShowScheduledIncome;
        private Panel panelShowScheduledExpenses;
        private Label labelScheduledExpenseNewAmount;
        private TextBox scheduledExpenseNewName;
        private Label labelScheduledExpenseNewName;
        private ComboBox comboBoxScheduledExpenses;
        private Label labelSelectMonthlyExpense;
        private TextBox scheduledExpenseNewAmount;
        private Panel panelEditScheduledExpenses;
        private Panel panelEditScheduledIncome;
        private ComboBox comboBoxScheduledIncome;
        private Label labelSelectScheduledIncome;
        private Panel panelChangeScheduledExpense;
        private Button buttonDeleteScheduledExpense;
        private Button buttonChangeScheduledExpense;
        private DateTimePicker scheduledExpenseNewFirstPay;
        private Label labelScheduledExpenseNewFirstPay;
        private ComboBox scheduledExpenseNewCategory;
        private Label labelScheduledExpenseNewCategory;
        private Button button7;
        private Button button8;
        private DateTimePicker dateTimePicker2;
        private Label label1;
        private ComboBox comboBox4;
        private Label label2;
        private TextBox textBox6;
        private Label label16;
        private Label label17;
        private TextBox textBox7;
        private Panel panelChangeScheduledIncome;
        private Button buttonDeleteScheduledIncome;
        private Button buttonChangeScheduledIncome;
        private DateTimePicker scheduledIncomeNewFirstPay;
        private Label labelScheduledIncomeNewFirstPay;
        private ComboBox scheduledIncomeNewCategory;
        private Label labelScheduledIncomeNewCat;
        private TextBox scheduledIncomeNewAmount;
        private Label labelScheduledIncomeNewAmount;
        private Label labelScheduledIncomeNewName;
        private TextBox scheduledIncomeNewName;
        private Button buttonMyScheduledIncome;
        private Button buttonAddNewScheduledIncome;
        private Button buttonMyScheduledExpenses;
        private Button buttonAddNewScheduledExpense;
        private Panel panelScheduledIncomeComment;
        private Label scheduledIncomeComment;
        private Panel panelScheduledExpensesComment;
        private Label scheduledExpensesComment;
    }
}

