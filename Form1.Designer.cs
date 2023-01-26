namespace SysChroma
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.checkBoxCPU = new System.Windows.Forms.CheckBox();
            this.checkBoxRAM = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.checkBoxGPU = new System.Windows.Forms.CheckBox();
            this.checkBoxThermals = new System.Windows.Forms.CheckBox();
            this.labelCPU = new System.Windows.Forms.Label();
            this.labelRAM = new System.Windows.Forms.Label();
            this.labelGPU = new System.Windows.Forms.Label();
            this.labelThermals = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkBoxCPU
            // 
            this.checkBoxCPU.AutoSize = true;
            this.checkBoxCPU.Location = new System.Drawing.Point(12, 12);
            this.checkBoxCPU.Name = "checkBoxCPU";
            this.checkBoxCPU.Size = new System.Drawing.Size(49, 19);
            this.checkBoxCPU.TabIndex = 0;
            this.checkBoxCPU.Text = "CPU";
            this.checkBoxCPU.UseVisualStyleBackColor = true;
            // 
            // checkBoxRAM
            // 
            this.checkBoxRAM.AutoSize = true;
            this.checkBoxRAM.Location = new System.Drawing.Point(12, 37);
            this.checkBoxRAM.Name = "checkBoxRAM";
            this.checkBoxRAM.Size = new System.Drawing.Size(52, 19);
            this.checkBoxRAM.TabIndex = 1;
            this.checkBoxRAM.Text = "RAM";
            this.checkBoxRAM.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // checkBoxGPU
            // 
            this.checkBoxGPU.AutoSize = true;
            this.checkBoxGPU.Location = new System.Drawing.Point(12, 62);
            this.checkBoxGPU.Name = "checkBoxGPU";
            this.checkBoxGPU.Size = new System.Drawing.Size(49, 19);
            this.checkBoxGPU.TabIndex = 2;
            this.checkBoxGPU.Text = "GPU";
            this.checkBoxGPU.UseVisualStyleBackColor = true;
            // 
            // checkBoxThermals
            // 
            this.checkBoxThermals.AutoSize = true;
            this.checkBoxThermals.Location = new System.Drawing.Point(12, 87);
            this.checkBoxThermals.Name = "checkBoxThermals";
            this.checkBoxThermals.Size = new System.Drawing.Size(74, 19);
            this.checkBoxThermals.TabIndex = 3;
            this.checkBoxThermals.Text = "Thermals";
            this.checkBoxThermals.UseVisualStyleBackColor = true;
            // 
            // labelCPU
            // 
            this.labelCPU.AutoSize = true;
            this.labelCPU.Location = new System.Drawing.Point(168, 13);
            this.labelCPU.Name = "labelCPU";
            this.labelCPU.Size = new System.Drawing.Size(38, 15);
            this.labelCPU.TabIndex = 4;
            this.labelCPU.Text = "label1";
            this.labelCPU.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelRAM
            // 
            this.labelRAM.AutoSize = true;
            this.labelRAM.Location = new System.Drawing.Point(168, 38);
            this.labelRAM.Name = "labelRAM";
            this.labelRAM.Size = new System.Drawing.Size(38, 15);
            this.labelRAM.TabIndex = 5;
            this.labelRAM.Text = "label2";
            this.labelRAM.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelGPU
            // 
            this.labelGPU.AutoSize = true;
            this.labelGPU.Location = new System.Drawing.Point(168, 63);
            this.labelGPU.Name = "labelGPU";
            this.labelGPU.Size = new System.Drawing.Size(38, 15);
            this.labelGPU.TabIndex = 6;
            this.labelGPU.Text = "label3";
            this.labelGPU.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelThermals
            // 
            this.labelThermals.AutoSize = true;
            this.labelThermals.Location = new System.Drawing.Point(168, 88);
            this.labelThermals.Name = "labelThermals";
            this.labelThermals.Size = new System.Drawing.Size(38, 15);
            this.labelThermals.TabIndex = 7;
            this.labelThermals.Text = "label4";
            this.labelThermals.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 115);
            this.Controls.Add(this.labelThermals);
            this.Controls.Add(this.labelGPU);
            this.Controls.Add(this.labelRAM);
            this.Controls.Add(this.labelCPU);
            this.Controls.Add(this.checkBoxThermals);
            this.Controls.Add(this.checkBoxGPU);
            this.Controls.Add(this.checkBoxRAM);
            this.Controls.Add(this.checkBoxCPU);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckBox checkBoxCPU;
        private CheckBox checkBoxRAM;
        private System.Windows.Forms.Timer timer1;
        private CheckBox checkBoxGPU;
        private CheckBox checkBoxThermals;
        private Label labelCPU;
        private Label labelRAM;
        private Label labelGPU;
        private Label labelThermals;
    }
}