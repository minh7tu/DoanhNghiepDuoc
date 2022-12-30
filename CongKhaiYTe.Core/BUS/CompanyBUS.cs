using CongKhaiYTe.Core.DAO;
using CongKhaiYTe.Core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CongKhaiYTe.Core.BUS
{
    public class CompanyBUS
    {
        CompanyDAO _dao;

        public CompanyBUS()
        {
            _dao = new CompanyDAO();
        }

        public void Insert(CompanyDTO dto)
        {
            _dao.Insert(dto);
        }

        public List<CompanyDTO> GetAll()
        {
            return _dao.GetAll();
        }
    }
}
