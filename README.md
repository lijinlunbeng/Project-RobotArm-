# Project-RobotArm

## Sprint 1

### Inroduction

Analyze images to identify specific items, training the Object Detection method which we need in the picture, and then control the robot arm to implement the capture task.

Computer Language: Python


### Minimum Value Project

The conveyor delivers objects. The robot should identify the object, grab it, and move it to the destination.

![Robot Arm](https://github.com/lijinlunbeng/Project-RobotArm-/blob/main/images/robotarm.jpg)

## Sprint 2

### Definition of archintecture

1. Image processing

Image processing is the problem of identifying to which of a set of categories (sub-populations) a new observation belongs, on the basis of a training set of data containing observations (or instances) whose category membership is known.

2. Robotic arm control system

A control system manages, commands, directs, or regulates the behavior of Robotic Arm using control loops.

3. Overall integration on Unity



### Technology Selection and justification

#### *Obeject Detection* (Python)

Object detection is a computer technology related to computer vision and image processing that deals with detecting instances of semantic objects of a certain class (such as humans, buildings, or cars) in digital images and videos.In our project, we only focus on specific items on the conveyor belt.

#### *Unity Game Machine Learning*

The Unity Machine Learning Agents Toolkit (ML-Agents) is an open-source project that enables games and simulations to serve as environments for training intelligent agents. Agents can be trained using reinforcement learning, imitation learning, neuroevolution, or other machine learning methods through a simple-to-use Python API.

[ML-agents](https://github.com/Unity-Technologies/ml-agents)

![ML-agents](https://github.com/Unity-Technologies/ml-agents/blob/master/docs/images/image-banner.png)

Using Version: Release 7

The Documentation link below include installation and usage instructions specific to each release.

[ML-Examples](https://github.com/Unity-Technologies/ml-agents/tree/release_7)


#### Functional Demonstration of major user story

#### Analysis:

Motion Detection [motiondetection](https://github.com/lijinlunbeng/Project-RobotArm-/tree/main/MotionDetection)

![](https://github.com/lijinlunbeng/Project-RobotArm-/blob/main/images/7.jpg)

![](https://github.com/lijinlunbeng/Project-RobotArm-/blob/main/images/8.jpg)

These two pictures show our personal motion detection code, which are trying to find the specific items (USB item), but unfortunatly, it doesn't work well to recongnize what we want. So we find another alternative way (Yolo), we will talk details in sprint 3.

#### Analysis:

3DBalls(*Unity*)

![](https://github.com/lijinlunbeng/Project-RobotArm-/blob/main/images/1.png)

![](https://github.com/lijinlunbeng/Project-RobotArm-/blob/main/images/2.png)

![](https://github.com/lijinlunbeng/Project-RobotArm-/blob/main/images/3.png)

The first picture shows that our 3D ball easy game. It is a balance ball task, where the agent balances the ball on it's head. And the goal of it, the agent must balance the ball on it's head for as long as possible. The environment contains 12 agents of the same kind, all using the same bahavior parameters. Hence, for the agent reward function, +0.1 for every step the ball reamins on it's head, or -1.0 if the ball falls of.

The second picture shows that the bahavior parameters of our 3D balls. Vector Observation space: 8 variables corresponding to rotation of the agent cube, and position and velocity of ball. Vector Observation space (Hard Version): 5 variables corresponding to rotation of the agent cube and position of ball. Vector Action space: (Continuous) Size of 2, with one value corresponding to X-rotation, and the other to Z-rotation. Visual Observations: Third-person view from the upper-front of the agent.

The third picture shows that our local trainings.

#### Analysis:

Reacher(*Unity*)

![](https://github.com/lijinlunbeng/Project-RobotArm-/blob/main/images/4.png)

![](https://github.com/lijinlunbeng/Project-RobotArm-/blob/main/images/5.png)

![](https://github.com/lijinlunbeng/Project-RobotArm-/blob/main/images/6.jpg)

The first picture shows that our reacher game. There are 24 recatangular maps, and each map has one white reacher agent. And then reacher agents will use their blue head to touch the green balls to gain winning scores. The agents must move its head to the goal location, and keep it there. The environment contains 10 agents will same behavior parameters. And the reward functions is independent, +0.1 each step agens' head is in goal location
Through a long time training, each agent will have highly abilty to catch the green balls. 

The second picture shows the behavior parameters of our agents.Vector Observation space: 26 variables corresponding to position, rotation, velocity, and angular velocities of the two arm rigid bodies. Vector Action space: (Continuous) Size of 4, corresponding to torque applicable to two joints.
Visual Observations: None.

The third pirctures show our trainings.

## Sprint 3
1.Improve Object Detection （Supply a gap, e.g.:Yolo)

[Yolo-example](https://www.youtube.com/watch?v=4eIBisqx9_g)

You only look once (Yolo) is a system for detecting objects on the Pascal VOC 2012 dataset. It can detect the 20 Pascal object classes:

  a.bird, cat, cow, dog, horse, sheep
  b.aeroplane, bicycle, boat, bus, car, motorbike, train
  c.bottle, chair, dining table, potted plant, sofa, tv/monitor
  d.person

2.Integration in the Unity

3.Improve Drive System
