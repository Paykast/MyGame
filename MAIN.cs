using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;

namespace MyGame
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            NICKNAME play = new NICKNAME();
            play.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            RATING rating = new RATING();
            rating.label1.Text = label2.Text;
            rating.label2.Text = label3.Text;
            rating.label3.Text = label4.Text;
            rating.label4.Text = label5.Text;
            rating.label5.Text = label6.Text;
            rating.label6.Text = label7.Text;
            rating.ShowDialog();
        }
        SoundPlayer sp;
        private void Main_Load(object sender, EventArgs e)
        {
            sp = new SoundPlayer();
            //вытягиваем из ресурсов звуковой файл
            sp.Stream = Properties.Resources.EV;
            sp.PlayLooping();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
