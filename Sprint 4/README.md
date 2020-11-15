# Sprint 4

Imagin Processing (Yolo)

We are trying to achieving and reproduce Yolo's module.

[Yolo](https://github.com/pjreddie/darknet/wiki/YOLO:-Real-Time-Object-Detection)

### Unity Project Review
We continued to study the Unity software, had a better 
understanding of online code examples and the ml-agents 
toolkit provided by the Unity offcials. 
We fixed some bugs, and made some adjustments to some of
the parameters in the project for better performance.

We discovered by studying the ml-agents example projects that 
a tf-model is needed for machine learning within the Unity
software. The "tf-model" is the model with which the system 
implements the tensorflow machine learning package. 

The 3DBall example project is an example in the ml-agents 
toolkit provided by the Unity Technology. We discovered that 
its tfmodel had 34 layers and 26 constants(using 41 weights). 
By interacting with this model file, the Unity software is
able to train the agents with tensorflow, which is a tool 
for machine learning. However, how this model should be written 
and how the scripts interact with it are not clear yet. We 
plan to take a deeper look in the future.

### Object Identification: YOLO

### Integration within Unity
We plan to integrate the Unity project itself with the Object 
Detection module.

The robot in Unity software is one of the two modules of the
entire project. The other module is the identification of objects.
Currently in the first module, we assume that the robot 
is able to identify the objects. The actions of grabbing them 
and counting them are based on this assumption. Therefore, the 
two modules of the project is now separated. 

To end the separation, we will integrate these modules together.

The object identification module is not within the Unity software.
To communicate with an external program, we need to output images
or video clips collected by the Unity software, and save it in a certain 
directory for the identification module to use. The identification 
program then identifies the object, and writes instruction into a 
file. The file will be read by the Unity project, which will then
act correspondingly.

*Task 1: Output record files*

We installed a plugin in the Unity project. Using the recorder plugin, 
we can record the scene in Unity, and save it in an external directory.

*Task 2: External of a Unity project*

