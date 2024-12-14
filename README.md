# SessionManagement
The "SessionManagement" ASP.Net project demonstrates session management in web applications using a SessionFacade pattern. It safely stores and retrieves session data such as user credentials and account details by encapsulating session variables with proper data type handling, preventing errors due to mismatched data types.

# SessionManagement - ASP.Net Web Application

This is a demonstration project that showcases session management in ASP.Net web forms using a SessionFacade pattern. The project ensures safe, error-free storage and retrieval of session data by encapsulating session variables with proper type handling, preventing issues like type mismatches.

## Features
- **Session Data Management**: Safely store and retrieve session data of various types (e.g., string, int, DateTime).
- **SessionFacade Pattern**: Encapsulates session variables in a dedicated class to avoid hardcoded session key names and mismatched types.
- **Multiple Pages**: Demonstrates session data usage across different pages and safe data access.
- **Login & Status**: Login page to set session data and a status page to display user information from session.

## Technologies Used
- ASP.Net Web Forms
- C#
- HTML, CSS, JavaScript (for frontend)
- Visual Studio (IDE)

## Project Structure
- **Page1.aspx**: Sets session data for the user and displays it.
- **ReadUserData.aspx**: Reads and displays session data from the session variable.
- **SessionFacade.cs**: Centralized class for session variable access with type safety.
- **Login.aspx**: A simple login page to set session data (username, password).
- **Status.aspx**: Displays user information from session (e.g., username, account number, last login).

## Setup Instructions

### Prerequisites
Ensure that you have the following installed:
- **Visual Studio** (Community or Professional edition)
- **ASP.Net** framework
- **IIS Express** or a local web server

### Cloning the Repository
1. Clone the repository using Git:
    ```bash
    git clone https://github.com/your-username/SessionManagement.git
    ```

2. Open the solution (`SessionManagement.sln`) file in Visual Studio.

3. Build the project to restore any necessary dependencies.

4. Run the application using the Visual Studio debugger or publish to a web server for production.

### Configuration
No additional configuration is needed beyond the default setup. The application uses session variables to store and retrieve data during the user's session.

### Running the Application
- Open **Page1.aspx** to set session data (e.g., user information).
- Navigate to **ReadUserData.aspx** to display the stored session data.
- **Login.aspx** allows users to input a username and password to simulate a login.
- **Status.aspx** displays the user data stored in the session, such as username, account number, and last login time.

## Project Details

### 1. **SessionFacade Class**
The `SessionFacade` class abstracts session variable access and ensures that the data types of session variables are validated before being retrieved or stored.

```csharp
public class SessionFacade
{
    const string USERNAME = "USERNAME";
    const string ACCOUNTNUM = "ACCOUNTNUM"; // integer storage
    const string LASTLOGIN = "LASTLOGIN"; // datetime

    public static string UserName
    {
        get { return (string)HttpContext.Current.Session[USERNAME] ?? null; }
        set { HttpContext.Current.Session[USERNAME] = value; }
    }

    public static int? Account
    {
        get { return (int?)HttpContext.Current.Session[ACCOUNTNUM]; }
        set { HttpContext.Current.Session[ACCOUNTNUM] = value; }
    }

    public static DateTime LastLogin
    {
        get { return (DateTime?)HttpContext.Current.Session[LASTLOGIN] ?? DateTime.MinValue; }
        set { HttpContext.Current.Session[LASTLOGIN] = value; }
    }
}
