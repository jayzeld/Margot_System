using System;
using System.Collections.Generic;

namespace Margot_System.Models;

public partial class LoginModel
{
    public int Id { get; set; }

    public string? UserName { get; set; }

    public string? Password { get; set; }

    public virtual ICollection<RegisterModel> RegisterTbs { get; set; } = new List<RegisterModel>();
}
