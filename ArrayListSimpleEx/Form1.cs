using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayListSimpleEx
{
    public partial class Form1 : Form
    {
        ArrayList phrase = new ArrayList();
        bool reversed;
        
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            phrase.Add("I");
            phrase.Add("love");
            phrase.Add("programming");
            phrase.Add("so");
            phrase.Add("much");


        }

        private void btnShowMsg_Click(object sender, EventArgs e)
        {
            if (reversed) { phrase.Reverse(); reversed = false; }

            string msg = string.Empty;
            foreach(string word in phrase)
            {
                msg += word + " ";
            }
            lblMessage.Text = msg;
        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            phrase.Reverse();
            string msg = string.Empty;
            foreach(string word in phrase)
            {
                msg += word + " ";
            }
            lblMessage.Text = msg;

            reversed = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (reversed)
            {
                MessageBox.Show("Re-reverse it, bro");
                return;
            }
            phrase.Insert(1, txtSecondPos.Text);


            ////display
            //string msg = string.Empty;
            //foreach (string word in phrase)
            //{
            //    msg += word + " ";
            //}
            //lblMessage.Text = msg;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (reversed)
            {
                MessageBox.Show("re-reverse it, bro");
                return;
            }
            phrase.RemoveAt(1);



            //display
            //string msg = string.Empty;
            //foreach (string word in phrase)
            //{
            //    msg += word + " ";
            //}
            //lblMessage.Text = msg;
        }
    }
}
