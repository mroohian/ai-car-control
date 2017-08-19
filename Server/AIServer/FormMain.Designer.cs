namespace AIServer {
    partial class FormMain {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.textBoxSensor1 = new System.Windows.Forms.TextBox();
            this.textBoxSensor2 = new System.Windows.Forms.TextBox();
            this.textBoxSensor3 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxSensor5 = new System.Windows.Forms.TextBox();
            this.textBoxSensor7 = new System.Windows.Forms.TextBox();
            this.textBoxSensor6 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSensor4 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(12, 12);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Enabled = false;
            this.buttonStop.Location = new System.Drawing.Point(93, 12);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStop.TabIndex = 1;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // textBoxSensor1
            // 
            this.textBoxSensor1.Location = new System.Drawing.Point(39, 19);
            this.textBoxSensor1.Name = "textBoxSensor1";
            this.textBoxSensor1.ReadOnly = true;
            this.textBoxSensor1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxSensor1.Size = new System.Drawing.Size(75, 20);
            this.textBoxSensor1.TabIndex = 2;
            // 
            // textBoxSensor2
            // 
            this.textBoxSensor2.Location = new System.Drawing.Point(39, 45);
            this.textBoxSensor2.Name = "textBoxSensor2";
            this.textBoxSensor2.ReadOnly = true;
            this.textBoxSensor2.Size = new System.Drawing.Size(75, 20);
            this.textBoxSensor2.TabIndex = 3;
            // 
            // textBoxSensor3
            // 
            this.textBoxSensor3.Location = new System.Drawing.Point(39, 71);
            this.textBoxSensor3.Name = "textBoxSensor3";
            this.textBoxSensor3.ReadOnly = true;
            this.textBoxSensor3.Size = new System.Drawing.Size(75, 20);
            this.textBoxSensor3.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBoxSensor4);
            this.groupBox1.Controls.Add(this.textBoxSensor5);
            this.groupBox1.Controls.Add(this.textBoxSensor7);
            this.groupBox1.Controls.Add(this.textBoxSensor6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxSensor1);
            this.groupBox1.Controls.Add(this.textBoxSensor3);
            this.groupBox1.Controls.Add(this.textBoxSensor2);
            this.groupBox1.Location = new System.Drawing.Point(12, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 130);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sensors";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "3:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "2:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "1:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(126, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "7:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(126, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "6:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(126, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "5:";
            // 
            // textBoxSensor5
            // 
            this.textBoxSensor5.Location = new System.Drawing.Point(148, 19);
            this.textBoxSensor5.Name = "textBoxSensor5";
            this.textBoxSensor5.ReadOnly = true;
            this.textBoxSensor5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxSensor5.Size = new System.Drawing.Size(75, 20);
            this.textBoxSensor5.TabIndex = 8;
            // 
            // textBoxSensor7
            // 
            this.textBoxSensor7.Location = new System.Drawing.Point(148, 71);
            this.textBoxSensor7.Name = "textBoxSensor7";
            this.textBoxSensor7.ReadOnly = true;
            this.textBoxSensor7.Size = new System.Drawing.Size(75, 20);
            this.textBoxSensor7.TabIndex = 10;
            // 
            // textBoxSensor6
            // 
            this.textBoxSensor6.Location = new System.Drawing.Point(148, 45);
            this.textBoxSensor6.Name = "textBoxSensor6";
            this.textBoxSensor6.ReadOnly = true;
            this.textBoxSensor6.Size = new System.Drawing.Size(75, 20);
            this.textBoxSensor6.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "4:";
            // 
            // textBoxSensor4
            // 
            this.textBoxSensor4.Location = new System.Drawing.Point(39, 97);
            this.textBoxSensor4.Name = "textBoxSensor4";
            this.textBoxSensor4.ReadOnly = true;
            this.textBoxSensor4.Size = new System.Drawing.Size(75, 20);
            this.textBoxSensor4.TabIndex = 14;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 245);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.Text = "AI Server";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.TextBox textBoxSensor1;
        private System.Windows.Forms.TextBox textBoxSensor2;
        private System.Windows.Forms.TextBox textBoxSensor3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxSensor4;
        private System.Windows.Forms.TextBox textBoxSensor5;
        private System.Windows.Forms.TextBox textBoxSensor7;
        private System.Windows.Forms.TextBox textBoxSensor6;
    }
}

