# VersionInfoApp

This project retrieves and displays the version information of a **.NET 8 C# project**, including the **Git commit hash** automatically.

## Features
- **Displays Version + Git Commit Hash**  
- Uses **.NET 8 SourceLink** to embed Git commit hash  
- Includes **xUnit tests** to verify version retrieval  
- Supports **team development** with GitHub  
- Clear **logging output**:  
  ```
  Retrieved C# Project Version with Hash: 1.0.0+<commit-hash>
  ```

## How to Run
```sh
dotnet run
```

## How to Test
```sh
dotnet test
```

---

## Team Development Features**
The following settings and improvements have been added for better **team collaboration**:

### **GitHub Repository Settings**
- ✅ **Invited `yutaro.yamada@hutzper.com`** as a collaborator.
- ✅ Configured `.gitignore` to **exclude unnecessary files** (bin, obj, logs).
- ✅ Added `.gitattributes` to **ensure cross-platform compatibility**.

### **Project Setup for Team Development**
- ✅ **Separate test project** using **xUnit** for easy testing.
- ✅ **Version retrieval automated** with `.NET 8 SourceLink` to include Git commit hash.
- ✅ **Consistent logging output format** for debugging.
- ✅ **Encapsulated version logic** inside `Program.cs` for easy modifications.

### **Best Practices for Team Workflow**
- ✅ **Uses `README.md`** for documentation.
- ✅ **Unit tests validate version retrieval**, reducing risk of errors.
- ✅ **Followed GitHub collaboration best practices** (branching, commits, PRs if needed).

---

## Project Structure
```
VersionInfoApp/
│── VersionInfoApp.csproj          # .NET 8 Project file
│── Program.cs                     # Main program that retrieves version info
│── README.md                      # Project documentation
│── VersionInfoApp.Tests/           # xUnit test project
│   ├── VersionInfoTests.cs        # Test to verify Git commit hash retrieval
│   ├── VersionInfoApp.Tests.csproj
│── .gitignore                     # Git ignore settings
│── .gitattributes                  # Git attributes for repo settings
```

## Testing Output Example
```
Retrieved C# Project Version with Hash: 1.0.0+77b569a6328ef9e8098a174cfce2051763188b29
```