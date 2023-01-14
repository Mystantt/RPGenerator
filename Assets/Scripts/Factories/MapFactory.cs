public static class MapFactory
{
	public static Map autoGenerate()
	{
		//TODO: Generating algo for the map
		return null;
	}

	public static Map generateManually(int height,int width,Theme theme, Square[,] squares)
	{
		return new Map(height,width,theme,squares);
	}
}