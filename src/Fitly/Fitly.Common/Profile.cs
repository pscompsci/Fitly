namespace Fitly.Common;

public class Profile
{
    /// <summary>
    /// Unique identifier of the profile
    /// </summary>
    public long Id { get; set; }

    /// <summary>
    /// Name of the person
    /// </summary>
    public string Name { get; set; } = "";

    /// <summary>
    /// Date of birth of the person
    /// </summary>
    public DateTime DateOfBirth { get; set; }

    /// <summary>
    /// Height of the person in centimetres
    /// </summary>
    public double Height { get; set; }

    /// <summary>
    /// Biological sex of the person
    /// </summary>
    public SexType BiologicalSex { get; set; }

    /// <summary>
    /// Preferred display unit (imperial | metric)
    /// </summary>
    public UnitType PreferredUnit { get; set; } = UnitType.Metric;
}
