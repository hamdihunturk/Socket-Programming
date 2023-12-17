using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSocket
{
    public partial class Form1 : Form
    {
        private List<Button> buttons = new List<Button>(9);
        public Form1()
        {
            InitializeComponent();
        }
        Aptallık aptallık = new Aptallık();
        List<string> Packtes = new List<string>();
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void stplistn_btn_Click(object sender, EventArgs e)
        {
              
        }

        private void snd_btn_Click(object sender, EventArgs e)
        {
            aptallık.send = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnWait_Click(object sender, EventArgs e)
        {
            if (aptallık.Bekle)
                aptallık.Bekle = false;
            else if (!aptallık.Bekle)
                aptallık.Bekle = true;
        }

        private void btnRightClick_Click(object sender, EventArgs e)
        {
            Task.Run(()=> aptallık.RightClick());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            aptallık.Port = Convert.ToInt32(textBox1.Text);
            MessageBox.Show("SuccesFuly!");
           
            
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
            Task.Run(() => aptallık.RightClick());
        }
    }

}
