# Sprint 4

## Unity Project Review
We continued to study the Unity software, had a better 
understanding of online code examples and the ml-agents 
toolkit provided by the Unity offcials. 
We fixed some bugs, and made some adjustments to some of
the parameters in the project for better performance.

We discovered by studying the ml-agents example projects that a tf-model is needed for machine learning within the Unity software. The "tf-model" is the model with which the system implements the tensorflow machine learning package. 

The 3DBall example project is an example in the ml-agents 
toolkit provided by the Unity Technology. We discovered that 
its tfmodel had 34 layers and 26 constants(using 41 weights). 

![3DBall](https://github.com/lijinlunbeng/Project-RobotArm-/blob/main/images/12.jpg)

By interacting with this model file, the Unity software is
able to train the agents with tensorflow, which is a tool 
for machine learning. However, how this model should be written and how the scripts interact with it are not clear yet. We plan to take a deeper look in the future.

## Object Identification

Imagin Processing (Yolo)

We are trying to achieving and reproduce Yolo's module.

[Yolo](https://github.com/pjreddie/darknet/wiki/YOLO:-Real-Time-Object-Detection)

## Integration within Unity
We plan to integrate the Unity project itself with the Object Detection module.

![Integration Plan](https://github.com/lijinlunbeng/Project-RobotArm-/blob/main/images/13.jpg)

The robot in Unity software is one of the two modules of the
entire project. The other module is the identification of objects.
Currently in the first module, we assume that the robot 
is able to identify the objects. The actions of grabbing them and counting them are based on this assumption. Therefore, the two modules of the project is now separated. 

To end the separation, we will integrate these modules together.

The object identification module is not within the Unity software.
To communicate with an external program, we need to output images or video clips collected by the Unity software, and save it in a certain directory for the identification module to use. The identification program then identifies the object, and writes instruction into a file. The file will be read by the Unity project, which will then act correspondingly.

*Task 1: Output record files*

We installed a plugin in the Unity project. Using the recorder plugin, we can record the scene in Unity, and save it in an external directory.

The recorder can record and save the results in multiple formats, including image sequences(.jpg files), video clips(.mp4 files), animation clips(.anmi files), etc. The records can be accessed by the object identification
module.

*Task 2: External Control of a Unity project*

To simulate the control of identification module to the robotic arm, said module gives control signals to the Unity project. The control signal is a .txt file in the /Assets/Resources directory. If the identification module detects the object that should be grabbed, it overwrites the text
file with "1", otherwise "0". 

We then inserted an if sentence in the grab function of the robotic arm script(file: MechanicalArm.cs). The grab function controls the grab action of the robotic arm. If it reads an "1", it will grab the object; if it reads anything else, it will not grab anything. 

Changes to this Control.txt file becomes effective immediately and do not require the Unity simulation to stop. It can be changed anytime, even when the Unity simulation is running, and when the next object comes, the robotic arm acts under the control of the changed Control.txt file.

## Summary (Sprint 5)

We have finished the majority of the entire project, and have achieved external control of the Unity game simulation. The information and control close-loop is established, except that the object identification module is not ready. The Unity game can even be controlled manually, where
human control takes the place of object identification module.
 
Tasks yet to be done are:

- The object identification module is still malfunctioning. We will fix it and make it functional soon.

- There are some bugs in the Unity game. Sometimes multiple objects are placed on the conveyor belt at the same time and they all collide with each other. We have not figured out the reason for this.

