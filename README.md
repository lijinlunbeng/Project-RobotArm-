# Project-RobotArm

## Task

Put a self-learning robot by a conveyor and let it learn for itself what to do. A repository for EC601 Product Design Section A2 Team 5 project.

## Contributors: 

Yongjie Yang - yangyj@bu.edu 

Sen Zhang - jasonall@bu.edu

**If you like this project, please give us a star**

## Sprint 1

[Sprint 1](https://github.com/lijinlunbeng/Project-RobotArm-/tree/main/Sprint%201)

### Inroduction

Analyze images to identify specific items, training the Object Detection method which we need in the picture, and then control the robot arm to implement the capture task.

Computer Language: Python


### Minimum Value Project

The conveyor delivers objects. The robot should identify the object, grab it, and move it to the destination.

![Robot Arm](https://github.com/lijinlunbeng/Project-RobotArm-/blob/main/images/robotarm.jpg)

### Definition of archintecture

1. Image processing

Image processing is the problem of identifying to which of a set of categories (sub-populations) a new observation belongs, on the basis of a training set of data containing observations (or instances) whose category membership is known.

2. Robotic arm control system

A control system manages, commands, directs, or regulates the behavior of Robotic Arm using control loops.

3. Overall integration on Unity




## Sprint 2

### Technology Selection and justification

Focusing on basic implementation of image processing and robot machine learning. [Sprint 2](https://github.com/lijinlunbeng/Project-RobotArm-/tree/main/Sprint%202)

#### *Obeject Detection* (Python)

Object detection is a computer technology related to computer vision and image processing that deals with detecting instances of semantic objects of a certain class (such as humans, buildings, or cars) in digital images and videos.In our project, we only focus on specific items on the conveyor belt.

#### *Unity Game Machine Learning*

The Unity Machine Learning Agents Toolkit (ML-Agents) is an open-source project that enables games and simulations to serve as environments for training intelligent agents. Agents can be trained using reinforcement learning, imitation learning, neuroevolution, or other machine learning methods through a simple-to-use Python API.

## Sprint 3

[Sprint 3](https://github.com/lijinlunbeng/Project-RobotArm-/tree/main/Sprint%203)

Build a new basic Unity game of a ArmRobot

![ArmRobot](https://github.com/lijinlunbeng/Project-RobotArm-/blob/main/images/10.PNG)

## Sprint 4

[Sprint 4](https://github.com/lijinlunbeng/Project-RobotArm-/tree/main/Sprint%204)

### Improve Object Detection

The Python program takes screenshots continuously and stores them in a certain directory for access. 
The screenshot is very small (409 pixels) and only covers the key area where object identification will happen.
The image will be transformed into an array (by using the package *numpy*) and then analyzed.


## Sprint 5

[Sprint 5](https://github.com/lijinlunbeng/Project-RobotArm-/tree/main/Sprint%205)

Integration our Unity game and Image Processing

### Improve User Interface

For easy control of the program, we made an interface using *tkinter* package. By clicking on the buttons 
on the interface, we can choose which objects to grab, or whether the arm will grab anything at all.
There are five options: Spheres, Cubes, Cuboids, All objects, and No object.



