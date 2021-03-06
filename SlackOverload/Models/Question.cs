using System;
using System.Collections.Generic;
using System.Linq;
using Dapper.Contrib.Extensions;

namespace SlackOverload.Models
{
    [Table("questions")]
    public class Question
    {
        [Key]
        public int questionId { get; set; }
        public string username { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public DateTime posted { get; set; }
        public string category { get; set; }
        public string tags { get; set; }
        public int status { get; set; }
    }
}