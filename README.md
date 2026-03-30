# CashFlow - Expense Management API

[![.NET](https://img.shields.io/badge/.NET-8.0-blue)](https://dotnet.microsoft.com/)
[![C#](https://img.shields.io/badge/C%23-12.0-purple)](https://docs.microsoft.com/en-us/dotnet/csharp/)
[![ASP.NET Core](https://img.shields.io/badge/ASP.NET%20Core-8.0-green)](https://docs.microsoft.com/en-us/aspnet/core/)
[![License](https://img.shields.io/badge/License-MIT-yellow)](LICENSE)

A modern, scalable expense management API built with ASP.NET Core 8.0, following Clean Architecture principles. This project demonstrates best practices in layered architecture, validation, error handling, and internationalization. As my first project in C# and ASP.NET, it showcases my learning journey in building robust backend applications.

## Table of Contents

- [CashFlow - Expense Management API](#cashflow---expense-management-api)
  - [Table of Contents](#table-of-contents)
  - [Features](#features)
  - [Architecture](#architecture)
  - [Technologies Used](#technologies-used)
  - [Getting Started](#getting-started)
    - [Prerequisites](#prerequisites)
    - [Installation](#installation)
  - [API Usage](#api-usage)
    - [Register an Expense](#register-an-expense)
  - [Validation \& Error Handling](#validation--error-handling)
    - [Validation Rules](#validation-rules)
    - [Error Response Format](#error-response-format)
  - [Localization](#localization)
  - [Future Enhancements](#future-enhancements)
  - [Contributing](#contributing)
  - [License](#license)

## Features

- **Expense Registration**: Register expenses with title, description, date, amount, and payment type
- **Comprehensive Validation**: Server-side validation using FluentValidation with detailed error messages
- **Multi-language Support**: Error messages in English, Portuguese (Brazil), and French
- **Clean Architecture**: Separated layers for API, Application, Domain, Infrastructure, Communication, and Exceptions
- **Global Exception Handling**: Consistent error responses across the API
- **Swagger Documentation**: Interactive API documentation with Swagger UI
- **Culture Middleware**: Automatic language detection based on HTTP Accept-Language header

## Architecture

This project follows Clean Architecture principles with clear separation of concerns:

```tree

CashFlow.Api (Presentation Layer)
├── Controllers
├── Filters
└── Middleware

CashFlow.Application (Business Logic Layer)
├── Use Cases
└── Validators

CashFlow.Domain (Domain Layer)
└── Entities & Business Rules

CashFlow.Infrastructure (Infrastructure Layer)
└── Data Access & External Services

CashFlow.Communication (Data Transfer Layer)
├── Requests
├── Responses
└── Enums

CashFlow.Exception (Cross-cutting Concerns)
├── Base Exceptions
└── Localized Error Messages
```

[Architecture Diagram - Coming Soon]

## Technologies Used

- **Framework**: ASP.NET Core 8.0
- **Language**: C# 12.0
- **Validation**: FluentValidation 12.1.1
- **API Documentation**: Swashbuckle.AspNetCore 6.6.2
- **Localization**: .NET ResX Resources
- **Build Tool**: .NET CLI
- **IDE**: Visual Studio 2022 / VS Code

## Getting Started

### Prerequisites

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [Git](https://git-scm.com/)

### Installation

1. Clone the repository:

    ```bash
    git clone https://github.com/your-username/cashflow.git
    cd cashflow
    ```

2. Restore dependencies:

    ```bash
    dotnet restore
    ```

3. Run the application:

    ```bash
    dotnet run --project src/CashFlow.Api
    ```

4. Open your browser and navigate to:
    - API: `http://localhost:5174`
    - Swagger UI: `http://localhost:5174/swagger`

## API Usage

### Register an Expense

**Endpoint**: `POST /api/expenses`

**Request Body**:

```json
{
 "title": "Grocery Shopping",
 "description": "Weekly groceries",
 "date": "2024-03-30T10:00:00Z",
 "amount": 150.5,
 "paymentType": 0
}
```

**Response** (201 Created):

```json
{
 "title": "Grocery Shopping"
}
```

**Payment Types**:

- 0: Cash
- 1: CreditCard
- 2: DebitCard
- 3: ElectronicTransfer

## Validation & Error Handling

The API includes comprehensive validation and error handling:

### Validation Rules

- **Title**: Required, non-empty string
- **Amount**: Must be greater than zero
- **Date**: Cannot be in the future
- **PaymentType**: Must be a valid enum value

### Error Response Format

```json
{
 "errorMessages": ["The title is required.", "The Amount must be greater than zero."]
}
```

## Localization

The API supports multiple languages for error messages:

- **English** (default)
- **Portuguese (Brazil)** - Set `Accept-Language: pt-BR`
- **French** - Set `Accept-Language: fr`

Example French error messages:

- "Le titre est obligatoire"
- "La valeur doit être supérieure à zéro"

## Future Enhancements

- [ ] Complete domain entity implementation
- [ ] Database integration (Entity Framework Core)
- [ ] Authentication and authorization
- [ ] Additional expense management features (update, delete, list)
- [ ] Unit and integration tests
- [ ] Docker containerization
- [ ] CI/CD pipeline setup

## Contributing

As this is a learning project, contributions are welcome! Please feel free to:

1. Fork the repository
2. Create a feature branch (`git checkout -b feature/amazing-feature`)
3. Commit your changes (`git commit -m 'Add some amazing feature'`)
4. Push to the branch (`git push origin feature/amazing-feature`)
5. Open a Pull Request

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

---

_This project represents my first steps in C# and ASP.NET development. Built with passion for learning and clean code principles._</content>
