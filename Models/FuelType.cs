﻿using System.Collections.Generic;

namespace CarsSelling.Models
{
    public class FuelType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Car> Cars { get; set; }
    }
}