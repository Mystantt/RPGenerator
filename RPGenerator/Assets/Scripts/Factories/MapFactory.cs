using Assets.Scripts.Business.Map;
using System;

namespace Assets.Scripts.Factories
{
    public static class MapFactory
    {
        public static Map autoGenerate()
        {
            Random rnd = new Random();
            string name = Enum.GetNames(typeof(Theme))[rnd.Next(1, Enum.GetNames(typeof(Theme)).Length)];
            Theme t = (Theme)Enum.Parse(typeof(Theme), name);

            //TODO: Generating algo for the map
            return new Map(0, 0, t, null);
        }

        public static Map generateManually(int height, int width, Theme theme, Square[,] squares)
        {
            return new Map(height, width, theme, squares);
        }
    }
}