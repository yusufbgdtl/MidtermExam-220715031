using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MidtermExam
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
            {
                MessageBox.Show($"You selected Grade: {comboBox1.SelectedItem}");
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            private void btnAddTask_Click(object sender, EventArgs e)
            {
                if (!string.IsNullOrEmpty(textBox1.Text))
                {
                    listBox1.Items.Add(textBox1.Text);
                    textBox1.Clear();
                }
            }

            private void btnRemoveTask_Click(object sender, EventArgs e)
            {
                if (listBox1.SelectedIndex != -1)
                {
                    listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                }
            }

            private void btnClearAll_Click(object sender, EventArgs e)
            {
                listBox1.Items.Clear();
            }

            private void btnBackToMain_Click(object sender, EventArgs e)
            {
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide();
            }
        }
    }
}
