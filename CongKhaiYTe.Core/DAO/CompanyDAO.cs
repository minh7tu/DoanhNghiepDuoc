using CongKhaiYTe.Core.DTO;
using CongKhaiYTe.Core.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace CongKhaiYTe.Core.DAO
{
    public class CompanyDAO
    {
        private readonly MySqlDbContext _context;

        public CompanyDAO()
        {
            _context = new MySqlDbContext();
        }

        public void Insert(CompanyDTO dto)
        {
            _context.OpenMySql();

            string sql = "insert ignore into infor_company(id,company_name,register_product_name,ad_confirm_number,tax_code,link) values(@id,@company_name,@register_product_name,@ad_confirm_number,@tax_code,@link)";
          
            MySqlCommand cmd = new MySqlCommand(sql, _context._connect);

            cmd.Parameters.AddWithValue("@id", dto.Id);
            cmd.Parameters.AddWithValue("@company_name", dto.CompanyName);
            cmd.Parameters.AddWithValue("@register_product_name", dto.RegisterProductName);
            cmd.Parameters.AddWithValue("@tax_code", dto.TaxCode);
            cmd.Parameters.AddWithValue("@ad_confirm_number", dto.AdComfirmNumber);
            cmd.Parameters.AddWithValue("@link", dto.Link);

            cmd.ExecuteNonQuery();

            _context.Dispose();

        }

        public List<CompanyDTO> GetAll()
        {
            _context.OpenMySql();

            List<CompanyDTO> listAll = new List<CompanyDTO>();

            string sql = "select * from infor_company";

            MySqlCommand cmd = new MySqlCommand(sql, _context._connect);

            MySqlDataReader data = cmd.ExecuteReader();

            while(data.Read())
            {
                CompanyDTO dto = new CompanyDTO();
                
                dto.CompanyName = data["link"].ToString();

                listAll.Add(dto);
            }

            _context.Dispose();

            return listAll;
        }
    }
}
