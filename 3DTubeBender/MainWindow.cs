using _3DTubeBender.Properties;
using System;
using System.Windows.Forms;

namespace _3DTubeBender
{
    public partial class MainWindow : Form
    {
        // Window is opened.
        public MainWindow()
        {
            InitializeComponent();
        }


        //
        //      BEND OPTIONS BUTTON
        //

        // Object: Bend Options Button
        // Action: Mouse Enters
        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            BendOptions.Image = Resources.ChooseBendHighlighted;
        }
        // Object: Bend Options Button
        // Action: Mouse Leaves
        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            BendOptions.Image = Resources.ChooseBend;
        }
        // Object: Bend Options Button
        // Action: Click
        private void BendOptions_Click(object sender, EventArgs e)
        {
            BendOptions bendWindow = new BendOptions();
            if (bendWindow.ShowDialog() == DialogResult.OK)
            {
                //This is where you can do things until the Done button is pressed.
            }
        }


        //
        //      X BUTTON
        //

        // Object: X Button
        // Action: Click
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }


        //
        //      CONFIGURATION BUTTON
        //

        // Object: Configuration Options Button
        // Action: Mouse Enters
        private void ConfigOptions_MouseEnter(object sender, EventArgs e)
        {
            ConfigOptions.Image = Resources.ConfigHighlighted;
        }
        // Object: Configuration Options Button
        // Action: Mouse Leaves
        private void ConfigOptions_MouseLeave(object sender, EventArgs e)
        {
            ConfigOptions.Image = Resources.Config;
        }
        // Object: Configuration Options Button
        // Action: Click
        private void ConfigOptions_Click(object sender, EventArgs e)
        {
            //This is the case that the pw is enabled
            if(Program.pwEnabled == true)
            {
                // First, open the Password Request window that will ask for a pw
                // Window will stay open until the pw is entered correctly
                // or Cancel is pressed.
                PasswordRequest pwWindow = new PasswordRequest();
                if (pwWindow.ShowDialog() == DialogResult.OK)
                {
                    // Check to see if the pw was correct
                    if (String.Equals(pwWindow.passwordInput.Text, "password"))
                    {
                        // If correct pw, open the Configuration Window
                        Config configWindow = new Config();
                        if (configWindow.ShowDialog() == DialogResult.OK)
                        {
                            // Data is updated before continuing
                            Program.UpdateDeviceConnections();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Wrong password. Please try again.");
                    }
                }
            }
            else
            {
                Config configWindow = new Config();
                if (configWindow.ShowDialog() == DialogResult.OK)
                {
                    // Data is updated before continuing
                    Program.UpdateDeviceConnections();
                }
            }
            
        }


        //
        //      START BEND BUTTON
        //

        // Object: Start Bend Button
        // Action: Mouse Enters
        private void startBend_MouseEnter(object sender, EventArgs e)
        {
            startBend.Image = Resources.StartBendHighlighted;
        }
        // Object: Start Bend Button
        // Action: Mouse Leaves
        private void startBend_MouseLeave(object sender, EventArgs e)
        {
            startBend.Image = Resources.StartBend;
        }
        // Object: Start Bend Button
        // Action: Click
        private void startBend_Click(object sender, EventArgs e)
        {
            // Setup the Bend window
            using (var startBend = new Bend())
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
                startBend.ShowDialog();
            }
        }
    }
}
