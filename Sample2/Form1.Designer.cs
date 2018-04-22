namespace Sample2
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
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBlock = new System.Windows.Forms.TextBox();
            this.txtNonce = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDificulty = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCharacter = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnMine = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblDuration2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.lblValid = new System.Windows.Forms.Label();
            this.txtHash = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data";
            // 
            // txtTexto
            // 
            this.txtTexto.Location = new System.Drawing.Point(132, 12);
            this.txtTexto.Multiline = true;
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(543, 116);
            this.txtTexto.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Block #";
            // 
            // txtBlock
            // 
            this.txtBlock.Location = new System.Drawing.Point(132, 145);
            this.txtBlock.Name = "txtBlock";
            this.txtBlock.Size = new System.Drawing.Size(134, 26);
            this.txtBlock.TabIndex = 3;
            this.txtBlock.Text = "1";
            // 
            // txtNonce
            // 
            this.txtNonce.Location = new System.Drawing.Point(132, 194);
            this.txtNonce.Name = "txtNonce";
            this.txtNonce.Size = new System.Drawing.Size(134, 26);
            this.txtNonce.TabIndex = 5;
            this.txtNonce.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nonce";
            // 
            // txtDificulty
            // 
            this.txtDificulty.Location = new System.Drawing.Point(541, 145);
            this.txtDificulty.Name = "txtDificulty";
            this.txtDificulty.Size = new System.Drawing.Size(134, 26);
            this.txtDificulty.TabIndex = 7;
            this.txtDificulty.Text = "4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(431, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Dificulty";
            // 
            // txtCharacter
            // 
            this.txtCharacter.Location = new System.Drawing.Point(541, 188);
            this.txtCharacter.Name = "txtCharacter";
            this.txtCharacter.Size = new System.Drawing.Size(134, 26);
            this.txtCharacter.TabIndex = 9;
            this.txtCharacter.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(431, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Character";
            // 
            // btnMine
            // 
            this.btnMine.Location = new System.Drawing.Point(26, 324);
            this.btnMine.Name = "btnMine";
            this.btnMine.Size = new System.Drawing.Size(199, 63);
            this.btnMine.TabIndex = 10;
            this.btnMine.Text = "Mine";
            this.btnMine.UseVisualStyleBackColor = true;
            this.btnMine.Click += new System.EventHandler(this.btnMine_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Hash";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(293, 324);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Duration";
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Location = new System.Drawing.Point(431, 324);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(0, 20);
            this.lblDuration.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 408);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 63);
            this.button1.TabIndex = 10;
            this.button1.Text = "Mine Parallel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblDuration2
            // 
            this.lblDuration2.AutoSize = true;
            this.lblDuration2.Location = new System.Drawing.Point(431, 408);
            this.lblDuration2.Name = "lblDuration2";
            this.lblDuration2.Size = new System.Drawing.Size(0, 20);
            this.lblDuration2.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(293, 408);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 20);
            this.label12.TabIndex = 17;
            this.label12.Text = "Duration";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(26, 491);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(199, 63);
            this.button2.TabIndex = 32;
            this.button2.Text = "Validate";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblValid
            // 
            this.lblValid.AutoSize = true;
            this.lblValid.Location = new System.Drawing.Point(293, 512);
            this.lblValid.Name = "lblValid";
            this.lblValid.Size = new System.Drawing.Size(0, 20);
            this.lblValid.TabIndex = 33;
            // 
            // txtHash
            // 
            this.txtHash.Location = new System.Drawing.Point(132, 251);
            this.txtHash.Name = "txtHash";
            this.txtHash.Size = new System.Drawing.Size(543, 26);
            this.txtHash.TabIndex = 34;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 575);
            this.Controls.Add(this.txtHash);
            this.Controls.Add(this.lblValid);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblDuration2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnMine);
            this.Controls.Add(this.txtCharacter);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDificulty);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNonce);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBlock);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTexto);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Sample2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTexto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBlock;
        private System.Windows.Forms.TextBox txtNonce;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDificulty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCharacter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnMine;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblDuration2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblValid;
        private System.Windows.Forms.TextBox txtHash;
    }
}

