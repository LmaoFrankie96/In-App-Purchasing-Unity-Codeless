# Codeless IAP System Implementation

This Unity project demonstrates a basic implementation of in-app purchases (IAPs) using the codeless IAP system provided by Unity. The project includes scripts and UI elements for purchasing virtual items within a game, such as coins and unlockable items.

## Overview

The `StoreManager` script manages the in-app purchase functionality, including handling purchase events, updating the player's wallet, and managing inventory items. The script is designed to work with Unity's codeless IAP system, allowing developers to set up and manage IAPs directly within the Unity Editor without writing additional code.

## Features

- **Purchase Handling**: Handles purchase events for different in-app products and updates the player's wallet accordingly.
- **Inventory Management**: Manages inventory items such as unlockable items and updates the UI to reflect the player's purchases.
- **UI Integration**: Integrates with Unity UI elements to provide a seamless in-app purchase experience for players.

## Usage

To use the codeless IAP system in your Unity project:

1. **Import Scripts**: Import the `StoreManager.cs` script into your Unity project.
2. **Set Up IAP Catalog**: Set up your in-app products and their corresponding IDs in the Unity IAP Catalog window.
3. **Configure UI Elements**: Assign UI elements such as buttons and text fields to the corresponding variables in the `StoreManager` script.
4. **Test and Deploy**: Test the in-app purchase functionality within the Unity Editor using Unity's testing tools. Once satisfied, build and deploy your project to your target platform.

## Dependencies

- Unity Engine (version 2021.3.25f1)
