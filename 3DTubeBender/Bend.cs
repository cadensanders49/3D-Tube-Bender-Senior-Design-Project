using System;
using System.Windows.Forms;

namespace _3DTubeBender
{
    public partial class Bend : Form
    {
        //Open the window
        public Bend()
        {
            InitializeComponent();
        }

        //
        //      START BUTTON
        //

        // Object: Start Button
        // Action: Click
        private void start_Click(object sender, EventArgs e)
        {
            Program.startMotors();
            Program.usc.setScriptDone(0);
        }


        //
        //      STOP BUTTON
        //

        // Object: Stop Button
        // Action: Click
        private void stop_Click(object sender, EventArgs e)
        {
            Program.stopMotors();
            Program.usc.setScriptDone(1);
        }
    }
}
