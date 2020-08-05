using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAPISample.Models;
using WebAPISample.Utils;

namespace WebAPISample.Repository
{
    public class AccountRepository
    {
        public static DataModel Search(string name, int orderStart = 0, int orderCount=10)
        {
            Helper _helper = new Helper();
            DataModel data = new DataModel();
            var count = 0;
            if(orderCount>100)
            {
                data.ErrNumber = 98;
                data.ErrMessage = "Không được tải dữ liệu lớn hơn 100 bản ghi";
                return data;
            }    

            if (_helper.OpenConnect())
            {
                _helper.cmdCount = _helper.connect.CreateCommand();
                _helper.cmdCount.CommandTimeout = 600;
                _helper.cmdCount.CommandText = string.Format("SELECT * FROM Account WHERE Name like N'%{0}%' ORDER BY [id] OFFSET {1} ROWS FETCH NEXT {2} ROWS ONLY;", name, 0, orderCount + 1);
                
                var reader = _helper.cmdCount.ExecuteReader();
                while (reader.Read())
                {
                    count ++;
                }
                data.Count = (count> orderCount) ? orderCount + "+": count.ToString();

                _helper.cmd = _helper.connect.CreateCommand();
                _helper.cmd.CommandTimeout = 600;
                _helper.cmd.CommandText = string.Format("SELECT * FROM Account WHERE Name like N'%{0}%' ORDER BY [id] OFFSET {1} ROWS FETCH NEXT {2} ROWS ONLY;", name, orderStart, orderCount);

                reader = _helper.cmd.ExecuteReader();
                while (reader.Read())
                {
                    data.List.Add(new Account()
                    {
                        id = (int)reader["ID"],
                        Name = reader["Name"].ToString(),
                        Address = reader["Address"].ToString(),
                        Phone = reader["Phone"].ToString()
                    });
                }

                _helper.connect.Close();
            }
            return data;
        }
    }
}