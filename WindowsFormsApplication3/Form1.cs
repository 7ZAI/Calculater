using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        GetInput getInput = new GetInput();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getInput.input(button1.Text);
            lableShow.Text = getInput.getString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            getInput.input(button2.Text);
            lableShow.Text = getInput.getString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            getInput.input(button3.Text);
            lableShow.Text = getInput.getString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            getInput.input(button4.Text);
            lableShow.Text = getInput.getString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            getInput.input(button5.Text);
            lableShow.Text = getInput.getString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            getInput.input(button6.Text);
            lableShow.Text = getInput.getString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            getInput.input(button7.Text);
            lableShow.Text = getInput.getString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            getInput.input(button8.Text);
            lableShow.Text = getInput.getString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            getInput.input(button9.Text);
            lableShow.Text = getInput.getString();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            getInput.input(buttonAdd.Text);
            lableShow.Text = getInput.getString();
        }

        private void buttonReduce_Click(object sender, EventArgs e)
        {
            getInput.input(buttonReduce.Text);
            lableShow.Text = getInput.getString();
        }

        private void buttonMulti_Click(object sender, EventArgs e)
        {
            getInput.input(buttonMulti.Text);
            lableShow.Text = getInput.getString();
        }

        private void buttondivi_Click(object sender, EventArgs e)
        {
            getInput.input(buttondivi.Text);
            lableShow.Text = getInput.getString();
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            lableShow.Text = getInput.getString() + "\n\r" + getInput.calculate();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            getInput.clear();
            lableShow.Text = "";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            getInput.input(button0.Text);
            lableShow.Text = getInput.getString();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            getInput.deleteOne();
            lableShow.Text = getInput.getString();
        }
    }
}
