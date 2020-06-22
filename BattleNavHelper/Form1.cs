using System;
using System.Windows.Forms;

namespace BattleNavHelper
{
    public partial class Form1 : Form
    {
        public static double hit_me = 0;
        public static double shot_me = 0;
        public static double our_max_goal = 6;
        public static double hit_them = 0;
        public static double shot_them = 0;
        public static double their_max_goal = 6;

        public Form1()
        {
            InitializeComponent();
        }

        private void TheyHitUs(object sender, EventArgs e)
        {
            hit_them += 1;
            shot_them += 1;
            TheyHitUsAmount.Text = Convert.ToString(hit_them);
            TheyShotTotal.Text = Convert.ToString(shot_them);
            TheirMaxGoal.Text = Convert.ToString(their_max_goal);
        }


        private void WeHitThem(object sender, EventArgs e)
        {
            hit_me += 1;
            shot_me += 1;
            WeHitThemAmount.Text = Convert.ToString(hit_me);
            WeShotTotal.Text = Convert.ToString(shot_me);
            OurMaxGoal.Text = Convert.ToString(our_max_goal);
            PercentageHit.Text = Convert.ToString((hit_me * 100 / shot_me));
        }

        private void WeMissedThem(object sender, EventArgs e)
        {
            shot_me += 1;
            WeHitThemAmount.Text = Convert.ToString(hit_me);
            WeShotTotal.Text = Convert.ToString(shot_me);
            OurMaxGoal.Text = Convert.ToString(our_max_goal);
            PercentageHit.Text = Convert.ToString(Math.Round((hit_me * 100 / shot_me),2));
        }

        private void TheyMissedUs(object sender, EventArgs e)
        {
            shot_them += 1;
            TheyHitUsAmount.Text = Convert.ToString(hit_them);
            TheyShotTotal.Text = Convert.ToString(shot_them);
            TheirMaxGoal.Text = Convert.ToString(their_max_goal);
        }

        private void ShipThem_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var ship in Ship.Values)
            {
                if (ShipThem.SelectedItem.ToString().Equals(ship.Name))
                {
                    var our_cannon_size = ship.Cannon_Size;
                    if (our_cannon_size == "Small")
                    {
                        their_max_goal = ship.Max_Small;
                    }
                    else if (our_cannon_size == "Medium")
                    {
                        their_max_goal = ship.Max_Medium;
                    }
                    else if (our_cannon_size == "Large")
                    {
                        their_max_goal = ship.Max_Large;
                    }
                }
            }
        }


        private void ShipUs_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var ship in Ship.Values)
            {
                if (ShipUs.SelectedItem.ToString().Equals(ship.Name))
                {
                    var their_cannon_size = ship.Cannon_Size;
                    if (their_cannon_size == "Small")
                    {
                        our_max_goal = ship.Max_Small;
                    }
                    else if (their_cannon_size == "Medium")
                    {
                        our_max_goal = ship.Max_Medium;
                    }
                    else if (their_cannon_size == "Large")
                    {
                        our_max_goal = ship.Max_Large;
                    }
                    else
                    {
                        MessageBox.Show("Failure");
                    }
                }
            }
        }

        private void ResetButton(object sender, EventArgs e)
        {
            hit_me = 0;
            shot_me = 0;
            hit_them = 0;
            shot_them = 0;
            WeHitThemAmount.Text = "";
            WeShotTotal.Text = "";
            OurMaxGoal.Text = "";
            PercentageHit.Text = "";
            TheyHitUsAmount.Text = "";
            TheyShotTotal.Text = "";
            TheirMaxGoal.Text = "";
        }

        private void Chat(object sender, EventArgs e)
        {
            string msg = String.Format("I hit them {0} times ({1}% dmg) and shot {2} times ({3}% accuracy) and they hit us {4} times ({5}% dmg) and shot {6} times ({7}% accuracy)",
            Convert.ToString(hit_me), Convert.ToString(Math.Round(100*hit_me/our_max_goal,2)), Convert.ToString(shot_me),Convert.ToString(100*hit_me/shot_me),Convert.ToString(hit_them),Convert.ToString(Math.Round(100*hit_them/their_max_goal,2)),Convert.ToString(shot_them),Convert.ToString(Math.Round(100*hit_them/shot_them,2)));
            Clipboard.SetText(msg);
        }
    }
}