# Game-Aided for Learning Celestial Sphere VR

This repository is an old Unity/VR learning project about the celestial sphere. It contains C# scripts for loading star and constellation data, displaying constellation labels, and controlling simple star/celestial-sphere behavior in Unity.

The project is preserved here as past work and a reference for the ideas, scripts, and learning experience behind the original prototype.

## Project Goal

The goal of this project was to support learning astronomy concepts through a VR environment. Instead of only reading about stars and constellations, learners could explore a celestial sphere visually and interactively.

## What This Repository Contains

- Unity C# scripts for star and constellation data loading.
- Data classes for star and constellation information.
- Utility scripts for parsing, file loading, color conversion, and asset handling.
- Runtime scripts for star movement, camera-facing behavior, object visibility, and UI labels.
- Unity editor inspector scripts for project-specific tools.
- Unity `.meta` files that preserve asset/folder identifiers from the original project.

## Main Script Areas

### Database Loading

These scripts load and parse star or constellation data:

- `DatabaseLoader.cs`
- `StarDatabaseLoader.cs`
- `ConstellationDatabaseLoader.cs`
- `IOUtility.cs`
- `ParseUtility.cs`

### Information Classes

These scripts represent parsed astronomy data:

- `StarInfo.cs`
- `ConstellationInfo.cs`

### Runtime Behavior

These scripts control objects and UI during the Unity scene:

- `StarMotion.cs`
- `AxisFollowCamera.cs`
- `ConstellationOverlayText.cs`
- `SetObjectActive.cs`
- `AddStar.cs`

### Editor and Asset Helpers

These scripts were used to support custom Unity editor workflows:

- `AssetUtility.cs`
- `AssetGeneratorInspector.cs`
- `DatabaseLoaderInspector.cs`
- `InstanceManagerInspector.cs`

## Repository Status

This is not a complete ready-to-run Unity project. It appears to contain the script files from the original project, but not all Unity scenes, prefabs, assets, datasets, or project settings.

Because this is preserved past work, the code is left as-is. Some scripts may require the original Unity project structure or missing classes before they can compile in a new Unity project.

Known referenced classes that are not included in this repository:

- `AssetGenerator`
- `InstanceManager`

## How to Use This Repository

Use this repository as a reference or archive of the original project code.

If you want to experiment with it in Unity:

1. Create or open a Unity project.
2. Copy these scripts into the `Assets/` folder.
3. Recreate the missing scenes, prefabs, UI objects, and data files.
4. Restore or rewrite any missing project-specific scripts.
5. Check the Unity console for compile errors and missing references.

## Notes for Future Cleanup

If this project is revived later, useful next steps would be:

- Rebuild the full Unity folder structure.
- Add the missing Unity scenes, prefabs, datasets, and project settings.
- Add a Unity `.gitignore`.
- Decide whether to keep, fix, or remove old editor scripts.
- Add screenshots or a short demo video of the original VR experience if available.
- Add a license if the project will be shared or reused by others.

## License

No license is currently specified.
