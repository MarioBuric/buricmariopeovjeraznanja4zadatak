namespace WindowsFormsApp1
{
    partial class FormStudenti
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
            this.buttonnovistudent = new System.Windows.Forms.Button();
            this.buttonobrisistudenta = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.listBoxstudenti = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buttonnovistudent
            // 
            this.buttonnovistudent.Location = new System.Drawing.Point(39, 16);
            this.buttonnovistudent.Name = "buttonnovistudent";
            this.buttonnovistudent.Size = new System.Drawing.Size(144, 23);
            this.buttonnovistudent.TabIndex = 0;
            this.buttonnovistudent.Text = "Dodaj novog studenta";
            this.buttonnovistudent.UseVisualStyleBackColor = true;
            this.buttonnovistudent.Click += new System.EventHandler(this.buttonnovistudent_Click);
            // 
            // buttonobrisistudenta
            // 
            this.buttonobrisistudenta.Location = new System.Drawing.Point(284, 91);
            this.buttonobrisistudenta.Name = "buttonobrisistudenta";
            this.buttonobrisistudenta.Size = new System.Drawing.Size(133, 23);
            this.buttonobrisistudenta.TabIndex = 1;
            this.buttonobrisistudenta.Text = "Obrisi studenta";
            this.buttonobrisistudenta.UseVisualStyleBackColor = true;
            this.buttonobrisistudenta.Click += new System.EventHandler(this.buttonobrisistudenta_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(63, 188);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Obrisi sve studente";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // listBoxstudenti
            // 
            this.listBoxstudenti.FormattingEnabled = true;
            this.listBoxstudenti.Location = new System.Drawing.Point(39, 57);
            this.listBoxstudenti.Name = "listBoxstudenti";
            this.listBoxstudenti.Size = new System.Drawing.Size(197, 95);
            this.listBoxstudenti.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxstudenti);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonobrisistudenta);
            this.Controls.Add(this.buttonnovistudent);
            this.Name = "Form1";
            this.Text = "Studenti";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonnovistudent;
        private System.Windows.Forms.Button buttonobrisistudenta;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox listBoxstudenti;
    }
}

