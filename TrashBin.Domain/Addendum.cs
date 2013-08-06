using System;

namespace TrashBin.Domain
{
    public class Addendum : Entity 
    {
        public Guid ContractId { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public decimal DailyRate { get; set; }
    }
}