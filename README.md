

# Fall Detection and Emergency Alert System

## Overview
This project is a **Fall Detection and Emergency Alert System** using an **Arduino** and a **vibration sensor**. The system detects if a person has fallen based on vibrations sensed in the tiles and triggers an alarm. A **safety button** allows the person to stop the alarm within 5 minutes to prevent false alerts. If the button is not pressed, an **emergency call** is made to a registered mobile number.

## Features
- **Fall Detection:** Uses a vibration sensor to detect falls.
- **Visual Indicators:** Red and Green LEDs indicate normal and emergency states.
- **Alarm System:** A buzzer sounds when a fall is detected.
- **Safety Button:** Can be pressed within 5 minutes to prevent false alarms.
- **Emergency Call:** If the button is not pressed, the system calls a registered number.

## Components Required
- **Arduino Board**
- **Vibration Sensor**
- **Buzzer**
- **LEDs (Red & Green)**
- **Push Button**
- **Resistors & Wires**

## Circuit Connections
- **Vibration Sensor:** Connected to digital pin **2**.
- **Push Button:** Connected to digital pin **12**.
- **Buzzer:** Connected to digital pin **13**.
- **Green LED:** Connected to digital pin **11**.
- **Red LED:** Connected to digital pin **10**.

## Code Explanation
1. **Initialization**
   - Serial communication is initialized.
   - Pins are configured as INPUT or OUTPUT.
   - A short delay allows the vibration sensor to stabilize.

2. **Loop Execution**
   - Reads the vibration sensor state.
   - If normal (LOW), Red LED is turned ON.
   - If emergency (HIGH), Green LED is turned ON and a **5-second delay** is given for button press.
   - If button is pressed, system resets.
   - If button is not pressed, the buzzer sounds, and an emergency call is made.

3. **Emergency Call**
   - Uses AT commands to dial the registered number.
   - The call is maintained for **20 seconds** before disconnecting.

## How It Works
1. Power ON the system.
2. If a fall occurs, the vibration sensor detects it.
3. The buzzer sounds, and the Green LED turns ON.
4. If the person is safe, they press the button within 5 minutes to stop the alert.
5. If the button is not pressed, an emergency call is made.

## AT Commands Used for Calling
- `AT` → Checks GSM module status.
- `ATD+<PhoneNumber>;` → Dials the registered number.
- `ATH` → Hangs up the call after 20 seconds.

## Future Enhancements
- Implement **SMS alert** along with a call.
- Integrate with **IoT platforms** for remote monitoring.
- Use **Machine Learning** to reduce false alarms.

## Note
- Ensure that the GSM module is properly connected for calling functionality.
- Modify the **phone number** in the `SendSMS()` function to the desired emergency contact.

