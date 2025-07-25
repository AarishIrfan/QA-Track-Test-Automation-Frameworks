```markdown
# QA Track – Test Automation Frameworks

**This repository provides modular test automation frameworks and utilities implemented in Selenium, Playwright, and MSTest. It is structured for scalable, data-driven, and functional testing workflows.**

---

## **Project Structure**

```

QA-Track-Test-Automation-Frameworks/
├── playwright-framework/         # Playwright automation structure
├── pom-action-based/            # Selenium Page Object Model with Action-Based design
├── selenium-framework/          # Basic Selenium structure for learning/demo
├── utilities/                   # Custom-built reusable utility components
│   ├── JSON Reader
│   ├── Excel Reader
│   ├── Random Data Generator
│   ├── Logger Configurations
│   └── File Manager
├── All\_TestLogger.bat           # Batch file to run test logger
├── TrxToHTML.exe                # Converts .trx test results to HTML reports
├── LICENSE                      # MIT License
└── README.md                    # Project documentation

````

---

## **Tech Stack**

- **Selenium WebDriver**
- **Playwright**
- **MSTest**
- **C#**
- **HTML/CSS**
- **PowerShell / Shell Scripts**
- **JavaScript (for custom logging utilities)**

---

## **Key Utilities**

- `ExcelReader.cs` – Reads Excel data for data-driven tests.
- `JsonReader.cs` – Parses JSON test configurations and payloads.
- `Logger.cs` – Log4Net logger setup for structured logging.
- `RandomDataGenerator.cs` – Generates synthetic data for test inputs.
- `FileManager.cs` – Manages custom file operations.
- `All_TestLogger.bat` – Batch script to trigger tests with logging.
- `TrxToHTML.exe` – Converts MSTest `.trx` files into HTML reports.

---

## **Getting Started**

1. **Clone the repository**
   ```bash
   git clone https://github.com/AarishIrfan/QA-Track-Test-Automation-Frameworks.git
````

2. **Navigate to a framework folder**

   ```bash
   cd playwright-framework
   ```

3. **Configure test data and environment paths**

4. **Execute tests**

   ```bash
   dotnet test
   ```
