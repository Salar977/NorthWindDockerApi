using System;
using System.Collections.Generic;

namespace NorthWindDockerApi.Entities;

public partial class Current_Product_List
{
    public int ProductID { get; set; }

    public string ProductName { get; set; } = null!;
}
