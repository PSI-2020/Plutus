using System;
using System.Windows.Forms;

namespace Plutus
{
    public partial class GUI : Form
    {
        private void ButtonAddGoal_Click(object sender, EventArgs e)
        {
            panelInsights.Visible = false;
            panelEditGoal.Visible = false;
            panelGoal.Visible = false;
            panelMyGoals.Visible = false;
            panelAddGoal.Visible = true;
        }

        private void ButtonMyGoals_Click(object sender, EventArgs e)
        {
            panelInsights.Visible = false;
            panelEditGoal.Visible = false;
            panelGoal.Visible = false;
            panelAddGoal.Visible = false;
            panelMyGoals.Visible = true;

            textBoxMyGoals.Text = goalManager.ShowGoals();
        }

        private void ButtonAddGoalEnter_Click(object sender, EventArgs e)
        {
            if (textBoxAddGoalName.Text.Length == 0 || textBoxAddGoalName.Text == null)
            {
                addGoalErrorLabel.Text = "Please enter name";
                return;
            }
            if (textBoxAddGoalAmount.Text.Length == 0 || textBoxAddGoalAmount.Text == null)
            {
                addGoalErrorLabel.Text = "Please enter amount";
                return;
            }
            if (!Double.TryParse(textBoxAddGoalAmount.Text, out _))
            {
                addGoalErrorLabel.Text = "Not a number!";
                return;
            }

            var name = textBoxAddGoalName.Text;
            var date = dateTimePickerAddGoal.Value;
            var amount = double.Parse(textBoxAddGoalAmount.Text);


            goalManager.AddGoal(new Goal(name, amount, date));

            panelAddGoal.Visible = false;
            panelGoal.Visible = true;
            labelGoal.Text = "Goal '" + name + "' was created!";
            if (comboBoxInsights.Items.Count > 0)
            {
                comboBoxInsights.Items.Add(name);
            }
            if (comboBoxEditGoal.Items.Count > 0)
            {
                comboBoxEditGoal.Items.Add(name);
            }
            textBoxAddGoalAmount.Text = null;
            textBoxAddGoalName.Text = null;
            dateTimePickerAddGoal.ResetText();

        }

        private void ButtonAddGoalCancel_Click(object sender, EventArgs e)
        {
            textBoxAddGoalAmount.Text = null;
            textBoxAddGoalName.Text = null;
            dateTimePickerAddGoal.ResetText();
        }

        private void EditGoalButton_Click(object sender, EventArgs e)
        {
            panelGoal.Visible = false;
            panelMyGoals.Visible = false;
            panelAddGoal.Visible = false;
            panelEditGoal.Visible = true;
            panelComment.Visible = false;
            comboBoxEditGoal.Text = null;
            panelChangeGoal.Visible = false;


            var goalList = goalManager.ReadGoals();

            if (comboBoxEditGoal.Items.Count == 0)
            {
                foreach (var goal in goalList)
                {
                    comboBoxEditGoal.Items.Add(goal.Name);
                }
            }
        }


        private void ComboBoxEditGoal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxEditGoal.SelectedIndex < 0) return;

            var list = goalManager.ReadGoals();
            var goals = list.ToArray();
            var index = comboBoxEditGoal.SelectedIndex;
            panelComment.Visible = false;
            panelChangeGoal.Visible = true;
            textBoxChangeGoalName.Text = goals[index].Name;
            textBoxChangeGoalAmount.Text = goals[index].Amount.ToString();
            dateTimePickerChangeGoal.Value = goals[index].DueDate;

        }

        private void ButtonChangeGoal_Click(object sender, EventArgs e)
        {
            goalManager.EditGoal(comboBoxEditGoal.SelectedIndex, textBoxChangeGoalName.Text, textBoxChangeGoalAmount.Text, dateTimePickerChangeGoal.Value);
            panelChangeGoal.Visible = false;
            panelComment.Visible = true;

        }
        private void ButtonDeleteGoal_Click(object sender, EventArgs e)
        {
            var index = comboBoxEditGoal.SelectedIndex;
            goalManager.DeleteGoal(index);
            comboBoxEditGoal.Items.RemoveAt(index);
            if (comboBoxInsights.Items.Count > 0)
            {
                comboBoxInsights.Items.RemoveAt(index);
            }
            panelChangeGoal.Visible = false;
            panelEditGoal.Visible = false;
            panelGoal.Visible = true;
            labelGoal.Text = "Goal was deleted.";

        }
        public void ButtonInsights_Click(object sender, EventArgs e)
        {
            panelGoal.Visible = false;
            panelMyGoals.Visible = false;
            panelAddGoal.Visible = false;
            panelEditGoal.Visible = false;
            panelInsights.Visible = true;
            monthlySpend.Text = " ";
            dailySpend.Text = " ";
            daysLeft.Text = " ";
            comboBoxInsights.Text = null;

            var goalList = goalManager.ReadGoals();

            if (comboBoxInsights.Items.Count <= 0)
            {
                foreach (var goal in goalList)
                {
                    comboBoxInsights.Items.Add(goal.Name);
                }
            }

        }

        private void ComboBoxInsights_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxInsights.SelectedIndex < 0) return;

            var list = goalManager.ReadGoals();
            var goals = list.ToArray();
            var index = comboBoxInsights.SelectedIndex;

            monthlySpend.Text = goalManager.Insights(manager, goals[index], true);
            dailySpend.Text = goalManager.Insights(manager, goals[index], false);
            daysLeft.Text = goalManager.DaysLeft(goals[index]);

        }
    }
}
