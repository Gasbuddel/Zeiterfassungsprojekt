using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zeiterfassung
{
	class ListItem
	{
		private int databankID;
		private string content;

		public ListItem(int databankID, string content)
		{
			this.databankID = databankID;
			this.content = content;
		}

		public int DatabankID 
		{
			get { return databankID; }
		}

		public string Content 
		{ 
			get { return content; } 
			set { content = value; }
		}

		public override string ToString()
		{
			return content;
		}
	}
}
