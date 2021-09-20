# Rentt

Demo Project

This project currectly is using the following technologies.

- ASP.NET Core 5
- Entity Framework Core 5
- MediatR
- FluentValidation

## Design Decisions

Clean Arquitecture with CQSR

The project was splitted into 4 different projects.

- Application: This project is to store all the business logic and high level definitions.
- Domain: This project is storing all the domain entities.
- Infrastructure: This project will be storing all the code related to cross cutting concerns.
- API: Host project
