using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace NotebookAppApi
{
    public class Employee
    {
        [Key]
        public ObjectId Id { get; private set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [BsonIgnore]
        public string FullName => string.IsNullOrWhiteSpace(FirstName)
            ? LastName
            : $"{LastName}, {FirstName}";

        public double Age { get; set; }
        public List<Specialty> Specialties { get; set; } = new List<Specialty>();
    }

    [ComplexType]
    public class Specialty
    {
        public string AnimalType { get; set; }
        public ZooTask Task { get; set; }
    }

    public enum ZooTask
    {
        Feeding,
        Training,
        Exercise,
        TourGuide
    }
}