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
    public partial class frm_StartProgram : Form
    {
        public frm_StartProgram()
        {
            InitializeComponent();
        }

        private void btn_Stratr_Click(object sender, EventArgs e)
        {
            if (txtName1Player.Text==""||txtName2Player.Text=="")
            {
                RtlMessageBox.Show("لطفا اطلاعات را وارد کنید","خطا",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                frm_StartGame game = new frm_StartGame();
                game.NameOne = txtName1Player.Text;
                game.NameTwo = txtName2Player.Text;
                this.Hide();
                game.ShowDialog();                
            }
        }
    }
}
