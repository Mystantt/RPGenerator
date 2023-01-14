public class DecorPart
{
    private double _obstructionLevel;

    public DecorPart(double obstructionLevel) { _obstructionLevel = obstructionLevel; }

    public double ObstructionLevel { get => _obstructionLevel; set => _obstructionLevel = value; }
}