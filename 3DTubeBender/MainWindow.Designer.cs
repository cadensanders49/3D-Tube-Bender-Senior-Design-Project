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
            this.BendOptions = new System.Windows.Forms.PictureBox();
            this.ConfigOptions = new System.Windows.Forms.PictureBox();
            this.startBend = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BendOptions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConfigOptions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startBend)).BeginInit();
            this.SuspendLayout();
            // 
            // BendOptions
            // 
            this.BendOptions.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BendOptions.BackgroundImage")));
            this.BendOptions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BendOptions.Location = new System.Drawing.Point(21, 253);
            this.BendOptions.Name = "BendOptions";
            this.BendOptions.Size = new System.Drawing.Size(253, 164);
            this.BendOptions.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BendOptions.TabIndex = 0;
            this.BendOptions.TabStop = false;
            this.BendOptions.Click += new System.EventHandler(this.BendOptions_Click);
            this.BendOptions.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.BendOptions.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // ConfigOptions
            // 
            this.ConfigOptions.BackgroundImage = global::_3DTubeBender.Properties.Resources.Config;
            this.ConfigOptions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ConfigOptions.Location = new System.Drawing.Point(477, 253);
            this.ConfigOptions.Name = "ConfigOptions";
            this.ConfigOptions.Size = new System.Drawing.Size(253, 164);
            this.ConfigOptions.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ConfigOptions.TabIndex = 1;
            this.ConfigOptions.TabStop = false;
            this.ConfigOptions.Click += new System.EventHandler(this.ConfigOptions_Click);
            this.ConfigOptions.MouseEnter += new System.EventHandler(this.ConfigOptions_MouseEnter);
            this.ConfigOptions.MouseLeave += new System.EventHandler(this.ConfigOptions_MouseLeave);
            // 
            // startBend
            // 
            this.startBend.BackgroundImage = global::_3DTubeBender.Properties.Resources.StartBend;
            this.startBend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.startBend.Location = new System.Drawing.Point(442, 12);
            this.startBend.Name = "startBend";
            this.startBend.Size = new System.Drawing.Size(300, 100);
            this.startBend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.startBend.TabIndex = 2;
            this.startBend.TabStop = false;
            this.startBend.Click += new System.EventHandler(this.startBend_Click);
            this.startBend.MouseEnter += new System.EventHandler(this.startBend_MouseEnter);
            this.startBend.MouseLeave += new System.EventHandler(this.startBend_MouseLeave);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::_3DTubeBender.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(754, 429);
            this.Controls.Add(this.startBend);
            this.Controls.Add(this.ConfigOptions);
            this.Controls.Add(this.BendOptions);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "3D Tube Bender";
            ((System.ComponentModel.ISupportInitialize)(this.BendOptions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConfigOptions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startBend)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox BendOptions;
        private System.Windows.Forms.PictureBox ConfigOptions;
        private System.Windows.Forms.PictureBox startBend;
    }
}

