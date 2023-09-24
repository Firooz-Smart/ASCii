namespace ASCII_Converter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtdecimal = new System.Windows.Forms.TextBox();
            this.txtbase4 = new System.Windows.Forms.TextBox();
            this.txthex = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblhex = new System.Windows.Forms.Label();
            this.Binary = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.txtbinary = new System.Windows.Forms.TextBox();
            this.txtoctal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtdecimal
            // 
            this.txtdecimal.Location = new System.Drawing.Point(143, 57);
            this.txtdecimal.Name = "txtdecimal";
            this.txtdecimal.Size = new System.Drawing.Size(116, 20);
            this.txtdecimal.TabIndex = 0;
            this.txtdecimal.TextChanged += new System.EventHandler(this.txtdecimal_TextChanged);
            // 
            // txtbase4
            // 
            this.txtbase4.Location = new System.Drawing.Point(143, 109);
            this.txtbase4.Name = "txtbase4";
            this.txtbase4.Size = new System.Drawing.Size(116, 20);
            this.txtbase4.TabIndex = 2;
            this.txtbase4.TextChanged += new System.EventHandler(this.txtbase4_TextChanged);
            // 
            // txthex
            // 
            this.txthex.Location = new System.Drawing.Point(143, 161);
            this.txthex.Name = "txthex";
            this.txthex.Size = new System.Drawing.Size(116, 20);
            this.txthex.TabIndex = 4;
            this.txthex.TextChanged += new System.EventHandler(this.txthex_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(91, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Decimal";
            // 
            // lblhex
            // 
            this.lblhex.AutoSize = true;
            this.lblhex.BackColor = System.Drawing.Color.Transparent;
            this.lblhex.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblhex.Location = new System.Drawing.Point(91, 164);
            this.lblhex.Name = "lblhex";
            this.lblhex.Size = new System.Drawing.Size(32, 13);
            this.lblhex.TabIndex = 6;
            this.lblhex.Text = "Hexa";
            // 
            // Binary
            // 
            this.Binary.AutoSize = true;
            this.Binary.BackColor = System.Drawing.Color.Transparent;
            this.Binary.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Binary.Location = new System.Drawing.Point(91, 86);
            this.Binary.Name = "Binary";
            this.Binary.Size = new System.Drawing.Size(36, 13);
            this.Binary.TabIndex = 7;
            this.Binary.Text = "Binary";
            this.Binary.Click += new System.EventHandler(this.Binary_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Location = new System.Drawing.Point(91, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Base4";
            // 
            // txt
            // 
            this.txt.AutoSize = true;
            this.txt.BackColor = System.Drawing.Color.Transparent;
            this.txt.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.txt.Location = new System.Drawing.Point(91, 135);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(38, 13);
            this.txt.TabIndex = 9;
            this.txt.Text = "Octal  ";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.BackColor = System.Drawing.Color.Transparent;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(178, 185);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 10;
            // 
            // txtbinary
            // 
            this.txtbinary.Location = new System.Drawing.Point(143, 83);
            this.txtbinary.Name = "txtbinary";
            this.txtbinary.Size = new System.Drawing.Size(116, 20);
            this.txtbinary.TabIndex = 11;
            this.txtbinary.TextChanged += new System.EventHandler(this.txtbinary_TextChanged);
            // 
            // txtoctal
            // 
            this.txtoctal.Location = new System.Drawing.Point(143, 135);
            this.txtoctal.Name = "txtoctal";
            this.txtoctal.Size = new System.Drawing.Size(116, 20);
            this.txtoctal.TabIndex = 12;
            this.txtoctal.TextChanged += new System.EventHandler(this.txtoctal_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(39, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Smart-Apps";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ASCII_Converter.Properties.Resources._5529;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(377, 264);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtoctal);
            this.Controls.Add(this.txtbinary);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Binary);
            this.Controls.Add(this.lblhex);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txthex);
            this.Controls.Add(this.txtbase4);
            this.Controls.Add(this.txtdecimal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ASCCI Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtdecimal;
        private System.Windows.Forms.TextBox txtbase4;
        private System.Windows.Forms.TextBox txthex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblhex;
        private System.Windows.Forms.Label Binary;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txt;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.TextBox txtbinary;
        private System.Windows.Forms.TextBox txtoctal;
        private System.Windows.Forms.Label label2;
    }
}

