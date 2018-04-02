namespace XmlDeviceSignal
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
            this.btn_LoadDevices = new System.Windows.Forms.Button();
            this.btn_LoadSignals = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_LoadDevices
            // 
            this.btn_LoadDevices.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LoadDevices.Location = new System.Drawing.Point(12, 12);
            this.btn_LoadDevices.Name = "btn_LoadDevices";
            this.btn_LoadDevices.Size = new System.Drawing.Size(156, 39);
            this.btn_LoadDevices.TabIndex = 0;
            this.btn_LoadDevices.Text = "Load devices";
            this.btn_LoadDevices.UseVisualStyleBackColor = true;
            this.btn_LoadDevices.Click += new System.EventHandler(this.btn_LoadDevices_Click);
            // 
            // btn_LoadSignals
            // 
            this.btn_LoadSignals.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LoadSignals.Location = new System.Drawing.Point(174, 12);
            this.btn_LoadSignals.Name = "btn_LoadSignals";
            this.btn_LoadSignals.Size = new System.Drawing.Size(156, 39);
            this.btn_LoadSignals.TabIndex = 1;
            this.btn_LoadSignals.Text = "Load signals";
            this.btn_LoadSignals.UseVisualStyleBackColor = true;
            this.btn_LoadSignals.Click += new System.EventHandler(this.btn_LoadSignals_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "XML Files (*.xml)|*.xml|All Files (*.*)|*.*";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(318, 77);
            this.button1.TabIndex = 2;
            this.button1.Text = "Create website";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(318, 32);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "http://localhost:1002/";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 185);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_LoadSignals);
            this.Controls.Add(this.btn_LoadDevices);
            this.Name = "Form1";
            this.Text = "XmlDeviceSignal by Futupas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_LoadDevices;
        private System.Windows.Forms.Button btn_LoadSignals;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

