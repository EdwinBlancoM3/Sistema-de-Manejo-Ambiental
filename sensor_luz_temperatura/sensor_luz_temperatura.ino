#include "DHT.h"
#include "SoftwareSerial.h"
#define DHTPIN 7 //Humedad y Temperatura Salida Digital
#define DHTTYPE DHT11 //Sensor de Humedad y Temperatura
DHT dht(DHTPIN, DHTTYPE);
int sensorPin = A1; // select the input pin for the potentiometer
int sensorTierra=A2;
int ledPin = 13; // select the pin for the LED
int sensorValue = 0; // variable to store the value coming from the sensor

// Pin analogico de entrada para el LDR
int pinLDR = 0;

// Variable donde se almacena el valor del LDR
int valorLDR = 0;  
int valorSuelo;


void setup () 
{
  pinMode (ledPin, OUTPUT);
  pinMode(10,OUTPUT); //LEDS
  pinMode(2,OUTPUT);  //Ventilador
  pinMode(6,OUTPUT);  //Bomba de Agua
  Serial.begin (9600);
  dht.begin();
}
 
void loop () 
{
  int h = dht.readHumidity();// Lee la humedad
  int t= dht.readTemperature();//Lee la temperatura
  sensorValue = analogRead (sensorPin);
  digitalWrite (ledPin, HIGH);
  delay (3000);
  digitalWrite (ledPin, LOW);
  delay (3000);
  int l=sensorValue;
  // Guardamos el valor leido del ADC en una variable
  // El valor leido por el ADC (voltaje) aumenta de manera directamente proporcional
  // con respecto a la luz percibida por el LDR
  valorLDR= analogRead(pinLDR);
  valorSuelo=analogRead(sensorTierra);
  
  Serial.println("a,"+(String)t+","+(String)h+","+(String)l+","+(String) valorLDR+","+(String) valorSuelo+",b,");

   while (Serial.available())
 {
 //Guardamos en dato el valor leido del puerto serie
 byte dato = Serial.read();
 switch (dato){
 //Si es '1' encendemos el led
 case '1':
 digitalWrite(10,HIGH);
  break;
 //Si es '0' apagamos el led
 case '0':
 digitalWrite(10,LOW);
 break;
 case '2':
 digitalWrite(2,HIGH);
 break;
 case '3':
 digitalWrite(2,LOW);
 break;
 case '4':
 digitalWrite(6,HIGH);
 break;
 case '5':
 digitalWrite(6,LOW);
 break;
 }
  
  //

//////////////////////////////////////////////////Humedad

///////////////////////////////////////////////////Temperatura              

///////////////////////////////////////////////////             
 }
}
