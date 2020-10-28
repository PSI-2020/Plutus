using System;
using System.Windows.Forms;

namespace Plutus
{
    enum ExpenseCategories
    {
        Food,
        Clothes,
        Bills,
        Other
    }

    enum IncomeCategories
    {
        Salary,
        Other
    }

    public partial class GUI : Form
    {
        readonly DataManager manager = new DataManager();
        readonly Statistics stats = new Statistics();
        public GUI() => InitializeComponent();

        private void buttonAddMonthlyExpenses_Click(object sender, EventArgs e)
        {
            if (monthlyExpensesName.Text.Length == 0 || monthlyExpensesName.Text == null)
            {
                errorLabel2.Text = "Name cannot be empty!";
                return;
            }
            if (monthlyExpensesAmount.Text.Length == 0 || monthlyExpensesAmount == null)
            {
                errorLabel2.Text = "Please enter amount!";
                return;
            }
            if (!Double.TryParse(monthlyExpensesAmount.Text, out _))
            {
                errorLabel2.Text = "Amount must be a number!";
                return;
            }
            if (monthlyExpensesCategory.Text.Length == 0 || monthlyExpensesCategory == null)
            {
                errorLabel2.Text = "Please choose a category!";
                return;
            }

            var name = monthlyExpensesName.Text;
            var date = monthlyExpensesDate.Value;
            var monthlyExpenses = Convert.ToDouble(monthlyExpensesAmount.Text);
            var category = monthlyExpensesCategory.Text;

            var scheduler = new Scheduler(date, name, monthlyExpenses, category, manager, false);
            scheduler.Start();

            errorLabel2.Text = "Monthly expenses were successfully added!";
            monthlyExpensesAmount.Clear();
            monthlyExpensesCategory.Text = null;
            monthlyExpensesName.Text = null;
            monthlyExpensesDate.ResetText();
        }

        private void buttonAddMonthlyIncome_Click(object sender, EventArgs e)
        {
            if (monthlyIncomeName.Text.Length == 0 || monthlyIncomeName.Text == null)
            {
                errorLabel.Text = "Name cannot be empty!";
                return;
            }
            if (monthlyIncomeAmount.Text.Length == 0 || monthlyIncomeAmount.Text == null)
            {
                errorLabel.Text = "Please enter amount!";
                return;
            }
            if (!Double.TryParse(monthlyIncomeAmount.Text, out _))
            {
                errorLabel.Text = "Amount must be a number!";
                return;
            }
            if (monthlyIncomeCategory.Text.Length == 0 || monthlyIncomeCategory == null)
            {
                errorLabel.Text = "Please choose a category!";
                return;
            }

            var name = monthlyIncomeName.Text;
            var date = monthlyIncomeDate.Value;
            var monthlyIncome = Convert.ToDouble(monthlyIncomeAmount.Text);
            var category = monthlyIncomeCategory.Text;

            var scheduler = new Scheduler(date, name, monthlyIncome, category, manager, true);
            scheduler.Start();

            errorLabel.Text = "Monthly income was added successfully!";
            monthlyIncomeAmount.Clear();
            monthlyIncomeCategory.Text = null;
            monthlyIncomeName.Text = null;
            monthlyIncomeDate.ResetText();
        }

        private void inputExpense(object sender, EventArgs e)
        {
            if (nameP.Text.Length == 0 || nameP.Text == null)
            {
                errorField.Text = "Name cannot be empty!";
                return;
            }
            if (!Double.TryParse(priceP.Text, out _))
            {
                errorField.Text = "Price must be a number!";
                return;
            }
            if (categoryP.Text.Length == 0 || categoryP == null)
            {
                errorField.Text = "Please choose a category!";
                return;
            }

            var date = (int)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
            var name = nameP.Text;
            var price = Convert.ToDouble(priceP.Text);
            var category = categoryP.Text;

            manager.addExpense(new Expense(date, name, price, category));
            errorField.Text = nameP.Text + " was successfully added!";
            nameP.Text = null;
            priceP.Text = null;
            categoryP.Text = null;
        }

        private void inputIncome(object sender, EventArgs e)
        {
            if (incomeSum.Text.Length == 0 || incomeSum == null)
            {
                errorField2.Text = "Please enter a sum!";
                return;
            }
            if (!Double.TryParse(incomeSum.Text, out _))
            {
                errorField2.Text = "Price must be a number!";
                return;
            }
            if (incomeCat.Text.Length == 0 || incomeCat == null)
            {
                errorField2.Text = "Please choose a category!";
                return;
            }
            var date = (int)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
            var sum = Convert.ToDouble(incomeSum.Text);
            var category = incomeCat.Text;

            manager.addIncome(new Income(date, sum, category));

            errorField2.Text = "Sum was added successfully!";
            incomeSum.Clear();
            incomeCat.Text = null;
        }

        private void showExpenses(object sender, EventArgs e)
        {
            var list = manager.readExpenses();
            if (list == null)
            {
                statScreen.Text = "No data found!";
                return;
            }
            statScreen.Text = "";
            foreach (var expense in list)
            {
                var date = new DateTime(1970, 1, 1, 0, 0, 0, 0).AddSeconds(expense.Date).ToLocalTime();
                statScreen.Text += date + " | " + expense.Name + " | " + expense.Price + "€ | " + expense.Category + System.Environment.NewLine;
            }
        }

        private void showIncome(object sender, EventArgs e)
        {
            var list = manager.readIncome();
            if (list == null)
            {
                statScreen.Text = "No data found!";
                return;
            }
            statScreen.Text = "";
            foreach (var income in list)
            {
                var date = new DateTime(1970, 1, 1, 0, 0, 0, 0).AddSeconds(income.Date).ToLocalTime();
                statScreen.Text += date + " | " + income.Sum + "€ | " + income.Category + System.Environment.NewLine;
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabs.SelectedIndex)
            {
                case 3:
                    editIncome();
                    label8.Text = "";
                    break;
                case 4:
                    editExpenses();
                    label9.Text = "";
                    break;
                default:
                    break;

            }
        }

        private void showStatistics(object sender, EventArgs e) => statScreen.Text = stats.generateExpenseStatistics(manager) + stats.generateIncomeStatistics(manager);

        private void editIncome()
        {
            comboBox1.Items.Clear();
            textBox1.Text = null;
            comboBox2.Text = null;
            var list = manager.readIncome();
            if (list.Count == 0)
            {
                comboBox1.Text = "No income data found!";
                return;
            }

            comboBox1.Text = "Select item to edit";
            foreach (var income in list)
            {
                //var date = new DateTime(1970, 1, 1, 0, 0, 0, 0).AddSeconds(income.Date).ToLocalTime();
                comboBox1.Items.Add(income.Sum + "€ | " + income.Category);
            }
        }

        private void onEditIncomeChange(object sender, EventArgs e)
        {
            var list = manager.readIncome();
            var array = list.ToArray();
            var index = comboBox1.SelectedIndex;
            textBox1.Text = array[index].Sum + "";
            comboBox2.SelectedItem = array[index].Category;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var list = manager.readIncome();
            if (list.Count == 0)
            {
                label8.Text = "Income data is empty!";
                return;
            }
            var array = list.ToArray();
            var index = comboBox1.SelectedIndex;
            if (index < 0 || index > array.Length)
            {
                label8.Text = "Select an item to edit!";
                return;
            }
            list.Remove(array[index]);
            manager.updateIncome(list);
            label8.Text = "Item deleted successfully!";
            editIncome();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var list = manager.readIncome();
            if (list.Count == 0)
            {
                label8.Text = "Income data is empty!";
                return;
            }
            if (!Double.TryParse(textBox1.Text, out _))
            {
                label8.Text = "Sum must be a number!";
                return;
            }

            if (comboBox2.Text.Length == 0 || comboBox2 == null)
            {
                label8.Text = "Please choose a category!";
                return;
            }

            var array = list.ToArray();
            var index = comboBox1.SelectedIndex;
            if (index < 0 || index > array.Length)
            {
                label8.Text = "Select an item to edit!";
                return;
            }
            list.Remove(array[index]);
            array[index].Date = (int)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
            array[index].Sum = Convert.ToDouble(textBox1.Text);
            array[index].Category = comboBox2.SelectedItem.ToString();
            list.Add(array[index]);
            manager.updateIncome(list);
            label8.Text = "Item edited successfully!";
            editIncome();
        }

        private void editExpenses()
        {
            comboBox5.Items.Clear();
            textBox3.Text = null;
            textBox2.Text = null;
            comboBox3.Text = null;
            var list = manager.readExpenses();
            if (list.Count == 0)
            {
                comboBox5.Text = "No expense data found!";
                return;
            }

            comboBox5.Text = "Select item to edit";
            foreach (var expense in list)
            {
                comboBox5.Items.Add(expense.Name + " | " + expense.Price + "€ | " + expense.Category);
            }
        }

        private void onEditExpenseChange(object sender, EventArgs e)
        {
            var list = manager.readExpenses();
            var array = list.ToArray();
            var index = comboBox5.SelectedIndex;
            textBox3.Text = array[index].Name;
            textBox2.Text = array[index].Price + "";
            comboBox3.SelectedItem = array[index].Category;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var list = manager.readExpenses();
            if (list.Count == 0)
            {
                label9.Text = "Expense data is empty!";
                return;
            }
            var array = list.ToArray();
            var index = comboBox5.SelectedIndex;
            if (index < 0 || index > array.Length)
            {
                label9.Text = "Select an item to edit!";
                return;
            }
            list.Remove(array[index]);
            manager.updateExpenses(list);
            label9.Text = "Item deleted successfully!";
            editExpenses();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var list = manager.readExpenses();
            if (list.Count == 0)
            {
                label9.Text = "Expense data is empty!";
                return;
            }
            if (textBox3.Text.Length == 0 || textBox3.Text == null)
            {
                label9.Text = "Name cannot be empty!";
                return;
            }
            if (!Double.TryParse(textBox2.Text, out _))
            {
                label9.Text = "Price must be a number!";
                return;
            }
            if (comboBox3.Text.Length == 0 || comboBox3 == null)
            {
                label9.Text = "Please choose a category!";
                return;
            }

            var array = list.ToArray();
            var index = comboBox5.SelectedIndex;
            if (index < 0 || index > array.Length)
            {
                label9.Text = "Select an item to edit!";
                return;
            }
            list.Remove(array[index]);
            array[index].Date = (int)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
            array[index].Name = textBox3.Text;
            array[index].Price = Convert.ToDouble(textBox2.Text);
            array[index].Category = comboBox3.SelectedItem.ToString();
            list.Add(array[index]);
            manager.updateExpenses(list);
            label9.Text = "Item edited successfully!";
            editExpenses();
        }




        
    }
}
