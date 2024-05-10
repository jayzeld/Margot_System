using System;
using System.Collections.Generic;

namespace Margot_System.Models;

public partial class RegisterTb
{
    public int Id { get; set; }

    public string Fname { get; set; } = null!;

    public string Lname { get; set; } = null!;

    public string Mname { get; set; } = null!;

    public string Uname { get; set; } = null!;

    public string Pass { get; set; } = null!;

    public string Cpass { get; set; } = null!;

    public int? Uid { get; set; }

    public virtual LoginTb? UidNavigation { get; set; }
}
