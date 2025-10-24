# 🎓 Student Database — Seneca Polytechnic Final Project

![C#](https://img.shields.io/badge/Language-C%23-178600?style=for-the-badge&logo=csharp&logoColor=white)
![Platform](https://img.shields.io/badge/Platform-Windows-0078D6?style=for-the-badge&logo=windows&logoColor=white)
![Framework](https://img.shields.io/badge/.NET-Framework%204.8-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![Database](https://img.shields.io/badge/Database-LocalDB%20(MDF)-CC2927?style=for-the-badge&logo=microsoftsqlserver&logoColor=white)
![IDE](https://img.shields.io/badge/IDE-Visual%20Studio%202022-5C2D91?style=for-the-badge&logo=visualstudio&logoColor=white)

---

### 🧾 Overview
This Windows Forms application was developed as a **final project at Seneca Polytechnic for PRG455**.  
It serves as a complete **student record management system**, featuring data entry, analytics, and record storage using a **local SQL Server `.mdf` database**.

The project demonstrates practical skills in **C# programming, ADO.NET database integration, and Windows UI design**.

---

## 🚀 Features

✅ **Student Record Management**
- Add, edit, and delete student records  
- Input validation for all numeric fields (0–100)  
- Unique student ID enforcement  

📊 **Statistics & Analytics**
- Per-student averages  
- Class mean and standard deviation  
- Semester performance comparison  

🧭 **User-Friendly Interface**
- Four Windows Forms:
  - **Main Menu** – navigation hub  
  - **Data Entry Form** – CRUD operations  
  - **Data Display Form** – searchable/sortable grid  
  - **Statistics Form** – average and percentile calculations  

💾 **Local Data Persistence**
- Stores all data in `SchoolRecords.mdf` using SQL Server LocalDB  
- Optional support for `.csv` files in the `Academic Records/` folder  

---

## 🧱 Project Structure
- Dykeman_FinalProject/
- │
- ├── Academic Records/ # Optional CSV/Excel backups
- │ └── Academic Records.xlsx
- │
- ├── SchoolRecords.mdf # Local SQL database
- ├── SchoolRecords_log.ldf # LocalDB log file
- │
- ├── Form1.cs / Form1.Designer.cs # Main Menu
- ├── Form2.cs / Form2.Designer.cs # Data Entry Form
- ├── Form3.cs / Form3.Designer.cs # Data Display Form
- ├── Form4.cs / Form4.Designer.cs # Statistics Form
- │
- ├── Program.cs # Entry point
- ├── App.config # Connection strings & settings
- ├── SchoolRecordsDataSet.* # Dataset schema files
- │
- ├── Dykeman_FinalProject.csproj # Project configuration
- ├── Dykeman_FinalProject.sln # Solution file
- └── Properties/ # Application settings

---

# Student Database

Prerequisites
- Visual Studio 2022
- .NET Framework 4.7.2 Developer Pack (targeting pack)
- NuGet (Visual Studio restores automatically)

How to run
1. Clone: git clone https://github.com/Dexy225/studentDatabase.git
2. Open `Ddykeman_FinalProject.sln` in Visual Studio 2022
3. Restore NuGet packages (Visual Studio does this automatically)
4. Set startup project, choose Debug/Release, then __Debug > Start Debugging__ or press F5

---

🧠 How It Works

Data Entry (Form2): Adds or edits records directly in the LocalDB database.

Display (Form3): Fetches live data into a DataGridView with sorting and search.

Statistics (Form4): Uses LINQ/C# arithmetic to compute averages, standard deviation, and percentiles.

Database: Managed via ADO.NET DataSets and TableAdapters.

---
