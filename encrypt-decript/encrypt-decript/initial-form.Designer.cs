namespace encrypt_decript
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.Key = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.inputTextPlain = new System.Windows.Forms.TextBox();
            this.outputEncrypt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.Location = new System.Drawing.Point(515, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 49);
            this.button1.TabIndex = 0;
            this.button1.Text = "ENCRYPT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Location = new System.Drawing.Point(515, 146);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 51);
            this.button2.TabIndex = 1;
            this.button2.Text = "DECRYPT";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(116, 38);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(380, 23);
            this.txtKey.TabIndex = 2;
            // 
            // Key
            // 
            this.Key.AutoSize = true;
            this.Key.Location = new System.Drawing.Point(72, 38);
            this.Key.Name = "Key";
            this.Key.Size = new System.Drawing.Size(26, 15);
            this.Key.TabIndex = 3;
            this.Key.Text = "Key";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Input ";
            // 
            // inputTextPlain
            // 
            this.inputTextPlain.Location = new System.Drawing.Point(116, 82);
            this.inputTextPlain.Multiline = true;
            this.inputTextPlain.Name = "inputTextPlain";
            this.inputTextPlain.Size = new System.Drawing.Size(380, 79);
            this.inputTextPlain.TabIndex = 5;
            this.inputTextPlain.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // outputEncrypt
            // 
            this.outputEncrypt.BackColor = System.Drawing.SystemColors.Info;
            this.outputEncrypt.Location = new System.Drawing.Point(116, 193);
            this.outputEncrypt.Multiline = true;
            this.outputEncrypt.Name = "outputEncrypt";
            this.outputEncrypt.Size = new System.Drawing.Size(380, 103);
            this.outputEncrypt.TabIndex = 5;
            this.outputEncrypt.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Result";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(178, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 15);
            this.label3.TabIndex = 6;
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(629, 323);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.outputEncrypt);
            this.Controls.Add(this.inputTextPlain);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Key);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Encrypt - Decript";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Label Key;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputTextPlain;
        private System.Windows.Forms.TextBox outputEncrypt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

