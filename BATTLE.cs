using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SQLite;

namespace MyGame
{
    public partial class BATTLE : Form
    {
        public BATTLE()
        {
            InitializeComponent();
            button2.Enabled = false;
            button3.Enabled = false;
        }

        private void BATTLE_Load(object sender, EventArgs e)
        {
            int Visota, Shirina;
            Visota = Convert.ToInt32(label3.Text);
            Shirina = Convert.ToInt32(label4.Text);
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.ColumnHeadersVisible = false;
            dataGridView1.ScrollBars = ScrollBars.None;
            dataGridView1.AllowUserToResizeColumns = false;

            for (int i = 0; i < Visota; i++)
            {
                dataGridView1.Columns.Add(Convert.ToString(i), " ");
            }
            for (int i = 0; i < (Shirina); i++)
            {
                dataGridView1.Rows.Add();
                if (Shirina == 30)
                {
                    dataGridView1.Rows[i].Height = 18;
                    dataGridView1.Size = new Size(773, 540);
                }
                if (Shirina == 25)
                {
                    dataGridView1.Rows[i].Height = 22;
                    dataGridView1.Size = new Size(773, 550);
                }
                if (Shirina == 20)
                {
                    dataGridView1.Rows[i].Height = 27;
                    dataGridView1.Size = new Size(773, 540);
                }

                System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
                System.IO.Stream resourcesStream = assembly.GetManifestResourceStream(@"MyGame.Music.wav");
                SoundPlayer player = new SoundPlayer(resourcesStream);
                player.Play();
                dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Green;
                dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Green;
            }
        }


        // Заполнение поля битвы

        int schet1 = 0;
        int schet2 = 0;
        int storona1, storona2;
        private void button1_Click(object sender, EventArgs e)
        {

            int cube1, cube2;
            Random rand = new Random();
            cube1 = rand.Next(1, 7);
            cube2 = rand.Next(1, 7);

            ///ОБРАБОТКА ВЫПАВШЕГО КУБИКА ПОД НОМЕРОМ 1
            if (cube1 == 1)
            {
                pictureBox1.Image = Properties.Resources.bone1;
                storona1 = 1;
            }
            if (cube1 == 2)
            {
                pictureBox1.Image = Properties.Resources.bone2;
                storona1 = 2;
            }
            if (cube1 == 3)
            {
                pictureBox1.Image = Properties.Resources.bone3;
                storona1 = 3;
            }
            if (cube1 == 4)
            {
                pictureBox1.Image = Properties.Resources.bone4;
                storona1 = 4;
            }
            if (cube1 == 5)
            {
                pictureBox1.Image = Properties.Resources.bone5;
                storona1 = 5;
            }
            if (cube1 == 6)
            {
                pictureBox1.Image = Properties.Resources.bone6;
                storona1 = 6;
            }

            ///ОБРАБОТКА ВЫПАВШЕГО КУБИКА ПОД НОМЕРОМ 2
            if (cube2 == 1)
            {
                pictureBox2.Image = Properties.Resources.bone1;
                storona2 = 1;
            }
            if (cube2 == 2)
            {
                pictureBox2.Image = Properties.Resources.bone2;
                storona2 = 2;
            }
            if (cube2 == 3)
            {
                pictureBox2.Image = Properties.Resources.bone3;
                storona2 = 3;
            }
            if (cube2 == 4)
            {
                pictureBox2.Image = Properties.Resources.bone4;
                storona2 = 4;
            }
            if (cube2 == 5)
            {
                pictureBox2.Image = Properties.Resources.bone5;
                storona2 = 5;
            }
            if (cube2 == 6)
            {
                pictureBox2.Image = Properties.Resources.bone6;
                storona2 = 6;
            }
            button1.Enabled = false;
            button2.Enabled = true;
            button3.Enabled = true;

        }
        int player = 0;

        private void button3_Click(object sender, EventArgs e)
        {
            if (player % 2 == 0)
                label1.Text = "PLAYER 2'S MOVE";
            else
                label1.Text = "PLAYER 1'S MOVE";
            player++;
            button1.Enabled = true;
            button2.Enabled = false;
            button3.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (schet1 > schet2)
            {
                MessageBox.Show("Счет игрока " + label6.Text + " " + Convert.ToString(schet1) + ": Счет игрока " + label7.Text + " " + Convert.ToString(schet2) +
                    "\n Выйграл игрок " + label6.Text);

                this.Hide();
                Main main = new Main();
                main.label2.Text = label6.Text;
                main.label3.Text = "1";
                main.label4.Text = "1";
                main.label5.Text = label7.Text;
                main.label6.Text = "1";
                main.label7.Text = "0";
                main.ShowDialog();
            }
            if (schet1 < schet2)
            {
                MessageBox.Show("Счет игрока " + label6.Text + " " + Convert.ToString(schet1) + ": Счет игрока " + label7.Text + " " + Convert.ToString(schet2) +
                    "\n Выйграл игрок " + label7.Text);

                this.Hide();
                Main main = new Main();
                main.label2.Text = label7.Text;
                main.label3.Text = "1";
                main.label4.Text = "1";
                main.label5.Text = label6.Text;
                main.label6.Text = "1";
                main.label7.Text = "0";
                main.ShowDialog();
            }
            if (schet1 == schet2)
            {
                MessageBox.Show("Счет игрока " + label6.Text + " " + Convert.ToString(schet1) + ": Счет игрока " + label7.Text + " " + Convert.ToString(schet2) +
                    "\n НИЧЬЯ");

                this.Hide();
                Main main = new Main();
                main.label2.Text = label6.Text;
                main.label3.Text = "1";
                main.label4.Text = "0";
                main.label5.Text = label7.Text;
                main.label6.Text = "1";
                main.label7.Text = "0";
                main.ShowDialog();
            }
        }

        private void BATTLE_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Ваши результаты не сохранились!");
            Application.Exit();
        }

        private void BATTLE_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Ваши результаты не сохранились!");
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int ploshad = storona1 * storona2;
            if (ploshad == Convert.ToInt32(dataGridView1.SelectedCells.Count))
            {
                Int32 selectedCellCount =
                        dataGridView1.GetCellCount(DataGridViewElementStates.Selected);
                if (selectedCellCount > 0)
                {
                    if (dataGridView1.AreAllCellsSelected(true))
                    {
                        MessageBox.Show("All cells are selected", "Selected Cells");
                    }
                    else
                    {
                        for (int i = 0; i < selectedCellCount; i++)
                        {
                            string index1 = dataGridView1.SelectedCells[i].RowIndex.ToString();
                            string index2 = dataGridView1.SelectedCells[i].ColumnIndex.ToString();
                            if (dataGridView1.Rows[Convert.ToInt32(index1)].Cells[Convert.ToInt32(index2)].Style.BackColor != Color.Empty)
                            {
                                MessageBox.Show("Выделенные кубики заходят на выделенную территорию!");
                                return;
                            }
                        }
                    }
                }
            }
            if (ploshad == Convert.ToInt32(dataGridView1.SelectedCells.Count))
            {
                Int32 selectedCellCount =
                        dataGridView1.GetCellCount(DataGridViewElementStates.Selected);
                if (selectedCellCount > 0)
                {
                    if (dataGridView1.AreAllCellsSelected(true))
                    {
                        MessageBox.Show("All cells are selected", "Selected Cells");
                    }
                    else
                    {
                        for (int i = 0; i < selectedCellCount; i++)
                        {
                            string index1 = dataGridView1.SelectedCells[i].RowIndex.ToString();
                            string index2 = dataGridView1.SelectedCells[i].ColumnIndex.ToString();
                            if (label1.Text == "PLAYER 2'S MOVE")
                            {
                                dataGridView1.Rows[Convert.ToInt32(index1)].Cells[Convert.ToInt32(index2)].Style.BackColor = Color.Blue;
                                schet2++;
                            }
                            if (label1.Text == "PLAYER 1'S MOVE")
                            {
                                dataGridView1.Rows[Convert.ToInt32(index1)].Cells[Convert.ToInt32(index2)].Style.BackColor = Color.Red;
                                schet1++;
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Количество выделенных ячеек не совпадает с выпавшим значением");
                return;
            }
            
            //ХОД ЧЕЛОВЕКА
            if (player % 2 == 0)
                label1.Text = "PLAYER 2'S MOVE";
            else
                label1.Text = "PLAYER 1'S MOVE";
            player++;
            button1.Enabled = true;
            button2.Enabled = false;
            button3.Enabled = false;
        }
    }
}
