# Simple Product Inventory Tracker (Console CLI)

An interactive console-based CRUD utility built with **C#** for managing product stock, prices, and catalog entries in real-time.

## Features
- **Add Products:** Register new inventory items with synchronized name, price, and stock levels.
- **Catalog View:** List all existing store items with dynamic index formatting.
- **Delete Functionality:** Search items by name and safely remove records from collections.
- **CLI Navigation:** Intuitive menu-driven interface powered by a continuous command loop.

## Concepts & Data Handling
- **Collections:** Synchronized tracking across `List<T>` types (`string`, `decimal`, `int`).
- **Control Flow:** `while(true)` application loop with `switch-case` command routing.
- **Data Parsing:** Type conversion with `decimal.Parse()` and `int.Parse()`.
