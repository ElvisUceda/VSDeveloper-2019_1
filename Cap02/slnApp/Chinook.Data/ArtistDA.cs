﻿using Chinook.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Chinook.Data
{
    public class ArtistDA : BaseConnection
    {
        public int GetCount()
        {
            var result = 0;

            var sql = "SELECT COUNT(1) FROM Artist";
            /*1: Create una instancia sql DbConnection*/
            using (IDbConnection cn = new SqlConnection(GetConnection()))
            {
                /*2: Create ua instancia de Command*/
                IDbCommand cmd = new SqlCommand(sql);
                cmd.Connection = cn;
                cn.Open(); //Abriendo la conexion a la DB
                           /*3. ejecutando el comando*/
                result = (int)cmd.ExecuteScalar();
            }

            return result;
        }

        public List<Artist> GetArtists()
        {
            var result = new List<Artist>();
            var sql = "SELECT ArtistId,Name FROM Artist";
            using (IDbConnection cn = new SqlConnection(GetConnection()))
            {
                /*2: Create ua instancia de Command*/
                IDbCommand cmd = new SqlCommand(sql);
                cmd.Connection = cn;
                cn.Open(); //Abriendo la conexion a la DB
                           /*3. ejecutando el comando*/

                var indice = 0;
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    indice = reader.GetOrdinal("ArtistId");
                    var artistId = reader.GetInt32(indice);

                    indice = reader.GetOrdinal("Name");
                    var name = reader.GetString(indice);

                    result.Add(
                            new Artist()
                            {
                                ArtistId = artistId,
                                Name = name
                            }
                        );
                }
            }

            return result;
        }

        public List<Artist> GetArtists(string filterByName)
        {
            var result = new List<Artist>();
            var sql = "SELECT ArtistId,Name FROM Artist WHERE Name like @name";
            using (IDbConnection cn = new SqlConnection(GetConnection()))
            {
                /*2: Create ua instancia de Command*/
                IDbCommand cmd = new SqlCommand(sql);
                cmd.Connection = cn;
                cn.Open(); //Abriendo la conexion a la DB
                           /*3. ejecutando el comando*/

                /*Configurando los parametros*/
                cmd.Parameters.Add(new
                    SqlParameter("@name", filterByName)
                    );

                var indice = 0;
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    indice = reader.GetOrdinal("ArtistId");
                    var artistId = reader.GetInt32(indice);

                    indice = reader.GetOrdinal("Name");
                    var name = reader.GetString(indice);

                    result.Add(
                            new Artist()
                            {
                                ArtistId = artistId,
                                Name = name
                            }
                        );
                }
            }

            return result;
        }

        public List<Artist> GetArtisWithSP(string filterByname)
        {
            var result = new List<Artist>();
            var sql = "usp_GetArtist";
            using (IDbConnection cn = new SqlConnection(GetConnection()))
            {
                /*2: Create ua instancia de Command*/
                IDbCommand cmd = new SqlCommand(sql);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = cn;

                //Agregando el parametro
                cmd.Parameters.Add(new SqlParameter("@pNombre", filterByname));

                cn.Open(); //Abriendo la conexion a la DB
                           /*3. ejecutando el comando*/

                var indice = 0;
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    indice = reader.GetOrdinal("ArtistId");
                    var artistId = reader.GetInt32(indice);

                    indice = reader.GetOrdinal("Name");
                    var name = reader.GetString(indice);

                    result.Add(
                            new Artist()
                            {
                                ArtistId = artistId,
                                Name = name
                            }
                        );
                }
            }

            return result;
        }
        public int InsertArtist(Artist entity)
        {
            var result = 0;
            using (IDbConnection cn
                = new SqlConnection(GetConnection()))
            {
                cn.Open();
                IDbCommand command =
                    new SqlCommand("usp_InsertArtist");
                command.Connection = cn;
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                    new SqlParameter("@Name", entity.Name)
                    );

                result = Convert.ToInt32(command.ExecuteScalar());

            }

            return result;

        }


        public int InsertArtistWithOutput(Artist entity)
        {
            var result = 0;
            using (IDbConnection cn
                = new SqlConnection(GetConnection()))
            {
                cn.Open();
                IDbCommand command =
                    new SqlCommand("usp_InsertArtistWithOutput");
                command.Connection = cn;
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                    new SqlParameter("@Name", entity.Name)
                    );

                var paramOutID = new SqlParameter();
                paramOutID.ParameterName = "@ID";
                paramOutID.Direction = ParameterDirection.Output;
                paramOutID.DbType = DbType.Int32;
                command.Parameters.Add(paramOutID);

                command.ExecuteScalar();

                result = Convert.ToInt32(paramOutID.Value);

            }

            return result;
        }

        public int InsertArtistWithTX(Artist entity)
        {
            var result = 0;
            using (IDbConnection cn
                = new SqlConnection(GetConnection()))
            {
                cn.Open();

                // Iniciando la Transaction local
                var transaction = cn.BeginTransaction();

                try
                {
                    IDbCommand command =

                   new SqlCommand("usp_InsertArtist");
                    command.Connection = cn;
                    command.Transaction = transaction; // Local transaction
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(
                        new SqlParameter("@Name", entity.Name)
                        );

                    result = Convert.ToInt32(command.ExecuteScalar());

                    // Simulando un error
                    // Throw new Exception(Error al insertar")

                    // Confirmando la transaccion
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback(); // Deshaciendo la transaccion local
                }

            }

            return result;

        }

       // Actualizar Artist

        public int UpdateArtist(Artist entity)
        {
            var result = 0;
            using (IDbConnection cn
                = new SqlConnection(GetConnection()))
            {
                cn.Open();
                IDbCommand command =
                    new SqlCommand("usp_UpdateArtist");
                command.Connection = cn;
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                      new SqlParameter("@Name", entity.Name)
                   );


              

            }
            return result;

        }

        // Eliminar Artist

        public int DeleteArtist(Artist entity)
        {
            var result = 0;
            using (IDbConnection cn
                = new SqlConnection(GetConnection()))
            {
                cn.Open();
                IDbCommand command =
                    new SqlCommand("usp_DeleteArtist");
                command.Connection = cn;
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                    new SqlParameter("@Name", entity.Name)
                    );

              

            }

            return result;

        }

        public int InsertArtistWithTXDist(Artist entity)
        {
            var result = 0;


            using (var tx = new TransactionScope())
            {
                try
                {
                    using (IDbConnection cn
                  = new SqlConnection(GetConnection()))
                    {
                        cn.Open();
                        IDbCommand command =
                            new SqlCommand("usp_InsertArtist");
                        command.Connection = cn;
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(
                            new SqlParameter("@Name", entity.Name)
                            );

                        result = Convert.ToInt32(command.ExecuteScalar());
                    }
                    tx.Complete();
                }
                catch (Exception ex)
                {

                }
               
            }

            return result;

        }
        

    }
}

