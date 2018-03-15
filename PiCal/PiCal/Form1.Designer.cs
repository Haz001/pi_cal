namespace PiCal
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
            this.components = new System.ComponentModel.Container();
            this.startworker = new System.Windows.Forms.Button();
            this.pi_box = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // startworker
            // 
            this.startworker.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.startworker.Location = new System.Drawing.Point(0, 207);
            this.startworker.Name = "startworker";
            this.startworker.Size = new System.Drawing.Size(284, 54);
            this.startworker.TabIndex = 0;
            this.startworker.Text = "Run";
            this.startworker.UseVisualStyleBackColor = true;
            this.startworker.Click += new System.EventHandler(this.startworker_Click);
            // 
            // pi_box
            // 
            this.pi_box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pi_box.Location = new System.Drawing.Point(0, 0);
            this.pi_box.Multiline = true;
            this.pi_box.Name = "pi_box";
            this.pi_box.Size = new System.Drawing.Size(284, 207);
            this.pi_box.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.pi_box);
            this.Controls.Add(this.startworker);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startworker;
        private System.Windows.Forms.TextBox pi_box;
        private System.Windows.Forms.Timer timer1;
    }
}

