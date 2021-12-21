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

        void DisableButtons()
        {
            b1.Enabled = false;
            b4.Enabled = false;
            b5.Enabled = false;
            b6.Enabled = false;
            b8.Enabled = false;
            b2.Enabled = false;
            b3.Enabled = false;
            b7.Enabled = false;
            b9.Enabled = false;
        }

        void Harchi(string value)
        {
            if (b1.Text == value && b2.Text == value && b3.Text == value)
            {
                if (value == "X")
                {
                    RtlMessageBox.Show($"{NameOne} بازی را برد.");
                    DisableButtons();
                }
                else
                {
                    RtlMessageBox.Show($"{NameTwo} بازی را برد.");
                    DisableButtons();
                }

            }
            if (b4.Text == value && b5.Text == value && b6.Text == value)
            {
                if (value == "X")
                {
                    RtlMessageBox.Show($"{NameOne} بازی را برد.");
                    DisableButtons();
                }
                else
                {
                    RtlMessageBox.Show($"{NameTwo} بازی را برد.");
                    DisableButtons();
                }

            }
            if (b7.Text == value && b8.Text == value && b9.Text == value)
            {
                if (value == "X")
                {
                    RtlMessageBox.Show($"{NameOne} بازی را برد.");
                    DisableButtons();
                }
                else
                {
                    RtlMessageBox.Show($"{NameTwo} بازی را برد.");
                    DisableButtons();
                }

            }
            if (b1.Text == value && b4.Text == value && b7.Text == value)
            {
                if (value == "X")
                {
                    RtlMessageBox.Show($"{NameOne} بازی را برد.");
                    DisableButtons();
                }
                else
                {
                    RtlMessageBox.Show($"{NameTwo} بازی را برد.");
                    DisableButtons();
                }

            }
            if (b2.Text == value && b5.Text == value && b8.Text == value)
            {
                if (value == "X")
                {
                    RtlMessageBox.Show($"{NameOne} بازی را برد.");
                    DisableButtons();
                }
                else
                {
                    RtlMessageBox.Show($"{NameTwo} بازی را برد.");
                    DisableButtons();
                }

            }
            if (b3.Text == value && b6.Text == value && b9.Text == value)
            {
                if (value == "X")
                {
                    RtlMessageBox.Show($"{NameOne} بازی را برد.");
                    DisableButtons();
                }
                else
                {
                    RtlMessageBox.Show($"{NameTwo} بازی را برد.");
                    DisableButtons();
                }

            }
            if (b1.Text == value && b5.Text == value && b9.Text == value)
            {
                if (value == "X")
                {
                    RtlMessageBox.Show($"{NameOne} بازی را برد.");
                    DisableButtons();
                }
                else
                {
                    RtlMessageBox.Show($"{NameTwo} بازی را برد.");
                    DisableButtons();
                }

            }
            if (b3.Text == value && b5.Text == value && b7.Text == value)
            {
                if (value == "X")
                {
                    RtlMessageBox.Show($"{NameOne} بازی را برد.");
                    DisableButtons();
                }
                else
                {
                    RtlMessageBox.Show($"{NameTwo} بازی را برد.");
                    DisableButtons();
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
            Refresh();
        }

        void Refresh()
        {
            b1.Enabled=true;
            b1.Text = "";
            b2.Enabled=true;
            b2.Text = "";
            b3.Enabled = true;
            b3.Text = "";
            b4.Enabled = true;
            b4.Text = "";
            b5.Enabled = true;
            b5.Text = "";
            b6.Enabled = true;
            b6.Text = "";
            b7.Enabled = true;
            b7.Text = "";
            b8.Enabled = true;
            b8.Text = "";
            b9.Enabled = true;
            b9.Text = "";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

            Application.Restart();
        }
    }
}
