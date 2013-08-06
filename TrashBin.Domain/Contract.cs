using System;

namespace TrashBin.Domain
{
    public class Contract : Entity 
    {
        public virtual Enterprise Customer { get; set; }

        public Guid CustomerId { get; set; }

        public virtual Project Project { get; set; }

        public Guid ProjectId { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }
    }
}
