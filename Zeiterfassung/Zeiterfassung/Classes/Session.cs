using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zeiterfassung
{
    public enum Authorization : int
    {
        Admin = 1,
        User = 2
    }

    public class Session
    {
        private int authorization = 0;

        private int userId;

		private int ProID;

        private bool startPw = false;

        private static Session instance;

        private Session(int authorization, int userId)
        {
            this.authorization = authorization;
            this.userId = userId;
        }

        public void StartPwChange()
        {
            if (this.startPw == false)
            {
                this.startPw = true;
            }
            else
            {
                this.startPw = false;
            }
        }

        /// <summary>
        /// Erstellt eine neue Session, es darf nur eine Existieren und der Wert der Authorisierung darf nur einmal gesetzt werden.
        /// </summary>
        /// <param name="authorization">Authorisationsstufe 1 = Admin, 2 = User</param>
        public static void CreateSession(int authorization, int userId)
        {
            if (instance == null)
                if (authorization == 1 || authorization == 2)
                    instance = new Session(authorization, userId);
                else
                    throw new FormatException("Es sind nur die Berechtigungsstufen 1, oder 2 zulässig");
            else
                throw new UnauthorizedAccessException("Es darf nur eine Session erstellt werden");
        }

		/// <summary>
		/// Gibt die aktuelle Session zurück, dafür muss aber zuerst eine Session erstellt worden sein
		/// </summary>
		/// <returns>Die aktuelle Session</returns>
        public static Session GetSession()
        {
            if (instance != null)
                return instance;
            else
                throw new AccessViolationException("Es existiert keine Session");
        }


		/// <summary>
		/// Authorisationsstufe (1 = Administrator, 2 = User)
		/// </summary>
        public int Authorization 
        { 
            get 
            { 
                return authorization;
            } 
        }

		/// <summary>
		/// BenutzerId aus der Datenbank
		/// </summary>
        public int UserId
        {
            get
            {
                return userId;
            }
        }

		public int ProId
		{
			get
			{
				return ProID;
			}

			set
			{
				this.ProID = value;
			}
		}

        public bool StartPw
        {
            get
            {
                return startPw;
            }
        }
    }
}
