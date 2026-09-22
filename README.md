# Inventory Management System

A C# Windows Forms desktop application for managing parts and products in a manufacturing inventory environment.

## Overview

The Inventory Management System provides a graphical interface for maintaining inventory records and managing the relationship between parts and products.

Users can:

- View current parts and products
- Add, modify, delete, and search inventory records
- Create In-House and Outsourced parts
- Track inventory, minimum, and maximum quantities
- Associate parts with products
- Remove parts from a product's associated-parts list
- Prevent deletion of parts that are currently associated with a product
- Automatically generate unique Part and Product IDs
- Validate inventory values against minimum and maximum limits

## Features

### Parts

Parts can be categorized as either:

- **In-House** — includes a Machine ID
- **Outsourced** — includes a Company Name

Each part contains:

- Part ID
- Name
- Inventory
- Price / Cost
- Minimum inventory
- Maximum inventory

### Products

Products contain:

- Product ID
- Name
- Inventory
- Price
- Minimum inventory
- Maximum inventory
- Associated parts

Parts can be selected from the available-parts list and added to a product. Associated parts can also be removed without deleting them from the overall inventory.

## User Interface

The following interface previews show the application's primary screens and workflows.

### Main Inventory Screen

<img width="591" height="250" alt="Screenshot 2026-09-21 at 5 14 16 PM" src="https://github.com/user-attachments/assets/45a25478-d5c2-461d-a259-7f9de58521ba" />

The main screen provides access to the parts and products tables, along with search, add, modify, delete, and exit functionality.

### Part Management

#### In-House Part

<img width="604" height="345" alt="Screenshot 2026-09-21 at 5 16 52 PM" src="https://github.com/user-attachments/assets/08687084-74a9-4eeb-977c-9341091e559f" />

In-House parts include a Machine ID.

#### Outsourced Part

<img width="613" height="345" alt="Screenshot 2026-09-21 at 5 18 24 PM" src="https://github.com/user-attachments/assets/4dd58c48-90ea-4256-b829-16758bf2768c" />

Outsourced parts include a Company Name.

### Product Management

#### Add Product

<img width="604" height="400" alt="Screenshot 2026-09-21 at 5 19 51 PM" src="https://github.com/user-attachments/assets/9511d152-dbba-4dd1-a95d-497abb0bedee" />


Products can be created while selecting parts from the available inventory.

#### Modify Product

<img width="595" height="406" alt="Screenshot 2026-09-21 at 5 20 35 PM" src="https://github.com/user-attachments/assets/93295ed5-8990-44b9-a506-5c38a58efade" />

Existing products can be updated along with their associated parts.

## Technologies

- C#
- .NET
- Windows Forms
- Visual Studio

## Object-Oriented Design

The application uses an object-oriented design built around:

- Abstract base classes
- Inheritance
- Encapsulation
- Polymorphism
- Collections
- Event-driven Windows Forms programming

The primary domain classes include `Part`, `Inhouse`, `Outsourced`, `Product`, and `Inventory`.

## Project Structure

```text
Inventory Management System
├── AddPartForm.cs
├── AddProductForm.cs
├── Form1.cs
├── Inhouse.cs
├── Inventory.cs
├── ModifyPartForm.cs
├── ModifyProductForm.cs
├── Outsourced.cs
├── Part.cs
├── Product.cs
└── ...
```

## Author

Khadijeh Rashid
