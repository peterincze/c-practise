using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_game_lite
{
	class Program
	{
		static List<char> LineGenerator(int size)
		{
			List<char> ret = new List<char>();
			for (int i = 0; i < size; ++i)
			{
				ret.Add('_');
			}
			return ret;
		}
		static List<List<char>> MapGenerator(int size)
		{
			List<List<char>> map = new List<List<char>>();
			for (int i = 0; i < size; ++i)
			{
				map.Add(LineGenerator(size));
			}
			return map;
		}
		static void MapDrower(List<List<char>> map)
		{
			for (int i = 0; i < map.Count; ++i)
			{
				for (int j = 0; j < map[i].Count; ++j)
				{
					Console.Write("{0}", map[j][i]);
				}
				Console.Write("\n");
			}
		}

		static void Main(string[] args)
		{
			List<List<char>> map = new List<List<char>>(MapGenerator(20));
			int heroeY = 19;
			int heroeX = 19;
			map[heroeX][heroeY] = 'X';			//x, y coordinates
			map[10][7] = 'O';
			MapDrower(map);
			ConsoleKeyInfo navigate = Console.ReadKey();

			while (navigate.Key != ConsoleKey.Escape)
			{
				navigate = Console.ReadKey();
				if (navigate.Key == ConsoleKey.LeftArrow)
				{
					if (heroeX > 0)
					{
						map[heroeX][heroeY] = '_';
						heroeX--;
						Console.Clear();
						map[heroeX][heroeY] = 'X';
						MapDrower(map);
					}
				}
				else if (navigate.Key == ConsoleKey.RightArrow)
				{
					if (heroeX < 19)
					{
						map[heroeX][heroeY] = '_';
						heroeX++;
						Console.Clear();
						map[heroeX][heroeY] = 'X';
						MapDrower(map);
					}
				}
				else if (navigate.Key == ConsoleKey.UpArrow)
				{
					if (heroeY > 0)
					{
						map[heroeX][heroeY] = '_';
						heroeY--;
						Console.Clear();
						map[heroeX][heroeY] = 'X';
						MapDrower(map);
					}
				}
				else if (navigate.Key == ConsoleKey.DownArrow)
				{
					if (heroeY < 19)
					{
						map[heroeX][heroeY] = '_';
						heroeY++;
						Console.Clear();
						map[heroeX][heroeY] = 'X';
						MapDrower(map);
					}
				}
			}

			Console.ReadLine();
		}
	}
}
