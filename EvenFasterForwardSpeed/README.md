# Even Faster-Forward Speed Multipliers

A mod for Lobotomy Corporation that modifies the in-game UI speed buttons to 1x, 8x, and 16x fast-forward speeds.
Requires BaseMod 5.0!

### Key Features

* Ultra Speed Multipliers: Replaces default `1.5x` and `2x` buttons with **`8x`** and **`16x`** speed multipliers.
* Native UI Integration: Works seamlessly with in-game speed controls and Spacebar pause.
* Smooth Physics & Timers: Dynamically scales `fixedDeltaTime` proportionally with game speed to prevent physics clipping or timer glitches.
* Framework Stability: Compiled against .NET Framework 4.7.2 for native compatibility with Unity Mono.

## In-Game Controls

Click the speed buttons in the bottom-left corner of the UI during the management phase:
* **Button 1 (`>`)**: 1x (Normal Speed)
* **Button 2 (`>>`)**: **8x Speed**
* **Button 3 (`>>>`)**: **16x Speed**

## Installation

### Option 1: Via Lobotomy Mod Manager (LMM)
1. Open `LobotomyModManager.exe`.
2. Click **Add LocalMod** and select `EvenFasterForwardSpeed-v1.0.0.zip`.
3. Ensure `EvenFasterForwardSpeed` is checked in your mod list, then click **Start Game**.

### Option 2: Manual Installation
1. Extract the `EvenFasterForwardSpeed` directory into your game folder:
   `LobotomyCorp_Data\BaseMods\EvenFasterForwardSpeed\`
2. Launch Lobotomy Corporation (or launch via LMM).

## Requirements

* Lobotomy Corporation
* BaseMod 5.0 or higher

## Building from Source

### Prerequisites
* .NET 8 SDK or .NET Framework 4.7.2 compiler
* Lobotomy Corporation with BaseMod 5.0 installed

```bash
dotnet build EvenFasterForwardSpeed.csproj -c Release
```

## License

Distributed under the MIT License. See `LICENSE` for more information.
