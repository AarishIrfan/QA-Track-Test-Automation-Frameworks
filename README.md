```markdown
# QA Track – Test Automation Frameworks

A structured and modular repository containing reusable test automation frameworks and utility components built using **Selenium**, **Playwright**, and **MSTest** in **C#**. Designed for scalable, maintainable, and data-driven testing solutions.

---

## Folder Structure

```

QA-Track-Test-Automation-Frameworks/
│
├── playwright-framework/          → Playwright-based automation setup
├── pom-action-based/              → Selenium Page Object Model with Action Methods
├── selenium-framework/            → Basic Selenium automation implementation
├── utilities/                     → Shared utility components for test frameworks
│   ├── ExcelReader.cs             → Data-driven testing from Excel files
│   ├── JsonReader.cs              → Configuration and payload handling from JSON
│   ├── RandomDataGenerator.cs     → Synthetic test data generator
│   ├── Logger.cs                  → Log4Net-based custom logger
│   └── FileManager.cs             → File operations for automation needs
│
├── All\_TestLogger.bat             → Batch script to trigger tests and logging
├── TrxToHTML.exe                  → MSTest report converter from .trx to HTML
├── LICENSE                        → Project license (MIT)
└── README.md                      → Documentation (this file)

````

---

## 🛠 Tech Stack

- **Language:** C#
- **Frameworks:** MSTest, Selenium WebDriver, Playwright
- **Tools:** Log4Net, TrxToHTML, PowerShell/CMD
- **Data Formats:** Excel (XLSX), JSON

---

## Utilities Overview

| Utility File              | Purpose                                                |
|---------------------------|--------------------------------------------------------|
| `ExcelReader.cs`          | Reads Excel files for data-driven test input           |
| `JsonReader.cs`           | Parses test configuration and payload from JSON files  |
| `RandomDataGenerator.cs`  | Creates random strings, numbers, and email addresses   |
| `Logger.cs`               | Implements custom logging using Log4Net                |
| `FileManager.cs`          | Handles file reads/writes, cleanup, and validation     |
| `All_TestLogger.bat`      | Executes test suites with logging                      |
| `TrxToHTML.exe`           | Converts MSTest `.trx` files into readable HTML reports|

---

## Getting Started

### Clone the Repository

```bash
git clone https://github.com/AarishIrfan/QA-Track-Test-Automation-Frameworks.git
````

### Run Tests (Example for MSTest)

```bash
cd pom-action-based
dotnet test
```

### Generate Reports

1. After running tests, locate `.trx` file in the TestResults folder.
2. Use `TrxToHTML.exe` to convert it:

   ```bash
   TrxToHTML.exe path\to\result.trx

