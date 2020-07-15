using Store.Shared;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Store.Infra.StoreContext.DataContext
{
    public class VanessaDataContext : IDisposable
    {
        public SqlConnection Connection { get; set; }

        public VanessaDataContext()
        {
            Connection = new SqlConnection(Settings.ConnectionString);
            Connection.Open();
        }

        public void Dispose()
        {
            if (Connection.State != ConnectionState.Closed)
                Connection.Close();
        }
    }
}
