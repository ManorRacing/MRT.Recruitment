MANOR RACING - Developer Technical Test
=======================================

The technical test consists of a short coding challenge, followed by some additional excercises.

# Top Tips
* We are looking for clean, reabable code that is easy to understand without comments.
* You should make best efforts to cover your code with Unit Tests. We are looking for code written in a TDD fashion.
* Check in little and often - we like to see how your solution evolves!
* Make it work, Make it right, Make it fast :)

We have provided a C# ASP.Net Core based Web.Api 2 project as a starter - please feel free to roll your own project from scratch if you want.

# Coding challenge
The subject of the coding challenge is an incomplete Web.API 2 project, providing access to Car Telemetry data. 
We have provided sample data (telemetry.json) for you to use.

As a minimum, we are looking for you to implement the following user story:
_"As a Vehicle Science Engineer, I want to view recorded telemetry data so that I can check the health of the car every lap"_

**Tasks:**
* Implement IRepository<Telemetry> in a TDD fashion.
* Complete the Get() and Get(id) methods in TelemetryController.cs.
* Add a method to TelemetryController.cs for adding more Telemetry data to the collection.
* Add a method for obtaining details of the fastest lap recorded.

**Please Note: We are not expecting you to persist data changes to the telemetry.json source data. An in-memory collection will do!**

# Additional tasks
These tasks are optional, but we recommend that you pick at least one to make your application competitive.
* Add end-to-end asynchronous capabilities to your solution.
* Add some form of API documentation (e.g. Swagger)
* Create a method for identifying slow laps where the car was entering/exiting the pit lane.
* Add a basic UI for comparing lap-by-lap telemetry data between CH1 and CH2. The UI should consist of a list of laps, a section for each car, a comparison panel comparing lap time deltas/fuel burn.
* Go wild! Add a feature of your own design, providing a simple User Story to describe the feature that you have added.

# Submission details
Due to email attachment size limits, we have set up some shared storage for taking submissions.

* Once you have completed the test, please email steve.ohara@manorracing.com and you will be provided with access to the shared storage. 
* Upload your solution and it will be reviewed by a member of our team.

Good luck!