# MANOR RACING - Software Engineering Tech Test
=======================================================

Thanks for your interest in Manor Racing! 

Our technical test consists of a short coding challenge, followed by some additional excercises.

We have provided a C# ASP.Net Core based Web.Api 2 project as a starter - please feel free to roll your own project from scratch if you want.


----------

## Coding challenge
The subject of the coding challenge is an incomplete Web.API 2 project, providing access to Car Telemetry data. 
We have provided sample data (telemetry.json) for you to use as a base.

As a minimum, we are looking for you to implement the following user stories:

### Story MR-001
_As a **Vehicle Science Engineer**_
_I want to **view recorded telemetry data by {car}**_
_So that I can **analyse {car} performance**_

#### Tasks
- Implement IRepository<Telemetry> in a TDD fashion.
- Complete the the Get methods in TelemetryController.cs.
- Add a method for obtaining details of the fastest lap recorded.
- **[Optional]** Add a basic UI for comparing lap-by-lap telemetry data between CH1 and CH2. The UI should consist of a list of laps, a section for each car, a comparison panel comparing lap time deltas/fuel burn. **Don't spend any time on styling - it just has to be functional!**

#### Acceptance Criteria
 - _**/api/telemetry/get**_ returns all telemetry.
 - _**/api/telemetry/chassis/{chassis}**_ returns all telemetry for a single car.
 - _**/api/telemetry/lap/{lap}**_ returns all telemetry for a single lap.
 - _**/api/telemetry/post**_ allows a new telemetry item to be added to the repository.
 - the API has a method to obtain the fastest lap.
 - solution is covered by unit tests.

 ----------

### Story MR-002
_As a **Race Engineer**_
_When a **{car} crosses the start/finish line**_
_I want to **record telemetry data**_
_So that I can **react to changing conditions during the race**_

#### Assumptions
- Each lap is unique, and records a maximum of 2 cars.
- The same car can not be tracked more than once per lap.

#### Tasks
- Add a method to TelemetryController.cs for accepting new lap to the collection.
- Ensure that any duplicated telemetry is handled appropriately.

#### Acceptance Criteria
 - _**/api/telemetry/post**_ allows a new telemetry item to be added to the repository.
 - _**/api/telemetry/lap/{lap}**_ returns all telemetry for your newly added lap.

**Please Note: We are not expecting you to persist your changes to a database. An in-memory stub will do!**

----------

## Additional stories
These stories are open and optional, but we recommend that you **pick at least one** to make your application competitive:

### Story MR-003
_As a **Race Engineer**_
_When **our telemetry repository is offline**_
_I want to **ensure new telemetry data is queued**_
_So that **we can record the data when connection is restored**_

#### Tasks
- Add end-to-end asynchronous capabilities to your solution.
- Add a queue to spool telemetry data writes in the event the repository is offline.

----------

### Story MR-004
_As a **Vehicle Science Engineer**_
_I want **to view documentation for the Telemetry API**_
_So that I can **implement it in my own solutions**_

#### Tasks
- Add some form of live API documentation (e.g. Swagger).

----------

### Story MR-005
_As a **Vehicle Science Engineer**_
_I want to **identify slow pit lane in-laps and out-laps**_
_So that **average calculations for normal laps aren't skewed**_

#### Assumptions
- Pit laps always include a tyre change.

#### Tasks
- Create a filter for identifying slow laps where the car was entering/exiting the pit lane.

----------

### Story MR-006
_As a **Race Engineer**_
_I want to **predict the performance of the car**_
_So that **I can make tactical decisions during the race**_

#### Assumptions
- the cars run with a minimum of two different tyre compounds per race. 
- a hard tyre compound lasts more laps and heats up more slowly than the soft tyre compound.

#### Tasks
- Create a method for calculating average kg/lap fuel burn.
- Create a method for calculating average tyreDeg/lap tyre degradation for **both** tyre compounds.
- Create a method for calculating average tyreTemp/lap tyre temperature increase for **both** tyre compounds.

----------

### Story MR-007
- Go wild! Add a feature of your own design, providing a simple User Story to describe the feature that you have added.

----------

## Submission details
Due to email attachment size limits, we have set up some shared storage for taking submissions.

- Once you have completed the test, please email your agent or Manor Racing contact and you will be provided with an invite for access to the OneDrive shared storage. 
- Upload your solution and it will be reviewed by a member of our team.

----------

## Top Tips
- We are looking for clean, reabable code that is easy to understand without comments.
- You should make best efforts to cover your code with Unit Tests. We are looking for code written in a TDD fashion.
- Check in little and often, referencing the Story # you are working on - we like to see how your solution evolves!
- We use xUnit and Moq here at Manor Racing. We've added the references, but feel free to add your own!
- Make it work, Make it right, Make it fast :)

Good luck - we are looking forward to reviewing your work!
**Software Engineers of Manor Racing**