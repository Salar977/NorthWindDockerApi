﻿using System;
using System.Collections.Generic;

namespace NorthWindDockerApi.Entities;

public partial class Order_Subtotal
{
    public int OrderID { get; set; }

    public decimal? Subtotal { get; set; }
}
