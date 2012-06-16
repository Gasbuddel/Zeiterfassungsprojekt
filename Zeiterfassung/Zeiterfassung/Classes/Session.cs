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

    class Session
    {
        private int authorization = 0;

        private static Session instance;

        private Session(int authorization)
        {
            this.authorization = authorization;
        }
        /// <summary>
        /// Erstellt eine neue Session, es darf nur eine Existieren und der Wert der Authorisierung darf nur einmal gesetzt werden.
        /// </summary>
        /// <param name="authorization">Authorisationsstufe 1 = Admin, 2 = User</param>
        public static void CreateSession(int authorization)
        {
            if (instance == null)
                if (authorization == 1 || authorization == 2)
                    instance = new Session(authorization);
                else
                    throw new FormatException("Es sind nur die Berechtigungsstufen 1, oder 2 zulässig");
            else
                throw new UnauthorizedAccessException("Es darf nur eine Session erstellt werden");
        }


        public static Session GetSession()
        {
            if (instance != null)
                return instance;
            else
                throw new AccessViolationException("Es existiert keine Session");
        }

        public int Authorization 
        { 
            get 
            { 
                return authorization;
            } 
        }
    }
}
