# JsonReceiptExtractor

This project is written in C# and demonstrates the process of reading and processing data from a JSON file. JSON data is converted to C# objects using the Newtonsoft.Json library.

## Usage

1. Download the project to your computer.
2. Add the JSON file you want to process to the `ResponseJsonFiles` folder. The file must be named "response.json."
3. The existing "response.json" file can be found by following the path "JsonReceiptExtractor/ResponseJsonFiles."
4. Open a terminal or command prompt in the directory where your project files are located.
5. Run the program using the `dotnet run` command.
6. The program will read the data from the JSON file and print it to the screen.

## Important Notes

- The name of the JSON file must be "response.json."
- The JSON data structure must conform to the `JsonModel` class.
- Coordinate data must be of type `int[]` and must contain four indices.

## Project Structure

- **Program.cs**: The main application file that reads and processes JSON data.
- **JsonModel.cs**: The class used for deserializing JSON data.

## Requirements

- [.NET SDK](https://dotnet.microsoft.com/download) (Version: 6.0 or higher)
- [Newtonsoft.Json](https://www.newtonsoft.com/json) (Installation: `dotnet add package Newtonsoft.Json`)
