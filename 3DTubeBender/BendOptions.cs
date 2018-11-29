using _3DTubeBender.Properties;
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

        //
        // DONE BUTTON
        //

        // Object: Start Bend Button
        // Action: Click
        private void startBend_Click(object sender, EventArgs e)
        {
            // Setup the Bend window
            using (var Bend = new Bend())
            {
                // Notifies user that there was no file chosen yet
                // This will need to change later once bend option buttons
                // are added.
                if (Equals(Program.fileName, ""))
                {
                    MessageBox.Show("You must choose a bend first.");
                    this.DialogResult = DialogResult.Cancel;
                    return;
                }

                // Update connections, start the motors, and start the
                //bend sequence stored in the specified file.
                Program.UpdateDeviceConnections();
                Program.startMotors();
                Program.runScript(Program.usc, Program.fileName);

                // Actually open the window
                // Will not open the window if the code does not get to this point.
                Bend.ShowDialog();

                loadCheck.Checked = false;
                obstructionCheck.Checked = false;
                harmReductionCheck.Checked = false;
            }
        }


        //
        //      BEND PREPARATION CHECK BOXES
        //

        // Object: Tube Load Check Box
        // Action: Check Changes
        private void loadCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (loadCheck.Checked == true &&
                obstructionCheck.Checked == true &&
                harmReductionCheck.Checked == true)
            {
                startBend.Enabled = true;
            }
            else
            {
                startBend.Enabled = false;
            }
        }

        // Object: Obstruction Check Box
        // Action: Check Changes
        private void obstructionCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (loadCheck.Checked == true &&
                obstructionCheck.Checked == true &&
                harmReductionCheck.Checked == true)
            {
                startBend.Enabled = true;
            }
            else
            {
                startBend.Enabled = false;
            }
        }

        // Object: Harm Reduction Check Box
        // Action: Check Changes
        private void harmReductionCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (loadCheck.Checked == true &&
                obstructionCheck.Checked == true &&
                harmReductionCheck.Checked == true)
            {
                startBend.Enabled = true;
            }
            else
            {
                startBend.Enabled = false;
            }
        }

        
    }
}
