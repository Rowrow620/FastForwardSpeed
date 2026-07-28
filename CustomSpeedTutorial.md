# How to Customize Speed Multipliers

You can easily modify the speed multipliers by editing the C# source code and rebuilding the mod.

## Step-by-Step Instructions

### 1. Open the Source File
Open `FastForwardSpeed.cs` (or `EvenFasterForwardSpeed.cs`) in a text editor or VS Code.

### 2. Locate the Speed Modifier Method
Find the `UpdateGameSpeed_Postfix` method inside the source file:

```csharp
public static void UpdateGameSpeed_Postfix(GameManager __instance)
{
    if (__instance.state != GameState.PLAYING)
    {
        return;
    }

    // Button 2 (>>)
    if (__instance.gameSpeedLevel == 2)
    {
        Time.timeScale = 4f;        // Change 4f to your desired multiplier (e.g., 5f)
        Time.fixedDeltaTime = 0.08f; // Set to 0.02 * timeScale (e.g., 0.02 * 5 = 0.1f)
    }
    // Button 3 (>>>)
    else if (__instance.gameSpeedLevel == 3)
    {
        Time.timeScale = 8f;        // Change 8f to your desired multiplier (e.g., 20f)
        Time.fixedDeltaTime = 0.16f; // Set to 0.02 * timeScale (e.g., 0.02 * 20 = 0.4f)
    }
}
```

### 3. Adjust timeScale and fixedDeltaTime
- Change `Time.timeScale` to any target speed value (for example, `10f` for 10x speed).
- Update `Time.fixedDeltaTime` using the formula: `0.02 * timeScale` (for 10x speed, `0.02 * 10 = 0.2f`). This maintains smooth physics and animation timing.

### 4. Rebuild the Project
Open a terminal in the mod directory and run:

```bash
dotnet build -c Release
```

Copy the generated `.dll` file from `bin/Release/net472/` into your Lobotomy Corporation `BaseMods` folder.
