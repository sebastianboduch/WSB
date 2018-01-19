#include "DHT.h"
#include <LiquidCrystal.h>
#define DHTPIN 8
#define DHTTYPE DHT22
DHT dht(DHTPIN, DHTTYPE);
const int rs = 12, en = 11, d4 = 5, d5 = 4, d6 = 3, d7 = 2;
LiquidCrystal lcd(rs, en, d4, d5, d6, d7);
String odczyt_serial = "";
String czujnikString = "nie";
boolean koniec_odczytu = false;
int czujnik = 7;

void setup() {
  Serial.begin(9600);
  dht.begin();
  lcd.begin(16, 2);
  lcd.clear();
  lcd.print("DZIEN DOBRY !!!");
  pinMode(czujnik, INPUT);
}

void loop() {
  delay(150);
  if (digitalRead(czujnik) == 0)
  {
    czujnikString = "1";
  }
  else {
    czujnikString = "0";
  }

  float h = dht.readHumidity();
  float t = dht.readTemperature();
  Serial.print("@a#");
  Serial.print(t);
  Serial.print("#");
  Serial.print(h);
  Serial.print("#");
  Serial.println(czujnikString);

  if (Serial.available() > 0)
  {
    while (Serial.available())
    {
      char wiadomosc = (char)Serial.read();
      odczyt_serial += wiadomosc;
      if (wiadomosc == '\n')
      {
        koniec_odczytu = true;
      }
      if (koniec_odczytu == true)
      {
        lcd.clear();
        lcd.print(odczyt_serial);

        koniec_odczytu = false;
        odczyt_serial = "";
      }
    }
  }
}
