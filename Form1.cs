using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace TodoList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            loadTasks();
        }

        public void ReloadTasks()
        {
            dataGridView1.Rows.Clear();
            loadTasks();
        }

        private void Button1_Click(object sender, EventArgs e) {

            using (Form2 popup = new Form2(this))
            {
                popup.ShowDialog();
            }
        }

        private void CancelOrCompletedTask (bool isCancel)
        {
            DataGridViewSelectedRowCollection rows = dataGridView1.SelectedRows;

            if (rows.Count == 0)
            {
                MessageBox.Show("Brak wybranych zadań");
                return;
            }

            foreach (DataGridViewRow row in rows)
            {
                if (int.TryParse(row.Cells["taskId"].Value?.ToString(), out int taskId))
                {
                    Task task = Task.GetTaskFromId(taskId);
                    if (isCancel)
                    {

                        if (task.IsCompleted())
                        {
                            MessageBox.Show($"Zadanie {task.GetName()} zostało już wcześniej oznaczone jako wykonane");
                            return;
                        }
                        task.SetCompleted();
                    }
                    else
                    {
                        if (task.IsCancelled())
                        {
                            MessageBox.Show($"Zadnaie {task.GetName()} zostało już wcześniej anulowane");
                            return;
                        }
                        task.SetCancelled();
                    }
                }
                else
                {
                    MessageBox.Show("Błąd poczas wybierania zadania");
                }
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            CancelOrCompletedTask(true);
            ReloadTasks();
            Task.SaveTasks("tasks.json");
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            CancelOrCompletedTask(false);
            ReloadTasks();
            Task.SaveTasks("tasks.json");
        }
    }
}
