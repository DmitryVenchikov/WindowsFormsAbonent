using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAbonent
{
    public class Class_Request
    {
        [BsonId]
        public ObjectId _id { get; set; }

        [BsonElementAttribute("Id")]
        public int Id { get; set; }

        [BsonElementAttribute("AccountCD")]
        public string AccountCD { get; set; }

        [BsonElementAttribute("ExecutorCD")]
        public string ExecutorCD { get; set; }

        [BsonElementAttribute("FailureCD")]
        public string FailureCD { get; set; }

        [BsonElementAttribute("IncomingDate")]
        public DateTime IncomingDate { get; set; }

        [BsonElementAttribute("ExecutionDate")]
        public DateTime ExecutionDate { get; set; }

        [BsonElementAttribute("Executed")]
        public bool Executed { get; set; }
    }
}
