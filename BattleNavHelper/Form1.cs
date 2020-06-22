using System;
using System.Windows.Forms;

namespace BattleNavHelper
{
    public partial class Form1 : Form
    {
        public static double hit_me = 0;
        public static double shot_me = 0;
        public static double max_me = 6;
        public static double hit_them = 0;
        public static double shot_them = 0;
        public static double max_them = 6;

        public Form1()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            hit_them += 1;
            shot_them += 1;
            textBox2.Text = Convert.ToString(hit_them);
            textBox7.Text = Convert.ToString(shot_them);
            textBox5.Text = Convert.ToString(max_them);
        }


        private void button3_Click(object sender, EventArgs e)
        {
            hit_me += 1;
            shot_me += 1;
            textBox1.Text = Convert.ToString(hit_me);
            textBox3.Text = Convert.ToString(shot_me);
            textBox6.Text = Convert.ToString(max_me);
            textBox4.Text = Convert.ToString((hit_me * 100 / shot_me));
        }

        private void button8_Click(object sender, EventArgs e)
        {
            shot_me += 1;
            textBox3.Text = Convert.ToString(shot_me);
            textBox4.Text = Convert.ToString(hit_me * 100 / shot_me);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            shot_them += 1;
            textBox7.Text = Convert.ToString(shot_them);
        }

        private void ShipUs_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var ship in Ship.Values)
            {
                if (ShipUs.SelectedItem.ToString().Equals(ship.Name))
                {
                    MessageBox.Show(ship.Cannon_Size);
                }
            }
        }

        private void ShipUs_DropDownClosed(object sender, EventArgs e)
        {
            //TODO:
        }
    }
}