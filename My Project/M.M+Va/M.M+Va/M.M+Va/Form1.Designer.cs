﻿namespace M.M_Va
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.InTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupRules = new System.Windows.Forms.GroupBox();
            this.AlfabetTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ClearButton = new System.Windows.Forms.Button();
            this.InButton = new System.Windows.Forms.Button();
            this.TrzyZnakoweCheckBox = new System.Windows.Forms.CheckBox();
            this.PierwszymZnakiemCheckBox = new System.Windows.Forms.CheckBox();
            this.R1R2CheckBox = new System.Windows.Forms.CheckBox();
            this.DrugiZnakiemCheckBox = new System.Windows.Forms.CheckBox();
            this.TylkoLiteryCheckBox = new System.Windows.Forms.CheckBox();
            this.CheckButton = new System.Windows.Forms.Button();
            this.groupRules.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // InTextBox
            // 
            this.InTextBox.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InTextBox.Location = new System.Drawing.Point(408, 141);
            this.InTextBox.Name = "InTextBox";
            this.InTextBox.Size = new System.Drawing.Size(274, 38);
            this.InTextBox.TabIndex = 0;
            this.InTextBox.Text = "...";
            this.InTextBox.TextChanged += new System.EventHandler(this.InTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.AliceBlue;
            this.label1.Location = new System.Drawing.Point(403, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Podaj Znak dla Alfabetu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.AliceBlue;
            this.label2.Location = new System.Drawing.Point(403, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 25);
            this.label2.TabIndex = 6;
            // 
            // groupRules
            // 
            this.groupRules.Controls.Add(this.TylkoLiteryCheckBox);
            this.groupRules.Controls.Add(this.DrugiZnakiemCheckBox);
            this.groupRules.Controls.Add(this.R1R2CheckBox);
            this.groupRules.Controls.Add(this.PierwszymZnakiemCheckBox);
            this.groupRules.Controls.Add(this.TrzyZnakoweCheckBox);
            this.groupRules.ForeColor = System.Drawing.Color.LavenderBlush;
            this.groupRules.Location = new System.Drawing.Point(392, 211);
            this.groupRules.Name = "groupRules";
            this.groupRules.Size = new System.Drawing.Size(495, 176);
            this.groupRules.TabIndex = 7;
            this.groupRules.TabStop = false;
            this.groupRules.Text = "GroupRelus";
            this.groupRules.Enter += new System.EventHandler(this.groupRules_Enter);
            // 
            // AlfabetTextBox
            // 
            this.AlfabetTextBox.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlfabetTextBox.Location = new System.Drawing.Point(43, 141);
            this.AlfabetTextBox.Multiline = true;
            this.AlfabetTextBox.Name = "AlfabetTextBox";
            this.AlfabetTextBox.ReadOnly = true;
            this.AlfabetTextBox.Size = new System.Drawing.Size(274, 282);
            this.AlfabetTextBox.TabIndex = 8;
            this.AlfabetTextBox.Text = "...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.AliceBlue;
            this.label3.Location = new System.Drawing.Point(38, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Alfabet:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(359, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(10, 540);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.Color.AliceBlue;
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClearButton.Location = new System.Drawing.Point(203, 440);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(114, 37);
            this.ClearButton.TabIndex = 11;
            this.ClearButton.Text = "Wyczyść";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // InButton
            // 
            this.InButton.BackColor = System.Drawing.Color.AliceBlue;
            this.InButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.InButton.Location = new System.Drawing.Point(701, 141);
            this.InButton.Name = "InButton";
            this.InButton.Size = new System.Drawing.Size(114, 37);
            this.InButton.TabIndex = 12;
            this.InButton.Text = "Dodaj";
            this.InButton.UseVisualStyleBackColor = false;
            this.InButton.Click += new System.EventHandler(this.InButton_Click);
            // 
            // TrzyZnakoweCheckBox
            // 
            this.TrzyZnakoweCheckBox.AutoSize = true;
            this.TrzyZnakoweCheckBox.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrzyZnakoweCheckBox.ForeColor = System.Drawing.Color.AliceBlue;
            this.TrzyZnakoweCheckBox.Location = new System.Drawing.Point(28, 41);
            this.TrzyZnakoweCheckBox.Name = "TrzyZnakoweCheckBox";
            this.TrzyZnakoweCheckBox.Size = new System.Drawing.Size(394, 18);
            this.TrzyZnakoweCheckBox.TabIndex = 5;
            this.TrzyZnakoweCheckBox.Text = "Tylko trzyznakowe ciągi znaków z alfabetu A są danymi";
            this.TrzyZnakoweCheckBox.UseVisualStyleBackColor = true;
            // 
            // PierwszymZnakiemCheckBox
            // 
            this.PierwszymZnakiemCheckBox.AutoSize = true;
            this.PierwszymZnakiemCheckBox.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PierwszymZnakiemCheckBox.ForeColor = System.Drawing.Color.AliceBlue;
            this.PierwszymZnakiemCheckBox.Location = new System.Drawing.Point(28, 64);
            this.PierwszymZnakiemCheckBox.Name = "PierwszymZnakiemCheckBox";
            this.PierwszymZnakiemCheckBox.Size = new System.Drawing.Size(416, 18);
            this.PierwszymZnakiemCheckBox.TabIndex = 6;
            this.PierwszymZnakiemCheckBox.Text = "Pierwszym znakiem danej musi być drugi znak z alfabetu A";
            this.PierwszymZnakiemCheckBox.UseVisualStyleBackColor = true;
            // 
            // R1R2CheckBox
            // 
            this.R1R2CheckBox.AutoSize = true;
            this.R1R2CheckBox.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.R1R2CheckBox.ForeColor = System.Drawing.Color.AliceBlue;
            this.R1R2CheckBox.Location = new System.Drawing.Point(28, 87);
            this.R1R2CheckBox.Name = "R1R2CheckBox";
            this.R1R2CheckBox.Size = new System.Drawing.Size(297, 18);
            this.R1R2CheckBox.TabIndex = 7;
            this.R1R2CheckBox.Text = "Tylko ciągi spełniające r1 i r2 są danymi ";
            this.R1R2CheckBox.UseVisualStyleBackColor = true;
            // 
            // DrugiZnakiemCheckBox
            // 
            this.DrugiZnakiemCheckBox.AutoSize = true;
            this.DrugiZnakiemCheckBox.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DrugiZnakiemCheckBox.ForeColor = System.Drawing.Color.AliceBlue;
            this.DrugiZnakiemCheckBox.Location = new System.Drawing.Point(28, 110);
            this.DrugiZnakiemCheckBox.Name = "DrugiZnakiemCheckBox";
            this.DrugiZnakiemCheckBox.Size = new System.Drawing.Size(395, 18);
            this.DrugiZnakiemCheckBox.TabIndex = 8;
            this.DrugiZnakiemCheckBox.Text = "Drugim Znakiem danej musi być trzeci znak z alfabetu A";
            this.DrugiZnakiemCheckBox.UseVisualStyleBackColor = true;
            // 
            // TylkoLiteryCheckBox
            // 
            this.TylkoLiteryCheckBox.AutoSize = true;
            this.TylkoLiteryCheckBox.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TylkoLiteryCheckBox.ForeColor = System.Drawing.Color.AliceBlue;
            this.TylkoLiteryCheckBox.Location = new System.Drawing.Point(28, 133);
            this.TylkoLiteryCheckBox.Name = "TylkoLiteryCheckBox";
            this.TylkoLiteryCheckBox.Size = new System.Drawing.Size(174, 18);
            this.TylkoLiteryCheckBox.TabIndex = 9;
            this.TylkoLiteryCheckBox.Text = "Tylko muszą być litery";
            this.TylkoLiteryCheckBox.UseVisualStyleBackColor = true;
            // 
            // CheckButton
            // 
            this.CheckButton.BackColor = System.Drawing.Color.AliceBlue;
            this.CheckButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CheckButton.Location = new System.Drawing.Point(701, 440);
            this.CheckButton.Name = "CheckButton";
            this.CheckButton.Size = new System.Drawing.Size(114, 37);
            this.CheckButton.TabIndex = 13;
            this.CheckButton.Text = "Sprawdź";
            this.CheckButton.UseVisualStyleBackColor = false;
            this.CheckButton.Click += new System.EventHandler(this.CheckButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(916, 540);
            this.Controls.Add(this.CheckButton);
            this.Controls.Add(this.InButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AlfabetTextBox);
            this.Controls.Add(this.groupRules);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupRules.ResumeLayout(false);
            this.groupRules.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupRules;
        private System.Windows.Forms.TextBox AlfabetTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button InButton;
        private System.Windows.Forms.CheckBox TylkoLiteryCheckBox;
        private System.Windows.Forms.CheckBox DrugiZnakiemCheckBox;
        private System.Windows.Forms.CheckBox R1R2CheckBox;
        private System.Windows.Forms.CheckBox PierwszymZnakiemCheckBox;
        private System.Windows.Forms.CheckBox TrzyZnakoweCheckBox;
        private System.Windows.Forms.Button CheckButton;
    }
}

