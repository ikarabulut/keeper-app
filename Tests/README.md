# Simple Dotnet Selenium Framework implementation
Runs a simple test suite on the frontend app located in this repos root directory.

Features
- Page Object Model Design pattern
- Xunit testing framework
- Selenium 4, and ChromeDriver

### Prerequisites
- Dotnet 6
- Local machine must have Chrome

### To Run locally
1. Clone the root repo `git clone https://github.com/ikarabulut/keeper-app.git`
2. `cd keeper-app/Tests`
3. `dotnet build'
4. Ensure the frontend is running locally
    - `cd ../code`
    - `npm start`
5. `dotnet test`
