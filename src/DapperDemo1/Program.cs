using Dapper;
using DapperDemo1.Models;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace DapperDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
       
            #region ++ 데이터 테이블 예제

            var dt = new DataTable();

            //using (var db = new SqlConnection("Server=localhost;Database=BookStoresDB;User Id=sa;Password=smkwon"))
            //{
            //    db.Open();
            //
            //    using (var cmd = new SqlCommand())
            //    {
            //        cmd.Connection = db;
            //        cmd.CommandText = insertSql;
            //        cmd.Parameters.AddWithValue("titye", "SSSund is not SSun");
            //        cmd.Parameters.AddWithValue("type", "business");
            //        cmd.Parameters.AddWithValue("pub_id", 1);
            //        cmd.Parameters.AddWithValue("price", 99.79);
            //        cmd.Parameters.AddWithValue("advance", 565555.00);
            //        cmd.Parameters.AddWithValue("royalty", 500);
            //        cmd.Parameters.AddWithValue("ytd_sales", 900);
            //        cmd.Parameters.AddWithValue("notes", "Favorite recipes for quick, easy, and elegant meals.");
            //        cmd.Parameters.AddWithValue("published_date", DateTime.Now);
            //
            //        cmd.ExecuteNonQuery();
            //    }
            //
            //
            //    using (var cmd = new SqlCommand())
            //    {
            //        cmd.Connection = db;
            //        cmd.CommandText = sql;
            //        cmd.Parameters.AddWithValue("type", "business");
            //
            //        dt.Load(cmd.ExecuteReader());
            //    }
            //}
            //
            //foreach (DataRow row in dt.Rows)
            //{
            //    Console.WriteLine(row["book_id"] as int?);
            //    Console.WriteLine(row["title"] as string);
            //}

            #endregion

            using (var db = new SqlConnection("Server=localhost;Database=BookStoresDB;User Id=sa;Password=smkwon"))
            {
                db.Open();

                /// 트랜잭션
                var tran = db.BeginTransaction();

                try
                {
                    var model = new TestModel();

                    model.title = "이 책은 세번째 Test Guide 이다";
                    model.type = "business";
                    model.pub_id = 2;
                    model.price = 11.95;
                    model.advance = 5000.00;
                    model.royalty = 10;
                    model.ytd_sales = 18722;
                    model.notes = "이 텍스트는 그냥 텍스트다.";
                    model.published_date = DateTime.Now;

                    model.Insert(db, tran);

                    tran.Commit();

                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    Console.WriteLine(ex.Message);
                }

                

                var list = TestModel.GetList(db, "type");

                foreach (var i in list)
                {
                    Console.WriteLine($"{i.book_id}_제목: {i.title} / 가격: {i.price}원_{i.published_date}");
                }


                //SqlMapper.Execute(db, insertSql, model);






            }
        }
    }
}
