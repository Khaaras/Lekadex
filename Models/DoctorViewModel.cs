﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lekadex
{
    public class DoctorViewModel
    {
        public string Name { get; set; }
        public List<PrescriptionViewModel> Prescriptions { get; set; }

    }
}
