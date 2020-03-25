# AugenBookStore
This is a test application for Augen company interview.

- The database, I created the JSON file to contain the information like the table in the assignment, the reason I separated same properties in the table is we can less change in the future when we want to update the table like base cost or some factor of each month.
- I using Repository Pattern and UnitOfWork Pattern because of the requirement: "Design your code so that the book enquiry can be easily substituted by other source of data e.g. 3rd Api, CSV, JSON, ...". That means I can change the source of data or using the ORM library, just change the DbContext and make sure the implementation of each function in Repository works well. In addition, we can reuse the generic/common functions with repository, to speed up I do not implement any generic functions. UnitOfWork to covert the transaction but we still have a repository, that why in the code the unitOfWork does not show much the powerful but when the application grows up we can handle it easier.
- I using the Services Layer Pattern to separate the business to another layer, not only that makes me easy to handle the business code in a place but also help me easier to write UnitTest.
- I using The Factory Patter to resolve the Deliver of each service. Because each delivery vendor has different vehicle so the delivery information will be different. I created the main factory has many factories, they will base on the ServiceType to know what is exactly the deliver want to create.

Time summary: 
- Design database/Get them into the code from json file: 1 hour.
- Build the BE structure: 2.5 hour (include implemetation of Repository/UnitOfWork Pattern)
- Build the FE structure: 1 hours (include setting libralies)
- Create component/styling/event handling/state management: 2 hour.
- Resolve the Delivery problem : 1 hour (include building Factory Pattern)
- Building and testing: 0.5 hour
Grand total: 8 hours 
 