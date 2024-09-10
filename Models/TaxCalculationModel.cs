// Models/TaxCalculationModel.cs
namespace MyCVProject.Models;

public class TaxCalculationModel
{
    public string? Country { get; set; }  // Nullable to avoid warning property is non-nullable
    public decimal Income { get; set; }
    public decimal CalculatedTax { get; set; }
}

