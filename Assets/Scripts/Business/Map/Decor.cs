using System.Collections.Generic;

public class Decor
{
    private readonly List<DecorPart> _decorParts;

    public Decor(List<DecorPart> parts) { _decorParts = parts; }

    public List<DecorPart> DecorParts => new List<>(_decorParts);
}