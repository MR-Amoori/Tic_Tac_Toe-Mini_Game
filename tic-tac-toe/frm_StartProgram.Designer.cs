namespace tic_tac_toe
{
    partial class frm_StartProgram
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
            this.txtName1Player = new System.Windows.Forms.TextBox();
            this.btn_Stratr = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName2Player = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtName1Player
            // 
            this.txtName1Player.ForeColor = System.Drawing.Color.Black;
            this.txtName1Player.Location = new System.Drawing.Point(10, 12);
            this.txtName1Player.Name = "txtName1Player";
            this.txtName1Player.Size = new System.Drawing.Size(143, 21);
            this.txtName1Player.TabIndex = 3;
            this.txtName1Player.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_Stratr
            // 
            this.btn_Stratr.ForeColor = System.Drawing.Color.Green;
            this.btn_Stratr.Location = new System.Drawing.Point(10, 71);
            this.btn_Stratr.Name = "btn_Stratr";
            this.btn_Stratr.Size = new System.Drawing.Size(222, 23);
            this.btn_Stratr.TabIndex = 2;
            this.btn_Stratr.Text = "شروع";
            this.btn_Stratr.UseVisualStyleBackColor = true;
            this.btn_Stratr.Click += new System.EventHandler(this.btn_Stratr_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "نام بازیکن اول :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "نام بازیکن دوم :";
            // 
            // txtName2Player
            // 
            this.txtName2Player.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtName2Player.Location = new System.Drawing.Point(10, 40);
            this.txtName2Player.Name = "txtName2Player";
            this.txtName2Player.Size = new System.Drawing.Size(143, 21);
            this.txtName2Player.TabIndex = 4;
            this.txtName2Player.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frm_StartProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(238, 101);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName2Player);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName1Player);
            this.Controls.Add(this.btn_Stratr);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_StartProgram";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "   بازی دوز    ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtName1Player;
        private System.Windows.Forms.Button btn_Stratr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName2Player;
    }
}

