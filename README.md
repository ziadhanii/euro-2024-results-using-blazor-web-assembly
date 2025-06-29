# EURO 2024 Results Application

This repository contains two related projects for displaying EURO 2024 football tournament results:

## Projects

### 1. EURO-Results-API

A .NET 8 Web API that provides endpoints for retrieving EURO 2024 match results and standings.

**Key Features:**

- RESTful API for match data and tournament standings
- Built with .NET 8
- Structured to serve data for the Blazor front-end application

### 2. EURO-Results-Blazor

A Blazor WebAssembly application that displays EURO 2024 match results and standings in a user-friendly interface.

**Key Features:**

- Interactive UI built with Blazor WebAssembly
- Responsive design for different device sizes
- Displays match results and tournament standings
- Consumes data from the EURO-Results-API

## Technologies Used

- ASP.NET Core (.NET 8)
- Blazor WebAssembly
- C#
- HTML/CSS

## Getting Started

### Prerequisites

- .NET 8 SDK
- A modern web browser

### Setup and Running Locally

1. Clone the repository:

   ```bash
   
   git clone https://github.com/ziadhanii/euro-2024-results-using-blazor-web-assembly.git
   ```

2. Navigate to the API project:

   ```bash
   cd euro-2024-results/EURO-Results-API
   ```

3. Run the API:

   ```bash
   dotnet run
   ```

4. In a new terminal, navigate to the Blazor project:

   ```bash
   cd ../EURO-Results-Blazor
   ```

5. Run the Blazor application:

   ```bash
   dotnet run
   ```

6. Open your browser and navigate to the URL shown in the terminal (typically `https://localhost:5001`)

## Project Structure

The solution is organized into two main projects:

- **EURO-Results-API**: Contains the backend API controllers and services
- **EURO-Results-Blazor**: Contains the frontend Blazor application with pages, components, and services

## License

[MIT License](LICENSE)

## Contact

Ziad Hany - [ziadhani64@gmail.com](mailto:ziadhani64@gmail.com)
