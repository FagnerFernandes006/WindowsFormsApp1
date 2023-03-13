using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class TelaCarregamento : Form
    {
        public TelaCarregamento()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            this.SetStyle(ControlStyles.UserPaint, true);

            label2.Text = "CARREGANDO O SISTEMA";
            this.Refresh();

            for (int i = 1; i < 101; i++)
            {
               
                progressBar1.Value = i;
                Thread.Sleep(40);
            }
            progressBar1.Value = 99;
            Thread.Sleep(500);

            this.Hide();
            Form f = new Home();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
