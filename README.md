# Top-Down Stealth 🎮

**Top-Down Stealth** is a Unity project where I experiment with stealth game mechanics in a top-down environment. The goal is to explore AI patrols, detection, and player-enemy interactions while creating a simple yet fun stealth loop.

---

## 🚀 Features Implemented

### 🕹️ Player Core

* WASD movement
* Top-down camera follow (smooth, manual implementation; no Cinemachine)

### 👀 Stealth Mechanics

* Enemy Field of View (FOV) detection
* Patrol via waypoints (no NavMesh)
* Investigation behavior when player is spotted
* Enemy disengages and returns to patrol if the player hides

### ⚔️ Enemy Interaction

* Player death on enemy contact → scene reload
* Patrol logic includes configurable wait times and paths
* Investigation includes smooth rotation and chase movement

### 🌍 Environment Systems

* Obstacles / walls that block enemy line of sight
* Ground plane or cube as playable area
* Finish triggers for level completion

### 🖥️ Scene Management & UI

* Scene reload on player death or level restart
* Debug messages for enemy detection and scene reloads

---

## 🛠️ Tech Stack

* **Engine:** Unity (URP)
* **Language:** C#
* **Version Control:** Git + GitHub
* **Camera:** Custom top-down follow

---

## 🎯 Project Goal

This isn’t meant to be a polished game — it’s a **mechanics playground**.

* Test AI patrols, chase/investigate behavior, and player detection.
* Expandable to multiple levels and stealth features like hiding, sound detection, and distractions.

---

## ⚡ Potential Next Features

* Dynamic enemy FOV visualization for debugging and player feedback
* Stealth mechanics: shadows, hiding spots, sound detection
* Level progression with multiple objectives
* Multiple enemies with improved patrol logic and randomization
* Polished UI for lives, objectives, and mission completion

---
