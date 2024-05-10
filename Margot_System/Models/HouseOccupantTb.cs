using System;
using System.Collections.Generic;

namespace Margot_System.Models;

public partial class HouseOccupantTb
{
    public int Id { get; set; }

    public string? FullName { get; set; }

    public string? Position { get; set; }

    public int? Age { get; set; }

    public string? BirthDate { get; set; }

    public string? CivilStatus { get; set; }

    public string? SourceIncome { get; set; }

    public virtual ICollection<AddPeopleTb> AddPeopleTbs { get; set; } = new List<AddPeopleTb>();
}
