namespace Fitly.Common;

public class Food
{
    /// <summary>
    /// Unique identifier for the food item
    /// </summary>
    public long Id { get; internal set; }

    /// <summary>
    /// Unique name of the food item
    /// </summary>
    public string Name { get; set; } = "";
    
    /// <summary>
    /// Standard serving size descriptor
    /// </summary>
    public double ServingSize { get; set; }

    /// <summary>
    /// Unit of measure of the serving size
    /// </summary>
    public UnitOfMeasure Unit { get; set; } = UnitOfMeasure.Gram;

    /// <summary>
    /// Energy content in Kilojoules
    /// </summary>
    public double Energy { get; set; }

    /// <summary>
    /// Protein in grams per serving
    /// </summary>
    public double Protein { get; set; }

    /// <summary>
    /// Carbohydrate in grams per serving
    /// </summary>
    public double Carbohydrate { get; set; }

    /// <summary>
    /// Total fat in grams per serving
    /// </summary>
    public double Fat { get; set; }
}
