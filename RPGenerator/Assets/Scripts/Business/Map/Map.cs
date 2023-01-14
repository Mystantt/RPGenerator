using Assets.Scripts.Business.Map;
using System.Collections.Generic;
using System.Text;

public enum Theme
{
    None,Swamp,Forest,City,Farm,Dungeon
}


/**
 * Class Map to handle RPG Maps where players can move and play the game
 * @author: Dompey Fabien
 * @date: 14/01/2023
 */
public class Map
{
    private int _height;
    private int _width;
    private Theme _theme;
    private Square[,] _squares;

    public Map(int height, int width,Theme theme, Square[,] squares)
    {
        _height = height;
        _width = width;
        _theme = theme;
        _squares = squares;
    }

    public int Height { get => _height; set => _height = value; }
    public int Width { get => _width; set => _width = value; }
    public Theme Theme { get => _theme; set => _theme = value; }

    public string InConsole()
    {
        StringBuilder stringBuilder= new StringBuilder();
        for (int i = 0; i < Height; i++)
        {
            for (int j = 0; j < Width; j++)
            {
                stringBuilder.Append("[ ");
                stringBuilder.Append(_squares[i,j].IsOccupied() ? "X" : "0");
                stringBuilder.Append(" ] ");
            }
            stringBuilder.Append('\n');
        }
        return stringBuilder.ToString();
    }
}