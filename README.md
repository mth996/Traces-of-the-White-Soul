# Traces of the White Soul

A university **2D action platformer** set in a fantasy medieval kingdom. Players follow Axie, a half-human, half-hound character who can switch between two forms, across **three levels** with enemies and boss encounters.

**Role:** QA Lead / Level Designer / Gameplay Programmer · **Engine:** Unity (2D) · **Type:** Team university project (BSc Computer Games Development)

▶ **[Watch the gameplay video on YouTube](https://youtu.be/wSd0UhX89NU)** · 🎬 [Project trailer](https://youtu.be/fb-Qhb0WQZA) · 🌐 [Portfolio case study](https://mthportfolio.chronocraftstudios.com/traces-white-soul.html)

## My Contributions

### QA Lead
I led quality assurance across the levels, enemies and boss encounters, using **unit, integration and black-box testing** to find bugs, failure cases and gameplay issues. The full test report is in **[Docs/Game-Test-Report.pdf](Docs/Game-Test-Report.pdf)**.

### Level Design
I contributed puzzle ideas, enemy placement and the overall layout of the three levels.

### Save / Load System
I implemented the checkpoint-based save system. It stores the player's position and soul count so progress continues between sessions.

| Script | Purpose |
| --- | --- |
| `Scripts/SaveSystem/SavingMushroom.cs` | Checkpoint trigger: saves when the player reaches a save mushroom |
| `Scripts/SaveSystem/SaveManager.cs` | Stores the player's position at the active checkpoint |
| `Scripts/SaveSystem/PlayerPrefManager.cs` | Saves and loads position and soul count with Unity PlayerPrefs |
| `Scripts/SaveSystem/JSONManager.cs` | Early prototype: JSON serialisation of save data (explored before choosing PlayerPrefs) |
| `Scripts/SaveSystem/GameHandler.cs` | Early prototype: writing player data to a JSON file |

### Voice Acting Coordination
I coordinated the voice actors for the player character, the boss and the NPCs.

## Repository Structure

```text
Traces-of-the-White-Soul/
├── Scripts/SaveSystem/   # Save/load scripts I implemented (with Unity .meta files)
├── Docs/                 # QA test report
└── README.md
```

## Note

This was a team project. The repository contains only my own scripts and the QA report, not the full Unity project or the team's assets.
