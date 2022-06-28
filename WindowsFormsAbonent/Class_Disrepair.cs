using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAbonent
{
    public class Class_Disrepair
    {
        [BsonId]
        public ObjectId _id { get; set; }

        [BsonElementAttribute("Id")]
        public int Id { get; set; }

        [BsonElementAttribute("FAILURENM")]
        public string FAILURENM { get; set; }

        public override string ToString()
        {
            return FAILURENM;
        }
    }
}
