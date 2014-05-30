using System;
using System.IO;
using System.Collections.Generic;

namespace pBook
{
	public class PBook
	{
		public List<PEntry> QueryResult;
		public String Query { get; private set;}


		public enum Error
		{
			NONE
		}

		public enum Field
		{

		}

		private PBook ()
		{
		}

		public static PBook create(Stream stream, out Error e)
		{

		}

		public void inputQuery(char c)
		{
		}

		public void clearQuery()
		{
		}

		public void query(String str)
		{
		}
	}
}

