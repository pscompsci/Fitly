namespace Fitly.Common;

public class Profile
{
    public long Id { get; set; }
    public string Name { get; set; } = "";
    public DateTime DateOfBirth { get; set; }
    public double Height { get; set; }
    public Sexes BiologicalSex { get; set; }
    public MeasurementStyle MeasurementPreference { get; set; } = MeasurementStyle.Metric;
}
