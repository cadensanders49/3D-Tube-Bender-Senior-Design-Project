using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _3DTubeBender
{
    public partial class PasswordRequest : Form
    {
        // Opens the window
        public PasswordRequest()
        {
            InitializeComponent();
        }


        //
        // PASSWORD REQUEST
        //

        // Object: Password Request
        // Action: Click
        private void enter_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
