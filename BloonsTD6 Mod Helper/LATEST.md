- Fixed a performance issue with the background Task Scheduler
  - Also added new `ScheduleType.WaitForSecondsScaled` that is affected by fast-forward mode
- Added a `ModRoundSet.Rounds1Index` override that changes the behavior of the `ModifyRoundModels` methods to match the
  player facing 1, 2, 3 and not the internal 0, 1, 2.
  - This will become the default in a later Mod Helper update
- Updated the way VanillaSprites.cs is generated, so it no longer includes many "false positives" of Sprites that have
  GUIDs but aren't properly able to be loaded on demand
- Added a Renderer extension `.ReplaceColor(Color targetColor, Color replacementColor, float threshold)` that
  replaces all the colors in the main texture within a certain threshold of the target with a new color.
- Added a Renderer extension `.AdjustHSV(float hueAdjust, float saturationAdjust, float valueAdjust)` that edits
  the Hue/Saturation/Value of the main texture.
  - Can also do
    `.AdjustHSV(float hueAdjust, float saturationAdjust, float valueAdjust, Color targetColor, float threshold)` to only
    apply the adjustment to certain colors in the texture

### Custom Jukebox Tracks

- Added a `ModJukeboxTrack` class that lets you easily add your own jukebox music from custom audio
- Also updated resource embedding behavior to also automatically embed .mp3 files in your project in addition to .wav
  files
- See the [wiki page](https://gurrenm3.github.io/BTD-Mod-Helper/wiki/Making-a-Custom-Jukebox-Track) for more info

### Model Serialize / Tower Quick Edit

- Added a new `ModelSerializer` that's better at serializing and deserializing things like TowerModels to/from JSON (
  sadly still not perfect)
- Making use of the above, added a new "Tower Quick Edit" functionality that can let you try out changes to TowerModels
  from within a Sandbox game
  - When activated (default hotkey Shift + Backslash) with a tower selected in Sandbox mode, a text editor will open up
    and
    let you edit the TowerModel as JSON. When you close the file, it will apply the changes back to the tower.
    - By default, it changes the "root" model of the tower, which is before any Mutators have been applied. If you
      instead want to see/edit the full tower model (e.g. one that has Paths++ mutators applied),
      use the "Quick Edit Mutated Model" hotkey (default Alt + Backslash)
      NOTE: This can have the side effect of stacking / reapplying mutators on the tower.
  - The default editor it opens with is Notepad
    - To make it edit with VsCode, change the "Quick Edit Program" mod helper setting to "code -w -n"
    - To make it edit with JetBrains Rider, change it to "%LOCALAPPDATA%\Programs\Rider\bin\rider64.exe --wait"

### Developer Console

- Simple CLI-style interface that modders can add commands to that can be run in game
  - Mainly an alternative to adding miscellaneous hotkeys or buttons for infrequently used actions
- Default hotkey is F8 (can be changed in settings under "Mod Making")
  - There's also a Mod Setting you can opt in to that make pressing Shift twice in a row activate it
- Define commands by creating classes that extend
  `ModCommand`, [see here for Mod Helper's examples](https://github.com/gurrenm3/BTD-Mod-Helper/tree/master/BloonsTD6%20Mod%20Helper/Api/Commands)