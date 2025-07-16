# Flappy Bird Clone

A physics-based 2D arcade game developed using Unity Engine and C#, inspired by the original Flappy Bird. This project demonstrates core gameplay mechanics such as player movement, score tracking, collision detection, dynamic object spawning, and audio integration.


---

## Features

### Core Gameplay

**Player Movement**
Implemented a smooth jump mechanic using Unity’s Rigidbody2D, responding to user input for an intuitive and responsive gameplay feel.

**Obstacle Spawning**
Procedurally generates pipes at regular intervals with varying vertical gaps to keep the challenge dynamic.

**Collision Detection**
Uses Unity’s 2D physics system to detect collisions with pipes or ground, which triggers a game-over state.

**Scoring System**
Increments score as the player successfully passes through pipe pairs. Displays the current and high score during and after gameplay.

**Game Loop**
Includes start, restart, and game-over states with appropriate UI transitions.

### Audio and Visuals

**Background Music**
Looped background soundtrack for immersive gameplay.

**Sound Effects**
Jump and collision effects for feedback and engagement.

**Parallax Background**
Implemented a moving background to simulate forward motion and enhance depth.

---

## Technologies Used

Unity Engine (2D Mode)
C# for game logic
Unity UI System for score display and game states
Rigidbody2D, Collider2D, and Animator components
Git and GitHub for version control

---

## What I Learned

Working with Unity’s physics engine and understanding Rigidbody2D behavior
Managing object lifecycles and memory through prefab pooling
Structuring game states (start, play, game-over) effectively
Improving user experience with visuals, sound, and fluid UI feedback
