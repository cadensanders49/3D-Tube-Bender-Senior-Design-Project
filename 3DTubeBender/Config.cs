using Pololu.Jrk;
using Pololu.Usc;
using System;
using System.Windows.Forms;

namespace _3DTubeBender
{
    public partial class Config : Form
    {
        string errorFileName;
        double startTargetTracker;
        int startTarget;
        string output;
        int degreeTracker = 0;
        int destinationTarget;
        Timer destinationTimer = new Timer();
        Timer loopTimer = new Timer();
        string notification;
        jrkVariables jrkVars;
        MaestroVariables maestroVars;
        ServoStatus[] servos;
        short[] stack;
        ushort[] call_stack;


        //Open the window
        public Config()
        {
            InitializeComponent();
            pwEnabledBox.Checked = Program.pwEnabled;
            destinationTimer.Tick += new EventHandler(timer_Tick); // Everytime timer ticks, timer_Tick will be called
            destinationTimer.Interval = (1000) * (3);              // Timer will tick evert second
            loopTimer.Tick += new EventHandler(timer_Tick); // Everytime timer ticks, timer_Tick will be called
            loopTimer.Interval = (1000) * (3);              // Timer will tick every second
        }


        //
        // STATUS BUTTON
        //

        // Object: Status Button
        // Action: Click
        private void status_Click(object sender, EventArgs e)
        {
            Program.UpdateDeviceConnections();
            Program.updateTable(statusDataGrid);
        }


        //
        // DONE BUTTON
        //

        // Object: Done Button
        // Action: Click
        private void done_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }


        //
        // FIRMWARE UPDATE BUTTON
        //

        // Object: Firmware Update Button
        // Action: Click
        private void firmwareUpdate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is not ready yet. Sorry.");
        }


        //
        // DOWNLOAD CONFIGURATION BUTTON
        //

        // Object: Download Configuration Button
        // Action: Click
        private void downloadConfiguration_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is not ready yet. Sorry.");
        }


        //
        // UPLOAD CONFIGURATION BUTTON
        //

        // Object: Upload Configuration Button
        // Action: Click
        private void uploadConfiguration_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is not ready yet. Sorry.");
        }


        //
        // CLEAR ERRORS BUTTON
        //

        // Object: Clear Errors Button
        // Action: Click
        private void clearErrors_Click(object sender, EventArgs e)
        {
            Program.clearAllErrors();
        }


        //
        // ERROR TESTING BUTTON
        //

        // Object: Error Testing Button
        // Action: Click
        private void errorTesting_Click(object sender, EventArgs e)
        {
            

            //
            // Case for when there are no motors conected
            //

            // Displays an OpenFileDialog so the user can select an output file.  
            OpenFileDialog errorTestingFileDialog = new OpenFileDialog();
            errorTestingFileDialog.Filter = "Text File for Output|*.txt";
            errorTestingFileDialog.Title = "Create a text file for data output.";

            // Show the Dialog.  
            // If the user clicked OK in the dialog and a correct file was selected, open it.  
            if (errorTestingFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                errorFileName = errorTestingFileDialog.FileName;
            }
            else
            {
                MessageBox.Show("An output file must be chosen. Please try again.");
                return;
            }

            //Notify user that testing has started.
            notificationBox.Text = "Testing has started. Please wait...";

            // Update the connections and start the motors
            Program.UpdateDeviceConnections();
            Program.startMotors();

            // Printing headers to the file
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(errorFileName, true))
            {
                file.WriteLine("Starting Angle, SN, Errors, Current, Jrk Target, Position (increments of 1/4 us), Jrk Feedback," +
                    "Jrk Scaled Feedback, errorSum, Duty Cycle Target, Duty Cycle, Speed, Acceleration\nStarting test for a target of {0} degrees...");
            }

            //Initialize the startTarget to zero degrees
            startTargetTracker = 9152;
            startTarget = 9152;

            //Initialize the destination target to zero degrees
            destinationTarget = 3776;

            //Start the sequence
            destinationTimer.Start();
        }


        private void printTimer_Tick(object sender, EventArgs e)
        {
            printTimer.Stop();

            // Preparing Jrk and Maestro data input
            jrkVars = Program.Jrk1.getVariables();
            Program.usc.getVariables(out maestroVars, out stack, out call_stack, out servos);

            // Reading Jrk current
            // Easier to store in a variable before sending to the table.
            Program.currentCalibrationForward = (Byte)Program.Jrk1.getJrkParameter(jrkParameter.PARAMETER_MOTOR_CURRENT_CALIBRATION_FORWARD);
            Program.currentCalibrationReverse = (Byte)Program.Jrk1.getJrkParameter(jrkParameter.PARAMETER_MOTOR_CURRENT_CALIBRATION_REVERSE);
            Program.current = Program.currentToMilliamps(Program.Jrk1, jrkVars.current, jrkVars.dutyCycle);

            // Reading Jrk errors
            // It's easier to store them all in one variable before sending to the table.
            Program.errors = "";
            if (1 == (1 & jrkVars.errorFlagBits >> (byte)jrkError.ERROR_AWAITING_COMMAND)) Program.errors += "Awaiting command, ";
            if (1 == (1 & jrkVars.errorFlagBits >> (byte)jrkError.ERROR_NO_POWER)) Program.errors += "No power, ";
            if (1 == (1 & jrkVars.errorFlagBits >> (byte)jrkError.ERROR_MOTOR_DRIVER)) Program.errors += "Motor driver error, ";
            if (1 == (1 & jrkVars.errorFlagBits >> (byte)jrkError.ERROR_INPUT_INVALID)) Program.errors += "Input invalid, ";
            if (1 == (1 & jrkVars.errorFlagBits >> (byte)jrkError.ERROR_INPUT_DISCONNECT)) Program.errors += "Input disconnect";
            if (1 == (1 & jrkVars.errorFlagBits >> (byte)jrkError.ERROR_FEEDBACK_DISCONNECT)) Program.errors += "Feedback disconnect, ";
            if (1 == (1 & jrkVars.errorFlagBits >> (byte)jrkError.ERROR_MAXIMUM_CURRENT_EXCEEDED)) Program.errors += "Max. current exceeded, ";
            if (1 == (1 & jrkVars.errorFlagBits >> (byte)jrkError.ERROR_SERIAL_SIGNAL)) Program.errors += "Serial signal error, ";
            if (1 == (1 & jrkVars.errorFlagBits >> (byte)jrkError.ERROR_SERIAL_OVERRUN)) Program.errors += "Serial overrun, ";
            if (1 == (1 & jrkVars.errorFlagBits >> (byte)jrkError.ERROR_SERIAL_BUFFER_FULL)) Program.errors += "Serial RX buffer full, ";
            if (1 == (1 & jrkVars.errorFlagBits >> (byte)jrkError.ERROR_SERIAL_CRC)) Program.errors += "Serial CRC error, ";
            if (1 == (1 & jrkVars.errorFlagBits >> (byte)jrkError.ERROR_SERIAL_PROTOCOL)) Program.errors += "Serial protocol error, ";
            if (1 == (1 & jrkVars.errorFlagBits >> (byte)jrkError.ERROR_SERIAL_TIMEOUT)) Program.errors += "Serial timeout error, ";

            output = Program.Jrk1.getSerialNumber() + "," + Program.errors + "," + Program.current + "," + jrkVars.target + "," + servos[0].position + "," +
                jrkVars.feedback + "," + jrkVars.scaledFeedback + "," + jrkVars.errorSum + "," + jrkVars.dutyCycleTarget + "," +
                jrkVars.dutyCycle + "," + servos[0].speed + "," + servos[0].acceleration;

            //Print data to the file
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(errorFileName, true))
            {
                file.WriteLine("{0}, {1}", degreeTracker, output);
            }

            //go to next spot
            //Set 0 motor to startTarget
            Program.usc.setTarget((byte)0, (ushort)startTarget);

            //Tracking values to make the loop go through even degree numbers
            startTargetTracker = startTargetTracker - 39.822;
            startTarget = Convert.ToInt32(startTargetTracker);
            degreeTracker++;
            
            if (degreeTracker== 45)
            {
                loopTimer.Interval = (1000) * (3);
                destinationTimer.Interval = (1000) * (3);
            }
            if (degreeTracker == 90)
            {
                loopTimer.Interval = (1000) * (6);
                destinationTimer.Interval = (1000) * (6);
            }
            if (degreeTracker == 135)
            {
                loopTimer.Interval = (1000) * (9);
                destinationTimer.Interval = (1000) * (9);
            }
            if (degreeTracker < 180)
            {
                notification = "Now servicing the starting degree of " + degreeTracker;
                notificationBox.Text = notification;
                destinationTimer.Start();
            }
        }


        void timer_Tick(object sender, EventArgs e)
        {
            destinationTimer.Stop();
            //second motor position
            Program.usc.setTarget((byte)0, (ushort)destinationTarget);
            printTimer.Start();
        }


        //
        //      START MOTORS BUTTON
        //

        // Object: Start Motors Button
        // Action: Click
        private void startMotors_Click(object sender, EventArgs e)
        {
            Program.startMotors();
        }


        //
        //      STOP MOTORS BUTTON
        //

        // Object: Stop Motors Button
        // Action: Click
        private void stopMotors_Click(object sender, EventArgs e)
        {
            Program.stopMotors();
        }


        //
        //      TARGET SELECTOR
        //

        // Object: Target Selector
        // Action: When the value changes
        private void targetSelector_ValueChanged(object sender, EventArgs e)
        {
            Program.usc.setTarget((byte)0, (ushort)(9152-(targetSelector.Value*40)));
        }


        //
        //      START STREAM BUTTON
        //

        // Object: Start Stream Button
        // Action: Click
        private void startStreamButton_Click(object sender, EventArgs e)
        {
            statusUpdateTimer.Enabled = true;
            notificationBox.Text = "Currently streaming data...";
        }


        //
        //      STOP STREAM BUTTON
        //

        // Object: Stop Stream Button
        // Action: Click
        private void stopStreamButton_Click(object sender, EventArgs e)
        {
            statusUpdateTimer.Enabled = false;
            notificationBox.Text = "Data streaming has ended.";
        }


        //
        //      STATUS UPDATE TIMER
        //

        // Object: Status Update Timer
        // Action: This function is called for every tick of the timer
        //          while the timer is enabled.
        private void statusUpdateTimer_Tick(object sender, EventArgs e)
        {
            Program.updateTable(statusDataGrid);
        }


        //
        //      PASSWORD ENABLED CHECKBOX
        //

        // Object: Password Enabled Checkbox
        // Action: Check value changes
        private void pwEnabledBox_CheckedChanged(object sender, EventArgs e)
        {
            Program.pwEnabled = pwEnabledBox.Checked;
        }

        
    }
}