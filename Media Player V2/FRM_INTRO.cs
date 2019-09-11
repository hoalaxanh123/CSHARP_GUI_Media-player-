using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Media_Player_V2
{
    public partial class FRM_INTRO : Form
    {
        public FRM_INTRO()
        {
            InitializeComponent();
        }
        int thoigian = 3;
        private void label_Loading_Click(object sender, EventArgs e)
        {
            //Debug
            this.Visible = false;
            FRM_MAIN Run = new FRM_MAIN();
            Run.Show();
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            thoigian--;
            this.toolStripStatusLabel_WaitTime.Text = thoigian.ToString();
            this.label_Loading.Text += ".";
            if (thoigian == 0)
            {
                this.Visible=false;
                FRM_MAIN Run = new FRM_MAIN();
                Run.Show();
                timer1.Stop();
               // this.Close();
            }
        }

        private void Intro_Load(object sender, EventArgs e)
        {
            this.timer1.Start();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
