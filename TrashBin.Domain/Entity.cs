using System;
using System.ComponentModel.DataAnnotations;

namespace TrashBin.Domain
{
    public abstract class Entity
    {
        [Key]
        public Guid Id { get; set; }
    }
}