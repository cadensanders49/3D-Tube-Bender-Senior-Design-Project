# 3D-Tube-Bender

The 3D Tube Bender project code base was created as part of my Senior Design project. The front-end runs off of WinForms which can be seen in the development photo below. The back-end uses serial communication drivers controlled through C#.

Our 3D Tube Bender was designed to bend quarter-inch copper tubing into helices and other complex geometries by implementing techniques from roll bending and rotary draw bending. The copper tubing needs to be loaded into the machine for bending. High torque servo motors are used to guide the dies to make bends while a continuous rotation servo pushes the tubing through the dies. The electrical aspect of the project is divided into three critical elements: power, motor control, and user interface. The power system will provide proper voltages to each component. The motor control system controls the die head assembly and the linear actuator to make the bends. The user interface communicates with the operator to get information about the desired bends while implementing safety features.

## WinForms Development
![alt text](https://github.com/cadensanders49/3D-Tube-Bender/blob/master/Graphics/ReadMeImages/Development%20Environment.PNG)

Our goal was to create a user-friendly system through intuitive UI controls with built-in safety protections. We were able to abstract the serial communication codes using simple UI buttons and numeric controls. The running UI can be seen in the photo below.

## UI in Action
![alt text](https://github.com/cadensanders49/3D-Tube-Bender/blob/master/Graphics/ReadMeImages/Running.PNG)

Some examples of the hardware and the configurations used can be seen in the photos below.

## Hardware
#### Controller
![alt text](https://github.com/cadensanders49/3D-Tube-Bender/blob/master/Graphics/ReadMeImages/Maestro.jpg)

#### Motor
<img src="https://github.com/cadensanders49/3D-Tube-Bender/blob/master/Graphics/ReadMeImages/Large%20Servo%20Motor.png" width="500" height="500" class="center">

### Functional Diagram
![alt text](https://github.com/cadensanders49/3D-Tube-Bender/blob/master/Graphics/ReadMeImages/Motor%20with%20Feedback%20v2.png)
