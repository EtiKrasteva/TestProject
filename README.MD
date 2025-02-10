# Test Automation Project - TestAutomationETI

## Overview
This project is a test automation framework designed for UI and API testing. It is structured to separate concerns, making it scalable and easy to maintain.

## Project Structure
```
TestAutomationETI
│── Configuration
│   └── Config.cs                  # Configuration settings
│── Keywords
│   └── ActionKeywords.cs          # Common action methods for test execution
│── Locators
│   ├── CssLocators.cs             # CSS locators for UI elements
│   └── PageTitles.cs              # Page titles for verification
│── Models
│   ├── CreateUserModels.cs        # Model for user creation
│   └── GetUserListModels.cs       # Model for retrieving user lists
│── Pages
│   ├── BasePage.cs                # Base class for all pages
│   ├── DragAndDropPage.cs         # Page object for drag and drop tests
│   └── HomePage.cs                # Page object for home page
│── Tests
│   ├── ApiTests
│   │   ├── BaseApiTest.cs         # Base class for API tests
│   │   ├── CreateUserTests.cs     # Tests related to user creation API
│   │   └── GetUsersTests.cs       # Tests for getting user list API
│   └── UiTests
│       ├── BaseUiTest.cs          # Base class for UI tests
│       └── TestDragAndDrop.cs     # UI test for drag and drop functionality
│── config.json                     # Configuration file
```

## Technologies Used
- **Programming Language**: C#
- **Test Framework**: NUnit
- **UI Automation**: Selenium WebDriver
- **API Testing**: RestSharp
- **Build Tool**: .NET 8

## How to Run Tests
### Prerequisites
- Install .NET 8 SDK
- Install dependencies using NuGet

### Running API Tests
```sh
cd TestAutomationETI
dotnet test --filter ApiTests
```

### Running UI Tests
```sh
cd TestAutomationETI
dotnet test --filter UiTests
```

## Configuration
Update `config.json` to modify test settings, such as base URLs, credentials, and browser settings.

## License
This project is licensed under the MIT License.

---
**Author**: Eti Krasteva-Peeva
