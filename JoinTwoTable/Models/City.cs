﻿using System;
using System.Collections.Generic;

namespace JoinTwoTable.Models
{
    public partial class City
    {
        public int CityId { get; set; }
        public string? CityName { get; set; }
        public int? StateId { get; set; }

        public virtual State? State { get; set; }
    }
}
