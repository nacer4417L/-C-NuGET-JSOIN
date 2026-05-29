# C# JSON Handling with NuGet (Newtonsoft.Json)

## Repository URL
https://github.com/nacer4417L/-C-NuGET-JSOIN

---

## Description

This project is a C# console application that demonstrates how to work with JSON data using the **Newtonsoft.Json** NuGet package. It covers creating JSON files manually, deserializing JSON into C# objects, using loops to process data, and applying object-oriented concepts such as inheritance.

---

## Project Structure

```
JsonExample/
├── Program.cs          - Main application logic
├── Models.cs           - User, AdminUser, RegularUser classes
├── users.json          - JSON file with user data
├── user_types.json     - JSON file with typed user data
└── JsonExample.csproj  - Project configuration and NuGet reference
```

---

## How to Run

```
cd JsonExample
dotnet run
```

---

## Tasks

### Task 1 - Create a JSON file and read it
Created `users.json` manually with 3 user entries. The file is read using `File.ReadAllText()` and deserialized into a `User` object using `JsonConvert.DeserializeObject`.

### Task 2 - Add a new entry to the JSON object
A new `User` is created at runtime and added to the existing list. The updated list is serialized back and saved to `users.json`.

### Task 3 - Deserialize all entries using a loop
The full `users.json` file is read and deserialized into a `List<User>`. A `foreach` loop iterates over every user and prints their data to the console.

### Task 4 - Inheritance to extend the User class
A base class `User` is defined in `Models.cs` with properties `Name`, `Age`, and `City`. Two subclasses extend it:
- `AdminUser` adds `UserType` and `AdminLevel`
- `RegularUser` adds `UserType` and `Subscription`

### Task 5 - Create a new JSON file for user types and deserialize it
A new file `user_types.json` is created containing separate arrays for admins and regular users. Both arrays are deserialized into their respective typed lists and printed to the console.

---

## Version History

| Version | Commit Message | Description |
|---------|---------------|-------------|
| v1.0 | `Task 1: Create users.json and read it` | Created users.json manually, read and deserialized into User objects |
| v1.1 | `Task 2: Add new user entry to JSON` | Added new user at runtime and saved back to file |
| v1.2 | `Task 3: Loop and print all users` | Used foreach loop to deserialize and print all users |
| v1.3 | `Task 4: Inheritance - AdminUser and RegularUser` | Created Models.cs with User base class and two subclasses |
| v1.4 | `Task 5: user_types.json deserialization` | Created user_types.json, deserialized both types and printed output |

---

## NuGet Package Used

**Newtonsoft.Json 13.0.3**
https://www.nuget.org/packages/Newtonsoft.Json

Installed via .NET CLI:
```
dotnet add package Newtonsoft.Json
```

---

## Expected Output

```
========================================
  TASK 1 - Read users from users.json
========================================
Loaded 3 users from file.

========================================
  TASK 2 - Add new user to JSON list
========================================
Added: Anna Smith, 22, Berlin
Saved updated list to users.json

========================================
  TASK 3 - Deserialize all users (loop)
========================================
  Name: John Doe | Age: 30 | City: New York
  Name: Jane Doe | Age: 25 | City: Los Angeles
  Name: Tom Brown | Age: 35 | City: Chicago
  Name: Anna Smith | Age: 22 | City: Berlin

========================================
  TASK 4 & 5 - Inheritance + user_types
========================================

  -- Admins --
  [Admin] Alice Admin | Age: 40 | City: San Francisco | Level: Super Admin
  [Admin] Bob Manager | Age: 38 | City: Seattle | Level: Moderator

  -- Regular Users --
  [User] Charlie User | Age: 27 | City: Miami | Subscription: Premium
  [User] Diana Guest | Age: 21 | City: Austin | Subscription: Free

========================================
  Done.
========================================
```
