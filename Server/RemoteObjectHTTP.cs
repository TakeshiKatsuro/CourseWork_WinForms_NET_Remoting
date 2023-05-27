using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Runtime.Remoting.Lifetime;
using System.IO;

namespace Server
{
    [Serializable]
    public class RemoteObjectHTTP : MarshalByRefObject, IGuitars
    {
        private string connectionString = "Data Source=C:/Users/Руслан/source/repos/CourseWork_TP_2023/DB_CourseWork.db";

        public RemoteObjectHTTP()
        {
            Console.WriteLine("Удаленный объект HTTP создан!");
        }
        ~RemoteObjectHTTP()
        {
            Console.WriteLine("Удаленный объект HTTP уничтожен!");
        }
        
        public byte[] Upload(string path)
        {
            return File.ReadAllBytes("Sources\\" + path);
        }

        public override object InitializeLifetimeService()
        {
            ILease lease = (ILease)base.InitializeLifetimeService();

            if (lease.CurrentState == LeaseState.Initial)
            {
                lease.InitialLeaseTime = TimeSpan.FromSeconds(3);
                lease.SponsorshipTimeout = TimeSpan.FromSeconds(10);
                lease.RenewOnCallTime = TimeSpan.FromSeconds(2);
            }

            return lease;
        }

        public int find(string brand, string model)
        {
            throw new NotImplementedException();
        }
    }
}
