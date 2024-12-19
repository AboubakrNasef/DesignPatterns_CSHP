using MongoDB.Bson;
using MongoDB.Driver;
using Testcontainers.MongoDb;

 MongoDbContainer mongoDbContainer = new MongoDbBuilder().WithImage("mongo:8.0.0").Build();
var connectionString = mongoDbContainer.GetConnectionString();
var mongoClient = new MongoClient(connectionString);
var database = mongoClient.GetDatabase("testdb");
var collection = database.GetCollection<BsonDocument>("testcollection");
var cursor = collection.Find(_=>true).ToCursor().ToEnumerable();

