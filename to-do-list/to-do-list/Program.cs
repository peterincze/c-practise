using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace to_do_list
{
	 class Datas
	{
		string task;
		int priority;
		bool state = false;

		public void GetDatas()
		{
			string data = Console.ReadLine();
			string command = data.Substring(0, 1);
			string task = data.Substring(3, data.Length - 1);
			int prio = int.Parse(data.Substring(data.Length - 1));
		}
	}
	
	class Program
	{
		static void Arguments()
		{
			Console.WriteLine("CLI Todo application\n" +
				" ====================\n \n " +
				"Command line arguments:\n" +
				"-l\t Lists all the tasks\n" +
				"-a\t Adds a new task\n" +
				"-r\t Removes an task\n" +
				"-c\t Completes an task\n" +
				"-x\t Exit");
		}

		static void Main(string[] args)
		{
			Arguments();
			
			
			Console.WriteLine("{0}\n{1}", command, task);
			Console.ReadLine();
		}
	}
}

