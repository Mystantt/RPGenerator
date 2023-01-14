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
            return _decorPart.ObstructionLevel;
        }
    }
}