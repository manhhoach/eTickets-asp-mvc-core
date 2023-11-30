using eTickets.Model.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace eTickets.Model.Models
{
    [Table("Cinemas")]
    public class Cinema : EntityBase
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Logo { get; set; }
    }
}
