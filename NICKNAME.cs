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
    public partial class NICKNAME : Form
    {
        public NICKNAME()
        {
            InitializeComponent();
        }

        string Nick1;
        string Nick2;
        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Введите никнеймы игроков");
                return;
            }
            if (textBox1.Text == textBox2.Text)
            {
                MessageBox.Show("Никнеймы должны быть разными");
                return;
            }
            Nick1 = textBox1.Text;
            Nick2 = textBox2.Text;


            this.Hide();
            PLAY play = new PLAY();
            play.label2.Text = Nick1;
            play.label3.Text = Nick2;
            play.ShowDialog();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Space)
                e.KeyChar = '\0';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.ShowDialog();
        }

        private void NICKNAME_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void NICKNAME_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
