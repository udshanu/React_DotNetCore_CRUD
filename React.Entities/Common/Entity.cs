﻿using System.ComponentModel.DataAnnotations;

namespace React.Entities.Common
{
    public abstract class Entity
    {
        public bool IsDeleted { get; set; }

        [Required]
        public DateTime DateCreated { get; set; }
        [Required]
        public string CreatedBy { get; set; }

        public DateTime? DateLastUpdated { get; set; }
        public string UpdatedBy { get; set; }
    }
}
