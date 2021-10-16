using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice_Events_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            picGhost.Visible = false;
        }

      

        private void btnShow_Click(object sender, EventArgs e)
        {
            string name1 = txtName.Text;
            if (name1 == string.Empty)
            {
                
                MessageBox.Show("Please make an input in the name box","Error");
            }

            else
            { 
                //get input from Name text box and place it in the Display text box.
                txtDisplay.Text = txtName.Text;
                picGhost.Visible = true;
                }
            
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = this.Text;
            picGhost.Visible = true;
            txtName.Clear();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
            txtName.Clear();
            picGhost.Visible = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
