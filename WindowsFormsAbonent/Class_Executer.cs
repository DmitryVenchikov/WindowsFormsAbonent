using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAbonent
{
    public class Class_Executer
    {
        [BsonId]
        public ObjectId _id { get; set; }

        [BsonElementAttribute("Id")]
        public int Id { get; set; }

        [BsonElementAttribute("Fio")]
        public string Fio { get; set; }

        public override string ToString()
        {
            return Fio;
        }
    }
}
