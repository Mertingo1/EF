﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfMapping.Orm.Entity.CompositeKey
{
    public class CompositeKeyTable
    {
        [Key,Column(Order = 1)]

        public int TestId { get; set; }

        public int DemoID { get; set; }
    }
}
