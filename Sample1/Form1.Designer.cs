namespace Sample1
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
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.btnMD5 = new System.Windows.Forms.Button();
            this.lblMD5Hash = new System.Windows.Forms.Label();
            this.lblSHA1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblSHA256 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.lblSHA384 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.lblSHA512 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTexto
            // 
            this.txtTexto.Location = new System.Drawing.Point(38, 22);
            this.txtTexto.Multiline = true;
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(889, 116);
            this.txtTexto.TabIndex = 0;
            // 
            // btnMD5
            // 
            this.btnMD5.Location = new System.Drawing.Point(38, 169);
            this.btnMD5.Name = "btnMD5";
            this.btnMD5.Size = new System.Drawing.Size(199, 63);
            this.btnMD5.TabIndex = 1;
            this.btnMD5.Text = "MD5 Hash";
            this.btnMD5.UseVisualStyleBackColor = true;
            this.btnMD5.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblMD5Hash
            // 
            this.lblMD5Hash.AutoSize = true;
            this.lblMD5Hash.Location = new System.Drawing.Point(255, 190);
            this.lblMD5Hash.Name = "lblMD5Hash";
            this.lblMD5Hash.Size = new System.Drawing.Size(0, 20);
            this.lblMD5Hash.TabIndex = 2;
            // 
            // lblSHA1
            // 
            this.lblSHA1.AutoSize = true;
            this.lblSHA1.Location = new System.Drawing.Point(255, 274);
            this.lblSHA1.Name = "lblSHA1";
            this.lblSHA1.Size = new System.Drawing.Size(0, 20);
            this.lblSHA1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(38, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 63);
            this.button1.TabIndex = 3;
            this.button1.Text = "SHA1 Hash";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lblSHA256
            // 
            this.lblSHA256.AutoSize = true;
            this.lblSHA256.Location = new System.Drawing.Point(255, 368);
            this.lblSHA256.Name = "lblSHA256";
            this.lblSHA256.Size = new System.Drawing.Size(0, 20);
            this.lblSHA256.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(38, 347);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(199, 63);
            this.button2.TabIndex = 5;
            this.button2.Text = "SHA256 Hash";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblSHA384
            // 
            this.lblSHA384.AutoSize = true;
            this.lblSHA384.Location = new System.Drawing.Point(255, 464);
            this.lblSHA384.Name = "lblSHA384";
            this.lblSHA384.Size = new System.Drawing.Size(0, 20);
            this.lblSHA384.TabIndex = 8;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(38, 443);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(199, 63);
            this.button3.TabIndex = 7;
            this.button3.Text = "SHA384 Hash";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblSHA512
            // 
            this.lblSHA512.AutoSize = true;
            this.lblSHA512.Location = new System.Drawing.Point(255, 553);
            this.lblSHA512.Name = "lblSHA512";
            this.lblSHA512.Size = new System.Drawing.Size(0, 20);
            this.lblSHA512.TabIndex = 10;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(38, 532);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(199, 63);
            this.button4.TabIndex = 9;
            this.button4.Text = "SHA512 Hash";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1520, 669);
            this.Controls.Add(this.lblSHA512);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.lblSHA384);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.lblSHA256);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblSHA1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblMD5Hash);
            this.Controls.Add(this.btnMD5);
            this.Controls.Add(this.txtTexto);
            this.Name = "Form1";
            this.Text = "Sample1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTexto;
        private System.Windows.Forms.Button btnMD5;
        private System.Windows.Forms.Label lblMD5Hash;
        private System.Windows.Forms.Label lblSHA1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblSHA256;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblSHA384;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblSHA512;
        private System.Windows.Forms.Button button4;
    }
}

