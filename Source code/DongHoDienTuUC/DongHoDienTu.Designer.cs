namespace DongHoDienTuUC
{
    partial class DongHoDienTu
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pbMinute1 = new System.Windows.Forms.PictureBox();
            this.pbMinute2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbSecond2 = new System.Windows.Forms.PictureBox();
            this.pbSecond1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numMinutes = new System.Windows.Forms.NumericUpDown();
            this.numSeconds = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinute1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinute2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSecond2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSecond1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSeconds)).BeginInit();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // pbMinute1
            // 
            this.pbMinute1.Image = global::DongHoDienTuUC.Properties.Resources._0;
            this.pbMinute1.Location = new System.Drawing.Point(4, 4);
            this.pbMinute1.Name = "pbMinute1";
            this.pbMinute1.Size = new System.Drawing.Size(18, 23);
            this.pbMinute1.TabIndex = 0;
            this.pbMinute1.TabStop = false;
            // 
            // pbMinute2
            // 
            this.pbMinute2.Image = global::DongHoDienTuUC.Properties.Resources._0;
            this.pbMinute2.Location = new System.Drawing.Point(28, 4);
            this.pbMinute2.Name = "pbMinute2";
            this.pbMinute2.Size = new System.Drawing.Size(18, 23);
            this.pbMinute2.TabIndex = 1;
            this.pbMinute2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.pbSecond2);
            this.panel1.Controls.Add(this.pbSecond1);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pbMinute2);
            this.panel1.Controls.Add(this.pbMinute1);
            this.panel1.Location = new System.Drawing.Point(89, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(123, 31);
            this.panel1.TabIndex = 2;
            // 
            // pbSecond2
            // 
            this.pbSecond2.Image = global::DongHoDienTuUC.Properties.Resources._0;
            this.pbSecond2.Location = new System.Drawing.Point(100, 4);
            this.pbSecond2.Name = "pbSecond2";
            this.pbSecond2.Size = new System.Drawing.Size(18, 23);
            this.pbSecond2.TabIndex = 4;
            this.pbSecond2.TabStop = false;
            // 
            // pbSecond1
            // 
            this.pbSecond1.Image = global::DongHoDienTuUC.Properties.Resources._0;
            this.pbSecond1.Location = new System.Drawing.Point(76, 4);
            this.pbSecond1.Name = "pbSecond1";
            this.pbSecond1.Size = new System.Drawing.Size(18, 23);
            this.pbSecond1.TabIndex = 3;
            this.pbSecond1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::DongHoDienTuUC.Properties.Resources._;
            this.pictureBox3.Location = new System.Drawing.Point(52, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(18, 23);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Minutes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(86, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Seconds";
            // 
            // numMinutes
            // 
            this.numMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.numMinutes.Location = new System.Drawing.Point(164, 52);
            this.numMinutes.Name = "numMinutes";
            this.numMinutes.Size = new System.Drawing.Size(48, 26);
            this.numMinutes.TabIndex = 13;
            this.numMinutes.ValueChanged += new System.EventHandler(this.numMinutes_ValueChanged);
            // 
            // numSeconds
            // 
            this.numSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.numSeconds.Location = new System.Drawing.Point(164, 86);
            this.numSeconds.Name = "numSeconds";
            this.numSeconds.Size = new System.Drawing.Size(48, 26);
            this.numSeconds.TabIndex = 14;
            this.numSeconds.ValueChanged += new System.EventHandler(this.numSeconds_ValueChanged);
            // 
            // DongHoDienTu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.numSeconds);
            this.Controls.Add(this.numMinutes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "DongHoDienTu";
            this.Size = new System.Drawing.Size(283, 131);
            ((System.ComponentModel.ISupportInitialize)(this.pbMinute1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinute2)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbSecond2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSecond1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSeconds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox pbMinute1;
        private System.Windows.Forms.PictureBox pbMinute2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbSecond2;
        private System.Windows.Forms.PictureBox pbSecond1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numMinutes;
        private System.Windows.Forms.NumericUpDown numSeconds;
    }
}
