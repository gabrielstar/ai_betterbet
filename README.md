# ai_betterbet
This is bet analytics application  with JS and .NET Core 2.1. It is a DEMO app to showcase various types of testing and deployments in Azure.

Features:

What app does ?
  Bet analytics app gathers statistics about upcoming footbal matches and suggests most likely outcomes using predictive analytics.
    Statistics are retrieved from external system via API.
    Own API is exposed.
  User can define leagues to watch.
  User can walk through teams statistics.
  User can pick teams for progression betting on draw events.
  
Technologies:

- Azure runtime
- .NET Core 2.1 MVC SUite (MVC+Web API)
- Angular/React as Frontend
  
Tests Monster:
 - unit tests with xUnit and quality goal of 70% coverage
 - examples of TDD
 - integration tests with Postman and MVC Controllers
 - examples of contract testing
 - performance tests with JMeter
 - UI tests with groovy selenium and/or protractor
 - test & deployment pipeline with Azure pipelines
      - including code coverage gates
      - including Nexus code quality score
