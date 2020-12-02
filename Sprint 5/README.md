# Integration of Image Processing And The Robotic Arm

## Screenshots (Input)

The Python program takes screenshots continuously and stores them in a certain directory for access. 
The screenshot is very small (409 pixels) and only covers the key area where object identification will happen.
The image will be transformed into an array (by using the package *numpy*) and then analyzed.

The *numpy.array* function transforms the image into a three-dimention vector img[rows, cols, channels].
It contains the RGB values of the image.
Channel 0 is the Red layer. Channel 1 is the Green layer, and Channel 2 is the Blue layer.
Quantified values make image processing more convenient.

Using the Python program itself to take a screenshot is faster and more convenient than using the Unity Recorder.

![Cuboid](https://github.com/lijinlunbeng/Project-RobotArm-/blob/main/images/14.jpg)
![Sphere](https://github.com/lijinlunbeng/Project-RobotArm-/blob/main/images/15.jpg)


## UI (Interface)

For easy control of the program, we made an interface using *tkinter* package. By clicking on the buttons 
on the interface, we can choose which objects to grab, or whether the arm will grab anything at all.
There are five options: Spheres, Cubes, Cuboids, All objects, and No object.

By pressing the buttons, the Python control program marks the corresponding options as the target, and 
continuously scans the screenshot image for the target. If the target is in the image, it writes "1" in the 
*Control.txt* text file, which will be accessed by the Unity program later. If the target is not in the
image, it writes "0" in the file.

![User Interface](https://github.com/lijinlunbeng/Project-RobotArm-/blob/main/images/16.jpg)

## Connection of Image Processing and Unity Game

There are two programs in this entire project: the image processing program, which is a Python program; and 
the robotic arm simulation game, which is a Unity project. Unity does not support Python, so we seperated 
these two parts of this project. They way we achieve external control of the Unity project using a Python 
program is to let it access a txt file(Control.txt). 

![Integration Plan](https://github.com/lijinlunbeng/Project-RobotArm-/blob/main/images/13.jpg)

Correction: In sprint 4, we put the text file in the Resources folder, which is in fact a part of the Unity
program, and used the *Resources.Load* function to access the file. However, changes to this file can only
come to effect when the user manually open and edit the file, or when the user presses the pause button 
of the game simulation. In other words, external changes to this file (for example, automatic writes and 
reads by the Python program, instead of by the user) is not effective. We assume the reason is that the 
Unity program reads the value of the text file, and stores it buffer only once, instead of reading it 
continuously. 

Another problem that we faced is that an external program (Python program) cannot make changes to a file
in the Unity project. Thus putting the control file in the Resources folder is not applicable, because 
the Resources folder is a part of the Unity project. The Python program reported authorization error when
it was supposed to write 1 to the Control.txt file.

To fix this problem, we abandoned the *Resources.Load* function, and moved the text file to an external
address from the Unity project. We used the FileStream function and StreamReader function to access a 
potentially occupied external file.


## Demo

## Future Plans (Final Presentation)

Debugs (Unity or Python codes)

The accuracy of this system is still to be improved. Although this project is fully functional and should
work automatically with very good accuracy in theory(no manual operation needed), it does not perform 
as expected. The performance of the computer itself is probably the reason. We will look into it in the 
future.

We might be able to provide more ways of identifying the object in the future.