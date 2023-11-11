using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestion_ABM_ADONET.CL
{
    public static class Contexto
    {
        #region Product
        public static List<Producto> LoadProduct()
        {
            List<Producto> listProduct = new List<Producto>();

            string connetionString = @"Server=NBNOBLEXAG\SQLEXPRESS;DataBase=SistemaGestion;Trusted_Connection=True;";

            string query = "SELECT Id,Descripciones,Costo,PrecioVenta,Stock,IdUsuario FROM Producto";

            try
            {
                using (SqlConnection connetion = new SqlConnection(connetionString))
                {
                    connetion.Open();

                    using (SqlCommand command = new SqlCommand(query, connetion))
                    {
                        using (SqlDataReader dr = command.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                while (dr.Read())
                                {
                                    var product = new Producto();
                                    product.Id = Convert.ToInt32(dr["Id"]);
                                    product.Descripciones = dr["Descripciones"].ToString();
                                    product.Costo = Convert.ToDecimal(dr["Costo"]);
                                    product.PrecioVenta = Convert.ToDecimal(dr["PrecioVenta"]);
                                    product.Stock = Convert.ToInt32(dr["Stock"]);
                                    product.IdUsuario = Convert.ToInt32(dr["IdUsuario"]);

                                    listProduct.Add(product);
                                }
                            }
                        }
                    }

                    connetion.Close();
                }

                return listProduct;

            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public static void CreateProduct(Producto product)
        {
            string connectionString = @"Server=NBNOBLEXAG\SQLEXPRESS;DataBase=SistemaGestion;Trusted_Connection=True;";

            string query = "INSERT INTO Producto (Descripciones, Costo, PrecioVenta, Stock, IdUsuario)" +
                            "VALUES(@Descripciones,@Costo, @PrecioVenta, @Stock, @IdUsuario); ";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add(new SqlParameter("Descripciones", SqlDbType.VarChar) { Value = product.Descripciones });
                        command.Parameters.Add(new SqlParameter("Costo", SqlDbType.Decimal) { Value = product.Costo });
                        command.Parameters.Add(new SqlParameter("PrecioVenta", SqlDbType.Decimal) { Value = product.PrecioVenta });
                        command.Parameters.Add(new SqlParameter("Stock", SqlDbType.BigInt) { Value = product.Stock });
                        command.Parameters.Add(new SqlParameter("IdUsuario", SqlDbType.BigInt) { Value = product.IdUsuario });
                        command.ExecuteNonQuery();

                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public static void UpdateProduct(Producto product)
        {
            string connectionString = @"Server=NBNOBLEXAG\SQLEXPRESS;DataBase=SistemaGestion;Trusted_Connection=True;";

            string query = "UPDATE Producto SET Descripciones = @Descripciones, Costo = @Costo, PrecioVenta = @PrecioVenta, Stock = @Stock, IdUsuario = @IdUsuario WHERE Id = @Id ";


            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add(new SqlParameter("Id", SqlDbType.BigInt) { Value = product.Id });
                        command.Parameters.Add(new SqlParameter("Descripciones", SqlDbType.VarChar) { Value = product.Descripciones });
                        command.Parameters.Add(new SqlParameter("Costo", SqlDbType.Decimal) { Value = product.Costo });
                        command.Parameters.Add(new SqlParameter("PrecioVenta", SqlDbType.Decimal) { Value = product.PrecioVenta });
                        command.Parameters.Add(new SqlParameter("Stock", SqlDbType.Decimal) { Value = product.Stock });
                        command.Parameters.Add(new SqlParameter("IdUsuario", SqlDbType.BigInt) { Value = product.IdUsuario });

                        command.ExecuteNonQuery();

                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                throw;
            }


        }
        public static void DeleteProduct(Producto product)
        {
            string connectionString = @"Server=NBNOBLEXAG\SQLEXPRESS;DataBase=SistemaGestion;Trusted_Connection=True;";

            string query = "DELETE FROM Producto WHERE Id = @Id ";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add(new SqlParameter("Id", SqlDbType.BigInt) { Value = product.Id });

                        command.ExecuteNonQuery();

                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                throw;
            }


        }

        #endregion

        #region ProductSold
        public static List<ProductoVendido> LoadProductSold()
        {
            List<ProductoVendido> listProductSold = new List<ProductoVendido>();

            string connectionString = @"Server=NBNOBLEXAG\SQLEXPRESS;DataBase=SistemaGestion;Trusted_Connection=True;";

            string query = "SELECT Id, Stock, IdProducto, IdVenta FROM ProductoVendido";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader dr = command.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                while (dr.Read())
                                {
                                    var productSold = new ProductoVendido();
                                    productSold.Id = Convert.ToInt32(dr["Id"]);
                                    productSold.Stock = Convert.ToInt32(dr["Stock"]);
                                    productSold.IdProducto = Convert.ToInt32(dr["IdProducto"]);
                                    productSold.IdVenta = Convert.ToInt32(dr["IdVenta"]);

                                    listProductSold.Add(productSold);
                                }
                            }
                        }
                    }
                    connection.Close();
                }

                return listProductSold;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static void CreateProductSold( ProductoVendido productSold)
        {
            string connectionString = @"Server=NBNOBLEXAG\SQLEXPRESS;DataBase=SistemaGestion;Trusted_Connection=True;";

            string query = "INSERT INTO ProductoVendido (Stock, IdProducto, IdVenta) VALUES (@Stock,@IdProducto, @IdVenta); ";

            try
            {
                using(SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using(SqlCommand command = new SqlCommand(query,connection))
                    {
                        command.Parameters.Add(new SqlParameter("Stock", SqlDbType.Int) { Value = productSold.Stock });
                        command.Parameters.Add(new SqlParameter("IdProducto", SqlDbType.BigInt) { Value = productSold.IdProducto });
                        command.Parameters.Add(new SqlParameter("IdVenta", SqlDbType.BigInt) { Value = productSold.IdVenta });
                        command.ExecuteNonQuery();
                    }
                    connection.Close();
                }
            }
            catch(Exception ex)
            {
                throw;
            }
        }

        public static void UpdateProductSold( ProductoVendido productSold)
        {
            string connectionString = @"Server=NBNOBLEXAG\SQLEXPRESS;DataBase=SistemaGestion;Trusted_Connection=True;";

            string query = "UPDATE ProductoVendido SET Stock = @Stock, IdProducto = @IdProducto, @IdVenta = @IdVenta WHERE Id = @Id";

            try
            {
                using(SqlConnection connection =new SqlConnection(connectionString))
                {
                    connection.Open();
                    using(SqlCommand command =new SqlCommand(query, connection))
                    {
                        command.Parameters.Add(new SqlParameter("Id", SqlDbType.BigInt) { Value = productSold.Id });
                        command.Parameters.Add(new SqlParameter("Stock", SqlDbType.Int) { Value = productSold.Stock });
                        command.Parameters.Add(new SqlParameter("IdProducto", SqlDbType.BigInt) { Value = productSold.IdProducto });
                        command.Parameters.Add(new SqlParameter("IdVenta", SqlDbType.BigInt) { Value = productSold.IdVenta });
                        command.ExecuteNonQuery();
                    }
                    connection.Close();
                }
            }catch (Exception ex)
            {
                throw;
            }

        }

        public static void DeleteProductSold(ProductoVendido productSold)
        {
            string connectionString = @"Server=NBNOBLEXAG\SQLEXPRESS;DataBase=SistemaGestion;Trusted_Connection=True;";

            string query = "DELETE ProductoVendido WHERE Id = @Id";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add(new SqlParameter("Id", SqlDbType.BigInt) { Value = productSold.Id });

                        command.ExecuteNonQuery();

                    }

                    connection.Close();
                }
            }
            catch(Exception ex) 
            { 
                throw; 
            }

        }
        #endregion

        # region Sold
        
        public static List<Venta> LoadSold()
        {
            List<Venta> saleList = new List<Venta>();

            string connectionString = @"Server=NBNOBLEXAG\SQLEXPRESS;DataBase=SistemaGestion;Trusted_Connection=True;";

            string query = "SELECT Id,Comentarios,IdUsuario FROM Venta";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader dr = command.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                while (dr.Read())
                                {
                                    var sale = new Venta();
                                    sale.Id = Convert.ToInt32(dr["Id"]);
                                    sale.Comentarios = dr["Comentarios"].ToString();
                                    sale.IdUsuario = Convert.ToInt32(dr["IdUsuario"]);

                                    saleList.Add(sale);
                                }
                            }
                        }
                    }
                    connection.Close();
                }

                return saleList;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static void CreateSold(Venta sold)
        {
            string connectionString = @"Server=NBNOBLEXAG\SQLEXPRESS;DataBase=SistemaGestion;Trusted_Connection=True;";

            string query = "INSERT INTO Venta (Comentarios, IdUsuario) VALUES (@Comentarios, @IdUsuario); ";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add(new SqlParameter("Comentarios", SqlDbType.VarChar) { Value = sold.Comentarios });
                        command.Parameters.Add(new SqlParameter("IdUsuario", SqlDbType.BigInt) { Value = sold.IdUsuario });
                        command.ExecuteNonQuery();
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static void UpdateSold(Venta sold)
        {
            string connectionString = @"Server=NBNOBLEXAG\SQLEXPRESS;DataBase=SistemaGestion;Trusted_Connection=True;";

            string query = "UPDATE Venta SET Comentarios = @Comentarios, IdUsuario = @IdUsuario WHERE Id = @Id";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add(new SqlParameter("Id", SqlDbType.BigInt) { Value = sold.Id });
                        command.Parameters.Add(new SqlParameter("Comentarios", SqlDbType.VarChar) { Value = sold.Comentarios });
                        command.Parameters.Add(new SqlParameter("IdUsuario", SqlDbType.BigInt) { Value = sold.IdUsuario });
                        command.ExecuteNonQuery();
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                throw;
            }

        }

        public static void DeleteSold(Venta sold)
        {
            string connectionString = @"Server=NBNOBLEXAG\SQLEXPRESS;DataBase=SistemaGestion;Trusted_Connection=True;";

            string query = "DELETE Venta WHERE Id = @Id";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add(new SqlParameter("Id", SqlDbType.BigInt) { Value = sold.Id });

                        command.ExecuteNonQuery();

                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                throw;
            }

        }
        #endregion

        #region User

        public static List<Usuario> LoadUser()
        {
            List<Usuario> listUser = new List<Usuario>();

            string connectionString = @"Server=NBNOBLEXAG\SQLEXPRESS;DataBase=SistemaGestion;Trusted_Connection=True;";

            string query = "SELECT Id,Nombre,Apellido,NombreUsuario,Contraseña,Mail FROM Usuario";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader dr = command.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                while (dr.Read())
                                {
                                    var user = new Usuario();

                                    user.Id = Convert.ToInt32(dr["Id"]);
                                    user.Nombre = dr["Nombre"].ToString();
                                    user.Apellido = dr["Apellido"].ToString();
                                    user.NombreUsuario = dr["NombreUsuario"].ToString();
                                    user.Contraseña = dr["Contraseña"].ToString();
                                    user.Mail = dr["Mail"].ToString();

                                    listUser.Add(user);
                                }
                            }
                        }
                    }
                    connection.Close();
                }

                return listUser;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static void CreateUser(Usuario user)
        {
            string connectionString = @"Server=NBNOBLEXAG\SQLEXPRESS;DataBase=SistemaGestion;Trusted_Connection=True;";

            string query = "INSERT INTO Usuario (Nombre, Apellido, NombreUsuario, Contraseña, Mail) VALUES (@Nombre, @Apellido, @NombreUsuario, @Contraseña, @Mail) ";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add(new SqlParameter("Nombre", SqlDbType.VarChar) { Value = user.Nombre});
                        command.Parameters.Add(new SqlParameter("Apellido", SqlDbType.VarChar) { Value = user.Apellido  });
                        command.Parameters.Add(new SqlParameter("NombreUsuario", SqlDbType.VarChar) { Value = user.NombreUsuario });
                        command.Parameters.Add(new SqlParameter("Contraseña", SqlDbType.VarChar) { Value = user.Contraseña  });
                        command.Parameters.Add(new SqlParameter("Mail", SqlDbType.VarChar) { Value = user.Mail });
                        command.ExecuteNonQuery();
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static void UpdateUser(Usuario user)
        {
            string connectionString = @"Server=NBNOBLEXAG\SQLEXPRESS;DataBase=SistemaGestion;Trusted_Connection=True;";

            string query = "UPDATE Usuario SET Nombre = @Nombre, Apellido = @Apellido, NombreUsuario = @NombreUsuario, Contraseña = @Contraseña, Mail = @Mail WHERE Id = @Id";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add(new SqlParameter("Id", SqlDbType.BigInt) { Value = user.Id });
                        command.Parameters.Add(new SqlParameter("Nombre", SqlDbType.VarChar) { Value = user.Nombre });
                        command.Parameters.Add(new SqlParameter("Apellido", SqlDbType.VarChar) { Value = user.Apellido });
                        command.Parameters.Add(new SqlParameter("NombreUsuario", SqlDbType.VarChar) { Value = user.NombreUsuario });
                        command.Parameters.Add(new SqlParameter("Contraseña", SqlDbType.VarChar) { Value = user.Contraseña });
                        command.Parameters.Add(new SqlParameter("Mail", SqlDbType.VarChar) { Value = user.Mail });
                        command.ExecuteNonQuery();
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                throw;
            }

        }

        public static void DeleteUser(Usuario user)
        {
            string connectionString = @"Server=NBNOBLEXAG\SQLEXPRESS;DataBase=SistemaGestion;Trusted_Connection=True;";

            string query = "DELETE Usuario WHERE Id = @Id";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add(new SqlParameter("Id", SqlDbType.BigInt) { Value = user.Id });

                        command.ExecuteNonQuery();

                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                throw;
            }

        }
        #endregion

    }
}
