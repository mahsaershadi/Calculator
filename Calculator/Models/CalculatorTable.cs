using System;
using System.Collections.Generic;

namespace Calculator.Models;

public partial class CalculatorTable
{
    public double? FirstNumber { get; set; }

    public string? Operator { get; set; }

    public double? SecondNumber { get; set; }
}
