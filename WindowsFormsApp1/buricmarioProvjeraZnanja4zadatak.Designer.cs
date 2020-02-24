namespace WindowsFormsApp1
{
    partial class FormUnosNovogStudenta
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
            this.buttonsnimi = new System.Windows.Forms.Button();
            this.buttonotkazi = new System.Windows.Forms.Button();
            this.labelIme = new System.Windows.Forms.Label();
            this.labelprezime = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelsmjer = new System.Windows.Forms.Label();
            this.labelBrojIndeksa = new System.Windows.Forms.Label();
            this.labeldatumrodenja = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonsnimi
            // 
            this.buttonsnimi.Location = new System.Drawing.Point(144, 249);
            this.buttonsnimi.Name = "buttonsnimi";
            this.buttonsnimi.Size = new System.Drawing.Size(75, 23);
            this.buttonsnimi.TabIndex = 0;
            this.buttonsnimi.Text = "Snimi";
            this.buttonsnimi.UseVisualStyleBackColor = true;
            // 
            // buttonotkazi
            // 
            this.buttonotkazi.Location = new System.Drawing.Point(415, 249);
            this.buttonotkazi.Name = "buttonotkazi";
            this.buttonotkazi.Size = new System.Drawing.Size(75, 23);
            this.buttonotkazi.TabIndex = 1;
            this.buttonotkazi.Text = "Otkazi";
            this.buttonotkazi.UseVisualStyleBackColor = true;
            // 
            // labelIme
            // 
            this.labelIme.AutoSize = true;
            this.labelIme.Location = new System.Drawing.Point(178, 50);
            this.labelIme.Name = "labelIme";
            this.labelIme.Size = new System.Drawing.Size(24, 13);
            this.labelIme.TabIndex = 2;
            this.labelIme.Text = "Ime";
            // 
            // labelprezime
            // 
            this.labelprezime.AutoSize = true;
            this.labelprezime.Location = new System.Drawing.Point(176, 112);
            this.labelprezime.Name = "labelprezime";
            this.labelprezime.Size = new System.Drawing.Size(44, 13);
            this.labelprezime.TabIndex = 3;
            this.labelprezime.Text = "Prezime";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(144, 66);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(141, 20);
            this.textBox1.TabIndex = 4;
            // 
            // labelsmjer
            // 
            this.labelsmjer.AutoSize = true;
            this.labelsmjer.Location = new System.Drawing.Point(176, 172);
            this.labelsmjer.Name = "labelsmjer";
            this.labelsmjer.Size = new System.Drawing.Size(33, 13);
            this.labelsmjer.TabIndex = 5;
            this.labelsmjer.Text = "Smjer";
            // 
            // labelBrojIndeksa
            // 
            this.labelBrojIndeksa.AutoSize = true;
            this.labelBrojIndeksa.Location = new System.Drawing.Point(370, 50);
            this.labelBrojIndeksa.Name = "labelBrojIndeksa";
            this.labelBrojIndeksa.Size = new System.Drawing.Size(65, 13);
            this.labelBrojIndeksa.TabIndex = 6;
            this.labelBrojIndeksa.Text = "Broj indeksa";
            // 
            // labeldatumrodenja
            // 
            this.labeldatumrodenja.AutoSize = true;
            this.labeldatumrodenja.Location = new System.Drawing.Point(370, 112);
            this.labeldatumrodenja.Name = "labeldatumrodenja";
            this.labeldatumrodenja.Size = new System.Drawing.Size(76, 13);
            this.labeldatumrodenja.TabIndex = 7;
            this.labeldatumrodenja.Text = "Datum rodenja";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(338, 66);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(139, 20);
            this.textBox3.TabIndex = 9;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(144, 128);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(141, 20);
            this.textBox5.TabIndex = 11;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(338, 128);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(139, 20);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Programer",
            "Sistem Administrator",
            "Mrežni Administrator"});
            this.comboBox1.Location = new System.Drawing.Point(144, 200);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(141, 21);
            this.comboBox1.TabIndex = 13;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.labeldatumrodenja);
            this.Controls.Add(this.labelBrojIndeksa);
            this.Controls.Add(this.labelsmjer);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelprezime);
            this.Controls.Add(this.labelIme);
            this.Controls.Add(this.buttonotkazi);
            this.Controls.Add(this.buttonsnimi);
            this.Name = "Form2";
            this.Text = "Unos novog studenta";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonsnimi;
        private System.Windows.Forms.Button buttonotkazi;
        private System.Windows.Forms.Label labelIme;
        private System.Windows.Forms.Label labelprezime;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelsmjer;
        private System.Windows.Forms.Label labelBrojIndeksa;
        private System.Windows.Forms.Label labeldatumrodenja;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}