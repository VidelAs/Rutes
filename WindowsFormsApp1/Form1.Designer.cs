namespace WindowsFormsApp1
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
            this.btn_Application = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_runcalcu = new System.Windows.Forms.Button();
            this.process1 = new System.Diagnostics.Process();
            this.SuspendLayout();
            // 
            // btn_Application
            // 
            this.btn_Application.Location = new System.Drawing.Point(26, 152);
            this.btn_Application.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Application.Name = "btn_Application";
            this.btn_Application.Size = new System.Drawing.Size(183, 39);
            this.btn_Application.TabIndex = 0;
            this.btn_Application.Text = "Application";
            this.btn_Application.UseVisualStyleBackColor = true;
            this.btn_Application.Click += new System.EventHandler(this.btn_Application_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(26, 97);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(651, 24);
            this.textBox1.TabIndex = 1;
            // 
            // btn_runcalcu
            // 
            this.btn_runcalcu.Location = new System.Drawing.Point(494, 152);
            this.btn_runcalcu.Margin = new System.Windows.Forms.Padding(4);
            this.btn_runcalcu.Name = "btn_runcalcu";
            this.btn_runcalcu.Size = new System.Drawing.Size(183, 39);
            this.btn_runcalcu.TabIndex = 2;
            this.btn_runcalcu.Text = "Run Calculator";
            this.btn_runcalcu.UseVisualStyleBackColor = true;
            this.btn_runcalcu.Click += new System.EventHandler(this.btn_runcalcu_Click);
            // 
            // process1
            // 
            this.process1.StartInfo.Domain = "";
            this.process1.StartInfo.LoadUserProfile = false;
            this.process1.StartInfo.Password = null;
            this.process1.StartInfo.StandardErrorEncoding = null;
            this.process1.StartInfo.StandardOutputEncoding = null;
            this.process1.StartInfo.UserName = "";
            this.process1.SynchronizingObject = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 242);
            this.Controls.Add(this.btn_runcalcu);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_Application);
            this.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Application;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_runcalcu;
        private System.Diagnostics.Process process1;
    }
}

