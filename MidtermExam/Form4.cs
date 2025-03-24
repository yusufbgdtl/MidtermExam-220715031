using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MidtermExam
{
    public partial class vScrollBarGreen : Form
    {
        public vScrollBarGreen()
        {
            InitializeComponent();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void vScrollBarGreen_Load(object sender, EventArgs e)
        {
            private void UpdateBackgroundColor()
            {
                int red = trackBarRed.Value;
                int green = vScrollBarGreen.Value;
                int blue = hScrollBarBlue.Value;
                this.BackColor = Color.FromArgb(red, green, blue);
                lblCurrentColor.Text = $"Current Color: RGB({red}, {green}, {blue})";
            }

            private void trackBarRed_Scroll(object sender, EventArgs e)
            {
                UpdateBackgroundColor();
            }

            private void hScrollBarBlue_Scroll(object sender, EventArgs e)
            {
                UpdateBackgroundColor();
            }

            private void vScrollBarGreen_Scroll(object sender, EventArgs e)
            {
                UpdateBackgroundColor();
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
