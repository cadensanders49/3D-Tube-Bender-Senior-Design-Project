namespace _3DTubeBender
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.toolbar = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.info = new System.Windows.Forms.PictureBox();
            this.settings = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.usbCheck = new System.Windows.Forms.CheckBox();
            this.harmReductionCheck = new System.Windows.Forms.CheckBox();
            this.obstructionCheck = new System.Windows.Forms.CheckBox();
            this.powerCheck = new System.Windows.Forms.CheckBox();
            this.messageBoard = new System.Windows.Forms.Label();
            this.loadButton = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.toolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.info)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settings)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolbar
            // 
            this.toolbar.BackColor = System.Drawing.Color.White;
            this.toolbar.BackgroundImage = global::_3DTubeBender.Properties.Resources.Toolbar;
            this.toolbar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolbar.Controls.Add(this.closeButton);
            this.toolbar.Location = new System.Drawing.Point(-4, 0);
            this.toolbar.Name = "toolbar";
            this.toolbar.Size = new System.Drawing.Size(804, 29);
            this.toolbar.TabIndex = 7;
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(99)))), ((int)(((byte)(150)))));
            this.closeButton.BackgroundImage = global::_3DTubeBender.Properties.Resources.Close___Unhighlighted;
            this.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.closeButton.Location = new System.Drawing.Point(776, 1);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(29, 27);
            this.closeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.closeButton.TabIndex = 4;
            this.closeButton.TabStop = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            this.closeButton.MouseEnter += new System.EventHandler(this.closeButton_MouseEnter);
            this.closeButton.MouseLeave += new System.EventHandler(this.closeButton_MouseLeave);
            // 
            // info
            // 
            this.info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(148)))), ((int)(((byte)(194)))));
            this.info.BackgroundImage = global::_3DTubeBender.Properties.Resources.Info;
            this.info.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.info.Location = new System.Drawing.Point(245, 466);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(31, 31);
            this.info.TabIndex = 6;
            this.info.TabStop = false;
            this.info.Click += new System.EventHandler(this.info_Click);
            this.info.MouseDown += new System.Windows.Forms.MouseEventHandler(this.info_MouseDown);
            this.info.MouseEnter += new System.EventHandler(this.info_MouseEnter);
            this.info.MouseLeave += new System.EventHandler(this.info_MouseLeave);
            this.info.MouseUp += new System.Windows.Forms.MouseEventHandler(this.info_MouseUp);
            // 
            // settings
            // 
            this.settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(148)))), ((int)(((byte)(194)))));
            this.settings.BackgroundImage = global::_3DTubeBender.Properties.Resources.Settings___Unhighlighted;
            this.settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.settings.Location = new System.Drawing.Point(596, 453);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(202, 45);
            this.settings.TabIndex = 5;
            this.settings.TabStop = false;
            this.settings.Click += new System.EventHandler(this.settings_Click);
            this.settings.MouseDown += new System.Windows.Forms.MouseEventHandler(this.settings_MouseDown);
            this.settings.MouseEnter += new System.EventHandler(this.settings_MouseEnter);
            this.settings.MouseLeave += new System.EventHandler(this.settings_MouseLeave);
            this.settings.MouseUp += new System.Windows.Forms.MouseEventHandler(this.settings_MouseUp);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(179)))), ((int)(((byte)(218)))));
            this.panel2.Controls.Add(this.usbCheck);
            this.panel2.Controls.Add(this.harmReductionCheck);
            this.panel2.Controls.Add(this.obstructionCheck);
            this.panel2.Controls.Add(this.powerCheck);
            this.panel2.Location = new System.Drawing.Point(1, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(240, 470);
            this.panel2.TabIndex = 9;
            // 
            // usbCheck
            // 
            this.usbCheck.AutoSize = true;
            this.usbCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usbCheck.Location = new System.Drawing.Point(10, 221);
            this.usbCheck.Name = "usbCheck";
            this.usbCheck.Size = new System.Drawing.Size(208, 36);
            this.usbCheck.TabIndex = 3;
            this.usbCheck.Text = "The tube bender is connected \r\n to this computer through USB.";
            this.usbCheck.UseVisualStyleBackColor = true;
            this.usbCheck.CheckedChanged += new System.EventHandler(this.usbCheck_CheckedChanged);
            // 
            // harmReductionCheck
            // 
            this.harmReductionCheck.AutoSize = true;
            this.harmReductionCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.harmReductionCheck.Location = new System.Drawing.Point(10, 149);
            this.harmReductionCheck.Name = "harmReductionCheck";
            this.harmReductionCheck.Size = new System.Drawing.Size(217, 36);
            this.harmReductionCheck.TabIndex = 2;
            this.harmReductionCheck.Text = " All persons are a safe distance \r\n from any moving parts.";
            this.harmReductionCheck.UseVisualStyleBackColor = true;
            this.harmReductionCheck.CheckedChanged += new System.EventHandler(this.harmReductionCheck_CheckedChanged);
            // 
            // obstructionCheck
            // 
            this.obstructionCheck.AutoSize = true;
            this.obstructionCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.obstructionCheck.Location = new System.Drawing.Point(10, 78);
            this.obstructionCheck.Name = "obstructionCheck";
            this.obstructionCheck.Size = new System.Drawing.Size(204, 36);
            this.obstructionCheck.TabIndex = 1;
            this.obstructionCheck.Text = " All obstructions have been \r\n cleared from the tube bender.";
            this.obstructionCheck.UseVisualStyleBackColor = true;
            this.obstructionCheck.CheckedChanged += new System.EventHandler(this.obstructionCheck_CheckedChanged);
            // 
            // powerCheck
            // 
            this.powerCheck.AutoSize = true;
            this.powerCheck.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.powerCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.powerCheck.Location = new System.Drawing.Point(10, 16);
            this.powerCheck.Name = "powerCheck";
            this.powerCheck.Size = new System.Drawing.Size(208, 36);
            this.powerCheck.TabIndex = 0;
            this.powerCheck.Text = "The tube bender is connected \r\n to power";
            this.powerCheck.UseVisualStyleBackColor = true;
            this.powerCheck.CheckedChanged += new System.EventHandler(this.powerCheck_CheckedChanged);
            // 
            // messageBoard
            // 
            this.messageBoard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(148)))), ((int)(((byte)(194)))));
            this.messageBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageBoard.Location = new System.Drawing.Point(258, 41);
            this.messageBoard.Name = "messageBoard";
            this.messageBoard.Size = new System.Drawing.Size(535, 135);
            this.messageBoard.TabIndex = 11;
            this.messageBoard.Text = resources.GetString("messageBoard.Text");
            // 
            // loadButton
            // 
            this.loadButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(213)))), ((int)(((byte)(239)))));
            this.loadButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.loadButton.Enabled = false;
            this.loadButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.loadButton.FlatAppearance.BorderSize = 2;
            this.loadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadButton.Location = new System.Drawing.Point(438, 213);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(159, 61);
            this.loadButton.TabIndex = 12;
            this.loadButton.Text = "Set System to \r\nLoading Position";
            this.loadButton.UseVisualStyleBackColor = false;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(274, 352);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(494, 22);
            this.progressBar1.TabIndex = 13;
            this.progressBar1.Visible = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::_3DTubeBender.Properties.Resources.New_Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(801, 501);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.info);
            this.Controls.Add(this.settings);
            this.Controls.Add(this.messageBoard);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.toolbar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainWindow";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "3D Tube Bender";
            this.toolbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.info)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settings)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox closeButton;
        private System.Windows.Forms.PictureBox settings;
        private System.Windows.Forms.PictureBox info;
        private System.Windows.Forms.Panel toolbar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox powerCheck;
        private System.Windows.Forms.Label messageBoard;
        private System.Windows.Forms.CheckBox harmReductionCheck;
        private System.Windows.Forms.CheckBox obstructionCheck;
        private System.Windows.Forms.CheckBox usbCheck;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

