# Anne-Frank-VR-Room

This project is part of the Bachelor's thesis **"Collaborative Learning Scenarios in a Historical Context Using SocialVR: The Case of the Anne Frank House"**. It explores how Virtual Reality can be utilized to foster collaborative learning in a historical environment.

## Project Overview

The application is a technical implementation in Unity that recreates the Anne Frank House as a SocialVR experience.

*   **Unity Version:** 2021.3.19f1
*   **XR Interaction:** The project utilizes the Unity XR Interaction Toolkit for VR interactions (grabbing, teleporting, hand animations).
*   **3D Models:** The environment includes custom 3D models (e.g., Anne's bed, doors) created in Blender.
*   **Features:**
    *   Interactive whiteboard (`Whiteboard.cs`, `WhiteboardMarker.cs`)
    *   Environmental effects such as flickering lights (`FlickeringLight.cs`)
    *   Full VR interactions (teleportation, grabbing)

## Prerequisites

*   **Unity Hub** with Unity version **2021.3.19f1** installed.
*   **VR Hardware:** An Oculus/Meta Quest or another OpenXR-compatible headset to test the VR features.
*   *(Optional)* **Blender** to edit the 3D source files in the `Blender_stuff/` directory.

## Getting Started

1. Add the project in Unity Hub (select the parent folder `A-F-VR-Room(v1.0)`).
2. Ensure the correct Unity version (2021.3.19f1) is selected.
3. Open the project and load the main scene at `Assets/_Project/Scenes/SampleScene.unity`.
4. Press the **Play** button in the Unity Editor (ensure your VR headset is connected via Link/AirLink).

## Project Structure Notes

- The active Unity project is in `A-F-VR-R(v1.0)/`.
- For better maintainability, non-Unity root assets were moved to:
    - `A-F-VR-R(v1.0)/_SourceAssets/LegacyRoot/`
- This keeps the project root clean without affecting Unity scene/prefab references, because these files were outside `Assets/`.
- Cleanup and refactor guidelines are documented in:
    - `A-F-VR-R(v1.0)/_Docs/PROJECT_STRUCTURE.md`
