using System;
using System.Collections.Generic;

namespace Margot_System.Models;

public partial class DashboardTb
{
    public int Id { get; set; }

    public string? LastName { get; set; }

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public bool? SeniorCitizen { get; set; }

    public bool? MedicationUser { get; set; }

    public bool? StreetSweeper { get; set; }

    public bool? PetOwner { get; set; }

    public bool? Resident { get; set; }

    public virtual ICollection<AddPeopleTb> AddPeopleTbs { get; set; } = new List<AddPeopleTb>();
}
