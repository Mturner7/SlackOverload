using System;
using System.Collections.Generic;
using System.Linq;
using Dapper.Contrib.Extensions;
using System.Threading.Tasks;

namespace SlackOverload.Models
{
    [Table("answers")]
    public class Answer
    {
        [Key]
        public int answerId { get; set; }
        public string username { get; set; }
        public string description { get; set; }
        public DateTime posted { get; set; }
        public int upvotes { get; set; }
        public int questionId { get; set; }
    }
}
