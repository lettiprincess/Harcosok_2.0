namespace Harcosok
{
    partial class Harcosok
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
            this.label2 = new System.Windows.Forms.Label();
            this.harcosNeveTextBox = new System.Windows.Forms.TextBox();
            this.letrehozasButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.hasznaloComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.kepessegNeveTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.leirasTextBox = new System.Windows.Forms.TextBox();
            this.hozzaadButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.harcosokListbox = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.kepessegekListBox = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.kepessegekLeirasaTextBox = new System.Windows.Forms.TextBox();
            this.torlesButton = new System.Windows.Forms.Button();
            this.modositButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Név:";
            // 
            // harcosNeveTextBox
            // 
            this.harcosNeveTextBox.Location = new System.Drawing.Point(71, 32);
            this.harcosNeveTextBox.Name = "harcosNeveTextBox";
            this.harcosNeveTextBox.Size = new System.Drawing.Size(154, 22);
            this.harcosNeveTextBox.TabIndex = 2;
            // 
            // letrehozasButton
            // 
            this.letrehozasButton.Location = new System.Drawing.Point(248, 32);
            this.letrehozasButton.Name = "letrehozasButton";
            this.letrehozasButton.Size = new System.Drawing.Size(101, 23);
            this.letrehozasButton.TabIndex = 3;
            this.letrehozasButton.Text = "Létrehozás";
            this.letrehozasButton.UseVisualStyleBackColor = true;
            this.letrehozasButton.Click += new System.EventHandler(this.letrehozasButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.harcosNeveTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.letrehozasButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(516, 76);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Harcos létrehozása";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.hozzaadButton);
            this.groupBox2.Controls.Add(this.leirasTextBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.kepessegNeveTextBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.hasznaloComboBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(13, 87);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(515, 128);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Képesség hozzáadása";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Használó: ";
            // 
            // hasznaloComboBox
            // 
            this.hasznaloComboBox.FormattingEnabled = true;
            this.hasznaloComboBox.Location = new System.Drawing.Point(88, 21);
            this.hasznaloComboBox.Name = "hasznaloComboBox";
            this.hasznaloComboBox.Size = new System.Drawing.Size(151, 24);
            this.hasznaloComboBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Név:";
            // 
            // kepessegNeveTextBox
            // 
            this.kepessegNeveTextBox.Location = new System.Drawing.Point(88, 61);
            this.kepessegNeveTextBox.Name = "kepessegNeveTextBox";
            this.kepessegNeveTextBox.Size = new System.Drawing.Size(151, 22);
            this.kepessegNeveTextBox.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(267, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Leírás:";
            // 
            // leirasTextBox
            // 
            this.leirasTextBox.Location = new System.Drawing.Point(270, 42);
            this.leirasTextBox.Multiline = true;
            this.leirasTextBox.Name = "leirasTextBox";
            this.leirasTextBox.Size = new System.Drawing.Size(239, 52);
            this.leirasTextBox.TabIndex = 5;
            // 
            // hozzaadButton
            // 
            this.hozzaadButton.Location = new System.Drawing.Point(7, 98);
            this.hozzaadButton.Name = "hozzaadButton";
            this.hozzaadButton.Size = new System.Drawing.Size(107, 23);
            this.hozzaadButton.TabIndex = 6;
            this.hozzaadButton.Text = "Hozzáadás";
            this.hozzaadButton.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Harcosok:";
            // 
            // harcosokListbox
            // 
            this.harcosokListbox.FormattingEnabled = true;
            this.harcosokListbox.ItemHeight = 16;
            this.harcosokListbox.Location = new System.Drawing.Point(12, 251);
            this.harcosokListbox.Name = "harcosokListbox";
            this.harcosokListbox.Size = new System.Drawing.Size(149, 212);
            this.harcosokListbox.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(183, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Képességei:";
            // 
            // kepessegekListBox
            // 
            this.kepessegekListBox.FormattingEnabled = true;
            this.kepessegekListBox.ItemHeight = 16;
            this.kepessegekListBox.Location = new System.Drawing.Point(186, 251);
            this.kepessegekListBox.Name = "kepessegekListBox";
            this.kepessegekListBox.Size = new System.Drawing.Size(152, 212);
            this.kepessegekListBox.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(356, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Képességek leírása:";
            // 
            // kepessegekLeirasaTextBox
            // 
            this.kepessegekLeirasaTextBox.Location = new System.Drawing.Point(359, 260);
            this.kepessegekLeirasaTextBox.Multiline = true;
            this.kepessegekLeirasaTextBox.Name = "kepessegekLeirasaTextBox";
            this.kepessegekLeirasaTextBox.Size = new System.Drawing.Size(163, 118);
            this.kepessegekLeirasaTextBox.TabIndex = 11;
            // 
            // torlesButton
            // 
            this.torlesButton.Location = new System.Drawing.Point(209, 469);
            this.torlesButton.Name = "torlesButton";
            this.torlesButton.Size = new System.Drawing.Size(107, 23);
            this.torlesButton.TabIndex = 12;
            this.torlesButton.Text = "Törlés";
            this.torlesButton.UseVisualStyleBackColor = true;
            this.torlesButton.Click += new System.EventHandler(this.torlesButton_Click);
            // 
            // modositButton
            // 
            this.modositButton.Location = new System.Drawing.Point(420, 384);
            this.modositButton.Name = "modositButton";
            this.modositButton.Size = new System.Drawing.Size(102, 23);
            this.modositButton.TabIndex = 13;
            this.modositButton.Text = "Módosít";
            this.modositButton.UseVisualStyleBackColor = true;
            this.modositButton.Click += new System.EventHandler(this.modositButton_Click);
            // 
            // Harcosok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 504);
            this.Controls.Add(this.modositButton);
            this.Controls.Add(this.torlesButton);
            this.Controls.Add(this.kepessegekLeirasaTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.kepessegekListBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.harcosokListbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Harcosok";
            this.Text = "Harcosok";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox harcosNeveTextBox;
        private System.Windows.Forms.Button letrehozasButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button hozzaadButton;
        private System.Windows.Forms.TextBox leirasTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox kepessegNeveTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox hasznaloComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox harcosokListbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox kepessegekListBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox kepessegekLeirasaTextBox;
        private System.Windows.Forms.Button torlesButton;
        private System.Windows.Forms.Button modositButton;
    }
}

