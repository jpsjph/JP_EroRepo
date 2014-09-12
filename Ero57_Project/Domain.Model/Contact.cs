﻿using Core.Infrastructure;
using Domain.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class Contact : EntityBase
    {
       public Contact()
       {
           Individuals = new HashSet<Individual>();
           //Registrations = new HashSet<Registration>();
       }
        public int ContactId { get; set; }
        public string ContactRef { get; set; }
        public string RoleName { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }
        public Status ContactStatus { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public int CreatorId { get; set; }
        public int UpdatorId { get; set; }
        public virtual ICollection<Individual> Individuals { get; set; }
        //public virtual ICollection<Registration> Registrations { get; set; }
    }
}
