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
            ShipUs.SelectedIndex = 0;
            ShipThem.SelectedIndex = 0;
        }

        private void setFields()
        {
            var shipUs = ShipComparator(ShipUs);
            var shipThem = ShipComparator(ShipThem);

            var ourCannonSize = shipUs.Cannon_Size; // Our cannon size = Sloop --> Small
            our_max_goal = ourCannonSize switch
            {
                // If ours = size, then our goal is size.Max_Size();
                "Small" => shipThem.Max_Small,
                "Medium" => shipThem.Max_Medium,
                "Large" => shipThem.Max_Large,
                _ => our_max_goal
            };

            var theirCannonSize = shipThem.Cannon_Size;
            their_max_goal = theirCannonSize switch
            {
                "Small" => shipUs.Max_Small,
                "Medium" => shipUs.Max_Medium,
                "Large" => shipUs.Max_Large,
                _ => their_max_goal
            };

            TheyHitUsAmount.Text = Convert.ToString(hit_them);
            TheyShotTotal.Text = Convert.ToString(shot_them);
            TheirMaxGoal.Text = Convert.ToString(their_max_goal);
            WeHitThemAmount.Text = Convert.ToString(hit_me);
            WeShotTotal.Text = Convert.ToString(shot_me);
            OurMaxGoal.Text = Convert.ToString(our_max_goal);
            PercentageHit.Text = Convert.ToString(Math.Round(hit_me * 100 / shot_me, 2));
        }

        private static Ship ShipComparator(ComboBox shipComboBox)
        {
            Ship ship = null;
            foreach (var shipFromEnum in Ship.Values)
            {
                if (shipComboBox.SelectedItem.ToString().Equals(shipFromEnum.Name))
                {
                    ship = shipFromEnum;
                }
            }

            return ship;
        }

        
        private void resetGame()
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

        private void TheyHitUs(object sender, EventArgs e)
        {
            hit_them += 1;
            shot_them += 1;
            setFields();
        }


        private void WeHitThem(object sender, EventArgs e)
        {
            hit_me += 1;
            shot_me += 1;
            setFields();
        }

        private void WeMissedThem(object sender, EventArgs e)
        {
            shot_me += 1;
            setFields();
        }

        private void TheyMissedUs(object sender, EventArgs e)
        {
            shot_them += 1;
            setFields();
        }

        private void ShipUs_SelectedIndexChanged(object sender, EventArgs e)
        {
            resetGame();
        }


        private void ShipThem_SelectedIndexChanged(object sender, EventArgs e)
        {
            resetGame();
        }

        private void ResetButton(object sender, EventArgs e)
        {
            resetGame();
        }

        private void Chat(object sender, EventArgs e)
        {
            string msg = String.Format(
                "I hit them {0} times ({1}% dmg) and shot {2} times ({3}% accuracy) and they hit us {4} times ({5}% dmg) and shot {6} times ({7}% accuracy)",
                Convert.ToString(hit_me), Convert.ToString(Math.Round(100 * hit_me / our_max_goal, 0)),
                Convert.ToString(shot_me), Convert.ToString(Math.Round(100 * hit_me / shot_me, 0)),
                Convert.ToString(hit_them), Convert.ToString(Math.Round(100 * hit_them / their_max_goal, 0)),
                Convert.ToString(shot_them), Convert.ToString(Math.Round(100 * hit_them / shot_them, 0)));
            Clipboard.SetText(msg);
        }
    }
}