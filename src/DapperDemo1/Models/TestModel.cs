using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace DapperDemo1.Models
{
    public class TestModel
    {
        public int book_id { get; set; }
        public string title { get; set; }
        public string type { get; set; }
        public int pub_id { get; set; }
        public double price { get; set; }
        public double advance { get; set; }
        public int royalty { get; set; }
        public int ytd_sales { get; set; }
        public string notes { get; set; }
        public DateTime published_date { get; set; }


        public static List<TestModel> GetList(IDbConnection db, string type)
        {
            string sql = @"Select * from Book where type like @type + '%' ";

            return SqlMapper.Query<TestModel>(db, sql, new { type = "business    " }).ToList();

        }

        public int Insert(IDbConnection db, IDbTransaction trans)
        {
            string insertSql = @"Insert into Book(title, type, pub_id, price, advance, royalty, ytd_sales, notes, published_date)
                                 Values(@title, @type, @pub_id, @price, @advance, @royalty, @ytd_sales, @notes, @published_date)";



            return SqlMapper.Execute(db, insertSql, this, trans);

            
        }


    }
}
