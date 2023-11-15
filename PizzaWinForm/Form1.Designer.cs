namespace PizzaWinForm
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
            this.button_FajlBeolvas = new System.Windows.Forms.Button();
            this.listBox_BeolvasottPizzak = new System.Windows.Forms.ListBox();
            this.button_Atlagar = new System.Windows.Forms.Button();
            this.groupBox_KeszpenzVagyKartya = new System.Windows.Forms.GroupBox();
            this.radioButton_Keszpenz = new System.Windows.Forms.RadioButton();
            this.radioButton_Kartya = new System.Windows.Forms.RadioButton();
            this.checkBox_Szamla = new System.Windows.Forms.CheckBox();
            this.textBox_KivalasztottPizza = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Darabszam = new System.Windows.Forms.TextBox();
            this.button_RendelesLeadasa = new System.Windows.Forms.Button();
            this.groupBox_KeszpenzVagyKartya.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_FajlBeolvas
            // 
            this.button_FajlBeolvas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button_FajlBeolvas.Location = new System.Drawing.Point(13, 13);
            this.button_FajlBeolvas.Name = "button_FajlBeolvas";
            this.button_FajlBeolvas.Size = new System.Drawing.Size(342, 44);
            this.button_FajlBeolvas.TabIndex = 0;
            this.button_FajlBeolvas.Text = "Fájl beolvasása";
            this.button_FajlBeolvas.UseVisualStyleBackColor = true;
            this.button_FajlBeolvas.Click += new System.EventHandler(this.button_FajlBeolvas_Click);
            // 
            // listBox_BeolvasottPizzak
            // 
            this.listBox_BeolvasottPizzak.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.listBox_BeolvasottPizzak.FormattingEnabled = true;
            this.listBox_BeolvasottPizzak.ItemHeight = 20;
            this.listBox_BeolvasottPizzak.Location = new System.Drawing.Point(13, 64);
            this.listBox_BeolvasottPizzak.Name = "listBox_BeolvasottPizzak";
            this.listBox_BeolvasottPizzak.Size = new System.Drawing.Size(342, 304);
            this.listBox_BeolvasottPizzak.TabIndex = 1;
            this.listBox_BeolvasottPizzak.SelectedIndexChanged += new System.EventHandler(this.listBox_BeolvasottPizzak_SelectedIndexChanged);
            // 
            // button_Atlagar
            // 
            this.button_Atlagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button_Atlagar.Location = new System.Drawing.Point(386, 13);
            this.button_Atlagar.Name = "button_Atlagar";
            this.button_Atlagar.Size = new System.Drawing.Size(342, 44);
            this.button_Atlagar.TabIndex = 2;
            this.button_Atlagar.Text = "Átlagár";
            this.button_Atlagar.UseVisualStyleBackColor = true;
            this.button_Atlagar.Click += new System.EventHandler(this.button_Atlagar_Click);
            // 
            // groupBox_KeszpenzVagyKartya
            // 
            this.groupBox_KeszpenzVagyKartya.Controls.Add(this.radioButton_Kartya);
            this.groupBox_KeszpenzVagyKartya.Controls.Add(this.radioButton_Keszpenz);
            this.groupBox_KeszpenzVagyKartya.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox_KeszpenzVagyKartya.Location = new System.Drawing.Point(386, 64);
            this.groupBox_KeszpenzVagyKartya.Name = "groupBox_KeszpenzVagyKartya";
            this.groupBox_KeszpenzVagyKartya.Size = new System.Drawing.Size(342, 100);
            this.groupBox_KeszpenzVagyKartya.TabIndex = 3;
            this.groupBox_KeszpenzVagyKartya.TabStop = false;
            this.groupBox_KeszpenzVagyKartya.Text = "Készpénz vagy Kártya?";
            // 
            // radioButton_Keszpenz
            // 
            this.radioButton_Keszpenz.AutoSize = true;
            this.radioButton_Keszpenz.Checked = true;
            this.radioButton_Keszpenz.Location = new System.Drawing.Point(23, 26);
            this.radioButton_Keszpenz.Name = "radioButton_Keszpenz";
            this.radioButton_Keszpenz.Size = new System.Drawing.Size(112, 24);
            this.radioButton_Keszpenz.TabIndex = 0;
            this.radioButton_Keszpenz.TabStop = true;
            this.radioButton_Keszpenz.Text = "Készpénz";
            this.radioButton_Keszpenz.UseVisualStyleBackColor = true;
            // 
            // radioButton_Kartya
            // 
            this.radioButton_Kartya.AutoSize = true;
            this.radioButton_Kartya.Location = new System.Drawing.Point(23, 57);
            this.radioButton_Kartya.Name = "radioButton_Kartya";
            this.radioButton_Kartya.Size = new System.Drawing.Size(84, 24);
            this.radioButton_Kartya.TabIndex = 1;
            this.radioButton_Kartya.Text = "Kártya";
            this.radioButton_Kartya.UseVisualStyleBackColor = true;
            // 
            // checkBox_Szamla
            // 
            this.checkBox_Szamla.AutoSize = true;
            this.checkBox_Szamla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBox_Szamla.Location = new System.Drawing.Point(386, 170);
            this.checkBox_Szamla.Name = "checkBox_Szamla";
            this.checkBox_Szamla.Size = new System.Drawing.Size(151, 24);
            this.checkBox_Szamla.TabIndex = 4;
            this.checkBox_Szamla.Text = "Kérek számlát";
            this.checkBox_Szamla.UseVisualStyleBackColor = true;
            // 
            // textBox_KivalasztottPizza
            // 
            this.textBox_KivalasztottPizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox_KivalasztottPizza.Location = new System.Drawing.Point(386, 256);
            this.textBox_KivalasztottPizza.Name = "textBox_KivalasztottPizza";
            this.textBox_KivalasztottPizza.Size = new System.Drawing.Size(342, 30);
            this.textBox_KivalasztottPizza.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label1.Location = new System.Drawing.Point(381, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "Válasszon ki egy pizzát a listában";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(386, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Darabszám:";
            // 
            // textBox_Darabszam
            // 
            this.textBox_Darabszam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox_Darabszam.Location = new System.Drawing.Point(510, 290);
            this.textBox_Darabszam.Name = "textBox_Darabszam";
            this.textBox_Darabszam.Size = new System.Drawing.Size(100, 30);
            this.textBox_Darabszam.TabIndex = 8;
            this.textBox_Darabszam.TextChanged += new System.EventHandler(this.textBox_Darabszam_TextChanged);
            // 
            // button_RendelesLeadasa
            // 
            this.button_RendelesLeadasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button_RendelesLeadasa.Location = new System.Drawing.Point(386, 326);
            this.button_RendelesLeadasa.Name = "button_RendelesLeadasa";
            this.button_RendelesLeadasa.Size = new System.Drawing.Size(342, 43);
            this.button_RendelesLeadasa.TabIndex = 9;
            this.button_RendelesLeadasa.Text = "Rendelés leadása";
            this.button_RendelesLeadasa.UseVisualStyleBackColor = true;
            this.button_RendelesLeadasa.Click += new System.EventHandler(this.button_RendelesLeadasa_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 388);
            this.Controls.Add(this.button_RendelesLeadasa);
            this.Controls.Add(this.textBox_Darabszam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_KivalasztottPizza);
            this.Controls.Add(this.checkBox_Szamla);
            this.Controls.Add(this.groupBox_KeszpenzVagyKartya);
            this.Controls.Add(this.button_Atlagar);
            this.Controls.Add(this.listBox_BeolvasottPizzak);
            this.Controls.Add(this.button_FajlBeolvas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "PizzaWinForm";
            this.groupBox_KeszpenzVagyKartya.ResumeLayout(false);
            this.groupBox_KeszpenzVagyKartya.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_FajlBeolvas;
        private System.Windows.Forms.ListBox listBox_BeolvasottPizzak;
        private System.Windows.Forms.Button button_Atlagar;
        private System.Windows.Forms.GroupBox groupBox_KeszpenzVagyKartya;
        private System.Windows.Forms.RadioButton radioButton_Kartya;
        private System.Windows.Forms.RadioButton radioButton_Keszpenz;
        private System.Windows.Forms.CheckBox checkBox_Szamla;
        private System.Windows.Forms.TextBox textBox_KivalasztottPizza;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Darabszam;
        private System.Windows.Forms.Button button_RendelesLeadasa;
    }
}

