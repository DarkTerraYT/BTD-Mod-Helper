- Minor fix for BTD6 v47

## Rogue Legends

- Added a preliminary version of custom artifacts via `ModItemArtifact` and `ModBoostArtifact`
  - Read more on the [wiki page](https://gurrenm3.github.io/BTD-Mod-Helper/wiki/Making-a-Custom-Artifact)
  - Vanilla artifact data will also now be included in Mod Helper's Export Game Data output
    - Viewable online [here](https://github.com/Btd6ModHelper/btd6-game-data/tree/main/Artifacts)
- Added new `ModHero` properties `RogueStarterArtifact` and `RogueStarterInstas` for defining custom loadouts
  - If not specified, defaults to Starting Strong Common with a 2-0-0 Ninja Monkey and 2-0-0 Alchemist
  - See the [wiki page](https://gurrenm3.github.io/BTD-Mod-Helper/wiki/Making-a-Custom-Hero#example) for more info
- Added new `ModTower` property `IncludeInRogueLegends` to control if a custom tower should be allowed to appear in Rogue Legends
  - Defaults to false