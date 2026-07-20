This is a non-profit, educational clone of Flappy Bird made for practice and game development learning purposes.

## Build Instructions

### Requirements
- Unity (use the same version the project was developed with).
- Input System package enabled (Unity's New Input System).

### Opening the Project
1. Clone or download the repository.
2. Open the project using Unity Hub.
3. Wait for Unity to import all assets and packages.

### Running the Game
1. Open the main scene.
2. Press **Play** in the Unity Editor.

### Building
1. Go to **File → Build Settings**.
2. Add the main scene to **Scenes In Build** if it is not already included.
3. Select your target platform.
4. Click **Build** (or **Build and Run**).

### Input System Notice
This project uses **Unity's New Input System** instead of the legacy Input Manager.

If you want to add new controls (such as extra keys, gamepad support, or touch input), make sure to:
- Open the project's **Input Actions** asset.
- Add the new action or binding to the appropriate Action Map.
- Regenerate the C# class if code generation is enabled.
- Update the relevant gameplay scripts to handle the new action.

> **Note:** Simply assigning a new key in code is not enough. All new inputs should be configured through the Input Actions asset to ensure compatibility across supported input devices.
