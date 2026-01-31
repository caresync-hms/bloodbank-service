# 🩸 Blood Bank Service

## 📌 Project Description

The **Blood Bank Service** is an independent **.NET-based microservice** developed as part of the Hospital Management System.  
Its purpose is to manage **blood donors, blood groups, availability, and blood-related data** in a secure and scalable manner.

This service is designed following **microservices architecture principles**, allowing it to run independently and integrate seamlessly with the main hospital system.

---

##  Architecture Overview

- Built using **ASP.NET Core (.NET 8)**
- Follows a **layered architecture**
- Uses **RESTful APIs** for communication
- Implements **Entity Framework Core** for database access
- Can be deployed and scaled independently

---

##  Technologies Used

- **ASP.NET Core (.NET 8)**
- **Entity Framework Core**
- **SQL Server**
- **REST APIs**

---

## Key Features

- Manage blood donors and donor details  
- Track blood group availability  
- Provide APIs for blood-related data access  
- Independent microservice architecture  
- Secure configuration using `appsettings.json`  
- Database migrations using Entity Framework Core  

---

##  Project Folder Structure
    ```bash 
        BloodBankService/
            ├── Controllers/                # Contains API controllers
            │   └── BloodController.cs      # REST APIs for blood bank operations
            │
            ├── Models/                     # Entity and model classes
            │   ├── Donor.cs                # Donor entity (blood group, details, etc.)
            │   └── ErrorViewModel.cs       # Model for error handling
            │
            ├── Migrations/                 # Entity Framework Core migrations
            │   ├── 20260128110222_InitialCreate.cs
            │   ├── 20260128110222_InitialCreate.Designer.cs
            │   └── BloodDbContextModelSnapshot.cs
            │
            ├── Properties/                 # Application launch configuration
            │   └── launchSettings.json     # Environment and port settings
            │
            ├── wwwroot/                    # Static files (if required)
            │   ├── css/                    # CSS files
            │   ├── js/                     # JavaScript files
            │   └── lib/                    # Third-party libraries (Bootstrap, jQuery)
            │
            ├── appsettings.json            # Application configuration
            ├── appsettings.Development.json# Development-specific configuration
            ├── Program.cs                  # Application entry point
            ├── BloodBankService.csproj     # .NET project file
            ├── BloodBankService.slnx       # Solution file
            └── .gitignore                  # Git ignored files


---

##  Roles Supported

- **Blood Bank Admin**
  - Manages blood donors
  - Updates blood availability
  - Handles blood-related records

---

## How to Run the Project

### Prerequisites
- .NET SDK 8.0
- SQL Server
- Visual Studio or VS Code

### Steps

1. Clone the repository
   ```bash
   - git clone https://github.com/caresync-hms/bloodbank-service.git
   - cd bloodbank-service
2. Restore dependencies
   ```bash
   dotnet restore


3. Update the database
   ```bash
    dotnet ef database update
   
4. Run the application
```bash 
dotnet run
   
