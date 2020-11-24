using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics;

namespace Plutus
{
    public partial class TrueGUI : Form
    {
        
        Label historyPageName;
        Button historyEditButton;
        Button historyFilterButton;
        ComboBox historyPaymentTypeBox;
        DataGridView historyDataGrid;

        private void InitializeHistoryPage()
        {
            historyPageName = CreatePageNameLabel("historyPageNameLabel", "HISTORY");
            historyEditButton = CreateClassicButton("historyEditButton", Properties.Resources.EditButton, 45, 160, 3, false, 30, 30);
            historyEditButton.Click += new EventHandler(EditButtonClick);

            historyPaymentTypeBox = new ComboBox
            {
                Name = "historyPaymentTypeBox",
                BackColor = _backgroundColor,
                ForeColor = _firstColor,
                Font = new Font(_lilitaOne, 11F, FontStyle.Regular, GraphicsUnit.Point),
                Width = 120,
                Height = 20,
                Top = 160,
                Left = 132,
                DropDownStyle = ComboBoxStyle.DropDownList,
                FlatStyle = FlatStyle.Flat,
            };

            historyPaymentTypeBox.Items.AddRange(new string[] { "All", "Expense", "Income" });
            historyPaymentTypeBox.SelectedIndexChanged += new EventHandler(UpdateHistory);

            historyDataGrid = new DataGridView
            {
                BackgroundColor = _backgroundColor,
                ForeColor = _firstColor,
                GridColor = _firstColor,

                Width = ClientSize.Width,
                Top = 220,
                Height = ClientSize.Height - 223,
                ColumnHeadersHeight = 45,

                ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None,

                BorderStyle = BorderStyle.None,
                ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single,

                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                MultiSelect = false,
                EnableHeadersVisualStyles = false,
                RowHeadersVisible = false,
                ReadOnly = true,
                AllowUserToResizeColumns = false,
                AllowUserToResizeRows = false
            };

            historyDataGrid.DefaultCellStyle.BackColor = _backgroundColor;
            historyDataGrid.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            historyDataGrid.DefaultCellStyle.SelectionBackColor = _secondColor;

            historyDataGrid.ColumnHeadersDefaultCellStyle.Font = new Font(_lilitaOne, 17, FontStyle.Regular, GraphicsUnit.Pixel);
            historyDataGrid.ColumnHeadersDefaultCellStyle.SelectionBackColor = _firstColor;
            historyDataGrid.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;
            historyDataGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            historyDataGrid.ColumnHeadersDefaultCellStyle.BackColor = _firstColor;
            historyDataGrid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            historyDataGrid.AdvancedCellBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None;
            historyDataGrid.AdvancedCellBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.None;

            historyDataGrid.RowTemplate.Height = 30;

            historyFilterButton = CreateClassicButton("historyFilterButton", Properties.Resources.FilterButton, historyEditButton.Right + 230, 160, 4, false, 30, 30);
        }

        private void LoadHistoryPage()
        {
            LoadMenuButton();
            LoadEscapeButton();
            Controls.Add(historyPageName);
            Controls.Add(historyEditButton);
            Controls.Add(historyFilterButton);
            Controls.Add(historyPaymentTypeBox);
            Controls.Add(historyDataGrid);
            ResumeLayout(false);
            PerformLayout();

            historyPaymentTypeBox.SelectedIndex = 0;
            var dataSource = _historyService.LoadDataGrid(_fileManager, historyPaymentTypeBox.SelectedIndex);
            if (dataSource == null)
            {
                MessageBox.Show("Unable to load new data!", "Error loading history data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            historyDataGrid.DataSource = dataSource;
        }

        private void UpdateHistory(object sender, EventArgs e)
        {
            var dataSource = _historyService.LoadDataGrid(_fileManager, historyPaymentTypeBox.SelectedIndex);
            if (dataSource == null)
            {
                MessageBox.Show("Unable to load new data!", "Error loading history data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            historyDataGrid.DataSource = dataSource;
        }

        private void EditButtonClick(object sender, EventArgs e)
        {
            //Controls.Clear();
            //LoadMenuButton();
            //LoadEscapeButton();
            //Controls.Add(CreatePageNameLabel("historyEditPageName", "Edit"));
            //ResumeLayout(false);
            //PerformLayout();

            var rowIndex = historyDataGrid.CurrentCell.RowIndex;
            var payment = new Payment
            {
                Date = DateTime.Parse(historyDataGrid.Rows[rowIndex].Cells[0].Value.ToString()).ConvertToInt(),
                Name = historyDataGrid.Rows[rowIndex].Cells[1].Value.ToString(),
                Amount = double.Parse(historyDataGrid.Rows[rowIndex].Cells[2].Value.ToString()),
                Category = historyDataGrid.Rows[rowIndex].Cells[3].Value.ToString()
            };

            var newPayment = new Payment
            {
                Date = DateTime.UtcNow.ConvertToInt(),
                Name = historyDataGrid.Rows[rowIndex].Cells[1].Value.ToString(),
                Amount = double.Parse(historyDataGrid.Rows[rowIndex].Cells[2].Value.ToString()),
                Category = historyDataGrid.Rows[rowIndex].Cells[3].Value.ToString()
            };

            switch (historyPaymentTypeBox.SelectedIndex)
            {
                case 0:
                    _fileManager.EditPayment(payment, newPayment, historyDataGrid.Rows[rowIndex].Cells[4].Value.ToString());
                    return;
                case 1:
                    _fileManager.EditPayment(payment, newPayment, "Expense");
                    return;
                case 2:
                    _fileManager.EditPayment(payment, newPayment, "Income");
                    return;
                default:
                    return;
            }
        }
    }
}
