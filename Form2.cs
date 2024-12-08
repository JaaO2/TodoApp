using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TodoList
{
    public partial class Form2 : Form
    {
        private readonly Form1 mainForm;
        public Form2(Form1 mainFormObj)
        {
            InitializeComponent();
            loadPriorities();
            mainForm = mainFormObj;
        }

        public void Button1_Click(object sender, EventArgs e)
        {
            DateTime deadline = this.dateTimePicker1.Value;
            string name = this.textBox1.Text;
            string priority = this.comboBox1.Text;

            if (name.Length < 5)
            {
                MessageBox.Show("Nazwa musi zawierać przynajmniej 5 znaków");
                return;
            }

            if (deadline < DateTime.Now)
            {
                MessageBox.Show("Data wykonania nie może być mniejszan niż aktualny czas");
                return;
            }

            if (String.IsNullOrEmpty(priority))
            {
                MessageBox.Show("Należy wybrać priorytet");
                return;
            }

            new Task(name, deadline, priority);
            mainForm.ReloadTasks();
            Task.SaveTasks("tasks.json"); 
        }

    }
}
