/*
 * Erstellt mit SharpDevelop.
 * Benutzer: Hemmerling.Oliver
 * Datum: 19.06.2012
 * Zeit: 08:34
 * 
 * Sie können diese Vorlage unter Extras > Optionen > Codeerstellung > Standardheader ändern.
 */
using System;
using System.Security.Cryptography;
using System.Text;

namespace Zeiterfassung
{
	/// <summary>
	/// Funktion zum MD5 erstellen und vergleichen.
	/// </summary>
	public class Md5
	{
		public static  string GetMD5(string pw)
		{
		    //Prüfen ob Daten übergeben wurden.
		    if((pw == null) || (pw.Length == 0))
		    {
			    return string.Empty;
		    }
	
		    MD5 md5 = new MD5CryptoServiceProvider();
		    // pw wird in byte umgewandelt
		    byte[] bpw = ASCIIEncoding.Default.GetBytes (pw);
		    //bpw wird mit md5 "verschlüsselt"
		    byte[] result = md5.ComputeHash(bpw); 
		    //Aus dem Bytearray result wird ein String via StringBuilder
		    StringBuilder md5string = new StringBuilder();
		    for (int i = 0; i < result.Length; i++)
		    {
			    md5string.Append(result[i].ToString("x2"));
		    }
	
		    return md5string.ToString();
		}

		public static bool Checkpw(string pw, string sqlpw)
		{
			string md5pw = GetMD5(pw);
			string md5sqlpw = GetMD5(sqlpw);

			if (md5pw == md5sqlpw)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}
