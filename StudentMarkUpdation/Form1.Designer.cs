namespace StudentMarkUpdation
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.tbxMalayalam = new System.Windows.Forms.TextBox();
            this.tbxEnglish = new System.Windows.Forms.TextBox();
            this.tbxHindi = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txbxAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "English";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Malayalam";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hindi";
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(127, 35);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(127, 20);
            this.tbxName.TabIndex = 4;
            // 
            // tbxMalayalam
            // 
            this.tbxMalayalam.Location = new System.Drawing.Point(127, 71);
            this.tbxMalayalam.Name = "tbxMalayalam";
            this.tbxMalayalam.Size = new System.Drawing.Size(127, 20);
            this.tbxMalayalam.TabIndex = 5;
            // 
            // tbxEnglish
            // 
            this.tbxEnglish.Location = new System.Drawing.Point(127, 106);
            this.tbxEnglish.Name = "tbxEnglish";
            this.tbxEnglish.Size = new System.Drawing.Size(127, 20);
            this.tbxEnglish.TabIndex = 6;
            // 
            // tbxHindi
            // 
            this.tbxHindi.Location = new System.Drawing.Point(127, 137);
            this.tbxHindi.Name = "tbxHindi";
            this.tbxHindi.Size = new System.Drawing.Size(127, 20);
            this.tbxHindi.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Blue;
            this.btnSave.Location = new System.Drawing.Point(127, 206);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(127, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txbxAddress
            // 
            this.txbxAddress.Location = new System.Drawing.Point(127, 170);
            this.txbxAddress.Name = "txbxAddress";
            this.txbxAddress.Size = new System.Drawing.Size(127, 20);
            this.txbxAddress.TabIndex = 10;
            this.txbxAddress.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Address";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(301, 263);
            this.Controls.Add(this.txbxAddress);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbxHindi);
            this.Controls.Add(this.tbxEnglish);
            this.Controls.Add(this.tbxMalayalam);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mark Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.TextBox tbxMalayalam;
        private System.Windows.Forms.TextBox tbxEnglish;
        private System.Windows.Forms.TextBox tbxHindi;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txbxAddress;
        private System.Windows.Forms.Label label5;
    }
}

