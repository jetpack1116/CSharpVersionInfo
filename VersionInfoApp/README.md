# VersionInfoApp

This project retrieves and displays the version information of a **.NET 8 C# project**, including the **Git commit hash** automatically.

## Features
- **Displays Version + Git Commit Hash**  
- Uses **.NET 8 SourceLink** to embed Git commit hash  
- Includes **xUnit tests** to verify version retrieval  
- Supports **team development** with GitHub  
- Clear **logging output**:  

---

## How to Run (Visual Studio 2022)
1. Open **VersionInfoApp.sln** in **Visual Studio 2022**.
2. In **Solution Explorer**, right-click `VersionInfoApp` → **Set as Startup Project**.
3. Click the **"Start" (▶) button** OR Press:
   - `F5` (Run with Debugging)
   - `Ctrl + F5` (Run without Debugging)

---

## How to Test (Visual Studio 2022)
### **Option 1: Using Test Explorer**
1. Open **Test Explorer**: `Test` → `Test Explorer` (`Ctrl + E, T`).
2. Click **Run All**.

### **Option 2: Run Tests via Solution Explorer**
1. Open **Solution Explorer**.
2. Right-click `VersionInfoApp.Tests` → Select **Run Tests**.

---

## Testing Output Example
```
Retrieved C# Project Version with Hash: 1.0.0+77b569a6328ef9e8098a174cfce2051763188b29
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

