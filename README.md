
# ASP.NET Core  + MongoDB

Guideline about information we learned during this project and consider it's useful


### Differences between NoSQL and SQL

A database is a collection of useful data of one or more related organizations structured in a way to make data an asset to the organization. A database management system is a software designed to assist in maintaining and extracting large collections of data in a timely fashion.

A Relational database is a type of database that stores and provides access to data points that are related to one another. Relational databases store data in a series of tables.

NoSQL databases offer data storage and retrieval that is modelled differently to “traditional” relational databases. NoSQL databases typically focus more on horizontal scaling, eventual consistency, speed and flexibility and is used commonly for big data and real-time streaming applications.

[Link to video](https://www.youtube.com/watch?v=3CzxJ9vb_QQ)

### JSON vs BSON

What is BSON? 

- BSON, or Binary JSON, is the data format that MongoDB uses to organize and store data. This data format includes all JSON data structure types and adds support for types including dates, different size integers, ObjectIds, and binary data. For a complete list of supported types, see the 
BSON Types
 server manual page.



<img width="489" alt="Screenshot 2023-09-04 at 16 26 41" src="https://github.com/MatiasLTonello/ASP.NetCore/assets/109622624/493a4250-4a54-4415-9103-891d8ebe3cd1">

### How to connect with MongoDB

[Integration](https://www.youtube.com/watch?v=jJK9alBkzU0)

[MongoDB Doc](https://www.mongodb.com/developer/languages/csharp/create-restful-api-dotnet-core-mongodb/)
### Integration to ASP.NET Core with MongoDB

#### MongoDB Driver

The MongoDB C# Driver is a software library that allows C# application developers to interact with a MongoDB database from within their applications written in C#. MongoDB is a popular NoSQL database that stores data in BSON (Binary JSON) format and is known for its scalability and flexibility.

The MongoDB C# Driver provides an application programming interface (API) that allows developers to connect to a MongoDB database, perform read and write operations, and manage data efficiently from their C# applications. This library facilitates interaction with MongoDB by providing methods and classes that simplify the creation, query and manipulation of data in the database.

Some of the features and functionality that the MongoDB C# Driver offers include:

Connection to MongoDB: Allows connections to a MongoDB instance to be established from within a C# application.

Object mapping: Facilitates the mapping of BSON documents from MongoDB to C# objects and vice versa. This means that documents stored in MongoDB can be represented as objects in C# code.

Querying and filtering: Provides a simple syntax for querying the MongoDB database, allowing you to efficiently search, filter and retrieve data.

Updating and writing data: Allows inserting, updating and deleting documents in the MongoDB database from a C# application.

Indexing: Allows the creation and management of indexes in the database to improve query performance.

Transactions: Supports transactions to ensure data consistency when multiple operations are performed on the database.

Authentication and security: Provides options for authenticating and securing connections to MongoDB.


#### Most used

- [BsonId]: This attribute is used to mark a property as the primary key of the BSON document. The property decorated with [BsonId] will be mapped to the _id field in MongoDB. It is essential for uniquely identifying documents in a collection.

- [BsonElement("name")]: This attribute is used to specify the name of the BSON field to which a class property will be mapped. For example, [BsonElement("name")] would be used to assign a class property named Name to the BSON field "name" in the documents.

- [BsonRepresentation(BsonType.ObjectId)]: This attribute is used to indicate that a property should be represented as an ObjectId in BSON. This is commonly used for the _id property in MongoDB documents.

- [BsonIgnore]: This attribute is used to mark a property to be excluded from mapping to BSON. You can use it if you have properties in your class that should not be stored in the MongoDB database.

- [BsonDateTimeOptions]: This attribute is used to customize how dates are represented in BSON. You can specify options such as date format, time zone, etc., to control how dates are stored and retrieved in MongoDB.

- [BsonIgnoreExtraElements]: This attribute tells the MongoDB driver to ignore additional properties in documents that do not have a match in the class. This is useful when documents may contain additional fields not defined in the class.

- [BsonRequired]: This attribute is used to indicate that a property is required and cannot be null in BSON documents. You can use it to validate the presence of a property in the documents.

- [BsonDefaultValue]: This attribute is used to specify a default value for a property in case the document does not have that field. You can assign a default value to a property, which is useful when inserting new documents.

- [BsonDiscriminator]: This attribute is used in inheritance and polymorphism classes to specify a discriminator value that is stored in the BSON document. This is useful when you need to differentiate between different subclasses stored in the same collection.

- [BsonIgnoreIfDefault]: This attribute is used to prevent properties from being serialized to BSON if they have a default value. It is useful when you want to avoid serializing properties with default values to save space in the document.
### MongoDB Usage examples

[Examples](https://www.mongodb.com/docs/drivers/csharp/current/quick-start/)

### Data Annotations

DataAnnotations is a set of attributes that are used in application development in the .NET environment to add metadata to classes and data properties. These attributes are primarily used to specify constraints, validations, and other metadata that affect how objects behave in an application.

Here are some examples of common DataAnnotations attributes and their usage:

```c#
[Required]: This attribute is used to mark properties that must have a non-null value on data entry. It is used for required field validation.
csharp
```
```c#
[Required].
public string Name { get; set; }
```

### Endpoints usage


- CRUD Endpoints 
- GetByGenre -> This endpoint will filter and return movies by the genre provided.
- GetByWins -> This endpoint will filter and return movies that has at least one award win
- GetByReleaseDate -> This endpoint will filter movies between an start date and end date




### Design Patterns

[Playlist with C# Design Patterns](https://www.youtube.com/playlist?list=PLWYKfSbdsjJiiaXNIW1OYhRnStsyGvr6t)
