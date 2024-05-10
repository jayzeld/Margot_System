using System;
using System.Collections.Generic;

namespace Margot_System.Models;

public partial class ProfileModel
{
    public int Id { get; set; }

    public int? DashboardId { get; set; }

    public int? OccupantId { get; set; }

    public string? LastName { get; set; }

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? PresentAddress { get; set; }

    public bool? HouseType { get; set; }

    public string? ProvincialAddress { get; set; }

    public string? LengthOfStay { get; set; }

    public string? Gender { get; set; }

    public bool? CivilStatus { get; set; }

    public int? ContactNumber { get; set; }

    public string? DateOfBirth { get; set; }

    public string? PlaceOfBirth { get; set; }

    public string? Religion { get; set; }

    public string? Email { get; set; }

    public string? Registered { get; set; }

    public int? PrecintNumber { get; set; }

    public string? Remarks { get; set; }

    public bool? SeniorCitizen { get; set; }

    public bool? StreetSweeper { get; set; }

    public bool? Residents { get; set; }

    public bool? TakingMeds { get; set; }

    public string? Meds { get; set; }

    public bool? PetOwner { get; set; }

    public string? Pets { get; set; }

    public string? EmployeeDuration { get; set; }

    public string? CompanyName { get; set; }

    public string? Employer { get; set; }

    public virtual DashboardModel? Dashboard { get; set; }

    public virtual HouseOccupantModel? Occupant { get; set; }
}
