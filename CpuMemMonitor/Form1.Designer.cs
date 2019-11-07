namespace CpuMemMonitor
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBarCpu = new System.Windows.Forms.ProgressBar();
            this.progressBarMem = new System.Windows.Forms.ProgressBar();
            this.buttonStart = new System.Windows.Forms.Button();
            this.CpuUsage = new System.Windows.Forms.Label();
            this.MemUsage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cpu Usage";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Memory Usage";
            // 
            // progressBarCpu
            // 
            this.progressBarCpu.Location = new System.Drawing.Point(12, 25);
            this.progressBarCpu.Name = "progressBarCpu";
            this.progressBarCpu.Size = new System.Drawing.Size(318, 24);
            this.progressBarCpu.TabIndex = 2;
            // 
            // progressBarMem
            // 
            this.progressBarMem.Location = new System.Drawing.Point(12, 88);
            this.progressBarMem.Name = "progressBarMem";
            this.progressBarMem.Size = new System.Drawing.Size(318, 24);
            this.progressBarMem.TabIndex = 3;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(12, 125);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 4;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // CpuUsage
            // 
            this.CpuUsage.AutoSize = true;
            this.CpuUsage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CpuUsage.Location = new System.Drawing.Point(347, 25);
            this.CpuUsage.Name = "CpuUsage";
            this.CpuUsage.Size = new System.Drawing.Size(35, 24);
            this.CpuUsage.TabIndex = 5;
            this.CpuUsage.Text = "0%";
            // 
            // MemUsage
            // 
            this.MemUsage.AutoSize = true;
            this.MemUsage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemUsage.Location = new System.Drawing.Point(347, 88);
            this.MemUsage.Name = "MemUsage";
            this.MemUsage.Size = new System.Drawing.Size(35, 24);
            this.MemUsage.TabIndex = 6;
            this.MemUsage.Text = "0%";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 160);
            this.Controls.Add(this.MemUsage);
            this.Controls.Add(this.CpuUsage);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.progressBarMem);
            this.Controls.Add(this.progressBarCpu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBarCpu;
        private System.Windows.Forms.ProgressBar progressBarMem;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label CpuUsage;
        private System.Windows.Forms.Label MemUsage;
    }
}

