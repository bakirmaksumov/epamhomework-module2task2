using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsHelloForms
{
    public partial class AppMainForm : Form
    { 
        public AppMainForm()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string inputTxt=txtMain.Text;
            if (inputTxt != String.Empty)
            {
                MessageBox.Show($"Hello {inputTxt}");
            }
            else
            {
                MessageBox.Show("textbox is empty");
            }
        }
    }
}
