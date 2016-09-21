using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasterMind
{
    public partial class Form1 : Form
    {
        private string solution1;
        public Form1()
        {
            InitializeComponent();

            Random random = new Random();
            solution1 = random.Next(1, 6).ToString();
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            if (guessBox1.Text == solution1)
            {
                guessBox1.BackColor = Color.LightGreen;
            }
            else
            {
                guessBox1.BackColor = Color.LightGray;
            }
        }
    }
}
