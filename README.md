# Technical Test Response - Andrew MacLeod

Please read the notes below to understand assumptions made and decisions taken. 

Simple Payment Flow is a web application made up of two parts:

- `SimplePaymentFlow.Ui` - A React front end application.
- `SimplePaymentFlow.Api` - A .Net Core Minimal Web API application. 

## Running the Application

### API

To start the API, using the command line, run:

```
cd SimplePaymentFlow.Api\SimplePaymentFlow.Api
dotnet run
```

This will start the API at the following address:

````
https://localhost:7152
````

### UI 

To start the UI, using the command line, run:

```
cd SimplePaymentFlow.Ui
npm install
npm start
```

This will start the UI at the following address:

````
http://localhost:3000
````

## Tests

### API

To run the API tests, using the command line, run:

```
cd SimplePaymentFlow.Api\SimplePaymentFlow.AcceptanceTests
dotnet test
```

### UI

To run the UI tests, using the command line, run:

```
cd SimplePaymentFlow.Ui
npm install #(if you haven't already)
npm test
```

## Notes and Assumptions

- More than 2 hours was taken to complete the test. 
- Due to ambiguities in the specification a simple user flow has been implemented.
- Some basic assumptions have been made about the domain entities involved and minimal implementations have been used.
- For the most part, the development has been test-driven, but due to time constraints this was not always possible. 
- In both projects, due to time constraints, testing has been implemented to show examples, but does not cover 100% of the behaviour of the application. 
- For simplicity, a site has a single pump.
- For simplicity, payments are implemented for a fixed value, this could easily be expanded upon. 

### API

- For expediency due to time constraints a simple .Net Core minimal API has been used.
- A simplified CQRS pattern has been used as this was sufficient to meet the requirement. 
- Exception handling is limited in the API due to time constraints (it is possible to break the application and receive `HTTP 500`, for example). With more time graceful error handling could have been implemented.
- An `HTTP PUT` endpoint has been used for the unlock pump operation. Though not strictly appropriate, it was deemed acceptable for expediency due to time constraints. Minimal API does not currently support `HTTP PATCH`. 
- It is acceptable to suppress compiler null warnings in tests with the null bang operator, not in application code.
- Simple in-memory singletons have been used for the data storage emulation. These are not as robust as they could be due to time constraints. 

### UI

- The UI App was scaffolded using the React CLI.
- The UI App tests use React Testing Library.
- A simple style framework has been used to style the app. 
- There is a known issue whereby if a search term is applied and a pump is enabled or disabled, the entire search list is refreshed and the filter is not re-applied. Again, with more time this could be resolved by introducing state to the search component. 

