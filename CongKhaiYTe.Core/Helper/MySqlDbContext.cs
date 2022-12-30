using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CongKhaiYTe.Core.Helper
{
    public class MySqlDbContext
    {
        internal static string _cons = @"Server=127.0.0.1;Database=qld;User ID=root;Password=Minhtu070801;charset=utf8";
        internal MySqlConnection _connect;

        public void OpenMySql()
        {
            _connect = new MySqlConnection(_cons);

            try
            {
                if (_connect.State == System.Data.ConnectionState.Closed || _connect.State == System.Data.ConnectionState.Broken)
                {
                    _connect.Open();
                }
            }
            catch (Exception)
            {

            }
        }

        //Đóng kết nối
        public void Dispose()
        {
            if (_connect.State == System.Data.ConnectionState.Open)
            {
                _connect.Close();
                _connect.Dispose();
            }
            else
            {
                _connect.Dispose();
            }
        }
    }
}
