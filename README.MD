# NoteTakingProject

A simple Windows Forms application for creating, saving, reading, and deleting notes.

## Features

- **Create Notes:** Enter a title and message, then save your note.
- **View Notes:** See a list of note titles in a table.
- **Read Notes:** Select a note and open it in a separate window to view its full content.
- **Delete Notes:** Remove unwanted notes from the list.
- **Clear Fields:** Quickly clear the input fields to start a new note.

## Getting Started

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- Visual Studio 2022 or later

### Running the Application

1. Clone or download the repository.
2. Open the solution in Visual Studio.
3. Build the solution.
4. Run the project (F5 or click the Start button).

## Usage

- **Add a Note:**  
  Enter a title and message, then click the **Save** button.
- **Read a Note:**  
  Select a note from the list and click the **Read** button.
- **Delete a Note:**  
  Select a note and click the **Delete** button.
- **New Note:**  
  Click the **New** button to clear the input fields.

## Project Structure

- `Form1.cs` - Main form for note management.
- `Form2.cs` - Displays the full content of a selected note.
- `Form1.Designer.cs` - UI layout for the main form.
- `Form@.Designer.cs` - UI layout for the seccond form.
