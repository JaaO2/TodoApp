using System;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using System.Collections.Generic;

namespace TodoList
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;


        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Button button1;
            System.Windows.Forms.Button button2;
            System.Windows.Forms.Button button3;
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.taskId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Taskname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deadline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            button1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            button1.Location = new System.Drawing.Point(12, 426);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(282, 23);
            button1.TabIndex = 0;
            button1.Text = "Dodaj nowe zadanie";
            button1.UseVisualStyleBackColor = true;
            button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            button2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            button2.Location = new System.Drawing.Point(354, 426);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(282, 23);
            button2.TabIndex = 5;
            button2.Text = "Oznacz jako wykonane";
            button2.UseVisualStyleBackColor = true;
            button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            button3.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            button3.Location = new System.Drawing.Point(690, 426);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(282, 23);
            button3.TabIndex = 6;
            button3.Text = "Anuluj zadanie";
            button3.UseVisualStyleBackColor = true;
            button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(308, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "Zadania do wykonania";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.taskId,
            this.Taskname,
            this.Deadline,
            this.priority});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(12, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowCellErrors = false;
            this.dataGridView1.ShowCellToolTips = false;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.ShowRowErrors = false;
            this.dataGridView1.Size = new System.Drawing.Size(960, 341);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.TabStop = false;
            // 
            // taskId
            // 
            this.taskId.DataPropertyName = "taskId";
            this.taskId.FillWeight = 50F;
            this.taskId.HeaderText = "id";
            this.taskId.Name = "taskId";
            this.taskId.ReadOnly = true;
            this.taskId.Visible = false;
            // 
            // Taskname
            // 
            this.Taskname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Taskname.HeaderText = "Zadanie";
            this.Taskname.MinimumWidth = 600;
            this.Taskname.Name = "Taskname";
            this.Taskname.ReadOnly = true;
            this.Taskname.Width = 600;
            // 
            // Deadline
            // 
            this.Deadline.HeaderText = "Data wykonania";
            this.Deadline.MinimumWidth = 150;
            this.Deadline.Name = "Deadline";
            this.Deadline.ReadOnly = true;
            // 
            // priority
            // 
            this.priority.HeaderText = "Priorytet";
            this.priority.Name = "priority";
            this.priority.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(button3);
            this.Controls.Add(button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TODO List";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        Dictionary<string, int> priorityMap = new Dictionary<string, int> {
            { "Zwykły", 1 }, 
            { "Niski", 2 }, 
            { "Średni", 3 }, 
            { "Ważny", 4 }, 
            { "Bardzo Ważny", 5 } 
        };

        private void setRowColors(Task item, DataGridViewRow row)
        {
            switch (item.GetPriority())
            {
                case "Zwykły":
                    row.DefaultCellStyle.BackColor = System.Drawing.Color.LightYellow;
                    break;
                case "Niski":
                    row.DefaultCellStyle.BackColor = System.Drawing.Color.LightGreen;
                    row.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
                    break;
                case "Średni":
                    row.DefaultCellStyle.BackColor = System.Drawing.Color.Orange;
                    row.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
                    break;
                case "Ważny":
                    row.DefaultCellStyle.BackColor = System.Drawing.Color.OrangeRed;
                    row.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
                    break;
                case "Bardzo Ważny":
                    row.DefaultCellStyle.BackColor = System.Drawing.Color.Red;
                    row.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
                    break;
            }
        }

        private void setRowSpecialFormats(Task item, DataGridViewRow row)
        {
            if (item.GetDeadline() < DateTime.Now && !item.IsCompleted() && !item.IsCancelled())
            {
                row.DefaultCellStyle.Font = new Font(dataGridView1.DefaultCellStyle.Font, FontStyle.Bold);
            }

            if (item.IsCompleted())
            {
                row.DefaultCellStyle.BackColor = System.Drawing.Color.Gray;
                row.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            }

            if (item.IsCancelled())
            {
                row.DefaultCellStyle.BackColor = System.Drawing.Color.Gray;
                row.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
                row.DefaultCellStyle.Font = new Font(dataGridView1.DefaultCellStyle.Font, FontStyle.Strikeout);
            }
        }

        private void loadTasks ()
        {
            List<Task> tasks = Task.GetTasks()
                                .OrderBy(task => task.IsCancelled())
                                .ThenBy(task => task.IsCompleted())
                                .ThenByDescending(task => task.GetDeadline() < DateTime.Now)
                                .ThenByDescending(task => priorityMap[task.GetPriority()])
                                .ToList();

            foreach (Task item in tasks)
            {
                int rowIndex = dataGridView1.Rows.Add(item.GetID(), item.GetName(), item.GetDeadline(), item.GetPriority());
                DataGridViewRow row = dataGridView1.Rows[rowIndex];
                setRowColors(item, row);
                setRowSpecialFormats(item, row);
            }
        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn taskId;
        private DataGridViewTextBoxColumn Taskname;
        private DataGridViewTextBoxColumn Deadline;
        private DataGridViewTextBoxColumn priority;
    }
}

