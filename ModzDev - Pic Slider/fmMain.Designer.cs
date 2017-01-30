namespace ModzDev___Pic_Slider
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.tbDir = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.cbStretch = new System.Windows.Forms.CheckBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslSize = new System.Windows.Forms.ToolStripStatusLabel();
            this.cbPreview = new System.Windows.Forms.CheckBox();
            this.cbLoop = new System.Windows.Forms.CheckBox();
            this.bRef = new System.Windows.Forms.Button();
            this.bRemove = new System.Windows.Forms.Button();
            this.pbPreview = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bStart = new System.Windows.Forms.Button();
            this.bDown = new System.Windows.Forms.Button();
            this.bUp = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbDir
            // 
            this.tbDir.Location = new System.Drawing.Point(13, 11);
            this.tbDir.Name = "tbDir";
            this.tbDir.Size = new System.Drawing.Size(443, 20);
            this.tbDir.TabIndex = 0;
            this.tbDir.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbDir_KeyUp);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(461, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(223, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.Enabled = false;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Instructions",
            "-------------------------------",
            "",
            "#Main Window",
            "-Up, Move up list",
            "-Down, Move down list",
            "-X, Removes item from list only",
            "-Refresh, Refreshes list as per directory.",
            "-Play, Begin Slideshow",
            "-Stretch, Strech image",
            "-Preview, Enable mini preview window",
            "-Loop, Loop slide show",
            "",
            "#Slide Show Window",
            "Left & Right, Change image",
            "Up & Down, Change view from normal to stretch",
            "Space, Change view to FIT.",
            "Escape & Click, close window.",
            "",
            "Created by Pranashan Moodley",
            "https://github.com/waynemodz"});
            this.listBox1.Location = new System.Drawing.Point(12, 34);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(443, 394);
            this.listBox1.TabIndex = 2;
            this.listBox1.Click += new System.EventHandler(this.listBox1_Click);
            this.listBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.listBox1_KeyUp);
            // 
            // cbStretch
            // 
            this.cbStretch.AutoSize = true;
            this.cbStretch.Enabled = false;
            this.cbStretch.Location = new System.Drawing.Point(461, 92);
            this.cbStretch.Name = "cbStretch";
            this.cbStretch.Size = new System.Drawing.Size(60, 17);
            this.cbStretch.TabIndex = 5;
            this.cbStretch.Text = "Stretch";
            this.cbStretch.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslSize});
            this.statusStrip1.Location = new System.Drawing.Point(0, 436);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(702, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslSize
            // 
            this.tsslSize.Name = "tsslSize";
            this.tsslSize.Size = new System.Drawing.Size(0, 17);
            // 
            // cbPreview
            // 
            this.cbPreview.AutoSize = true;
            this.cbPreview.Enabled = false;
            this.cbPreview.Location = new System.Drawing.Point(527, 92);
            this.cbPreview.Name = "cbPreview";
            this.cbPreview.Size = new System.Drawing.Size(64, 17);
            this.cbPreview.TabIndex = 10;
            this.cbPreview.Text = "Preview";
            this.cbPreview.UseVisualStyleBackColor = true;
            this.cbPreview.Click += new System.EventHandler(this.listBox1_Click);
            // 
            // cbLoop
            // 
            this.cbLoop.AutoSize = true;
            this.cbLoop.Enabled = false;
            this.cbLoop.Location = new System.Drawing.Point(599, 92);
            this.cbLoop.Name = "cbLoop";
            this.cbLoop.Size = new System.Drawing.Size(50, 17);
            this.cbLoop.TabIndex = 14;
            this.cbLoop.Text = "Loop";
            this.cbLoop.UseVisualStyleBackColor = true;
            // 
            // bRef
            // 
            this.bRef.Enabled = false;
            this.bRef.FlatAppearance.BorderSize = 0;
            this.bRef.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.bRef.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.bRef.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bRef.Image = global::ModzDev___Pic_Slider.Properties.Resources.btref;
            this.bRef.Location = new System.Drawing.Point(599, 40);
            this.bRef.Name = "bRef";
            this.bRef.Size = new System.Drawing.Size(40, 40);
            this.bRef.TabIndex = 13;
            this.bRef.UseVisualStyleBackColor = true;
            this.bRef.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // bRemove
            // 
            this.bRemove.Enabled = false;
            this.bRemove.FlatAppearance.BorderSize = 0;
            this.bRemove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.bRemove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.bRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bRemove.Image = global::ModzDev___Pic_Slider.Properties.Resources.btdel;
            this.bRemove.Location = new System.Drawing.Point(553, 40);
            this.bRemove.Name = "bRemove";
            this.bRemove.Size = new System.Drawing.Size(40, 40);
            this.bRemove.TabIndex = 12;
            this.bRemove.UseVisualStyleBackColor = true;
            this.bRemove.Click += new System.EventHandler(this.btRemove_Click);
            // 
            // pbPreview
            // 
            this.pbPreview.Location = new System.Drawing.Point(461, 115);
            this.pbPreview.Name = "pbPreview";
            this.pbPreview.Size = new System.Drawing.Size(223, 202);
            this.pbPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPreview.TabIndex = 11;
            this.pbPreview.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.ErrorImage = global::ModzDev___Pic_Slider.Properties.Resources.logo_v1_50P;
            this.pictureBox1.Image = global::ModzDev___Pic_Slider.Properties.Resources.logo_v1_50P;
            this.pictureBox1.Location = new System.Drawing.Point(461, 320);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(221, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // bStart
            // 
            this.bStart.Enabled = false;
            this.bStart.FlatAppearance.BorderSize = 0;
            this.bStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.bStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.bStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bStart.Image = global::ModzDev___Pic_Slider.Properties.Resources.slider;
            this.bStart.Location = new System.Drawing.Point(644, 40);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(40, 40);
            this.bStart.TabIndex = 6;
            this.bStart.UseVisualStyleBackColor = true;
            this.bStart.Click += new System.EventHandler(this.Start_Click);
            // 
            // bDown
            // 
            this.bDown.Enabled = false;
            this.bDown.FlatAppearance.BorderSize = 0;
            this.bDown.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.bDown.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.bDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bDown.Font = new System.Drawing.Font("Webdings", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.bDown.Image = global::ModzDev___Pic_Slider.Properties.Resources.btDown;
            this.bDown.Location = new System.Drawing.Point(507, 40);
            this.bDown.Name = "bDown";
            this.bDown.Size = new System.Drawing.Size(40, 40);
            this.bDown.TabIndex = 4;
            this.bDown.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bDown.UseVisualStyleBackColor = true;
            this.bDown.Click += new System.EventHandler(this.button2_Click);
            // 
            // bUp
            // 
            this.bUp.Enabled = false;
            this.bUp.FlatAppearance.BorderSize = 0;
            this.bUp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.bUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.bUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bUp.Font = new System.Drawing.Font("Webdings", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.bUp.Image = global::ModzDev___Pic_Slider.Properties.Resources.btup;
            this.bUp.Location = new System.Drawing.Point(461, 40);
            this.bUp.Name = "bUp";
            this.bUp.Size = new System.Drawing.Size(40, 40);
            this.bUp.TabIndex = 3;
            this.bUp.UseVisualStyleBackColor = true;
            this.bUp.Click += new System.EventHandler(this.Up_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 458);
            this.Controls.Add(this.cbLoop);
            this.Controls.Add(this.bRef);
            this.Controls.Add(this.bRemove);
            this.Controls.Add(this.pbPreview);
            this.Controls.Add(this.cbPreview);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bStart);
            this.Controls.Add(this.cbStretch);
            this.Controls.Add(this.bDown);
            this.Controls.Add(this.bUp);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbDir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MSharp Pic Slider";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox tbDir;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button bUp;
        private System.Windows.Forms.Button bDown;
        private System.Windows.Forms.CheckBox cbStretch;
        private System.Windows.Forms.Button bStart;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.CheckBox cbPreview;
        private System.Windows.Forms.PictureBox pbPreview;
        private System.Windows.Forms.Button bRemove;
        private System.Windows.Forms.Button bRef;
        private System.Windows.Forms.CheckBox cbLoop;
        private System.Windows.Forms.ToolStripStatusLabel tsslSize;
    }
}

