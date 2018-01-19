using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace Program_na_zaawansowane
{
    public partial class Form1 : Form
    {

        string wilgotnosc;
        string temperatura;
        string numerPortu;
        string predkoscTransmisjiString;
        string stanLampy;
        int stanLampyInt;
        int predkoscTransmisjiInt;
        public bool parz = true;
        public Form1()
        {
            InitializeComponent();
            buttonRozlacz.Enabled = false;
            stanPolaczenia.Text = "Brak połączenia";
            lamp.Text = "Nieaktywny";
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e) // instrukcje jakie mają się wykonac w przypadku wyłączenia okna programu
        {
            serialPort2.Close();
        }

        private void serialPort2_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {

            string odczyt = serialPort2.ReadLine();
            string[] wartosciOdczytu = odczyt.Split('#');

            if (wartosciOdczytu.Length == 4)
            {
                temperatura = wartosciOdczytu[1];
                wilgotnosc = wartosciOdczytu[2];
                stanLampy = wartosciOdczytu[3];
                Int32.TryParse(stanLampy, out stanLampyInt);
                this.Invoke(new EventHandler(WyswietlDane));
                this.Invoke(new EventHandler(ZapalLampe));

            }
        }


        private void WyswietlDane(object sender, EventArgs e)
        {

            textBox1.Text = temperatura + " °C";
            textBox2.Text = wilgotnosc + " %";

        }

        private void ZapalLampe(object sender, EventArgs e)
        {
            if (stanLampyInt == 1)
            {
                lamp.BackColor = Color.Lime;
                lamp.Text = "Aktywny";
            }
            else
            {
                lamp.BackColor = Color.Red;
                lamp.Text = "Nieaktywny";
            }

        }

        private void buttonPolacz_Click(object sender, EventArgs e)
        {
            if (comboNumerPortu.SelectedItem == null || comboPredkoscTransmisji.SelectedItem == null)
            {
                MessageBox.Show(this, "Podaj numer portu i prędkość transmisji.", "Brak danych", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (!serialPort2.IsOpen)
                {
                    try
                    {

                        numerPortu = comboNumerPortu.SelectedItem.ToString();
                        predkoscTransmisjiString = comboPredkoscTransmisji.SelectedItem.ToString();
                        Int32.TryParse(predkoscTransmisjiString, out predkoscTransmisjiInt);
                        serialPort2.PortName = numerPortu;
                        serialPort2.BaudRate = predkoscTransmisjiInt;
                        serialPort2.Open();
                    }
                    catch
                    {
                        MessageBox.Show(this, "Nie podłączono urządzenia lub jest zajęte przez inną aplikację.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    stanPolaczenia.Text = "Otwarto port " + serialPort2.PortName;

                    buttonPolacz.Enabled = false;
                    buttonRozlacz.Enabled = true;

                }
            }
        }

        private void buttonRozlacz_Click(object sender, EventArgs e)
        {
            serialPort2.Close();
            stanPolaczenia.Text = "Zamknieto port " + serialPort2.PortName;

            buttonPolacz.Enabled = true;
            buttonRozlacz.Enabled = false;
        }

        private void buttonWyslij_Click(object sender, EventArgs e)
        {
            if (!serialPort2.IsOpen)
            {
                MessageBox.Show(this, "Brak połączenia.", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string wiadomosc = textBoxWiadomosc.Text;
                serialPort2.WriteLine(wiadomosc);
            }
        }
    }
}
