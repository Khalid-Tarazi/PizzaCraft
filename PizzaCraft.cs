using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaCraft
{
    public partial class PizzaCraft : Form
    {
        public PizzaCraft()
        {
            InitializeComponent();
        }

        private void PizzaCraft_Load(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (rbLarge.Checked)
            {
                label1.Text = rbLarge.Text;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            list.Items.Clear();

            if (chkExtraCheese.Checked)
                list.Items.Add(chkExtraCheese.Text);

            if (chkMushrooms.Checked)
                list.Items.Add(chkMushrooms.Text);

            if (chkTomatoes.Checked)
                list.Items.Add(chkTomatoes.Text);

            if (chkOnion.Checked)
                list.Items.Add(chkOnion.Text);

            if (chkOlives.Checked)
                list.Items.Add(chkOlives.Text);

            if (chkGreenPeppers.Checked)
                list.Items.Add(chkGreenPeppers.Text);

            //---



            //message box confirm selection then show


            gbBox5.Visible = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void gbBox1_Enter(object sender, EventArgs e)
        {

        }

        private void rbSmall_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSmall.Checked)
            {
                label1.Text = rbSmall.Text;
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void rbMedium_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMedium.Checked)
            {
                label1.Text = rbMedium.Text;
            }
        }

        private void rbThin_CheckedChanged(object sender, EventArgs e)
        {
            if (rbThin.Checked)
            {
                label3.Text = rbThin.Text;
            }
        }

        private void rbThick_CheckedChanged(object sender, EventArgs e)
        {
            if (rbThick.Checked)
            {
                label3.Text = rbThick.Text;
            }
        }

        private void rbEatIn_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEatIn.Checked)
            {
                label4.Text = rbEatIn.Text;
            }
        }

        private void rbTakeOut_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTakeOut.Checked)
            {  
                label4.Text = rbTakeOut.Text;
            }
        }

        private void chkExtraCheese_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void chkMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void list_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
