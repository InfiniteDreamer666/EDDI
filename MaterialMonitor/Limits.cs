﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EddiMaterialMonitor
{
    /// <summary>
    /// Limits for a material
    /// </summary>
    public class Limits
    {
        public int? minimum { get; set; }
        public int? desired { get; set; }
        public int? maximum { get; set; }

        public Limits(int? minimum, int? desired, int? maximum)
        {
            this.minimum = minimum;
            this.desired = desired;
            this.maximum = maximum;
        }
    }
}
