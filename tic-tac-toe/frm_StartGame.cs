using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tic_tac_toe
{
    public partial class frm_StartGame : Form
    {
        public string NameOne
        {
            get; set;
        }
        public string NameTwo
        {
            get; set;
        }

        public frm_StartGame()
        {
            InitializeComponent();
        }

        private void StartGame_Load(object sender, EventArgs e)
        {
            lblNobat.Text = $"بازی نوبت {NameOne} است.";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void Harchi(string value)
        {
            if (b1.Text == value && b2.Text == value && b3.Text == value)
            {
                if (value == "X")
                {
                    RtlMessageBox.Show($"{NameOne} بازی را برد.");
                }
                else
                {
                    RtlMessageBox.Show($"{NameTwo} بازی را برد.");
                }

            }
            if (b4.Text == value && b5.Text == value && b6.Text == value)
            {
                if (value == "X")
                {
                    RtlMessageBox.Show($"{NameOne} بازی را برد.");
                }
                else
                {
                    RtlMessageBox.Show($"{NameTwo} بازی را برد.");
                }

            }
            if (b7.Text == value && b8.Text == value && b9.Text == value)
            {
                if (value == "X")
                {
                    RtlMessageBox.Show($"{NameOne} بازی را برد.");
                }
                else
                {
                    RtlMessageBox.Show($"{NameTwo} بازی را برد.");
                }

            }
            if (b1.Text == value && b4.Text == value && b7.Text == value)
            {
                if (value == "X")
                {
                    RtlMessageBox.Show($"{NameOne} بازی را برد.");
                }
                else
                {
                    RtlMessageBox.Show($"{NameTwo} بازی را برد.");
                }

            }
            if (b2.Text == value && b5.Text == value && b8.Text == value)
            {
                if (value == "X")
                {
                    RtlMessageBox.Show($"{NameOne} بازی را برد.");
                }
                else
                {
                    RtlMessageBox.Show($"{NameTwo} بازی را برد.");
                }

            }
            if (b3.Text == value && b6.Text == value && b9.Text == value)
            {
                if (value == "X")
                {
                    RtlMessageBox.Show($"{NameOne} بازی را برد.");
                }
                else
                {
                    RtlMessageBox.Show($"{NameTwo} بازی را برد.");
                }

            }
            if (b1.Text == value && b5.Text == value && b9.Text == value)
            {
                if (value == "X")
                {
                    RtlMessageBox.Show($"{NameOne} بازی را برد.");
                }
                else
                {
                    RtlMessageBox.Show($"{NameTwo} بازی را برد.");
                }

            }
            if (b3.Text == value && b5.Text == value && b7.Text == value)
            {
                if (value == "X")
                {
                    RtlMessageBox.Show($"{NameOne} بازی را برد.");
                }
                else
                {
                    RtlMessageBox.Show($"{NameTwo} بازی را برد.");
                }

            }
        }

        int Counter = 0;
        private void b1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (Counter % 2 == 0)
            {
                btn.Text = "X";
                lblNobat.Text = $"بازی نوبت {NameTwo} است.";
                Counter++;
            }
            else
            {
                btn.Text = "O";
                lblNobat.Text = $"بازی نوبت {NameOne} است.";
                Counter++;
            }

            btn.Enabled = false;
            Harchi("X");
            Harchi("O");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Restart();  
        }
    }
}
