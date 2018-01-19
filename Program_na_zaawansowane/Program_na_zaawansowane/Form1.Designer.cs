namespace Program_na_zaawansowane
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.buttonPolacz = new System.Windows.Forms.Button();
            this.buttonRozlacz = new System.Windows.Forms.Button();
            this.serialPort2 = new System.IO.Ports.SerialPort(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboNumerPortu = new System.Windows.Forms.ComboBox();
            this.comboPredkoscTransmisji = new System.Windows.Forms.ComboBox();
            this.stanPolaczenia = new System.Windows.Forms.Label();
            this.textBoxWiadomosc = new System.Windows.Forms.TextBox();
            this.buttonWyslij = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lamp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Temperatura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Wilgotność";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(105, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(154, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(105, 52);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(154, 20);
            this.textBox2.TabIndex = 3;
            // 
            // buttonPolacz
            // 
            this.buttonPolacz.Location = new System.Drawing.Point(265, 271);
            this.buttonPolacz.Name = "buttonPolacz";
            this.buttonPolacz.Size = new System.Drawing.Size(75, 23);
            this.buttonPolacz.TabIndex = 4;
            this.buttonPolacz.Text = "POŁĄCZ";
            this.buttonPolacz.UseVisualStyleBackColor = true;
            this.buttonPolacz.Click += new System.EventHandler(this.buttonPolacz_Click);
            // 
            // buttonRozlacz
            // 
            this.buttonRozlacz.Location = new System.Drawing.Point(265, 305);
            this.buttonRozlacz.Name = "buttonRozlacz";
            this.buttonRozlacz.Size = new System.Drawing.Size(75, 23);
            this.buttonRozlacz.TabIndex = 5;
            this.buttonRozlacz.Text = "ROZŁĄCZ";
            this.buttonRozlacz.UseVisualStyleBackColor = true;
            this.buttonRozlacz.Click += new System.EventHandler(this.buttonRozlacz_Click);
            // 
            // serialPort2
            // 
            this.serialPort2.PortName = "COM3";
            this.serialPort2.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort2_DataReceived);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Numer portu:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 26);
            this.label5.TabIndex = 12;
            this.label5.Text = "Prędkość \r\ntransmisji:";
            // 
            // comboNumerPortu
            // 
            this.comboNumerPortu.FormattingEnabled = true;
            this.comboNumerPortu.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9"});
            this.comboNumerPortu.Location = new System.Drawing.Point(105, 278);
            this.comboNumerPortu.Name = "comboNumerPortu";
            this.comboNumerPortu.Size = new System.Drawing.Size(121, 21);
            this.comboNumerPortu.TabIndex = 13;
            // 
            // comboPredkoscTransmisji
            // 
            this.comboPredkoscTransmisji.FormattingEnabled = true;
            this.comboPredkoscTransmisji.Items.AddRange(new object[] {
            "300",
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600"});
            this.comboPredkoscTransmisji.Location = new System.Drawing.Point(105, 305);
            this.comboPredkoscTransmisji.Name = "comboPredkoscTransmisji";
            this.comboPredkoscTransmisji.Size = new System.Drawing.Size(121, 21);
            this.comboPredkoscTransmisji.TabIndex = 14;
            // 
            // stanPolaczenia
            // 
            this.stanPolaczenia.AutoSize = true;
            this.stanPolaczenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.stanPolaczenia.Location = new System.Drawing.Point(364, 290);
            this.stanPolaczenia.Name = "stanPolaczenia";
            this.stanPolaczenia.Size = new System.Drawing.Size(46, 17);
            this.stanPolaczenia.TabIndex = 15;
            this.stanPolaczenia.Text = "label3";
            // 
            // textBoxWiadomosc
            // 
            this.textBoxWiadomosc.Location = new System.Drawing.Point(12, 135);
            this.textBoxWiadomosc.MaxLength = 25;
            this.textBoxWiadomosc.Name = "textBoxWiadomosc";
            this.textBoxWiadomosc.Size = new System.Drawing.Size(151, 20);
            this.textBoxWiadomosc.TabIndex = 16;
            // 
            // buttonWyslij
            // 
            this.buttonWyslij.Location = new System.Drawing.Point(169, 114);
            this.buttonWyslij.Name = "buttonWyslij";
            this.buttonWyslij.Size = new System.Drawing.Size(75, 41);
            this.buttonWyslij.TabIndex = 17;
            this.buttonWyslij.Text = "Wyślij";
            this.buttonWyslij.UseVisualStyleBackColor = true;
            this.buttonWyslij.Click += new System.EventHandler(this.buttonWyslij_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Wiadomość do wyświetlenia";
            // 
            // lamp
            // 
            this.lamp.BackColor = System.Drawing.Color.Red;
            this.lamp.Location = new System.Drawing.Point(356, 42);
            this.lamp.Name = "lamp";
            this.lamp.Size = new System.Drawing.Size(166, 123);
            this.lamp.TabIndex = 19;
            this.lamp.Text = "button1";
            this.lamp.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 356);
            this.Controls.Add(this.lamp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonWyslij);
            this.Controls.Add(this.textBoxWiadomosc);
            this.Controls.Add(this.stanPolaczenia);
            this.Controls.Add(this.comboPredkoscTransmisji);
            this.Controls.Add(this.comboNumerPortu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonRozlacz);
            this.Controls.Add(this.buttonPolacz);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button buttonPolacz;
        private System.Windows.Forms.Button buttonRozlacz;
        private System.IO.Ports.SerialPort serialPort2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboNumerPortu;
        private System.Windows.Forms.ComboBox comboPredkoscTransmisji;
        private System.Windows.Forms.Label stanPolaczenia;
        private System.Windows.Forms.TextBox textBoxWiadomosc;
        private System.Windows.Forms.Button buttonWyslij;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button lamp;
    }
}

