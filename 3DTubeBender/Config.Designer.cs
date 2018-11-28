namespace _3DTubeBender
{
    partial class Config
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.status = new System.Windows.Forms.Button();
            this.clearErrors = new System.Windows.Forms.Button();
            this.uploadConfiguration = new System.Windows.Forms.Button();
            this.downloadConfiguration = new System.Windows.Forms.Button();
            this.firmwareUpdate = new System.Windows.Forms.Button();
            this.done = new System.Windows.Forms.Button();
            this.statusDataGrid = new System.Windows.Forms.DataGridView();
            this.jrkDataSource = new System.Windows.Forms.BindingSource(this.components);
            this.errorTesting = new System.Windows.Forms.Button();
            this.notificationBox = new System.Windows.Forms.TextBox();
            this.errorTestingFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.startMotors = new System.Windows.Forms.Button();
            this.stopMotors = new System.Windows.Forms.Button();
            this.targetSelector = new System.Windows.Forms.NumericUpDown();
            this.targetSelectorLabel = new System.Windows.Forms.Label();
            this.startStreamButton = new System.Windows.Forms.Button();
            this.stopStreamButton = new System.Windows.Forms.Button();
            this.statusUpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.pwEnabledBox = new System.Windows.Forms.CheckBox();
            this.printTimer = new System.Windows.Forms.Timer(this.components);
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.statusDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jrkDataSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.targetSelector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // status
            // 
            this.status.Location = new System.Drawing.Point(12, 103);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(124, 23);
            this.status.TabIndex = 0;
            this.status.Text = "Update Status";
            this.status.UseVisualStyleBackColor = true;
            this.status.Click += new System.EventHandler(this.status_Click);
            // 
            // clearErrors
            // 
            this.clearErrors.Location = new System.Drawing.Point(12, 375);
            this.clearErrors.Name = "clearErrors";
            this.clearErrors.Size = new System.Drawing.Size(96, 23);
            this.clearErrors.TabIndex = 1;
            this.clearErrors.Text = "Clear Errors";
            this.clearErrors.UseVisualStyleBackColor = true;
            this.clearErrors.Click += new System.EventHandler(this.clearErrors_Click);
            // 
            // uploadConfiguration
            // 
            this.uploadConfiguration.Location = new System.Drawing.Point(618, 155);
            this.uploadConfiguration.Name = "uploadConfiguration";
            this.uploadConfiguration.Size = new System.Drawing.Size(158, 23);
            this.uploadConfiguration.TabIndex = 2;
            this.uploadConfiguration.Text = "Upload Configuration";
            this.uploadConfiguration.UseVisualStyleBackColor = true;
            this.uploadConfiguration.Click += new System.EventHandler(this.uploadConfiguration_Click);
            // 
            // downloadConfiguration
            // 
            this.downloadConfiguration.Location = new System.Drawing.Point(618, 126);
            this.downloadConfiguration.Name = "downloadConfiguration";
            this.downloadConfiguration.Size = new System.Drawing.Size(158, 23);
            this.downloadConfiguration.TabIndex = 3;
            this.downloadConfiguration.Text = "Download Configuration";
            this.downloadConfiguration.UseVisualStyleBackColor = true;
            this.downloadConfiguration.Click += new System.EventHandler(this.downloadConfiguration_Click);
            // 
            // firmwareUpdate
            // 
            this.firmwareUpdate.Location = new System.Drawing.Point(618, 97);
            this.firmwareUpdate.Name = "firmwareUpdate";
            this.firmwareUpdate.Size = new System.Drawing.Size(158, 23);
            this.firmwareUpdate.TabIndex = 4;
            this.firmwareUpdate.Text = "Firmware Update";
            this.firmwareUpdate.UseVisualStyleBackColor = true;
            this.firmwareUpdate.Click += new System.EventHandler(this.firmwareUpdate_Click);
            // 
            // done
            // 
            this.done.Location = new System.Drawing.Point(675, 375);
            this.done.Name = "done";
            this.done.Size = new System.Drawing.Size(101, 23);
            this.done.TabIndex = 5;
            this.done.Text = "Done";
            this.done.UseVisualStyleBackColor = true;
            this.done.Click += new System.EventHandler(this.done_Click);
            // 
            // statusDataGrid
            // 
            this.statusDataGrid.AllowUserToAddRows = false;
            this.statusDataGrid.AllowUserToDeleteRows = false;
            this.statusDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.statusDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.statusDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.statusDataGrid.ColumnHeadersVisible = false;
            this.statusDataGrid.Location = new System.Drawing.Point(159, 132);
            this.statusDataGrid.Name = "statusDataGrid";
            this.statusDataGrid.ReadOnly = true;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.statusDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.statusDataGrid.RowHeadersVisible = false;
            this.statusDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.statusDataGrid.Size = new System.Drawing.Size(424, 295);
            this.statusDataGrid.TabIndex = 7;
            // 
            // errorTesting
            // 
            this.errorTesting.Location = new System.Drawing.Point(618, 184);
            this.errorTesting.Name = "errorTesting";
            this.errorTesting.Size = new System.Drawing.Size(158, 23);
            this.errorTesting.TabIndex = 8;
            this.errorTesting.Text = "Error Testing";
            this.errorTesting.UseVisualStyleBackColor = true;
            this.errorTesting.Click += new System.EventHandler(this.errorTesting_Click);
            // 
            // notificationBox
            // 
            this.notificationBox.Location = new System.Drawing.Point(159, 99);
            this.notificationBox.Name = "notificationBox";
            this.notificationBox.Size = new System.Drawing.Size(424, 20);
            this.notificationBox.TabIndex = 9;
            this.notificationBox.Text = "Notification Box...";
            // 
            // startMotors
            // 
            this.startMotors.Location = new System.Drawing.Point(377, 61);
            this.startMotors.Name = "startMotors";
            this.startMotors.Size = new System.Drawing.Size(103, 23);
            this.startMotors.TabIndex = 10;
            this.startMotors.Text = "Start Motors";
            this.startMotors.UseVisualStyleBackColor = true;
            this.startMotors.Click += new System.EventHandler(this.startMotors_Click);
            // 
            // stopMotors
            // 
            this.stopMotors.Location = new System.Drawing.Point(486, 61);
            this.stopMotors.Name = "stopMotors";
            this.stopMotors.Size = new System.Drawing.Size(96, 23);
            this.stopMotors.TabIndex = 11;
            this.stopMotors.Text = "Stop Motors";
            this.stopMotors.UseVisualStyleBackColor = true;
            this.stopMotors.Click += new System.EventHandler(this.stopMotors_Click);
            // 
            // targetSelector
            // 
            this.targetSelector.Location = new System.Drawing.Point(618, 267);
            this.targetSelector.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.targetSelector.Name = "targetSelector";
            this.targetSelector.Size = new System.Drawing.Size(47, 20);
            this.targetSelector.TabIndex = 12;
            this.targetSelector.ValueChanged += new System.EventHandler(this.targetSelector_ValueChanged);
            // 
            // targetSelectorLabel
            // 
            this.targetSelectorLabel.AutoSize = true;
            this.targetSelectorLabel.Location = new System.Drawing.Point(615, 251);
            this.targetSelectorLabel.Name = "targetSelectorLabel";
            this.targetSelectorLabel.Size = new System.Drawing.Size(111, 13);
            this.targetSelectorLabel.TabIndex = 13;
            this.targetSelectorLabel.Text = "Motor Angle Selection";
            // 
            // startStreamButton
            // 
            this.startStreamButton.Location = new System.Drawing.Point(12, 132);
            this.startStreamButton.Name = "startStreamButton";
            this.startStreamButton.Size = new System.Drawing.Size(124, 25);
            this.startStreamButton.TabIndex = 14;
            this.startStreamButton.Text = "Start Streaming Status";
            this.startStreamButton.UseVisualStyleBackColor = true;
            this.startStreamButton.Click += new System.EventHandler(this.startStreamButton_Click);
            // 
            // stopStreamButton
            // 
            this.stopStreamButton.Location = new System.Drawing.Point(12, 163);
            this.stopStreamButton.Name = "stopStreamButton";
            this.stopStreamButton.Size = new System.Drawing.Size(124, 24);
            this.stopStreamButton.TabIndex = 15;
            this.stopStreamButton.Text = "Stop Streaming Status";
            this.stopStreamButton.UseVisualStyleBackColor = true;
            this.stopStreamButton.Click += new System.EventHandler(this.stopStreamButton_Click);
            // 
            // statusUpdateTimer
            // 
            this.statusUpdateTimer.Interval = 300;
            this.statusUpdateTimer.Tick += new System.EventHandler(this.statusUpdateTimer_Tick);
            // 
            // pwEnabledBox
            // 
            this.pwEnabledBox.AutoSize = true;
            this.pwEnabledBox.Checked = true;
            this.pwEnabledBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.pwEnabledBox.Location = new System.Drawing.Point(618, 327);
            this.pwEnabledBox.Name = "pwEnabledBox";
            this.pwEnabledBox.Size = new System.Drawing.Size(108, 17);
            this.pwEnabledBox.TabIndex = 16;
            this.pwEnabledBox.Text = "Enable Password";
            this.pwEnabledBox.UseVisualStyleBackColor = true;
            this.pwEnabledBox.CheckedChanged += new System.EventHandler(this.pwEnabledBox_CheckedChanged);
            // 
            // printTimer
            // 
            this.printTimer.Interval = 10000;
            this.printTimer.Tick += new System.EventHandler(this.printTimer_Tick);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(99)))), ((int)(((byte)(150)))));
            this.closeButton.BackgroundImage = global::_3DTubeBender.Properties.Resources.Close___Unhighlighted;
            this.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.closeButton.Location = new System.Drawing.Point(779, 1);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(29, 27);
            this.closeButton.TabIndex = 18;
            this.closeButton.TabStop = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            this.closeButton.MouseEnter += new System.EventHandler(this.closeButton_MouseEnter);
            this.closeButton.MouseLeave += new System.EventHandler(this.closeButton_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImage = global::_3DTubeBender.Properties.Resources.Toolbar;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.closeButton);
            this.panel1.Location = new System.Drawing.Point(-4, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(808, 29);
            this.panel1.TabIndex = 19;
            // 
            // Config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::_3DTubeBender.Properties.Resources.New_Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(805, 505);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pwEnabledBox);
            this.Controls.Add(this.stopStreamButton);
            this.Controls.Add(this.startStreamButton);
            this.Controls.Add(this.targetSelectorLabel);
            this.Controls.Add(this.targetSelector);
            this.Controls.Add(this.stopMotors);
            this.Controls.Add(this.startMotors);
            this.Controls.Add(this.notificationBox);
            this.Controls.Add(this.errorTesting);
            this.Controls.Add(this.clearErrors);
            this.Controls.Add(this.status);
            this.Controls.Add(this.downloadConfiguration);
            this.Controls.Add(this.firmwareUpdate);
            this.Controls.Add(this.uploadConfiguration);
            this.Controls.Add(this.statusDataGrid);
            this.Controls.Add(this.done);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Config";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "System Configuration";
            ((System.ComponentModel.ISupportInitialize)(this.statusDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jrkDataSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.targetSelector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button status;
        private System.Windows.Forms.Button clearErrors;
        private System.Windows.Forms.Button uploadConfiguration;
        private System.Windows.Forms.Button downloadConfiguration;
        private System.Windows.Forms.Button firmwareUpdate;
        private System.Windows.Forms.Button done;
        private System.Windows.Forms.BindingSource jrkDataSource;
        private System.Windows.Forms.Button errorTesting;
        private System.Windows.Forms.TextBox notificationBox;
        private System.Windows.Forms.OpenFileDialog errorTestingFileDialog;
        private System.Windows.Forms.Button startMotors;
        private System.Windows.Forms.Button stopMotors;
        private System.Windows.Forms.NumericUpDown targetSelector;
        private System.Windows.Forms.Label targetSelectorLabel;
        private System.Windows.Forms.Button startStreamButton;
        private System.Windows.Forms.Button stopStreamButton;
        public System.Windows.Forms.DataGridView statusDataGrid;
        private System.Windows.Forms.Timer statusUpdateTimer;
        private System.Windows.Forms.CheckBox pwEnabledBox;
        private System.Windows.Forms.Timer printTimer;
        private System.Windows.Forms.PictureBox closeButton;
        private System.Windows.Forms.Panel panel1;
    }
}