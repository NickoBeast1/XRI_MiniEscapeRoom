# XR Interaction Toolkit – Individual Mini Project

**Author:** Nick Hesbourne Agon’g  
**Unity Version:** 2021.3.18f1  
**XR Interaction Toolkit: 3.3.1** 
  

---

##  Project Overview

This individual mini-project focuses exclusively on mastering the functionalities provided by the **XR Interaction Toolkit (XRI)**.

The objective of this project is strictly technical and conceptual. The emphasis is placed on:

- Interaction logic  
- Object manipulation  
- Event-driven architecture  
- Socket-based object placement  
- Scene state progression  

Visual or artistic aspects were intentionally kept minimal in order to focus on correct implementation of VR interaction principles.

---

##  Learning Objectives Demonstrated

This project demonstrates correct implementation of:

-  XR Origin setup  
-  Locomotion (Continuous Move / Turn or Teleport)  
-  XR Grab Interactable  
-  XR Socket Interactor  
-  UnityEvents for interaction-driven logic  
-  Conditional activation of environment elements  
-  Centralized Hint / Feedback System  

---

##  Experience Flow

The experience follows a minimal escape-room–style interaction logic.

### 1️. Button Interaction
- A button is pressed using an XRI-based interactable.
- A UnityEvent is triggered.
- A crystal object becomes active in the scene.
- A contextual hint is displayed to guide the user.

### 2️. Object Manipulation
- The crystal uses **XR Grab Interactable**.
- When grabbed, a `Select Entered` event triggers contextual feedback.
- This demonstrates event-based interaction handling tied directly to XRI components.

### 3️. Socket-Based Placement
- A brazier contains an **XR Socket Interactor**.
- When the crystal is placed correctly:
  - A particle system is activated.
  - Environment state changes occur.
  - A new hint is displayed.
  - A new interaction stage is unlocked.

This validates correct use of **Socket Interactor events** to drive progression logic.

### 4️. State Progression
The project implements progressive unlocking behavior:
- Interactions modify environment states.
- Events are modular and centrally managed.
- No complex gameplay scripting was required — logic relies on XRI and UnityEvents.

---

##  Technical Architecture

### Core Components Used

- `XR Origin`
- `XR Grab Interactable`
- `XR Socket Interactor`
- Unity `Collider` and `Trigger` systems
- UnityEvents
- Centralized `HintManager`

### Design Approach

- Event-driven architecture
- Modular interaction logic
- Clear separation between interaction input and scene response
- Minimal dependency on heavy scripting

The design ensures that interaction flow remains transparent and aligned with XRI best practices.

---

##  Controls

If tested using XR Device Simulator (desktop mode):

- **Movement:** WASD  
- **Look:** Mouse  
- **Grab / Select:** Trigger input  
- **Interact:** Controller interaction button  

(Adjust if your control mapping differs.)

---

## How to Run the Project

1. Clone the repository.
2. Open the project using **Unity 2021.3.18f1**.
3. Ensure XR Interaction Toolkit is installed via Package Manager.
4. Open the main scene.
5. Press Play.

---

##  Demo Video

(https://drive.google.com/drive/folders/1Eb2z_xhE4tmFl___9KIZSxa0oKJKwRsp)

---


##  Conclusion

This project successfully demonstrates:

- Proper usage of XR Grab Interactable
- Correct implementation of XR Socket Interactor
- Event-based scene progression
- Modular interaction logic
- Conceptual understanding of XRI interaction principles

The focus remains strictly technical, emphasizing correct XRI usage over visual design.

---
