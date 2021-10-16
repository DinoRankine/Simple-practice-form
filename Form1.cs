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
            //hide picture on program start.
            picGhost.Visible = false;
        }

      

        private void btnShow_Click(object sender, EventArgs e)
        {
            //declare variable name1 and assign input from Name text box to it.
            string name1 = txtName.Text;
            //if statement in case user leaves text box empty
            if (name1 == string.Empty)
            {
             //error message that will show up if Name text box is left empty.   
                MessageBox.Show("Please make an input in the name box","Error");
            }
            //else statement if name1 is NOT empty.
            else
            { 
                //get input from Name text box and place it in the Display text box.
                txtDisplay.Text = txtName.Text;
                //show picture
                picGhost.Visible = true;
                }
            
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            //display form name in Display text box.
            txtDisplay.Text = this.Text;
            //show picture
            picGhost.Visible = true;
            //clear contents of Name text box.
            txtName.Clear();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //clear contents of Display text box.
            txtDisplay.Clear();
            //clear contents of Name text box.
            txtName.Clear();
            //hide picture
            picGhost.Visible = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //close the form
            this.Close();
        }
    }
}
