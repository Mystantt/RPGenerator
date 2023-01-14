using Assets.Scripts.Business.Map;
using System;

namespace Assets.Scripts.Factories
{
    public static class MapFactory
    {
        private static int HEIGHT_DEFAULT=100;
        private static int WIDTH_DEFAULT=250;
        public static Map autoGenerate()
        {
            Theme t = GenerateThemeForMap();
            return GenerateManually(HEIGHT_DEFAULT, WIDTH_DEFAULT,t,GenerateSquares(HEIGHT_DEFAULT,WIDTH_DEFAULT,t));
        }

        private static Square[,] GenerateSquares(int height,int width,Theme t)
        {
            //Simplified algorithm to complexify in a near future
            Square[,] squares = new Square[height,width];
            Random rnd = new Random();
            int prob = 0;
            for(int i=0; i<height;i++)
            {
                for(int j=0; j < width; j++)
                {
                    prob = rnd.Next(100);
                    if(prob < 33)
                    {
                        squares[i, j] = new Square(new DecorPart(rnd.NextDouble()));
                    }
                    else
                    {

                        squares[i, j] = new Square();
                    }
                }
            }
            return squares;
        }

        public static Map CreateWithSize(int height,int width)
        {
            Theme t = GenerateThemeForMap();
            return GenerateManually(height,width, t, GenerateSquares(height,width,t));
        }

        public static Map CreateWithTheme(Theme theme)
        {
            return GenerateManually(HEIGHT_DEFAULT, WIDTH_DEFAULT, theme, GenerateSquares(HEIGHT_DEFAULT,WIDTH_DEFAULT,theme));
        }

        public static Map CreateWithoutSquares(int height,int width,Theme t)
        {
            return GenerateManually(height,width,t, GenerateSquares(height,width,t));
        }
        private static Theme GenerateThemeForMap()
        {
            Random rnd = new Random();
            string name = Enum.GetNames(typeof(Theme))[rnd.Next(1, Enum.GetNames(typeof(Theme)).Length)];
            return (Theme)Enum.Parse(typeof(Theme), name);
            
        }
        public static Map GenerateManually(int height, int width, Theme theme, Square[,] squares)
        {
            return new Map(height, width, theme, squares);
        }
    }
}