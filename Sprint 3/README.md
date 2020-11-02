# Sprint 3

## Deccription

The phase 3 features building and simulating the robotic arm
using Unity3D, which is a widely used game engine. The model in the game is a robotic arm with 3 nodes (represented as a ball) and 3 segments (represented as a pillar). The nodes can rotate along with its segment, thus moving the robotic arm.

Unity is a powerful game engine that enables the user to make fine simulations and games. It has built-in physics algorithm, and enables specific modifications to many features of an object, e.g. fraction, material, 
object type, timescale, size, etc. There are also many resources online that can help one to learn about this software. This is an important reason for our choosing 
this game engine for the simulation of the project. 

C# and JavaScript are two of the programming languages that Unity supports. C# is very similar to C/C++, and is therefore easier for us to pick up. We have studied many programs and tutorial materials online, and chose C# as the programming language for the scripts in this project. 

This is only a very basic model, but is contains the necessary features that the MVP should include. Further improvements are to be made.


## Core function: Rotation

**Node.transform.DORotate(new Vector3(x, y, z), GrabTime, RotateMode)**

Rotation of the robotic arm is done by rotating the node with the function **transform.DORotate**.
We can specify a vector in 3D (key word: new vector3) and give it three parameters: 
x, y, and z. These are the angles by which the node rotates around the corresponding axis.
 For example, if we want the node to rotate around axis x by 50 degrees, we will write the function as: **Node.transform.DORotate(new Vector3(50, 0, 0), GrabTime, RotateMode)**
 
Unity also supports many plugins that provide good supplement for the engine. DOTween is a plugin that enables advanced rotation functions. It can be used by importing the library with "using DG.tweening". Some versions of Unity might have it installed already.

## ArmRobot Unity Model

A famous game in Steam Platform (Factorio)

![Factorio](https://github.com/lijinlunbeng/Project-RobotArm-/blob/main/images/Gl4ckPl.jpg)

This is our Unity model of ArmRobot. 

![ArmRobot](https://github.com/lijinlunbeng/Project-RobotArm-/blob/main/images/10.PNG)

![ArmRobot2](https://github.com/lijinlunbeng/Project-RobotArm-/blob/main/images/11.PNG)

### Code

[Code Components](https://github.com/lijinlunbeng/Project-RobotArm-/tree/main/Sprint%203/ARM/Assets/Script)

Ten components in the file.

1.Edge
2.Grab
3.Item
4.ItemPlane (Conveyor)
5.MechanicalArm
6.Move
7.MovePlane
8.Node (three)
9.Region
10.UI

#### Without Machine Learning

Basically, we have assumed knowing what item it is.

#### MachanicalArm Coding

### User Interface

There are three lines shows our grabing results

### Demo

### Shortages

1.Some dropping items bug

2.Time is inaccurate sometimes

3.ArmRobot cannot grab all items

### Conference

We really appreaciate some links from website to help us a lot for doing this.

1. [Code](https://blog.csdn.net/Ro969668074/article/details/84788173?utm_medium=distribute.pc_relevant.none-task-blog-BlogCommendFromMachineLearnPai2-1.channel_param&depth_1-utm_source=distribute.pc_relevant.none-task-blog-BlogCommendFromMachineLearnPai2-1.channel_param)


2. [Draw Unity Game](https://www.youtube.com/watch?v=7_JdDUGmLL0)

3. [Unity 3D Arm](https://github.com/JinghanSun/armSimulationByUnity3D)

4. [ArmSwinger](https://github.com/ElectricNightOwl/ArmSwinger)

5. [Conveyorbelt](https://www.youtube.com/watch?v=zTXSdvKs5lc)

6. [Eulerrangle](https://blog.csdn.net/schrodinger1900/article/details/52734568)


# Sprint 4

Imagin Processing (Yolo)

We are trying to achieving and reproduce Yolo's module.

[Yolo](https://github.com/pjreddie/darknet/wiki/YOLO:-Real-Time-Object-Detection)
