using System;
using System.IO;

namespace CSGO_Case_Calculator {

	internal class Timer {

		public static readonly string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) +
		                                     "\\WriterResults.txt";

		public static readonly FileStream fileStreamTimer =
			new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);

		public static StreamWriter streamWriterTimer = new StreamWriter(fileStreamTimer);

	}

}
