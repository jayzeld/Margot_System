using System;
using System.Collections.Generic;

namespace Margot_System.Models;

public partial class LoginTb
{
    public int Id { get; set; }

    public string? UserName { get; set; }

    public string? Password { get; set; }

    public virtual ICollection<RegisterTb> RegisterTbs { get; set; } = new List<RegisterTb>();
}
