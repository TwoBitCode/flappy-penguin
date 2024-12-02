# Flappy Bird Game 🐦🎮

Play the game on Itch.io: https://twobitcode.itch.io/flappy-penguin

Flappy Bird is a simple yet addictive mobile game where the player controls a bird 🐦 that must navigate through pipes 🏗️ without hitting them. The goal is to get the highest score possible by passing through as many pipes as you can.

## Features ✨

- **Easy-to-learn gameplay**: Tap to make the bird fly 🦅, avoid pipes 🚧.
  
- **Endless gameplay**: The game continues until the bird collides with an obstacle 🛑.

- **Score tracking**: Your score increases as you pass each pipe 🎯.

- **Responsive controls**: Tap the screen to make the bird flap 🐦⬆️.

## Implementation 🛠️

- Creating pipe spawner that generates pipes 🚧. -
each pipe is constructed from 3 parts, the top, bottom- sprites with collider component. And the middle, that is mainly a collider with a tag, and trigger so whenever the penguin comes in contact (aka pass through), the score would update.
Once the pipes are out of our vision they get destroyed as to not fill the memory, and are generated at different heights for more interest.
https://github.com/TwoBitCode/flappy-penguin/blob/main/Assets/Scripts/SpawnPipe.cs

- Creating penguin object 🐧 that is the bird in this game, that flies when hitting the space key.
the penguin has a rigid body and a movement script, when it comes in contact with the pipes the game is over and you can restart.
-https://github.com/TwoBitCode/flappy-penguin/blob/main/Assets/Scripts/ObjectMover.cs

- Adding score counter 🏆. -
- The score is essential in this game since it helps create the interest. The score goes up by trigger every time the bird and middle pipe come in contact.
- https://github.com/TwoBitCode/flappy-penguin/blob/main/Assets/Scripts/Manager.cs

- Since the emphasis of the application was on the core processes, the game is not closed. (for example if the penguin does not hit the pipe and just falls down, there is no restart button, I didn't have time to make boundaries for the game).

## Controls 🎮

- **Hit Space key** ␣ to make the bird flap and rise 🌤️.

- **Avoid pipes**: The bird must pass through gaps between the pipes without hitting them 🚧❌.

## Technologies Used 🖥️

- **Unity** game engine 🎮.

## How to Play 🎮

1. Tap the space bar ␣ to make the bird flap and rise 🌤️.
2. Avoid hitting the pipes 🚧 or the ground 🌍.
3. Each time the bird passes through a pair of pipes, your score increases 🏆.
4. The game ends when the bird collides with a pipe 🚧 or the ground 🌍.

## source
I used different guides to implement the mini game.
- CHATGPT
- youtube tutorials
