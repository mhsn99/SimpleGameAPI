﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaming.Entities
{
    public class Company : IEntity
    {
        public int Id { get ; set ; }
        public string CompanyName { get; set ; }

        public ICollection<Game> Games { get; set ; }
    }
}
