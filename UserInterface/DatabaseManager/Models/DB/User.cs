using System;
using System.Collections.Generic;

namespace UserInterface.Models.DB;

public partial class User
{
    public string Name { get; set; } = null!;

    public string Password { get; set; } = null!;

    public int Id { get; set; }

    public DateTime? DateOfSignUp { get; set; }
}
