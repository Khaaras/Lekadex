using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lekadex
{
    public static class TestDataBasePleaseDelete
    {
        public static List<DoctorViewModel> Doctors => new List<DoctorViewModel>
        {
            new DoctorViewModel
            {
                Name = "Basia",
                Prescriptions = new List<PrescriptionViewModel>
                {
                    new PrescriptionViewModel
                    {
                        Name = "Recepta1/1",
                        Medicines = new List<MedicineViewModel>
                        {
                            new MedicineViewModel
                            {
                                Name = "Magnez 1"
                            },
                            new MedicineViewModel
                            {
                                Name = "Aspiryna 1"
                            }
                        }
                    },
                    new PrescriptionViewModel
                    {
                        Name = "Recepta2/1",
                        Medicines = new List<MedicineViewModel>
                        {
                            new MedicineViewModel
                            {
                                Name = "Amantadyna 1"
                            },
                            new MedicineViewModel
                            {
                                Name = "Etopiryna 1"
                            }
                        }
                    }
                }
                
            },
            new DoctorViewModel
            {
                Name = "Piotr",
                Prescriptions = new List<PrescriptionViewModel>
                {
                    new PrescriptionViewModel
                    {
                        Name = "Recepta1/2",
                        Medicines = new List<MedicineViewModel>
                        {
                            new MedicineViewModel
                            {
                                Name = "Magnez 2"
                            },
                            new MedicineViewModel
                            {
                                Name = "Aspiryna 2"
                            }
                        }
                    },
                    new PrescriptionViewModel
                    {
                        Name = "Recepta2/2",
                        Medicines = new List<MedicineViewModel>
                        {
                            new MedicineViewModel
                            {
                                Name = "Amantadyna 2"
                            },
                            new MedicineViewModel
                            {
                                Name = "Etopiryna 2"
                            }
                        }
                    }
                }
            },
            new DoctorViewModel
            {
                Name = "Gosia",
                Prescriptions = new List<PrescriptionViewModel>
                {
                    new PrescriptionViewModel
                    {
                        Name = "Recepta1/3",
                        Medicines = new List<MedicineViewModel>
                        {
                            new MedicineViewModel
                            {
                                Name = "Magnez 3"
                            },
                            new MedicineViewModel
                            {
                                Name = "Aspiryna 3"
                            }
                        }
                    },
                    new PrescriptionViewModel
                    {
                        Name = "Recepta2/3",
                        Medicines = new List<MedicineViewModel>
                        {
                            new MedicineViewModel
                            {
                                Name = "Amantadyna 3"
                            },
                            new MedicineViewModel
                            {
                                Name = "Etopiryna 3"
                            }
                        }
                    }
                }
            },
        };
    }
}
