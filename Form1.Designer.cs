namespace regisztracios_alkalmazas
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
            this.ment_button = new System.Windows.Forms.Button();
            this.betolt_button = new System.Windows.Forms.Button();
            this.h_h_button = new System.Windows.Forms.Button();
            this.nev_tb = new System.Windows.Forms.TextBox();
            this.hh_tb = new System.Windows.Forms.TextBox();
            this.szuletesi_dtp = new System.Windows.Forms.DateTimePicker();
            this.hobbi_tb = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.f_rb = new System.Windows.Forms.RadioButton();
            this.n_rb = new System.Windows.Forms.RadioButton();
            this.mentess = new System.Windows.Forms.SaveFileDialog();
            this.ofd_nyit = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // ment_button
            // 
            this.ment_button.Location = new System.Drawing.Point(97, 113);
            this.ment_button.Name = "ment_button";
            this.ment_button.Size = new System.Drawing.Size(75, 23);
            this.ment_button.TabIndex = 0;
            this.ment_button.Text = "Mentés";
            this.ment_button.UseVisualStyleBackColor = true;
            this.ment_button.Click += new System.EventHandler(this.ment_button_Click);
            // 
            // betolt_button
            // 
            this.betolt_button.Location = new System.Drawing.Point(12, 113);
            this.betolt_button.Name = "betolt_button";
            this.betolt_button.Size = new System.Drawing.Size(75, 23);
            this.betolt_button.TabIndex = 1;
            this.betolt_button.Text = "Betöltés";
            this.betolt_button.UseVisualStyleBackColor = true;
            this.betolt_button.Click += new System.EventHandler(this.betolt_button_Click);
            // 
            // h_h_button
            // 
            this.h_h_button.Location = new System.Drawing.Point(207, 113);
            this.h_h_button.Name = "h_h_button";
            this.h_h_button.Size = new System.Drawing.Size(120, 23);
            this.h_h_button.TabIndex = 2;
            this.h_h_button.Text = "Hobbi hozzáad";
            this.h_h_button.UseVisualStyleBackColor = true;
            this.h_h_button.Click += new System.EventHandler(this.h_h_button_Click);
            // 
            // nev_tb
            // 
            this.nev_tb.Location = new System.Drawing.Point(97, 12);
            this.nev_tb.Name = "nev_tb";
            this.nev_tb.Size = new System.Drawing.Size(100, 20);
            this.nev_tb.TabIndex = 3;
            // 
            // hh_tb
            // 
            this.hh_tb.Location = new System.Drawing.Point(333, 113);
            this.hh_tb.Name = "hh_tb";
            this.hh_tb.Size = new System.Drawing.Size(100, 20);
            this.hh_tb.TabIndex = 4;
            // 
            // szuletesi_dtp
            // 
            this.szuletesi_dtp.Location = new System.Drawing.Point(97, 39);
            this.szuletesi_dtp.Name = "szuletesi_dtp";
            this.szuletesi_dtp.Size = new System.Drawing.Size(200, 20);
            this.szuletesi_dtp.TabIndex = 5;
            // 
            // hobbi_tb
            // 
            this.hobbi_tb.FormattingEnabled = true;
            this.hobbi_tb.Items.AddRange(new object[] {
            "Gokart",
            "Netezés",
            "Zenélés"});
            this.hobbi_tb.Location = new System.Drawing.Point(313, 12);
            this.hobbi_tb.Name = "hobbi_tb";
            this.hobbi_tb.Size = new System.Drawing.Size(120, 95);
            this.hobbi_tb.TabIndex = 6;
            this.hobbi_tb.SelectedIndexChanged += new System.EventHandler(this.hobbi_tb_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Név";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Születési dátum:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Neme:";
            // 
            // f_rb
            // 
            this.f_rb.AutoSize = true;
            this.f_rb.Location = new System.Drawing.Point(212, 65);
            this.f_rb.Name = "f_rb";
            this.f_rb.Size = new System.Drawing.Size(45, 17);
            this.f_rb.TabIndex = 10;
            this.f_rb.TabStop = true;
            this.f_rb.Text = "Férfi";
            this.f_rb.UseVisualStyleBackColor = true;
            // 
            // n_rb
            // 
            this.n_rb.AutoSize = true;
            this.n_rb.Location = new System.Drawing.Point(112, 65);
            this.n_rb.Name = "n_rb";
            this.n_rb.Size = new System.Drawing.Size(39, 17);
            this.n_rb.TabIndex = 11;
            this.n_rb.TabStop = true;
            this.n_rb.Text = "Nő";
            this.n_rb.UseVisualStyleBackColor = true;
            // 
            // mentess
            // 
            this.mentess.DefaultExt = "txt";
            // 
            // ofd_nyit
            // 
            this.ofd_nyit.DefaultExt = "txt";
            this.ofd_nyit.Title = "Megnyitás";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 142);
            this.Controls.Add(this.n_rb);
            this.Controls.Add(this.f_rb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hobbi_tb);
            this.Controls.Add(this.szuletesi_dtp);
            this.Controls.Add(this.hh_tb);
            this.Controls.Add(this.nev_tb);
            this.Controls.Add(this.h_h_button);
            this.Controls.Add(this.betolt_button);
            this.Controls.Add(this.ment_button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ment_button;
        private System.Windows.Forms.Button betolt_button;
        private System.Windows.Forms.Button h_h_button;
        private System.Windows.Forms.TextBox nev_tb;
        private System.Windows.Forms.TextBox hh_tb;
        private System.Windows.Forms.DateTimePicker szuletesi_dtp;
        private System.Windows.Forms.ListBox hobbi_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton f_rb;
        private System.Windows.Forms.RadioButton n_rb;
        private System.Windows.Forms.SaveFileDialog mentess;
        private System.Windows.Forms.OpenFileDialog ofd_nyit;
    }
}

