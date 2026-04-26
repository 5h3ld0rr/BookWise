# BookWise - Library Management System

BookWise is a robust and user-friendly Library Management System built with .NET Windows Forms and MySQL. It streamlines library operations including book tracking, member management, and transaction handling with automated fine calculations.

## Features

- **Authentication & Authorization**: Secure sign-in system with role-based access control (Admin/Member).
- **Book Management**: Efficiently track book inventory, including titles, ISBNs, authors, and availability.
- **Member Management**: Maintain detailed member records with contact information and borrowing history.
- **Transaction System**: Seamlessly handle book borrowing and returns with real-time availability updates.
- **Automated Fine System**: Configurable rules for borrowing limits, return periods, and daily late fines.
- **History Tracking**: Comprehensive logs of all book transactions with advanced filtering options.
- **Email Notifications**: Integrated email system for communication and reminders.

## Tech Stack

- **Frontend**: C# .NET Windows Forms (WinForms)
- **Backend**: C# .NET
- **Database**: MySQL

## Prerequisites

- Visual Studio 2022 or later
- .NET Desktop Development workload
- MySQL Server (v8.0 or later)
- MySQL Workbench (optional, for database management)

## Setup and Installation

### 1. Database Configuration
1. Open your MySQL client (e.g., MySQL Workbench).
2. Execute the provided `BookWise.sql` script to create the database and necessary tables.
3. The script includes a default administrator account:
   - **Email**: `admin@gmaill.com`
   - **Password**: `admin123` (Hashed in database)

### 2. Application Configuration
1. Open the solution file `BookWise.sln` in Visual Studio.
2. Navigate to the `BookWise` project.
3. Locate `Config.cs` (or use `Config.cs.template` to create one).
4. Update the database connection string with your MySQL credentials (Server, User, Password).

### 3. Build and Run
1. Restore NuGet packages.
2. Build the solution (Ctrl+Shift+B).
3. Press **F5** to run the application.

## Project Structure

- `BookWise/UI`: Contains all Windows Forms and user interface controls.
- `BookWise/DataAccess`: Data access layer for database interactions.
- `BookWise/Mails`: Logic for handling email notifications.
- `BookWise.sql`: Database schema and initial data setup.
