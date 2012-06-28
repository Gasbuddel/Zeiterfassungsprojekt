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

        /// <summary>
        /// Listitem, das DatenbankId und Inhalt abspeichert
        /// </summary>
        /// <param name="databankID"></param>
        /// <param name="content"></param>
		public ListItem(int databankID, string content)
		{
			this.databankID = databankID;
			this.content = content;
		}

        /// <summary>
        /// ID in der Datenbank
        /// </summary>
		public int DatabankID 
		{
			get { return databankID; }
		}

        /// <summary>
        /// Textinhalt aus der Datenbank
        /// </summary>
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
