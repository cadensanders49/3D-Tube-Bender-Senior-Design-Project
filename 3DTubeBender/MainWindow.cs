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
        //      CLOSE BUTTON
        //

        // Object: Close Button
        // Action: Mouse Enters
        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            closeButton.Image = Resources.Close___Highlighted;
        }

        // Object: Close Button
        // Action: Mouse Leaves
        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.Image = Resources.Close___Unhighlighted;
        }

        // Object: Close Button
        // Action: Click
        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }


        //
        //      SETTINGS BUTTON (AKA SYSTEM CONFIGURATION)
        //

        // Object: Settings Button
        // Action: Mouse Enter
        private void settings_MouseEnter(object sender, EventArgs e)
        {
            settings.Image = Resources.Settings___Highlighted;
        }

        // Object: Settings Button
        // Action: Mouse Leave
        private void settings_MouseLeave(object sender, EventArgs e)
        {
            settings.Image = Resources.Settings___Unhighlighted;
        }

        // Object: Settings Button
        // Action: Mouse is pressed down
        private void settings_MouseDown(object sender, MouseEventArgs e)
        {
            settings.Image = Resources.Settings___Clicked;
        }

        // Object: Settings Button
        // Action: Mouse is released
        private void settings_MouseUp(object sender, MouseEventArgs e)
        {
            settings.Image = Resources.Settings___Unhighlighted;
        }

        // Object: Settings Button
        // Action: Click
        private void settings_Click(object sender, EventArgs e)
        {
            //This is the case that the pw is enabled
            if (Program.pwEnabled == true)
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
        //      INFO BUTTON
        //

        // Object: Info Button
        // Action: Mouse Enter
        private void info_MouseEnter(object sender, EventArgs e)
        {
            info.Image = Resources.Info___Highlighted;
        }

        // Object: Info Button
        // Action: Mouse Leave
        private void info_MouseLeave(object sender, EventArgs e)
        {
            info.Image = Resources.Info;
        }

        // Object: Info Button
        // Action: Mouse is pressed down
        private void info_MouseDown(object sender, MouseEventArgs e)
        {
            info.Image = Resources.Info___Clicked;
        }

        // Object: Info Button
        // Action: Mouse is released
        private void info_MouseUp(object sender, MouseEventArgs e)
        {
            info.Image = Resources.Info;
        }

        // Object: Info Button
        // Action: Click
        private void info_Click(object sender, EventArgs e)
        {
            //Code for showing info
        }


        //
        //      LOAD TUBE CHECK BOXES
        //

        // Object: Power Check Box
        // Action: Check Changes
        private void powerCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (powerCheck.Checked == true &&
                obstructionCheck.Checked == true &&
                harmReductionCheck.Checked == true &&
                usbCheck.Checked == true)
            {
                loadButton.Enabled = true;
            }
            else
            {
                loadButton.Enabled = false;
            }
        }

        // Object: Obstruction Check Box
        // Action: Check Changes
        private void obstructionCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (powerCheck.Checked == true &&
                obstructionCheck.Checked == true &&
                harmReductionCheck.Checked == true &&
                usbCheck.Checked == true)
            {
                loadButton.Enabled = true;
            }
            else
            {
                loadButton.Enabled = false;
            }
        }

        // Object: Harm Reduction Check Box
        // Action: Check Changes
        private void harmReductionCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (powerCheck.Checked == true &&
                obstructionCheck.Checked == true &&
                harmReductionCheck.Checked == true &&
                usbCheck.Checked == true)
            {
                loadButton.Enabled = true;
            }
            else
            {
                loadButton.Enabled = false;
            }
        }

        // Object: USB Check Box
        // Action: Check Changes
        private void usbCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (powerCheck.Checked == true &&
                obstructionCheck.Checked == true &&
                harmReductionCheck.Checked == true &&
                usbCheck.Checked == true)
            {
                loadButton.Enabled = true;
            }
            else
            {
                loadButton.Enabled = false;
            }
        }


        //
        //      LOAD TUBE BUTTON
        //

        // Object: Load Tube Button
        // Action: Click
        private void loadButton_Click(object sender, EventArgs e)
        {
            powerCheck.Checked = false;
            obstructionCheck.Checked = false;
            harmReductionCheck.Checked = false;
            usbCheck.Checked = false;

            // Set motors to loading position and set window for 
            // choosing a bend. Use the loading bar to signify progress.

            BendOptions bendWindow = new BendOptions();
            if (bendWindow.ShowDialog() == DialogResult.OK)
            {
                //This is where you can do things until the Done button is pressed.

            }
        }
    }

}