using System;
using System.Diagnostics;

namespace BattleNavHelper
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.WeHitThemAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TheyHitUsAmount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.PercentageHit = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ShipThem = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.hit_me_button = new System.Windows.Forms.Button();
            this.ShipUs = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TheirMaxGoal = new System.Windows.Forms.TextBox();
            this.OurMaxGoal = new System.Windows.Forms.TextBox();
            this.WeShotTotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TheyShotTotal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.debuggeroutput = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // WeHitThemAmount
            // 
            this.WeHitThemAmount.Location = new System.Drawing.Point(83, 205);
            this.WeHitThemAmount.Name = "WeHitThemAmount";
            this.WeHitThemAmount.Size = new System.Drawing.Size(27, 20);
            this.WeHitThemAmount.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Enemy Hit";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Hits on us";
            // 
            // TheyHitUsAmount
            // 
            this.TheyHitUsAmount.Location = new System.Drawing.Point(83, 231);
            this.TheyHitUsAmount.Name = "TheyHitUsAmount";
            this.TheyHitUsAmount.Size = new System.Drawing.Size(27, 20);
            this.TheyHitUsAmount.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(12, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "Percentage";
            // 
            // PercentageHit
            // 
            this.PercentageHit.Location = new System.Drawing.Point(83, 257);
            this.PercentageHit.Name = "PercentageHit";
            this.PercentageHit.Size = new System.Drawing.Size(52, 20);
            this.PercentageHit.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(138, 333);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ResetButton);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 333);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Chat";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Chat);
            // 
            // ShipThem
            // 
            this.ShipThem.FormattingEnabled = true;
            this.ShipThem.Items.AddRange(new object[] {"Sloop", "Cutter", "Dhow", "Fanchuan", "Longship", "Baghlah", "Junk", "Merchant brig", "War brig", "Merchant galleon", "War galleon", "Xebec", "War frigate", "Grand frigate"});
            this.ShipThem.Location = new System.Drawing.Point(101, 42);
            this.ShipThem.Name = "ShipThem";
            this.ShipThem.Size = new System.Drawing.Size(100, 21);
            this.ShipThem.TabIndex = 2;
            this.ShipThem.SelectedIndexChanged += new System.EventHandler(this.ShipThem_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(107, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enemy:\r\n";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Me:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button9);
            this.groupBox1.Controls.Add(this.button8);
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.hit_me_button);
            this.groupBox1.Controls.Add(this.ShipUs);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ShipThem);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(201, 186);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(101, 98);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(100, 23);
            this.button9.TabIndex = 11;
            this.button9.Text = "Missed";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.TheyMissedUs);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(0, 98);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(98, 23);
            this.button8.TabIndex = 10;
            this.button8.Text = "Missed";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.WeMissedThem);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(101, 127);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(100, 23);
            this.button7.TabIndex = 9;
            this.button7.Text = "Rock";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(101, 69);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 23);
            this.button6.TabIndex = 8;
            this.button6.Text = "Hit";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.TheyHitUs);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(0, 127);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(98, 23);
            this.button5.TabIndex = 7;
            this.button5.Text = "Rock";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(0, 156);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(201, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "Ram";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // hit_me_button
            // 
            this.hit_me_button.Location = new System.Drawing.Point(0, 69);
            this.hit_me_button.Name = "hit_me_button";
            this.hit_me_button.Size = new System.Drawing.Size(98, 23);
            this.hit_me_button.TabIndex = 5;
            this.hit_me_button.Text = "Hit";
            this.hit_me_button.UseVisualStyleBackColor = true;
            this.hit_me_button.Click += new System.EventHandler(this.WeHitThem);
            // 
            // ShipUs
            // 
            this.ShipUs.DropDownWidth = 100;
            this.ShipUs.FormattingEnabled = true;
            this.ShipUs.Items.AddRange(new object[] {"Sloop", "Cutter", "Dhow", "Fanchuan", "Longship", "Baghlah", "Junk", "Merchant brig", "War brig", "Merchant galleon", "War galleon", "Xebec", "War frigate", "Grand frigate"});
            this.ShipUs.Location = new System.Drawing.Point(0, 42);
            this.ShipUs.Name = "ShipUs";
            this.ShipUs.Size = new System.Drawing.Size(98, 21);
            this.ShipUs.TabIndex = 4;
            this.ShipUs.SelectedIndexChanged += new System.EventHandler(this.ShipUs_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(116, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 23);
            this.label7.TabIndex = 15;
            this.label7.Text = "/";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(116, 234);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "/";
            // 
            // TheirMaxGoal
            // 
            this.TheirMaxGoal.Location = new System.Drawing.Point(130, 231);
            this.TheirMaxGoal.Name = "TheirMaxGoal";
            this.TheirMaxGoal.Size = new System.Drawing.Size(27, 20);
            this.TheirMaxGoal.TabIndex = 18;
            // 
            // OurMaxGoal
            // 
            this.OurMaxGoal.Location = new System.Drawing.Point(130, 205);
            this.OurMaxGoal.Name = "OurMaxGoal";
            this.OurMaxGoal.Size = new System.Drawing.Size(27, 20);
            this.OurMaxGoal.TabIndex = 17;
            // 
            // WeShotTotal
            // 
            this.WeShotTotal.Location = new System.Drawing.Point(179, 205);
            this.WeShotTotal.Name = "WeShotTotal";
            this.WeShotTotal.Size = new System.Drawing.Size(27, 20);
            this.WeShotTotal.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(163, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 23);
            this.label5.TabIndex = 19;
            this.label5.Text = "/";
            // 
            // TheyShotTotal
            // 
            this.TheyShotTotal.Location = new System.Drawing.Point(179, 231);
            this.TheyShotTotal.Name = "TheyShotTotal";
            this.TheyShotTotal.Size = new System.Drawing.Size(27, 20);
            this.TheyShotTotal.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(163, 234);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 23);
            this.label9.TabIndex = 21;
            this.label9.Text = "/";
            // 
            // debuggeroutput
            // 
            this.debuggeroutput.Location = new System.Drawing.Point(12, 286);
            this.debuggeroutput.Name = "debuggeroutput";
            this.debuggeroutput.Size = new System.Drawing.Size(194, 20);
            this.debuggeroutput.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 368);
            this.Controls.Add(this.debuggeroutput);
            this.Controls.Add(this.TheyShotTotal);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.WeShotTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TheirMaxGoal);
            this.Controls.Add(this.OurMaxGoal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PercentageHit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TheyHitUsAmount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.WeHitThemAmount);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.TextBox debuggeroutput;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button hit_me_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox OurMaxGoal;
        private System.Windows.Forms.TextBox PercentageHit;
        private System.Windows.Forms.ComboBox ShipThem;
        private System.Windows.Forms.ComboBox ShipUs;
        private System.Windows.Forms.TextBox TheirMaxGoal;
        private System.Windows.Forms.TextBox TheyHitUsAmount;
        private System.Windows.Forms.TextBox TheyShotTotal;
        private System.Windows.Forms.TextBox WeHitThemAmount;
        private System.Windows.Forms.TextBox WeShotTotal;

        #endregion
    }
}