# CS312 - Digital Library Management System (GUI & GDI+ Visualization)

**Course:** CS312  
**Group:** Group 30  
**Student ID:** 200048290  
**Project:** Digital Library Management System (Windows Forms & GDI+)

---

## 📌 Project Overview
This project is an advanced **Digital Library Management System** desktop application developed in C# using **Windows Forms** and **GDI+**. It provides an intuitive, modern administrative dashboard for managing books, members, loans, and generating executive reports with visual analytics.

---

## 🎯 Submission Requirements Covered

### 1. Windows Forms Controls & Event Handling
- **Forms & Dialogs:**
  - `LoginForm`: Custom authentication dialog with password masking/reveal and keyboard event handling (`Enter` to submit).
  - `MainForm`: Main dashboard featuring a multi-tab interface (`TabControl`), data tables (`DataGridView`), navigation, and action toolbars.
  - `BookDialog`: Modal dialog for creating and editing library books with input validation (`ErrorProvider`).
  - `MemberDialog`: Modal dialog for managing library members and membership statuses.
  - `BorrowDialog` & `ReturnDialog`: Dialogs for checking out and returning library materials.
  - `ExecutiveReportDialog`: Comprehensive summary report preview.
- **Event Handling:**
  - Real-time search and dynamic data filtering on text changes (`TextChanged` events on search fields).
  - Button interactions, form state transitions, and responsive controls (`Click`, `CheckedChanged`, `KeyDown` handlers).

### 2. GDI+ / Graphics / Visualization
- **Custom GDI+ Chart Component (`GdiChartControl`):**
  - High-performance, custom-painted user control using `System.Drawing.Drawing2D.Graphics`.
  - Supports **Donut/Pie Charts** and **Bar Charts** with anti-aliased rendering (`SmoothingMode.AntiAlias`, `TextRenderingHint.ClearTypeGridFit`).
  - Custom color palettes, percentage calculations, dynamic layout calculation, and interactive hover tooltips.
- **Custom Metric Stat Cards (`StatCardControl`):**
  - Custom-drawn stat summary cards utilizing GDI+ borders, accent color bars, and typography measurement (`MeasureString`).

---

## 🚀 How to Run the Project
1. Open `DigitalLibrarySystem.sln` in **Visual Studio 2022**.
2. Ensure the .NET Desktop Development workload is installed.
3. Build the solution (**Build → Rebuild Solution**).
4. Run the project (**F5** or **Ctrl+F5**).
