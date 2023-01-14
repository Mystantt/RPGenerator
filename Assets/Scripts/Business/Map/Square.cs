public class Square(){
    private DecorPart _decorPart;

    public Square(DecorPart decorPart)
    {
        _decorPart = decorPart;
    }
    public Square()
    {
        _decorPart = null;
    }
    public double GetObstructionLevel()
    {
        return _decorPart.ObstructionLevel;
    }
}