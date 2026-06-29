# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Project

BDM (Black Desert Mobile) Equipment Upgrade Calculator — a C# console simulation that models the probabilistic enchanting system of the game. It simulates upgrade attempts from level 0→10, tracking consumed materials and the Anvil (guaranteed upgrade) fail-stack mechanic.

## Commands

```bash
# Build
dotnet build

# Run
dotnet run

# Build + Run
dotnet run --project EquipmentCalculator.csproj
```

## Architecture

```
Program.cs
  └─ Leveling.EquipmentLeveling()          ← main loop (0–10 attempts)
       ├─ ConsumedMaterials                 ← tracks silver, rolls, crystals per run
       └─ Anvil.GetRandomNumber()           ← rolls against LevelSuccessRates; on fail calls AddStacks
            ├─ LevelSuccessRates            ← static Dict<level, chance%> (0=70% … 9=0.5%)
            └─ AddStacks.AddFails()         ← counts fails per level; returns true when Anvil threshold hit
                 └─ Anvil.MaxAttemptsToLvlUp ← static Dict<level, maxFails> (e.g. lvl 8 = 50 fails)
```

**Key mechanic — Anvil system:** Each level has a `MaxAttemptsToLvlUp` threshold. Once that many failures accumulate for a level, the next attempt is guaranteed to succeed. Only the fail-stack for that specific level resets on success.

**Current state (work in progress):** `AddStacks` has a logic bug — the third `if` branch (guaranteed success trigger) is unreachable because the second `if` always returns first. Also, `AddStacks.CurrentLevel` is never synced from `Anvil.CurrentLevel`, so stacks are always counted against level 0. `Leveling.cs` also instantiates an unused `AddStacks _stacks` object.

## Namespace / folder mapping

| Folder | Namespace alias | Purpose |
|---|---|---|
| `SimulationSystem/EquipmentSystem/` | `EquipmentSystem` | Static rate tables |
| `SimulationSystem/UpgradeSystem/FailStackManager/` | `FailStackManager` | Anvil + fail-stack logic |
| `SimulationSystem/UpgradeSystem/LevelManager/` | — | Main upgrade loop |
| `SimulationSystem/ItemsToUpgrade/TotalUsedMaterials/` | `ItemsToUpgrade.TotalUsedMaterials` | Result accumulator |
| `SimulationSystem/ItemsToUpgrade/ForASaverEnchant/` | — | Material constants (Akhram, crystals) |
