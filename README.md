
# HRMS Fullstack with OpenTelemetry + New Relic + Load Test

## Run
docker-compose up

## Access
Frontend: http://localhost:4200  
Backend: http://localhost:5000/api/employees  
Locust: http://localhost:8089  

## Steps for New Relic
1. Replace <YOUR_NEW_RELIC_KEY> in Program.cs
2. Run app
3. Generate load via Locust
4. View traces in New Relic

## Features
- Angular UI
- .NET backend
- OpenTelemetry tracing
- New Relic integration
- Locust load testing
