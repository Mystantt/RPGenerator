using System;

namespace Assets.Scripts.Business.Map
{
    public class Square
    {

        private readonly DecorPart _decorPart;

        public Square(DecorPart decorPart) => _decorPart = decorPart;
        public Square()
        {
            _decorPart = null;
        }
        public double GetObstructionLevel()
        {
            if (_decorPart == null) return 0;
            return _decorPart.ObstructionLevel;
        }

        public Boolean IsOccupied()
        {
            return _decorPart != null;
        }
    }
}