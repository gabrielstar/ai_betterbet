# ai_betterbet
This is bet analytics application  with JS and .NET Core 2.1. It is a DEMO app to showcase various types of testing and deployments (pipeline) in Azure.

Features:

What app does ?
  Bet analytics app gathers statistics about upcoming footbal matches and suggests most likely outcomes using predictive analytics.
    Statistics are retrieved from external system via API.
    Own API is exposed.
    User can define leagues to watch.
    User can walk through teams statistics.
    User can pick teams for progression betting on draw events.
    Data can be visualized with charts_studio online.
  
Technologies:

- Azure runtime
- .NET Core 2.1.1 MVC SUite (MVC+Web API)
-  Angular/React as Frontend
  
Tests:
 
 Unit tests
 
 - unit tests with xUnit and quality goal of 70% coverage
 - unit testing of services, repositories, controllers
 - examples of TDD
 
 Integration tests
 
 - integration tests with Postman
 - integration tests with Microsoft.AspNetCore.Mvc.Testing
 - examples of contract testing
 
 Non-functional tests
 
 - performance tests with JMeter
 - security tests with Zap
 - security manual examples against CSRF (Cross Site Request Forgery) and XSS
 
 E2E Tests
 
 - UI tests with groovy selenium and/or protractor for frontend
 
 DevOps
 
 - test & deployment pipeline with Azure pipelines
      - including code coverage gates
      - including Nexus code quality score
