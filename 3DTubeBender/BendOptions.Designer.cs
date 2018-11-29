namespace _3DTubeBender
{
    partial class BendOptions
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
            this.manualBendFile = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.doneButton = new System.Windows.Forms.Button();
            this.toolbar = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.harmReductionCheck = new System.Windows.Forms.CheckBox();
            this.obstructionCheck = new System.Windows.Forms.CheckBox();
            this.loadCheck = new System.Windows.Forms.CheckBox();
            this.startBend = new System.Windows.Forms.Button();
            this.messageBoard = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // manualBendFile
            // 
            this.manualBendFile.Location = new System.Drawing.Point(12, 415);
            this.manualBendFile.Name = "manualBendFile";
            this.manualBendFile.Size = new System.Drawing.Size(167, 23);
            this.manualBendFile.TabIndex = 0;
            this.manualBendFile.Text = "Choose a Manual Bend File";
            this.manualBendFile.UseVisualStyleBackColor = true;
            this.manualBendFile.Click += new System.EventHandler(this.manualBendFile_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // doneButton
            // 
            this.doneButton.Location = new System.Drawing.Point(714, 466);
            this.doneButton.Name = "doneButton";
            this.doneButton.Size = new System.Drawing.Size(75, 23);
            this.doneButton.TabIndex = 1;
            this.doneButton.Text = "Home";
            this.doneButton.UseVisualStyleBackColor = true;
            this.doneButton.Click += new System.EventHandler(this.doneButton_Click);
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(179)))), ((int)(((byte)(218)))));
            this.panel2.Controls.Add(this.harmReductionCheck);
            this.panel2.Controls.Add(this.obstructionCheck);
            this.panel2.Controls.Add(this.loadCheck);
            this.panel2.Location = new System.Drawing.Point(1, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(240, 470);
            this.panel2.TabIndex = 10;
            // 
            // harmReductionCheck
            // 
            this.harmReductionCheck.AutoSize = true;
            this.harmReductionCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.harmReductionCheck.Location = new System.Drawing.Point(12, 217);
            this.harmReductionCheck.Name = "harmReductionCheck";
            this.harmReductionCheck.Size = new System.Drawing.Size(217, 36);
            this.harmReductionCheck.TabIndex = 3;
            this.harmReductionCheck.Text = " All persons are a safe distance \r\n from any moving parts.";
            this.harmReductionCheck.UseVisualStyleBackColor = true;
            this.harmReductionCheck.CheckedChanged += new System.EventHandler(this.harmReductionCheck_CheckedChanged);
            // 
            // obstructionCheck
            // 
            this.obstructionCheck.AutoSize = true;
            this.obstructionCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.obstructionCheck.Location = new System.Drawing.Point(11, 119);
            this.obstructionCheck.Name = "obstructionCheck";
            this.obstructionCheck.Size = new System.Drawing.Size(204, 36);
            this.obstructionCheck.TabIndex = 2;
            this.obstructionCheck.Text = " All obstructions have been \r\n cleared from the tube bender.";
            this.obstructionCheck.UseVisualStyleBackColor = true;
            this.obstructionCheck.CheckedChanged += new System.EventHandler(this.obstructionCheck_CheckedChanged);
            // 
            // loadCheck
            // 
            this.loadCheck.AutoSize = true;
            this.loadCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadCheck.Location = new System.Drawing.Point(11, 25);
            this.loadCheck.Name = "loadCheck";
            this.loadCheck.Size = new System.Drawing.Size(195, 36);
            this.loadCheck.TabIndex = 0;
            this.loadCheck.Text = "The tube is loaded properly \r\ninto the system.";
            this.loadCheck.UseVisualStyleBackColor = true;
            this.loadCheck.CheckedChanged += new System.EventHandler(this.loadCheck_CheckedChanged);
            // 
            // startBend
            // 
            this.startBend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(213)))), ((int)(((byte)(239)))));
            this.startBend.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.startBend.Enabled = false;
            this.startBend.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.startBend.FlatAppearance.BorderSize = 2;
            this.startBend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startBend.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBend.Location = new System.Drawing.Point(442, 404);
            this.startBend.Name = "startBend";
            this.startBend.Size = new System.Drawing.Size(124, 44);
            this.startBend.TabIndex = 13;
            this.startBend.Text = "Start Bending";
            this.startBend.UseVisualStyleBackColor = false;
            this.startBend.Click += new System.EventHandler(this.startBend_Click);
            // 
            // messageBoard
            // 
            this.messageBoard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(148)))), ((int)(((byte)(194)))));
            this.messageBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageBoard.Location = new System.Drawing.Point(247, 41);
            this.messageBoard.Name = "messageBoard";
            this.messageBoard.Size = new System.Drawing.Size(535, 135);
            this.messageBoard.TabIndex = 14;
            this.messageBoard.Text = "The system is now in the loading position. Verify that the tube is loaded by chec" +
    "king the boxes on the left. Once finished, click the button below to start bendi" +
    "ng the tube.";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(325, 189);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 15;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // BendOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::_3DTubeBender.Properties.Resources.New_Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(801, 501);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.messageBoard);
            this.Controls.Add(this.startBend);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.toolbar);
            this.Controls.Add(this.doneButton);
            this.Controls.Add(this.manualBendFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BendOptions";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Bend Options";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button manualBendFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button doneButton;
        private System.Windows.Forms.Panel toolbar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button startBend;
        private System.Windows.Forms.Label messageBoard;
        private System.Windows.Forms.CheckBox loadCheck;
        private System.Windows.Forms.CheckBox obstructionCheck;
        private System.Windows.Forms.CheckBox harmReductionCheck;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}