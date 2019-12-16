namespace TibiaHelper
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
            this.cmbHPKey = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbHPUpperStronger = new System.Windows.Forms.ComboBox();
            this.cmbHPKeyStronger = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.checkboxHP = new System.Windows.Forms.CheckBox();
            this.cmbHPUpper = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkboxMana = new System.Windows.Forms.CheckBox();
            this.cmbManaUpper = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbManaKey = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkboxUtama = new System.Windows.Forms.CheckBox();
            this.cmbUtamaKey = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.checkboxAutoClick = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbAutoClickKey = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txbAutoClick = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbHPKey
            // 
            this.cmbHPKey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHPKey.FormattingEnabled = true;
            this.cmbHPKey.Location = new System.Drawing.Point(110, 54);
            this.cmbHPKey.Name = "cmbHPKey";
            this.cmbHPKey.Size = new System.Drawing.Size(61, 21);
            this.cmbHPKey.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cmbHPUpperStronger);
            this.groupBox1.Controls.Add(this.cmbHPKeyStronger);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.checkboxHP);
            this.groupBox1.Controls.Add(this.cmbHPUpper);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbHPKey);
            this.groupBox1.Location = new System.Drawing.Point(1, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 81);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "HP";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(183, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "High Healing";
            // 
            // cmbHPUpperStronger
            // 
            this.cmbHPUpperStronger.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHPUpperStronger.FormattingEnabled = true;
            this.cmbHPUpperStronger.Location = new System.Drawing.Point(195, 27);
            this.cmbHPUpperStronger.Name = "cmbHPUpperStronger";
            this.cmbHPUpperStronger.Size = new System.Drawing.Size(61, 21);
            this.cmbHPUpperStronger.TabIndex = 18;
            // 
            // cmbHPKeyStronger
            // 
            this.cmbHPKeyStronger.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHPKeyStronger.FormattingEnabled = true;
            this.cmbHPKeyStronger.Location = new System.Drawing.Point(195, 54);
            this.cmbHPKeyStronger.Name = "cmbHPKeyStronger";
            this.cmbHPKeyStronger.Size = new System.Drawing.Size(61, 21);
            this.cmbHPKeyStronger.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(75, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "KEY";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(107, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Light Healing";
            // 
            // checkboxHP
            // 
            this.checkboxHP.AutoSize = true;
            this.checkboxHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkboxHP.Location = new System.Drawing.Point(6, 19);
            this.checkboxHP.Name = "checkboxHP";
            this.checkboxHP.Size = new System.Drawing.Size(71, 24);
            this.checkboxHP.TabIndex = 13;
            this.checkboxHP.Text = "Active";
            this.checkboxHP.UseVisualStyleBackColor = true;
            this.checkboxHP.CheckStateChanged += new System.EventHandler(this.checkboxHP_CheckStateChanged);
            // 
            // cmbHPUpper
            // 
            this.cmbHPUpper.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHPUpper.FormattingEnabled = true;
            this.cmbHPUpper.Location = new System.Drawing.Point(110, 27);
            this.cmbHPUpper.Name = "cmbHPUpper";
            this.cmbHPUpper.Size = new System.Drawing.Size(61, 21);
            this.cmbHPUpper.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(74, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "HP <";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.checkboxMana);
            this.groupBox2.Controls.Add(this.cmbManaUpper);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cmbManaKey);
            this.groupBox2.Location = new System.Drawing.Point(1, 92);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(265, 81);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mana";
            // 
            // checkboxMana
            // 
            this.checkboxMana.AutoSize = true;
            this.checkboxMana.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkboxMana.Location = new System.Drawing.Point(6, 19);
            this.checkboxMana.Name = "checkboxMana";
            this.checkboxMana.Size = new System.Drawing.Size(71, 24);
            this.checkboxMana.TabIndex = 12;
            this.checkboxMana.Text = "Active";
            this.checkboxMana.UseVisualStyleBackColor = true;
            this.checkboxMana.CheckStateChanged += new System.EventHandler(this.checkboxMana_CheckStateChanged);
            // 
            // cmbManaUpper
            // 
            this.cmbManaUpper.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbManaUpper.FormattingEnabled = true;
            this.cmbManaUpper.Location = new System.Drawing.Point(195, 27);
            this.cmbManaUpper.Name = "cmbManaUpper";
            this.cmbManaUpper.Size = new System.Drawing.Size(61, 21);
            this.cmbManaUpper.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(142, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "MANA <";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(160, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "KEY";
            // 
            // cmbManaKey
            // 
            this.cmbManaKey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbManaKey.FormattingEnabled = true;
            this.cmbManaKey.Location = new System.Drawing.Point(195, 54);
            this.cmbManaKey.Name = "cmbManaKey";
            this.cmbManaKey.Size = new System.Drawing.Size(61, 21);
            this.cmbManaKey.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.txbAutoClick);
            this.groupBox3.Controls.Add(this.checkboxAutoClick);
            this.groupBox3.Controls.Add(this.checkboxUtama);
            this.groupBox3.Controls.Add(this.cmbAutoClickKey);
            this.groupBox3.Controls.Add(this.cmbUtamaKey);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(1, 179);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(265, 121);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Others";
            // 
            // checkboxUtama
            // 
            this.checkboxUtama.AutoSize = true;
            this.checkboxUtama.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkboxUtama.Location = new System.Drawing.Point(12, 13);
            this.checkboxUtama.Name = "checkboxUtama";
            this.checkboxUtama.Size = new System.Drawing.Size(119, 28);
            this.checkboxUtama.TabIndex = 11;
            this.checkboxUtama.Text = "Utamo Vita";
            this.checkboxUtama.UseVisualStyleBackColor = true;
            this.checkboxUtama.CheckStateChanged += new System.EventHandler(this.checkboxUtama_CheckStateChanged);
            // 
            // cmbUtamaKey
            // 
            this.cmbUtamaKey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUtamaKey.FormattingEnabled = true;
            this.cmbUtamaKey.Location = new System.Drawing.Point(195, 17);
            this.cmbUtamaKey.Name = "cmbUtamaKey";
            this.cmbUtamaKey.Size = new System.Drawing.Size(61, 21);
            this.cmbUtamaKey.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(160, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "KEY";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Cyan;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(42, 322);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(183, 38);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // checkboxAutoClick
            // 
            this.checkboxAutoClick.AutoSize = true;
            this.checkboxAutoClick.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkboxAutoClick.Location = new System.Drawing.Point(12, 62);
            this.checkboxAutoClick.Name = "checkboxAutoClick";
            this.checkboxAutoClick.Size = new System.Drawing.Size(171, 28);
            this.checkboxAutoClick.TabIndex = 11;
            this.checkboxAutoClick.Text = "AutoClick Hotkey";
            this.checkboxAutoClick.UseVisualStyleBackColor = true;
            this.checkboxAutoClick.CheckStateChanged += new System.EventHandler(this.checkboxAutoClick_CheckStateChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(160, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "KEY";
            // 
            // cmbAutoClickKey
            // 
            this.cmbAutoClickKey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAutoClickKey.FormattingEnabled = true;
            this.cmbAutoClickKey.Location = new System.Drawing.Point(195, 94);
            this.cmbAutoClickKey.Name = "cmbAutoClickKey";
            this.cmbAutoClickKey.Size = new System.Drawing.Size(61, 21);
            this.cmbAutoClickKey.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(18, 94);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "After";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(75, 94);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Seconds";
            // 
            // txbAutoClick
            // 
            this.txbAutoClick.Location = new System.Drawing.Point(47, 91);
            this.txbAutoClick.Name = "txbAutoClick";
            this.txbAutoClick.Size = new System.Drawing.Size(28, 20);
            this.txbAutoClick.TabIndex = 15;
            this.txbAutoClick.Text = "10";
            this.txbAutoClick.TextChanged += new System.EventHandler(this.txbAutoClick_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(269, 374);
            this.ControlBox = false;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "CandiaHelprer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbHPKey;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbHPUpper;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbManaUpper;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbManaKey;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkboxUtama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkboxHP;
        private System.Windows.Forms.CheckBox checkboxMana;
        private System.Windows.Forms.ComboBox cmbUtamaKey;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbHPUpperStronger;
        private System.Windows.Forms.ComboBox cmbHPKeyStronger;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkboxAutoClick;
        private System.Windows.Forms.ComboBox cmbAutoClickKey;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txbAutoClick;
    }
}

