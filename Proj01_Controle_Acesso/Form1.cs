using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proj01_Controle_Acesso
{
    public partial class Form1 : Form
    {
        Timer tm = new Timer();
        Timer dl = new Timer();
        public Form1()
        {
            InitializeComponent();
            this.tm.Enabled = true;
            this.dl.Enabled = true;

            tm.Interval = 600;
            dl.Interval = 3000;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 10;

            if (progressBar1.Value == progressBar1.Maximum)
            {
                tm.Stop();
                progressBar1.Value = 100;               
                dl.Start();
                dl.Tick += Dl_Tick;
            }

        }

        private void Dl_Tick(object sender, EventArgs e)
        {          
            Login frLogin = new Login();
            this.Hide();
            dl.Stop();
            frLogin.ShowDialog();
        }


        private void button1_Click(object sender, EventArgs e)
        {            
            Login login = new Login();
            this.Hide();
            login.ShowDialog();  
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            progressBar1.Enabled = true;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;

            progressBar1.Value = 0;

            tm.Start();
            tm.Tick += Timer1_Tick;


        }
    }
}
