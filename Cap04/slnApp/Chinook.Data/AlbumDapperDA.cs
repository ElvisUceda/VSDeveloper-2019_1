using Chinook.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using Dapper;

namespace Chinook.Data
{
   public class AlbumDapperDA:BaseConnection
    {
        public int GetCount()
        {
            var result = 0;

            var sql = "SELECT COUNT(1) FROM Album";
            /*1: Create una instancia sql DbConnection*/
            using (IDbConnection cn = new SqlConnection(GetConnection()))
            {
                result = cn.Query<int>(sql).Single();

            }

            return result;
        }

        public List<Album> GetAlbum()
        {
            var result = new List<Album>();
            var sql = "SELECT AlbumId,Title FROM Album";
            using (IDbConnection cn = new SqlConnection(GetConnection()))
            {

                result = cn.Query<Album>(sql).ToList();

            }

            return result;
        }

        public List<Album> GetAlbum(string filterByName)
        {
            var result = new List<Album>();
            var sql = "SELECT AlbumId,Title FROM Album WHERE Title like @title";
            using (IDbConnection cn = new SqlConnection(GetConnection()))
            {

                result = cn.Query<Album>(sql
                    , new { title = filterByName }).ToList();


            }

            return result;
        }

        public List<Album> GetAlbumWithSP(string filterByname)
        {
            var result = new List<Album>();
            var sql = "usp_GetAlbum";
            using (IDbConnection cn = new SqlConnection(GetConnection()))
            {
                result = cn.Query<Album>(sql
                      , new { pTitle = filterByname }
                      , commandType: CommandType.StoredProcedure).ToList();



            }

            return result;
        }

        public int InsertAlbum(Album entity)
        {
            var result = 0;
            using (IDbConnection cn
                = new SqlConnection(GetConnection()))
            {
                result = cn.Query<int>("usp_InsertAlbum",
                     new { Title = entity.Title, ArtistId = entity.ArtistId },

                    commandType: CommandType.StoredProcedure).Single();




            }

            return result;

        }

        public bool UpdateAlbum(Album entity)
        {
            var result = false;
            using (IDbConnection cn
                = new SqlConnection(GetConnection()))
            {
                cn.Query("usp_UpdateAlbum",
                    new {AlbumId = entity.AlbumId, Title = entity.Title, ArtistId = entity.ArtistId },
                    commandType: CommandType.StoredProcedure);

                result = true;

            }
            return result;
        }

       
        public int DeleteAlbum(Album entity)
        {
            var result = 0;
            using (IDbConnection cn
                = new SqlConnection(GetConnection()))
            {
                result = cn.Query<int>("usp_DeleteAlbum",
                     new { Title = entity.Title },

                     commandType: CommandType.StoredProcedure).Single();


            }

            return result;
        }
    }
}
