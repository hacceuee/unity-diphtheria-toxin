## Example Scenes for JHUAAM Unity Course by Alex 
Hello! There are a couple of scripts you can use. I have set up example scenes. Feel free to reach out to me or submit an issue if you're having any trouble. 

<img width="958" alt="Screenshot 2024-12-05 at 3 19 30 PM" src="https://github.com/user-attachments/assets/500b2026-6939-4d74-a989-c1bfeac1836e">

## Scenes
1) Blue
    - Click mol surface to turn it transparent
    - Toggle turns entire chain off
    
2) Purple
    - Click mol surface to highlight/turn white
    - Toggle turns mol surface transparent
    
3) Pink
    - Click mol surface to isolate that chain
    - Toggle turns mol surface transparent
    
4) Green
    - Click mol surface turn other surfaces transparent
    - Toggle turns entire chain off

## Scripts
### ChangeColor_ToggleMaterial
  1. Input: Two materials (Ex: opaque and transparent), two colors (Ex: blue and white)
  2. Set-up: Place on the object you want to click. Assign the two materials you want to switch between, and the two colors. <br>
  <img width="400" alt="Screenshot 2024-12-05 at 3 28 15 PM" src="https://github.com/user-attachments/assets/41d3adc0-c935-49e7-8058-01a702b21a10"><br>
  On the toggle/switch, assign the object that you put the script on, and set the action to ChangeColor_ToggleMaterial -> SwitchToggled.<br>
  <img width="400" alt="Screenshot 2024-12-05 at 3 28 33 PM" src="https://github.com/user-attachments/assets/a19b92da-74a2-4c74-8f41-02e8e8d477eb"><br>
  3. Action: When clicking on the object, it will change the color of the opaque material. When the toggle is clicked, it will switch the material to transparent, and the color will no longer change. 

### ChangeDifferentObjectMaterial
1. Input: 1 target object, two materials (Ex: opaque and transparent)
2. Set-up: Place on the object you want to click. Assign the target object and the two materials you want to switch between. You will need to do one script for each object you want to change! <br>
   <img width="455" alt="Screenshot 2024-12-05 at 3 35 03 PM" src="https://github.com/user-attachments/assets/470d0f6e-6923-4aba-8e25-04500c88556f">
4. Action: When clicking on the object, it will change the material of the other objects.

### ChangeOtherOnOff
1. Input: Target objects (as many as wanted)
2. Set-up: Place on the object you want to click. Assign the target objects.<br>
   <img width="400" alt="Screenshot 2024-12-05 at 3 34 13 PM" src="https://github.com/user-attachments/assets/3588efe1-86e5-4dd4-aad7-eaf1d38496fa">
3. Action: When clicking on the object, it will turn off the other objects by deactivating them. 

### ChangeOwnMaterial
1. Input: Two materials (Ex: opaque and transparent)
2. Set-up: Place on the object you want to click. Assign the two materials.<br>
<img width="400" alt="Screenshot 2024-12-05 at 3 33 44 PM" src="https://github.com/user-attachments/assets/e8beae6d-5a13-42e8-af13-f692e793dccd"><br>
3. Action: When clicking on the object, it will change its own material. 

## Other Set-Up 
To make the switches turn off objects: <br>
<img width="400" alt="Screenshot 2024-12-05 at 3 36 59 PM" src="https://github.com/user-attachments/assets/f7b7a40f-8976-4c0f-9916-2c609f57df3e">
