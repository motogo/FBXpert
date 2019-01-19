using DBBasicClassLibrary;
using MessageLibrary;
using System.Threading;

namespace FBXpert.Globals
{
    class DBHandlingClass
    {
        private static readonly object _lockThis = new object();
        
        private static DBHandlingClass instance;
        public static DBHandlingClass Instance()
        {
            if (instance == null)
            {
                lock (_lockThis)
                {
                    instance = new DBHandlingClass();
                }
            }
            return (instance);
        }

        protected DBHandlingClass()
        {

        }

        public void WaitClosed(ConnectionClass cc1, string str)
        {
            int n = 0;
            while (!cc1.ConnectionIsClosed() && (n < 10))
            {
                Thread.Sleep(200);
                n++;
            }

            if (cc1.ConnectionIsClosed()) return;
            if (NotifiesClass.Instance().AllowErrors)
            {
                NotifiesClass.Instance().AddToERROR("Timeout for Connection " + cc1.ConnName + " while " + str);
            }
        }

        public void WaitClosed(ConnectionClass cc1, ConnectionClass cc2, string str)
        {
            int n = 0;
            while ((!cc1.ConnectionIsClosed() && !cc2.ConnectionIsClosed()) && (n < 10))
            {
                Thread.Sleep(200);
                n++;
            }
            if (!cc1.ConnectionIsClosed())
            {
                if (NotifiesClass.Instance().AllowErrors)
                {
                    NotifiesClass.Instance().AddToERROR("Timeout for Connection " + cc1.ConnName + " while " + str);
                }
            }
            if (!cc2.ConnectionIsClosed())
            {
                if (NotifiesClass.Instance().AllowErrors)
                {
                    NotifiesClass.Instance().AddToERROR("Timeout for Connection " + cc2.ConnName + " while " + str);
                }
            }
        }
    }
}
