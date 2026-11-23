# DevOps Engineering Portfolio

An end-to-end DevOps implementation project demonstrating application development, containerization, CI/CD automation, Kubernetes orchestration, and application deployment.

## Project Overview

This repository contains an integrated DevOps project built around a simple ASP.NET Core Web API application with Microsoft SQL Server as its database.

The objective is to implement and understand the application lifecycle, from source code development to automated deployment and container orchestration.

Rather than documenting individual technology tutorials, this repository focuses on a practical implementation that connects multiple DevOps components into one deployment workflow.

## Technology Stack

| Category | Technology |
|---|---|
| Backend | ASP.NET Core Web API |
| Framework | .NET 10 LTS |
| Database | Microsoft SQL Server |
| ORM | Entity Framework Core |
| Version Control | Git, GitHub |
| CI/CD | Jenkins |
| Containerization | Docker |
| Container Management | Docker Compose |
| Orchestration | Kubernetes |
| Local Kubernetes | Minikube |
| Reverse Proxy / Ingress | Nginx |
| Operating System | Ubuntu Linux / WSL2 |

## Architecture

The project follows an end-to-end deployment workflow:

Developer → GitHub → Jenkins → Docker Build → Container Registry → Kubernetes → Nginx Ingress → Application

The application consists of:

- ASP.NET Core Web API.
- Microsoft SQL Server database.
- Docker containers.
- Jenkins CI/CD pipeline.
- Kubernetes workloads and services.
- Nginx-based external application routing.

## Implementation Scope

### 1. Application Development
- ASP.NET Core Web API.
- RESTful API implementation.
- Entity Framework Core.
- Microsoft SQL Server integration.
- Application testing.

### 2. Containerization
- Dockerfile.
- Docker image building.
- Docker Compose.
- Container networking.
- Persistent data storage.

### 3. Reverse Proxy
- Nginx configuration.
- Reverse proxy.
- HTTP routing.
- Application access.

### 4. CI/CD Automation
- GitHub integration.
- Jenkins pipeline.
- Automated build and testing.
- Docker image publishing.
- Deployment automation.

### 5. Kubernetes Orchestration
- Kubernetes Deployments.
- Services.
- ConfigMaps and Secrets.
- StatefulSets.
- PersistentVolumeClaims.
- Ingress.
- Application health checks.

### 6. Troubleshooting
- Container troubleshooting.
- Application deployment issues.
- Database connectivity.
- Networking.
- Kubernetes workload troubleshooting.
- CI/CD pipeline failures.

## Repository Structure

```text
application/    Application source code and tests
deployment/     Docker, Jenkins, and Kubernetes configurations
scripts/        Automation and operational scripts
docs/           Architecture and technical documentation
assets/         Diagrams and implementation evidence
```

## Development Environment

The initial implementation environment:

- Windows 11.
- WSL2.
- Ubuntu Linux.
- Docker.
- Minikube.
- kubectl.

## Project Status

This project is under active development.

Implementation will progress from application development and local container deployment toward Jenkins automation and Kubernetes orchestration.

## Security Considerations

- Database credentials must not be committed to Git.
- Sensitive configuration must use environment variables or Kubernetes Secrets.
- Database services should not be unnecessarily exposed externally.
- Persistent storage must be configured for database workloads.

## Objective

The objective is to demonstrate practical DevOps engineering capabilities through an integrated application deployment project, including automation, infrastructure configuration, container orchestration, and troubleshooting.