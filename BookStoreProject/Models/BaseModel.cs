﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreProject.Models
{
    public class BaseModel
    {
        public int Id { get; set; }
        public Guid Guid { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public string? Description { get; set; }
        public DateTime DateCreated { get; set; }= DateTime.Now;
        public DateTime DateModified { get; set; }=DateTime.Now;
        public DateTime DateDeleted { get; set; }= DateTime.Now;
        public bool IsDeleted { get; set; } = false;
        public bool IsActive { get; set; } = true;

    }
}
