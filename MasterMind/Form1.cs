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
        private string solution2;
        private string solution3;
        private string solution4;
        private List<int> random_list;
        private List<int> checkBoxCondition_list;

        public Form1()
        {
            InitializeComponent();

            Random random = new Random();
            int solution1 = random.Next(1, 6);
            int solution2 = random.Next(1, 6);
            int solution3 = random.Next(1, 6);
            int solution4 = random.Next(1, 6);

            random_list = new List<int>();
            random_list.Add(solution1);
            random_list.Add(solution2);
            random_list.Add(solution3);
            random_list.Add(solution4);
        }
   
        private void checkButton_Click(object sender, EventArgs e)
        {
            checkBoxCondition_list = new List<int>();
            if (guessBox1.Text == random_list[0].ToString())
            {
                guessBox1.BackColor = Color.LightGreen;
                checkBoxCondition_list.Add(2);
            }
            else if (random_list.Contains(int.Parse(guessBox1.Text)))
            {
                guessBox1.BackColor = Color.Yellow;
                checkBoxCondition_list.Add(1);
            }
            else
            {
                guessBox1.BackColor = Color.LightGray;
                checkBoxCondition_list.Add(0);
            }
            ///////////////////////////////////////////////////////////
            if (guessBox2.Text == random_list[1].ToString())
            {
                guessBox2.BackColor = Color.LightGreen;
                checkBoxCondition_list.Add(2);
            }
            else if (random_list.Contains(int.Parse(guessBox2.Text)))
            {
                guessBox2.BackColor = Color.Yellow;
                checkBoxCondition_list.Add(1);
            }
            else
            {
                guessBox2.BackColor = Color.LightGray;
                checkBoxCondition_list.Add(0);
            }
            ///////////////////////////////////////////////////////////
            if (guessBox3.Text == random_list[2].ToString())
            {
                guessBox3.BackColor = Color.LightGreen;
                checkBoxCondition_list.Add(2);
            }
            else if (random_list.Contains(int.Parse(guessBox3.Text)))
            {
                guessBox3.BackColor = Color.Yellow;
                checkBoxCondition_list.Add(1);
            }
            else
            {
                guessBox3.BackColor = Color.LightGray;
                checkBoxCondition_list.Add(0);
            }
            ///////////////////////////////////////////////////////////
            if (guessBox4.Text == random_list[3].ToString())
            {
                guessBox4.BackColor = Color.LightGreen;
                checkBoxCondition_list.Add(2);
            }
            else if (random_list.Contains(int.Parse(guessBox4.Text)))
            {
                guessBox4.BackColor = Color.Yellow;
                checkBoxCondition_list.Add(1);
            }
            else
            {
                guessBox4.BackColor = Color.LightGray;
                checkBoxCondition_list.Add(0);
            }
            ///////////////////////////////////////////////////////////
            if (!checkBoxCondition_list.Contains(0) || !checkBoxCondition_list.Contains(1))
            {
                MessageBox.Show(checkBoxCondition_list.ToString());
                //MessageBox.Show("Je hebt de juiste code gevonden");
            }
        }
    }
}
