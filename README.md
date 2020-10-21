# Project-RobotArm-sprint 2

## Sprint 1

### Inroduction

Analyze images to identify specific items, training the Object Detection method which we need in the picture, and then control the robot arm to implement the capture task.

Computer Language: Python


### Minimum Value Project

The conveyor delivers objects. The robot should identify the object, grab it, and move it to the destination.

![Robot Arm](https://github.com/lijinlunbeng/Project-RobotArm-/blob/main/images/robotarm.jpg)

## Definition of archintecture

1. Image processing

Image processing is the problem of identifying to which of a set of categories (sub-populations) a new observation belongs, on the basis of a training set of data containing observations (or instances) whose category membership is known.

2. Robotic arm control system

A control system manages, commands, directs, or regulates the behavior of Robotic Arm using control loops.

3. Overall integration on Unity



## Technology Selection and justification

### *Obeject Detection* (Python)

Object detection is a computer technology related to computer vision and image processing that deals with detecting instances of semantic objects of a certain class (such as humans, buildings, or cars) in digital images and videos.In our project, we only focus on specific items on the conveyor belt.

### *Unity Game Machine Learning*

The Unity Machine Learning Agents Toolkit (ML-Agents) is an open-source project that enables games and simulations to serve as environments for training intelligent agents. Agents can be trained using reinforcement learning, imitation learning, neuroevolution, or other machine learning methods through a simple-to-use Python API.

[ML-agents](https://github.com/Unity-Technologies/ml-agents)

![ML-agents](https://github.com/Unity-Technologies/ml-agents/blob/master/docs/images/image-banner.png)

Using Version: Release 7

The Documentation link below include installation and usage instructions specific to each release.

[ML-Examples](https://github.com/Unity-Technologies/ml-agents/tree/release_7)


## Functional Demonstration of major user story

### Analysis:

Motion Detection(wallet)

### Analysis:

3DBalls(*Unity*)

### Analysis:

Reacher(*Unity*)

## Sprint 3
1.Improve Object Detection （Supply a gap, e.g.:Yolo)

[Yolo-example](https://www.youtube.com/watch?v=4eIBisqx9_g)

You only look once (YOLO) is a system for detecting objects on the Pascal VOC 2012 dataset. It can detect the 20 Pascal object classes:

  a.bird, cat, cow, dog, horse, sheep
  b.aeroplane, bicycle, boat, bus, car, motorbike, train
  c.bottle, chair, dining table, potted plant, sofa, tv/monitor
  d.person

2.Integration in the Unity

3.Improve Drive System
