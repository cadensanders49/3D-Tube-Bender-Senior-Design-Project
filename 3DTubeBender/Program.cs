// 3D Tube Bender Program class
//
// Authors: Caden Sanders
//
// This is where the main control class for the program is.
// Program includes many public variables and functions
// which can be called by other classes. This is where
// instantiations of each Jrk and Maestro is made. The 
// devices need to be disconnected and reconnected in
// various places to operate properly.


using Pololu.Jrk;                   // A class library for all Jrks
using Pololu.UsbWrapper;            // A library for serial communication through USB
using Pololu.Usc;                   // A class library for all Maestros
using Pololu.Usc.Bytecode;

// The following are System libraries
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace _3DTubeBender
{
    // Class with lots of public functions
    // and variables for the rest of the solution.
    static class Program
    {
        public static string fileName = "";
        public static int NumOfConnectedJrks;
        public static int NumOfConnectedMaestros;
        public static Jrk Jrk1;
        public static Jrk Jrk2;
        public static Jrk Jrk3;
        public static Jrk Jrk4;
        public static Usc usc;
        public static DataTable statusValues = new DataTable();
        private static DeviceListItem item = null;
        private static DeviceListItem item1 = null;
        public static string errors;
        public static int current;
        public static jrkVariables jrkVars;
        public static Byte currentCalibrationForward;
        public static Byte currentCalibrationReverse;
        public static MaestroVariables maestroVars;
        public static ServoStatus[] servos;
        public static short[] stack;
        public static ushort[] call_stack;
        public static bool pwEnabled;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Automatic code generated for UI
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // The table for data viewing is created right away to be used in any other class
            CreateTable();

            //Determines if the pw is inherently enabled
            pwEnabled = false;

            // It's important to disconnect from devices, if needed
            // There will be an error if the devices are connected elsewhere.
            // This function will disconnect all devices as well as reconnect them.
            UpdateDeviceConnections();

            // Main window is opened
            Application.Run(new MainWindow());
        }

        // This function is called when the device connections need to be updated.
        public static void UpdateDeviceConnections()
        {
            // Start by removing any previous connections.
            disconnectDevices();
            
            // Preparing a list of all of the currently connected devices.
            List<DeviceListItem> listOfJrks = Jrk.getConnectedDevices();
            List<DeviceListItem> listOfMaestros = Usc.getConnectedDevices();

            // Store the number of connected devices in these public
            // variables for use throughout all classes.
            NumOfConnectedJrks = listOfJrks.Count;
            NumOfConnectedMaestros = listOfMaestros.Count;

            // Attempting to connect to all available devices.
            if (NumOfConnectedMaestros > 0)
            {
                item1 = listOfMaestros[0];
                usc = new Usc(item1);
            }
            else
            {
                MessageBox.Show("There are no Maestros connected, so no operations can be done. Please connect to a Maestro and try again.");
                return;
            }

            if (NumOfConnectedJrks > 0)
            {
                item = listOfJrks[0];
                Jrk1 = new Jrk(item);
            }
            else
            {
                MessageBox.Show("There are no Jrks connected, so no operations can be done. Please connect to a Jrk and try again.");
                return;
            }
            if (NumOfConnectedJrks > 1)
            {
                item = listOfJrks[1];
                Jrk2 = new Jrk(item);
            }
            if (NumOfConnectedJrks > 2)
            {
                item = listOfJrks[2];
                Jrk3 = new Jrk(item);
            }
            if (NumOfConnectedJrks > 3)
            {
                item = listOfJrks[3];
                Jrk4 = new Jrk(item);
            }
        }

        // Disconnects all devices that are currently connected.
        public static void disconnectDevices()
        {
            if (NumOfConnectedMaestros > 0)
            {
                usc.disconnect();
            }
            if (NumOfConnectedJrks > 0)
            {
                Jrk1.disconnect();
            }
            if (NumOfConnectedJrks > 1)
            {
                Jrk2.disconnect();
            }
            if (NumOfConnectedJrks > 2)
            {
                Jrk3.disconnect();
            }
            if (NumOfConnectedJrks > 3)
            {
                Jrk4.disconnect();
            }
        }

        // Used to set up the data viewing table for use
        // in other classes.
        private static void CreateTable()
        {
            statusValues.Columns.Add("Device Type", typeof(string));
            statusValues.Columns.Add("Serial Number", typeof(string));
            statusValues.Columns.Add("Errors", typeof(string));
            statusValues.Columns.Add("Scripting Target", typeof(int));
            statusValues.Columns.Add("PWM Period", typeof(string));
            statusValues.Columns.Add("Jrk Target", typeof(int));
            statusValues.Columns.Add("Jrk Scaled Feedback (Actual Target)", typeof(int));
            statusValues.Columns.Add("Jrk Feedback", typeof(int));
            statusValues.Columns.Add("Jrk Integral", typeof(int));
            statusValues.Columns.Add("Jrk Duty Cycle Target", typeof(int));
            statusValues.Columns.Add("Jrk Duty Cycle", typeof(int));
            statusValues.Columns.Add("Acceleration", typeof(int));
            statusValues.Columns.Add("Speed", typeof(int));
            statusValues.Columns.Add("Scaled Current", typeof(int));
        }

        // Pulls data from the devices and places it in the table created earlier.
        public static void updateTable(DataGridView dataTable)
        {
            DataTable flippedStatusValues = new DataTable();
            string period;

            //
            // PULLING DATA FROM MAESTRO
            //
            statusValues.Clear();
            if (NumOfConnectedMaestros > 0)
            {
                usc.getVariables(out maestroVars, out stack, out call_stack, out servos);
                errors = "";
                foreach (var error in Enum.GetValues(typeof(uscError)))
                {
                    if ((maestroVars.errors & (1 << (int)(uscError)error)) != 0)
                    {
                        errors += (error.ToString() + ", ");
                    }
                }
                //
                //
                // Need to add data information for other values, if needed
                //
                //
                statusValues.Rows.Add("Maestro", usc.getSerialNumber(), errors, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1);
            }
            // Case for when there are no connected Maestros
            else
            {
                statusValues.Rows.Add("Maestro", "No Maestros Found", "", -1, -1, -1, -1, -1, -1, -1, -1, -1, -1);
            }

            //
            // PULLING DATA FROM JRK 1
            //
            if (Program.NumOfConnectedJrks > 0 && usc.servoCount>0)
            {
                // Preparing Jrk data input
                jrkVars = Jrk1.getVariables();

                // Reading Jrk current
                // Easier to store in a variable before sending to the table.
                currentCalibrationForward = (Byte)Jrk1.getJrkParameter(jrkParameter.PARAMETER_MOTOR_CURRENT_CALIBRATION_FORWARD);
                currentCalibrationReverse = (Byte)Jrk1.getJrkParameter(jrkParameter.PARAMETER_MOTOR_CURRENT_CALIBRATION_REVERSE);
                current = currentToMilliamps(Jrk1, jrkVars.current, jrkVars.dutyCycle);

                // Reading Jrk errors
                // It's easier to store them all in one variable before sending to the table.
                errors = "";
                if (1 == (1 & jrkVars.errorFlagBits >> (byte)jrkError.ERROR_AWAITING_COMMAND)) errors += "Awaiting command, ";
                if (1 == (1 & jrkVars.errorFlagBits >> (byte)jrkError.ERROR_NO_POWER)) errors += "No power, ";
                if (1 == (1 & jrkVars.errorFlagBits >> (byte)jrkError.ERROR_MOTOR_DRIVER)) errors += "Motor driver error, ";
                if (1 == (1 & jrkVars.errorFlagBits >> (byte)jrkError.ERROR_INPUT_INVALID)) errors += "Input invalid, ";
                if (1 == (1 & jrkVars.errorFlagBits >> (byte)jrkError.ERROR_INPUT_DISCONNECT)) errors += "Input disconnect";
                if (1 == (1 & jrkVars.errorFlagBits >> (byte)jrkError.ERROR_FEEDBACK_DISCONNECT)) errors += "Feedback disconnect, ";
                if (1 == (1 & jrkVars.errorFlagBits >> (byte)jrkError.ERROR_MAXIMUM_CURRENT_EXCEEDED)) errors += "Max. current exceeded, ";
                if (1 == (1 & jrkVars.errorFlagBits >> (byte)jrkError.ERROR_SERIAL_SIGNAL)) errors += "Serial signal error, ";
                if (1 == (1 & jrkVars.errorFlagBits >> (byte)jrkError.ERROR_SERIAL_OVERRUN)) errors += "Serial overrun, ";
                if (1 == (1 & jrkVars.errorFlagBits >> (byte)jrkError.ERROR_SERIAL_BUFFER_FULL)) errors += "Serial RX buffer full, ";
                if (1 == (1 & jrkVars.errorFlagBits >> (byte)jrkError.ERROR_SERIAL_CRC)) errors += "Serial CRC error, ";
                if (1 == (1 & jrkVars.errorFlagBits >> (byte)jrkError.ERROR_SERIAL_PROTOCOL)) errors += "Serial protocol error, ";
                if (1 == (1 & jrkVars.errorFlagBits >> (byte)jrkError.ERROR_SERIAL_TIMEOUT)) errors += "Serial timeout error, ";

                period = servos[0].position * 0.25 + " microseconds";

                //Setting up the table with values
                statusValues.Rows.Add("Jrk", Jrk1.getSerialNumber(), errors, servos[0].position, period, jrkVars.target, jrkVars.scaledFeedback, jrkVars.feedback,
                    jrkVars.errorSum, jrkVars.dutyCycleTarget, jrkVars.dutyCycle, servos[0].speed, servos[0].acceleration, current);
            }
            else
            {
                statusValues.Rows.Add("Jrk","No Jrks Found");
            }

            //
            // PULLING DATA FROM JRK 2
            //
            if (Program.NumOfConnectedJrks > 1)
            {
                //Preparing Jrk data input
                jrkVars = Jrk2.getVariables();

                //Reading Jrk current
                // Easier to store in a variable before sending to the table.
                currentCalibrationForward = (Byte)Jrk2.getJrkParameter(jrkParameter.PARAMETER_MOTOR_CURRENT_CALIBRATION_FORWARD);
                currentCalibrationReverse = (Byte)Jrk2.getJrkParameter(jrkParameter.PARAMETER_MOTOR_CURRENT_CALIBRATION_REVERSE);
                current = currentToMilliamps(Jrk2, jrkVars.current, jrkVars.dutyCycle);

                //Reading Jrk errors
                // It's easier to store them all in one variable before sending to the table.
                errors = "";
                if (1 == (1 & jrkVars.errorFlagBits >> (byte)jrkError.ERROR_AWAITING_COMMAND)) errors += "Awaiting command, ";
                if (1 == (1 & jrkVars.errorFlagBits >> (byte)jrkError.ERROR_NO_POWER)) errors += "No power, ";
                if (1 == (1 & jrkVars.errorFlagBits >> (byte)jrkError.ERROR_MOTOR_DRIVER)) errors += "Motor driver error, ";
                if (1 == (1 & jrkVars.errorFlagBits >> (byte)jrkError.ERROR_INPUT_INVALID)) errors += "Input invalid, ";
                if (1 == (1 & jrkVars.errorFlagBits >> (byte)jrkError.ERROR_INPUT_DISCONNECT)) errors += "Input disconnect";
                if (1 == (1 & jrkVars.errorFlagBits >> (byte)jrkError.ERROR_FEEDBACK_DISCONNECT)) errors += "Feedback disconnect, ";
                if (1 == (1 & jrkVars.errorFlagBits >> (byte)jrkError.ERROR_MAXIMUM_CURRENT_EXCEEDED)) errors += "Max. current exceeded, ";
                if (1 == (1 & jrkVars.errorFlagBits >> (byte)jrkError.ERROR_SERIAL_SIGNAL)) errors += "Serial signal error, ";
                if (1 == (1 & jrkVars.errorFlagBits >> (byte)jrkError.ERROR_SERIAL_OVERRUN)) errors += "Serial overrun, ";
                if (1 == (1 & jrkVars.errorFlagBits >> (byte)jrkError.ERROR_SERIAL_BUFFER_FULL)) errors += "Serial RX buffer full, ";
                if (1 == (1 & jrkVars.errorFlagBits >> (byte)jrkError.ERROR_SERIAL_CRC)) errors += "Serial CRC error, ";
                if (1 == (1 & jrkVars.errorFlagBits >> (byte)jrkError.ERROR_SERIAL_PROTOCOL)) errors += "Serial protocol error, ";
                if (1 == (1 & jrkVars.errorFlagBits >> (byte)jrkError.ERROR_SERIAL_TIMEOUT)) errors += "Serial timeout error, ";

                period = servos[1].position * 0.25 + " microseconds";

                //Setting up the table with values
                statusValues.Rows.Add("Jrk", Jrk1.getSerialNumber(), errors, servos[1].position, period,jrkVars.target, jrkVars.scaledFeedback, jrkVars.feedback,
                    jrkVars.errorSum, jrkVars.dutyCycleTarget, jrkVars.dutyCycle, servos[1].speed, servos[1].acceleration, current);

            }

            //Future extension to more devices
            /*
            if (Program.NumOfConnectedJrks > 2)
            {
            }
            if (Program.NumOfConnectedJrks > 3)
            {
            }
            */
            
            flippedStatusValues.Columns.Add("");
            string deviceTrack = "";

            for (int i = 0; i < statusValues.Rows.Count; i++)
            {
                deviceTrack = "Device " + i;
                flippedStatusValues.Columns.Add(deviceTrack);
            }

            for (int i = 0; i < statusValues.Columns.Count; i++)
            {
                DataRow newRow = flippedStatusValues.NewRow();

                newRow[0] = statusValues.Columns[i].Caption;
                for (int j = 0; j < statusValues.Rows.Count; j++)
                    newRow[j + 1] = statusValues.Rows[j][i];
                flippedStatusValues.Rows.Add(newRow);
            }

            // Configuring the table to show the data
            dataTable.DataSource = flippedStatusValues;
        }

        // Function used for converting serial data to readable current data.
        public static int currentToMilliamps(Jrk jrk, byte rawCurrent, short dutyCycle)
        {
            int current = rawCurrent;

            if (dutyCycle > 0)
            {
                current *= currentCalibrationForward;
            }
            else
            {
                current *= currentCalibrationReverse;
            }

            if (jrk.divideCurrent)
            {
                if (dutyCycle == 0)
                {
                    current = 0;
                }
                else
                {
                    current = (current * 600) / dutyCycle;
                }
            }
            return current;
        }

        // Starts the motor
        public static void startMotors()
        {
            if (NumOfConnectedJrks > 0)
            {
                UInt16 target = Jrk1.getVariables().target;
                Jrk1.setTarget(target);
            }
            if (NumOfConnectedJrks > 1)
            {
                UInt16 target = Jrk2.getVariables().target;
                Jrk2.setTarget(target);
            }
            if (NumOfConnectedJrks > 2)
            {
                UInt16 target = Jrk3.getVariables().target;
                Jrk3.setTarget(target);
            }
            if (NumOfConnectedJrks > 3)
            {
                UInt16 target = Jrk4.getVariables().target;
                Jrk4.setTarget(target);
            }
        }

        //Stops the motor
        public static void stopMotors()
        {
            if (NumOfConnectedJrks > 0)
            {
                Jrk1.motorOff();
            }
            if (NumOfConnectedJrks > 1)
            {
                Jrk2.motorOff();
            }
            if (NumOfConnectedJrks > 2)
            {
                Jrk3.motorOff(); ;
            }
            if (NumOfConnectedJrks > 3)
            {
                Jrk4.motorOff();
            }
        }

        // Clears all Jrk and Maestro errors
        public static void clearAllErrors()
        {
            if (NumOfConnectedMaestros > 0)
            {
                usc.clearErrors();
            }
            if (NumOfConnectedJrks > 0)
            {
                Jrk1.clearErrors();
            }
            if (NumOfConnectedJrks > 1)
            {
                Jrk2.clearErrors();
            }
            if (NumOfConnectedJrks > 2)
            {
                Jrk3.clearErrors();
            }
            if (NumOfConnectedJrks > 3)
            {
                Jrk4.clearErrors();
            }
            if (NumOfConnectedJrks == 0)
            {
                MessageBox.Show("No Jrks Found");
            }
            else
                MessageBox.Show("All Jrk and Maestro errors have been cleared.");
        }

        // function for evaluating a text file program for the motors
        public static void runScript(Usc usc, string fileName)
        {
            //Getting program text from text file
            string text = new StreamReader(fileName).ReadToEnd();
            MessageBox.Show(text);
            BytecodeProgram program = BytecodeReader.Read(text, usc.servoCount != 6);
            BytecodeReader.WriteListing(program, fileName + ".lst");

            // Stops any previous scripts that are running
            usc.setScriptDone(1);

            // ???
            usc.eraseScript();
            List<byte> byteList = program.getByteList();
            if (byteList.Count > usc.maxScriptLength)
            {
                MessageBox.Show("Script too long for device (" + byteList.Count + " bytes)");
            }
            if (byteList.Count < usc.maxScriptLength)
            {
                byteList.Add((byte)Opcode.QUIT);
            }
            // Setting up subroutines
            usc.setSubroutines(program.subroutineAddresses, program.subroutineCommands);
            // Loading the bytes
            usc.writeScript(byteList);
            // Restarting
            usc.reinitialize();
        }
    }
}
