using eTickets.Models.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace eTickets.Models
{
    [Table("Cinemas")]
    public class Cinema : EntityBase
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Logo { get; set; }
    }
}
