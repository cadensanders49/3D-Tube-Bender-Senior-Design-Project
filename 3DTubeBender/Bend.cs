using System;
using System.Windows.Forms;
using _3DTubeBender.Properties;
using Pololu.Jrk;
using Pololu.Usc;

namespace _3DTubeBender
{
    public partial class Bend : Form
    {
        //Open the window
        public Bend()
        {
            InitializeComponent();
            statusUpdateTimer.Start();
        }


        //
        //      STATUS UPDATE TIMER
        //

        // Object: Status Update Timer
        // Action: This function is called for every tick of the timer
        // while the timer is enabled.
        private void statusUpdateTimer_Tick(object sender, EventArgs e)
        {
            Program.updateTable(statusDataGrid);
        }


        //
        //      EMERGENCY STOP BUTTON
        //

        // Object: Emergency Stop Button
        // Action: Mouse Enters
        private void emergencyStopButton_MouseEnter(object sender, EventArgs e)
        {
            emergencyStopButton.Image = Resources.Emergency_Stop___Clicked;
        }

        private void emergencyStopButton_MouseLeave(object sender, EventArgs e)
        {
            emergencyStopButton.Image = Resources.Emergency_Stop;
        }

        private void emergencyStopButton_Click(object sender, EventArgs e)
        {

        }
    }
}
