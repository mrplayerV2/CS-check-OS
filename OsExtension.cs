using System;

public static class OsExtension
{
	public static bool IsXpOr2003(this Version version)
	{
		if (version != null)
		{
			if (version.Major != 5 || version.Minor != 1)
			{
				if (version.Major == 5)
				{
					return version.Minor == 2;
				}
				return false;
			}
			return true;
		}
		return false;
	}

	public static bool IsXp(this Version version)
	{
		if (version != null)
		{
			if (version.Major == 5)
			{
				return version.Minor == 1;
			}
			return false;
		}
		return false;
	}

	public static bool IsWin7(this Version version)
	{
		if (version != null)
		{
			if (version.Major == 6)
			{
				return version.Minor == 1;
			}
			return false;
		}
		return false;
	}
}
