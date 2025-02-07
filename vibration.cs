const int vibrationsensor = 2;
const int buttonPin = 12;  
const int buzzerPin =  13;
const int Green_led =  11;
const int Red_led =  10;
int buttonState = 0;
int Sensor_State = 0;  
int f1=0;
int i=0;


void setup()
{
  Serial.begin(9600); 
  Serial.println("Vibration sensor warming up!");
  delay(2000); 
  pinMode(buzzerPin, OUTPUT);
  pinMode(Green_led, OUTPUT);
  pinMode(Red_led, OUTPUT);
  pinMode(vibrationsensor, INPUT);
  pinMode(buttonPin, INPUT);
  digitalWrite(buzzerPin, LOW);
}

void loop()
{
  Sensor_State = digitalRead(vibrationsensor);
  Serial.println(Sensor_State);
  if(Sensor_State == LOW)
  {
    Serial.print(" Normal");
    digitalWrite(Green_led, LOW);
    digitalWrite(Red_led, HIGH);
  }
  else if(Sensor_State == HIGH)
  {
        digitalWrite(Red_led, LOW);
        digitalWrite(Green_led, HIGH);
        Serial.print(" Emergency ");
        for (i=0; i<=5; i++)
        {
        buttonState = digitalRead(buttonPin);
        delay(1000);
        if(buttonState == HIGH)98io9io
        {
            f1=1;
            break;
        }
        }
    
        if (buttonState == HIGH && f1 == 1)
        {
            delay(4000);
            digitalWrite(Red_led, LOW);
            digitalWrite(Green_led, HIGH);
        }
        else if (buttonState == LOW && f1 == 0)
        {
            delay(4000);
            digitalWrite(Red_led, LOW);
            digitalWrite(Green_led, HIGH);
            digitalWrite(buzzerPin, HIGH);
            SendSMS();
            Serial.println("calling....");
            digitalWrite(buzzerPin, LOW);
        }
    }
  Serial.println("");
}

void SendSMS()
{
  Serial.println("AT");    
  delay(1000);
  Serial.println("ATD+ +919944553102;"); 
  delay(20000);
  Serial.println("ATH");
}
