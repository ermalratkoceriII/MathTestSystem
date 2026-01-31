# Student Math Test System

## Overview
A .NET-based system for automatically checking student arithmetic exams provided in XML format.

## Features
- XML-based mass exam upload
- Automatic math evaluation
- Student result grading
- Teacher and student result views
- Independent math processing engine
- Public API for third-party integration

## Architecture
- Domain layer for core entities
- Application layer for grading logic
- Infrastructure layer for XML parsing
- Independent MathEngine
- ASP.NET Core Web API
- Swagger/OpenAPI support

## Tech Stack
- .NET 8 (LTS)
- ASP.NET Core Web API
- WPF (UI placeholder)
- LINQ to XML
- Swagger / OpenAPI

## Assumptions
- XML schema is valid and trusted
- Operators: + - * /
- Standard operator precedence
- Authentication is out of scope

## How to Run
1. Run `StudentMath.Api`
2. Open `/swagger`
3. Upload XML file via `/api/Exams/upload`

## Future Improvements
- Persistence layer (DB)
- Authentication
- Student analytics UI
- Safer math expression parser
