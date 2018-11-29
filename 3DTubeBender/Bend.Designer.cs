namespace _3DTubeBender
{
    partial class Bend
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
            this.statusDataGrid = new System.Windows.Forms.DataGridView();
            this.notificationBox = new System.Windows.Forms.TextBox();
            this.toolbar = new System.Windows.Forms.Panel();
            this.statusUpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.jrkDataSource = new System.Windows.Forms.BindingSource(this.components);
            this.emergencyStopButton = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.statusDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jrkDataSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emergencyStopButton)).BeginInit();
            this.SuspendLayout();
            // 
            // statusDataGrid
            // 
            this.statusDataGrid.AllowUserToAddRows = false;
            this.statusDataGrid.AllowUserToDeleteRows = false;
            this.statusDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.statusDataGrid.Location = new System.Drawing.Point(12, 97);
            this.statusDataGrid.Name = "statusDataGrid";
            this.statusDataGrid.ReadOnly = true;
            this.statusDataGrid.Size = new System.Drawing.Size(776, 341);
            this.statusDataGrid.TabIndex = 0;
            // 
            // notificationBox
            // 
            this.notificationBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notificationBox.Location = new System.Drawing.Point(225, 38);
            this.notificationBox.Multiline = true;
            this.notificationBox.Name = "notificationBox";
            this.notificationBox.Size = new System.Drawing.Size(563, 53);
            this.notificationBox.TabIndex = 3;
            this.notificationBox.Text = "Notification Box...";
            // 
            // toolbar
            // 
            this.toolbar.BackColor = System.Drawing.Color.White;
            this.toolbar.BackgroundImage = global::_3DTubeBender.Properties.Resources.Toolbar;
            this.toolbar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolbar.Location = new System.Drawing.Point(-4, 0);
            this.toolbar.Name = "toolbar";
            this.toolbar.Size = new System.Drawing.Size(804, 29);
            this.toolbar.TabIndex = 8;
            // 
            // statusUpdateTimer
            // 
            this.statusUpdateTimer.Interval = 300;
            this.statusUpdateTimer.Tick += new System.EventHandler(this.statusUpdateTimer_Tick);
            // 
            // emergencyStopButton
            // 
            this.emergencyStopButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(148)))), ((int)(((byte)(194)))));
            this.emergencyStopButton.BackgroundImage = global::_3DTubeBender.Properties.Resources.Emergency_Stop;
            this.emergencyStopButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.emergencyStopButton.Location = new System.Drawing.Point(12, 38);
            this.emergencyStopButton.Name = "emergencyStopButton";
            this.emergencyStopButton.Size = new System.Drawing.Size(207, 56);
            this.emergencyStopButton.TabIndex = 10;
            this.emergencyStopButton.TabStop = false;
            this.emergencyStopButton.Click += new System.EventHandler(this.emergencyStopButton_Click);
            this.emergencyStopButton.MouseEnter += new System.EventHandler(this.emergencyStopButton_MouseEnter);
            this.emergencyStopButton.MouseLeave += new System.EventHandler(this.emergencyStopButton_MouseLeave);
            // 
            // Bend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::_3DTubeBender.Properties.Resources.New_Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.emergencyStopButton);
            this.Controls.Add(this.toolbar);
            this.Controls.Add(this.notificationBox);
            this.Controls.Add(this.statusDataGrid);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Bend";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Bend";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.statusDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jrkDataSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emergencyStopButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView statusDataGrid;
        private System.Windows.Forms.TextBox notificationBox;
        private System.Windows.Forms.Panel toolbar;
        private System.Windows.Forms.Timer statusUpdateTimer;
        private System.Windows.Forms.BindingSource jrkDataSource;
        private System.Windows.Forms.PictureBox emergencyStopButton;
    }
}