namespace övn
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
            this.btnöppna = new System.Windows.Forms.Button();
            this.btnSpara = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxFör = new System.Windows.Forms.TextBox();
            this.tbxEpost = new System.Windows.Forms.TextBox();
            this.tbxTele = new System.Windows.Forms.TextBox();
            this.tbxEfter = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // btnöppna
            // 
            this.btnöppna.Location = new System.Drawing.Point(277, 83);
            this.btnöppna.Name = "btnöppna";
            this.btnöppna.Size = new System.Drawing.Size(92, 23);
            this.btnöppna.TabIndex = 0;
            this.btnöppna.Text = "öppna";
            this.btnöppna.UseVisualStyleBackColor = true;
            this.btnöppna.Click += new System.EventHandler(this.btnöppna_Click);
            // 
            // btnSpara
            // 
            this.btnSpara.Location = new System.Drawing.Point(277, 118);
            this.btnSpara.Name = "btnSpara";
            this.btnSpara.Size = new System.Drawing.Size(92, 23);
            this.btnSpara.TabIndex = 1;
            this.btnSpara.Text = "Spara som...";
            this.btnSpara.UseVisualStyleBackColor = true;
            this.btnSpara.Click += new System.EventHandler(this.btnSpara_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Förnamn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "efternamn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "epost";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "mobilnr";
            // 
            // tbxFör
            // 
            this.tbxFör.Location = new System.Drawing.Point(77, 10);
            this.tbxFör.Name = "tbxFör";
            this.tbxFör.Size = new System.Drawing.Size(160, 20);
            this.tbxFör.TabIndex = 6;
            // 
            // tbxEpost
            // 
            this.tbxEpost.Location = new System.Drawing.Point(77, 85);
            this.tbxEpost.Name = "tbxEpost";
            this.tbxEpost.Size = new System.Drawing.Size(160, 20);
            this.tbxEpost.TabIndex = 7;
            // 
            // tbxTele
            // 
            this.tbxTele.Location = new System.Drawing.Point(77, 125);
            this.tbxTele.Name = "tbxTele";
            this.tbxTele.Size = new System.Drawing.Size(160, 20);
            this.tbxTele.TabIndex = 8;
            // 
            // tbxEfter
            // 
            this.tbxEfter.Location = new System.Drawing.Point(77, 46);
            this.tbxEfter.Name = "tbxEfter";
            this.tbxEfter.Size = new System.Drawing.Size(160, 20);
            this.tbxEfter.TabIndex = 9;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 167);
            this.Controls.Add(this.tbxEfter);
            this.Controls.Add(this.tbxTele);
            this.Controls.Add(this.tbxEpost);
            this.Controls.Add(this.tbxFör);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSpara);
            this.Controls.Add(this.btnöppna);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnöppna;
        private System.Windows.Forms.Button btnSpara;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxFör;
        private System.Windows.Forms.TextBox tbxEpost;
        private System.Windows.Forms.TextBox tbxTele;
        private System.Windows.Forms.TextBox tbxEfter;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

