﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lekadex
{
    public class PrescriptionViewModel
    {
        public string Name { get; set; }

        public List<MedicineViewModel> Medicines { get; set; }
    }
}
