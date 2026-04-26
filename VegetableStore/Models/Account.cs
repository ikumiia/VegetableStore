using System;
using System.Collections.Generic;

namespace VegetableStore.Models;

public partial class Account
{
    public int AccountId { get; set; }

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string Fio { get; set; } = null!;

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
