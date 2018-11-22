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
    public partial class BendOptions : Form
    {
        // Window is opened
        public BendOptions()
        {
            InitializeComponent();
        }


        //
        //      MANUAL BEND FILE BUTTON
        //

        // Object: Manual Bend File Button
        // Action: Click
        private void manualBendFile_Click(object sender, EventArgs e)
        {
            // Displays an OpenFileDialog so the user can select a Cursor.  
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Bend Program Files|*.txt";
            openFileDialog1.Title = "Select a text file with bending commands.";

            // Show the Dialog.  
            // If the user clicked OK in the dialog and  
            // a correct file was selected, open it.  
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Program.fileName = openFileDialog1.FileName;
            }
        }


        //
        // DONE BUTTON
        //

        // Object: Done Button
        // Action: Click
        private void doneButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
        
    }
}
