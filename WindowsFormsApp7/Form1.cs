using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        struct Record
        {
            public int key { get; set; }
        }
        Record[] array;
        public Form1()
        {
            InitializeComponent();
        }
        int i;
        private void Random_Click(object sender, EventArgs e)
        {
            {
                Random R = new Random();
                if (i <= 2)
                {
                    this.ColvoMass_Click(sender, e);
                }
                massiv.RowCount = 1;
                massiv.ColumnCount = i;
                for (int j = 0; j < i; j++)
                {
                    massiv.Columns[j].Width = 30;
                    massiv.Rows[0].Cells[j].Value = R.Next(0, 100);
                }
                for (int j = 1; j < i; j++)
                {
                    massiv.Rows[0].Cells[j].Style.BackColor = Color.White;
                }

            }
        }
        private void ColvoMass_Click(object sender, EventArgs e)
        {
            labVvod.Visible = true;
            input.Visible = true;
            butInput.Visible = true;

        }
        private void butInput_Click(object sender, EventArgs e)
        {
            string tmp = input.Text;
            if (int.TryParse(tmp, out i) && (i >= 2))
            {
                array = new Record[i];
                labVvod.Visible = false;
                input.Visible = false;
                butInput.Visible = false;
                Random_Click(sender, e);
                sravnenie.Visible = true;
            }
            else
            {
                MessageBox.Show("Ошибка ввода");
            }
        }
        public bool Check(object sender, EventArgs e)
        {
            bool OK = true;
            int j = 0;
            while (OK && (j < i))
            {
                int tmp;
                if (!int.TryParse(massiv.Rows[0].Cells[j].Value.ToString(), out tmp))
                {
                    OK = false;
                    massiv.Rows[0].Cells[j].Style.BackColor = Color.Red;
                    MessageBox.Show("Ошибка ввода");
                }
                j++;
            }
            return OK;
        }

        private async void CountSort_Click(object sender, EventArgs e)
        {
            if (Check(sender, e))
            {
                for (int j = 0; j < array.Length; j++)
                {
                    array[j].key = int.Parse(massiv.Rows[0].Cells[j].Value.ToString());
                }
                int max = array[0].key;
                var count = new int[101];
                massiv.RowCount = 2;
                massiv.ColumnCount = 101;
                for (int i = 0; i < 101; i++)
                {
                    count[i] = 0;
                    massiv.Rows[0].Cells[i].Value = i;
                    massiv.Rows[1].Cells[i].Value = 0;
                    massiv.Columns[i].Width = 30;
                }
                for (int i = 0; i < array.Length; i++)
                {
                    count[array[i].key]++;
                    massiv.Rows[1].Cells[array[i].key].Value = count[array[i].key];
                    massiv.Rows[1].Cells[array[i].key].Style.BackColor = Color.Green;
                }                
                await Task.Delay(5000);
                massiv.RowCount = 1;
                massiv.ColumnCount = array.Length;
                int index = 0;
                for (int i = 0; i < count.Length; i++)
                {
                    for (int j = 0; j < count[i]; j++)
                    {
                        array[index].key = i;
                        massiv.Rows[0].Cells[index].Value = array[index].key;
                        index++;
                    }
                }
            }
            
        }
    }
}
