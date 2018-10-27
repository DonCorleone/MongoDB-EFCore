using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace NotebookAppApi.Model
{
    [BsonKnownTypes(typeof(Tiger), typeof(PolarBear), typeof(Otter))]
    [BsonDiscriminator(Required = true, RootClass = true)]
    public abstract class Animal
    {
        [BsonId]
        public ObjectId Id { get; private set; }
        public string Name { get; set; }
        public double Age { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
    }

    [BsonDiscriminator("panthera tigris")]
    public class Tiger : Animal { }

    [BsonDiscriminator("Ursus maritimus")]
    public class PolarBear : Animal { }

    [BsonDiscriminator("Lutrinae")]
    [BsonKnownTypes(typeof(SeaOtter), typeof(EurasianOtter))]
    public abstract class Otter : Animal { }

    [BsonDiscriminator("Enhydra lutris")]
    public class SeaOtter : Otter { }

    [BsonDiscriminator("Lutra lutra")]
    public class EurasianOtter : Otter { }
}