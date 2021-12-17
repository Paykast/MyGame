using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyGame
{
    public partial class PLAY : Form
    {
        public PLAY()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            NICKNAME main = new NICKNAME();
            main.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            BATTLE battle = new BATTLE();
            battle.label3.Text = "40";
            battle.label4.Text = "30";
            battle.label6.Text = label2.Text;
            battle.label7.Text = label3.Text;
            battle.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            BATTLE battle = new BATTLE();
            battle.label3.Text = "35";
            battle.label4.Text = "25";
            battle.label6.Text = label2.Text;
            battle.label7.Text = label3.Text;
            battle.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            BATTLE battle = new BATTLE();
            battle.label3.Text = "30";
            battle.label4.Text = "20";
            battle.label6.Text = label2.Text;
            battle.label7.Text = label3.Text;
            battle.ShowDialog();
        }

        private void PLAY_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void PLAY_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
