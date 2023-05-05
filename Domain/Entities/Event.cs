using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Event : AuditableEntity
    {
        public Guid EventId { get; set; }
        public string Name { get; set; } = String.Empty;
        public int Price { get; set; }
        public string? Artits { get; set; }
        public DateTime Date { get; set; }
        public string? Description { get; set; }
        public string? ImageUrl { get; set; }
        public Guid CategoryId { get; set; }
        public Category Category { get; set; } = default!;
    }
}
