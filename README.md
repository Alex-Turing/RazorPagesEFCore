# Northwind Traders Management System

## Table of Contents

1. [Overview](#overview)  
2. [Features](#features)  
   - [General](#general)  
   - [Employees Management](#employees-management)  
   - [Orders Management](#orders-management)  
3. [Technology Stack](#technology-stack)  
4. [License](#license)  

---

## Overview

**Northwind Traders Management System** is a web-based application that provides a seamless interface for managing employees and analyzing high-value orders for the fictional Northwind Traders company. Built with **ASP.NET Core Razor Pages**, the system is designed for simplicity, responsiveness, and robust database interactions using **Entity Framework Core**.

This project serves as an educational example of building a CRUD-based application that demonstrates advanced customization of scaffolded pages, data annotations, and dynamic functionality.

---

## Features

### General
- **Dynamic Titles and Headings**: Ensures clarity with context-relevant page titles and headings across the app.
- **Responsive Design**: Fully responsive user interface using Bootstrap for a modern and professional appearance.

### Employees Management
- **CRUD Operations**: Create, view, update, and delete employee records.
- **Bootstrap Card Layout**: Displays employees on the index page in an intuitive card-based layout, each linking to detailed profiles.
- **Custom Photo Upload**:
  - Employees can upload photos with automatically generated unique file names.
  - Old photos are removed when new ones are uploaded.
- **Reports To Dropdown**: Displays supervisors’ full names in dropdown menus.
- **Enhanced Form Fields**:
  - Focus on the `Last Name` field by default.
  - Multi-line notes are editable in a textarea field.

### Orders Management
- **High-Value Order Filtering**:
  - Displays orders where freight exceeds $250.
  - Enables filtering by employee using a dropdown menu sorted by last name.
- **Streamlined Pages**: Retains only the index page, removing unnecessary CRUD pages.
- **Enhanced Order Overview**: Offers a clean, detailed overview of relevant orders.

---

## Technology Stack

- **Framework**: ASP.NET Core (.NET 7.0)
- **Language**: C#
- **Database**: SQL Server Express LocalDB with Entity Framework Core
- **UI Framework**: Bootstrap for responsiveness and modern styling

---

## License

This project is licensed under the [MIT License](LICENSE). Feel free to use, modify, and distribute this application for educational purposes.
