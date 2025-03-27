# Overlay Panels

A flexible state machine for managing overlay panels in casual games.

## Features

- **Hierarchy & Order Preservation**: Ensures correct panel layering.
- **Multiple Closing Methods**: Supports closing panels via background tap, back button, close button, and more.
- **Seamless Integration**: Works with `DoTween` for animations and `TextMeshPro`.
- **Plug & Play**: Includes a ready-to-use prefab (`OverlayingPanels`).
- **Optimized UI Management**: State-driven approach prevents UI conflicts.

## Installation

1. Import the package into your Unity project.
2. Ensure that `DoTween` and `TextMeshPro` are installed.
3. Drag the `OverlayingPanels` prefab from the `Prefabs` folder into your scene.
4. Ensure an `EventSystem` exists in the scene.
5. Assign a camera to the Canvas component inside `OverlayingPanels`.

## Quick Start

### Adding a New Panel
1. Duplicate `TemplatePanel` and customize it.
2. Ensure it has the `UniversalPanel` component.
3. Set required parameters:
   - `PanelObject` (mandatory) – toggles visibility based on the state machine.
   - `ObjectToAnim` (optional) – applies animations when entering/exiting.
   - `Escape Key Pressed` – enables closing via `Escape` or `Back` button.
4. Add an `AddPanelButton` component to a button and link your panel.
5. Assign `PanelMachine` (included in `OverlayingPanels`).

### Closing a Panel
- Use `CloseLastPanelButton` to close the most recent panel.
- All panels are managed through `PanelMachine`, ensuring proper UI flow.
- Clicking the background automatically closes the top panel.

## Core Components

### `PanelMachine`
- `AddPanel(PanelBase panel)`: Adds a new panel.
- `CloseLastPanel()`: Closes the most recent panel.
- `SwitchLastPanelTo(PanelBase panel)`: Replaces the last panel with a new one.
- `EnableTransition(bool enable)`: Enables/disables panel transitions.
- `CloseAllMenuPanel()`: Closes all panels implementing `IMenuPanel`.

### `PanelBase`
- `Enter(PanelMachine machineInstance)`: Called when a panel opens.
- `Exit(PanelMachine machineInstance)`: Called when a panel closes.
- `CanExit()`: Returns `true` if the panel can be closed.
- `EscapeKeyPressed()`: Handles `Escape` key input.

### `UniversalPanel`
- Extends `PanelBase` with additional features:
  - `panelObject`: Reference to the panel GameObject.
  - `objectToAnim`: Object for animations.
  - `escapeKeyPressed`: Determines if `Escape` key is supported.
- Methods:
  - `OpenPanel()`: Animates panel entry.
  - `ClosePanel()`: Animates panel exit.

### Additional Components
- **`CloseLastPanelButton`**: Button to close the last active panel.
- **`AddPanelButton`**: Button to add a new panel.
- **`PhysicalClicksCatcher`**: Handles `Escape` key inputs.

## Example
A working implementation is available in `ExampleScene`.

## License

This project is licensed under the MIT License. See the `LICENSE` file for details.
