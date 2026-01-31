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
- WinForms (UI placeholder)
- LINQ to XML
- Swagger / OpenAPI

## Assumptions
- XML schema is valid and trusted
- Operators: + - * /
- Standard operator precedence
- Authentication is out of scope

## How to Run
### NOTE: The teacher must insert the data first for the students to be able to see them
1. Startup config must be set to run these projects: `MathTest.Api` and `MathTest.WinFormsClient`. Afterwards run the project.
2. Open `/swagger` or the WinForm window that pops up
4. Select the teachers tab and insert the password (its in the appsettings.json for dev environment)
5. Click the Upload Exams button
6. Open MathTest.Sandbox folder
7. Sample.xml or MassiveSample file can be used to test via WinForms UI
8. Exam results will show on the individual student tab and also teachers tab as bulk.

