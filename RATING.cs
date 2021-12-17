using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MyGame
{
    public partial class RATING : Form
    {
        public RATING()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.ShowDialog();
        }

      
               

        int proverka1 = 0; 
        int proverka2 = 0;
        private void RATING_Load(object sender, EventArgs e)
        {
            this.rattingTableAdapter.Fill(this.rATTINGDataSet.ratting);
            if (label1.Text != "")
            {
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    if (label1.Text == dataGridView1.Rows[i].Cells[1].Value.ToString())
                    {
                        dataGridView1.Rows[i].Cells[0].Value = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value);
                        dataGridView1.Rows[i].Cells[1].Value = dataGridView1.Rows[i].Cells[1].Value;
                        dataGridView1.Rows[i].Cells[2].Value = Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value) + Convert.ToInt32(label2.Text);
                        dataGridView1.Rows[i].Cells[3].Value = Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value) + Convert.ToInt32(label3.Text);
                        rattingTableAdapter.Update(rATTINGDataSet.ratting);
                        dataGridView1.Refresh();
                        proverka1 = 1;
                    }
                    ////////////
                    if (label4.Text == dataGridView1.Rows[i].Cells[1].Value.ToString())
                    {
                        dataGridView1.Rows[i].Cells[0].Value = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value);
                        dataGridView1.Rows[i].Cells[1].Value = Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);
                        dataGridView1.Rows[i].Cells[2].Value = Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value) + Convert.ToInt32(label2.Text);
                        dataGridView1.Rows[i].Cells[3].Value = Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value) + Convert.ToInt32(label3.Text);
                        rattingTableAdapter.Update(rATTINGDataSet.ratting);
                        dataGridView1.Refresh();
                        proverka2 = 1;
                    }
                }

                if (proverka1 != 1)
                {
                    int Number = dataGridView1.RowCount;
                    RATTINGDataSet.rattingRow newRegionRow;
                    newRegionRow = rATTINGDataSet.ratting.NewrattingRow();
                    newRegionRow.NUMBER = dataGridView1.RowCount + 1;
                    newRegionRow.NICKNAME = label1.Text;
                    newRegionRow.TOTAL_GAME = Convert.ToInt32(label2.Text);
                    newRegionRow.VICTORIES = Convert.ToInt32(label3.Text);
                    rATTINGDataSet.ratting.Rows.Add(newRegionRow);
                    rattingBindingSource.EndEdit();
                    rattingTableAdapter.Update(rATTINGDataSet.ratting);
                    dataGridView1.Refresh();
                }
                if (proverka2 != 1)
                {
                    int Number = dataGridView1.RowCount;
                    RATTINGDataSet.rattingRow newRegionRow1;
                    newRegionRow1 = rATTINGDataSet.ratting.NewrattingRow();
                    newRegionRow1.NUMBER = dataGridView1.RowCount + 1;
                    newRegionRow1.NICKNAME = label4.Text;
                    newRegionRow1.TOTAL_GAME = Convert.ToInt32(label5.Text);
                    newRegionRow1.VICTORIES = Convert.ToInt32(label6.Text);
                    rATTINGDataSet.ratting.Rows.Add(newRegionRow1);
                    rattingBindingSource.EndEdit();
                    rattingTableAdapter.Update(rATTINGDataSet.ratting);
                    dataGridView1.Refresh();

                }
            }
        }

        private void RATING_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void RATING_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
