# 📚 School Management System (SMS)

A basic school management system built with **ASP.NET Core MVC** and **Entity Framework Core**, connected to an **MS SQL Server** database. This project demonstrates core concepts like MVC architecture, data modeling, database integration, and basic frontend interaction.

---

## 🚀 Technologies Used

- **Backend:** C#, ASP.NET Core MVC, Entity Framework Core (Code-First)
- **Database:** Microsoft SQL Server (MSSQL)
- **Frontend:** HTML5, CSS3, Bootstrap, JavaScript
- **Tools:** Visual Studio, SSMS, GitHub

---

## 🧱 Architecture Overview

- **MVC Structure:**
  - `Models` folder defines the data structure (Student, Teacher, Course, etc.)
  - `Controllers` handle the business logic and route data between views and models
  - `Views` display data using Razor templates

- **Entity Framework Core:**
  - Code-First approach to generate the database
  - Migrations used to handle schema changes
  - `DbContext` class handles database operations

- **Scripts & UI Assets:**
  - Custom scripts for UI validation and interaction
  - `img/` folder contains static image resources

---

## ✨ Features

- Student creation, editing, and deletion
- Teacher and class management
- Course assignment and grading
- Admin panel for system control
- Input validation and user feedback

---

## 🗃️ Database

- MSSQL is used for storing system data
- Tables include Students, Teachers, Courses, Enrollments, etc.
- Relationships are mapped using navigation properties in C#
- Data seeded using EF Core migrations (if needed)

---

## 📸 Project Screenshots

### 🖼️ Dashboard View
<img width="1273" height="910" alt="image" src="https://github.com/user-attachments/assets/b0eadbba-4711-4426-bad8-6241cc7c06cc" />


<img width="1238" height="857" alt="image" src="https://github.com/user-attachments/assets/88037ec0-d407-4da5-912f-1dbb4294d8e4" />



---

##

```bash
# 1. Clone the repository
git clone https://github.com/mahmutaran17/SMS

# 2. Open the project in Visual Studio

# 3. Update your MSSQL connection string in appsettings.json

# 4. Apply migrations and create the database
dotnet ef database update

# 5. Run the project
dotnet run
