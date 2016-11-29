using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using MySql.Data.Types;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Servidor.POJO;
using System.Data.SqlClient;

namespace Servidor
{
    // https://www.codeproject.com/articles/43438/connect-c-to-mysql
    class ConexionBD
    {
        private MySqlConnection conex;

        public ConexionBD()
        { }

        public ConexionBD(string server, string database, string uid, string pass)
        {
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + pass + ";";
            conex = new MySqlConnection(connectionString);
            Console.WriteLine("Conexión establecida :)");
            //Console.ReadKey();
        }

        public Usuario consultarUsuario(int idCliente)
        {
            if ( open() )
            {
                try
                {
                    string query = "SELECT * FROM USERS WHERE idUser=?id";
                    MySqlCommand cmd = new MySqlCommand(query, conex);
                    cmd.Parameters.Add("?id", MySqlDbType.Int16).Value = idCliente;

                    MySqlDataReader dataReader = cmd.ExecuteReader();
                    dataReader.Read();

                    string username = dataReader.GetString(1);
                    string firstname = dataReader.GetString(3);
                    string lastname = dataReader.GetString(4);
                    string lastname2 = dataReader.GetString(5);

                    Usuario usr = new Usuario(idCliente, username);
                    usr.nombre = firstname;
                    usr.apellidoP = lastname;
                    usr.apellidoM = lastname2;

                    dataReader.Close();
                    close();

                    return usr;
                }
                catch (Exception e)
                {
                    Console.WriteLine("An exception of type " + e.GetType() + " was encountered.");
                    close();
                    return null;
                }
            }

            Console.WriteLine("Connection closed.");
            return null;
        }

        public Cuenta consultarCuenta(int idCuenta)
        {
            if ( open() )
            {
                try
                {
                    string query = "SELECT * FROM ACCOUNT WHERE idAccount=?id";
                    MySqlCommand cmd = new MySqlCommand(query, conex);
                    cmd.Parameters.Add("?id", MySqlDbType.Int16).Value = idCuenta;

                    MySqlDataReader dataReader = cmd.ExecuteReader();
                    dataReader.Read();

                    int idUsr = dataReader.GetInt16(1);
                    int tipo = dataReader.GetInt16(2);
                    double balance = dataReader.GetDouble(3);
                    double credit;
                    if (tipo == 1)
                        { credit = dataReader.GetDouble(4); }
                    else
                        { credit = 0; }

                    dataReader.Close();
                    close();

                    Usuario usr = consultarUsuario(idUsr);
                    return new Cuenta(idCuenta, usr, tipo, balance, credit);
                }
                catch (Exception e)
                {
                    Console.WriteLine("An exception of type " + e.GetType() + " was encountered.");
                    close();
                    return null;
                }
            }

            Console.WriteLine("Connection closed.");
            return null;
        }

        public bool actualizarBalance(int idCuenta, double cambio) //El cambio puede ser positivo o negativo
        {
            Cuenta cuenta = consultarCuenta(idCuenta);

            if ( open() )
            {
                try
                {
                    string query = "UPDATE account SET balance=?bal WHERE idAccount=?id;";

                    MySqlCommand cmd = new MySqlCommand(query, conex);
                    cmd.Parameters.Add("?id", MySqlDbType.Int16).Value = idCuenta;
                    cmd.Parameters.Add("?bal", MySqlDbType.Double).Value = cuenta.balance + cambio;

                    cmd.ExecuteNonQuery();
                    close();

                    return true;
                }
                catch (Exception e)
                {
                    Console.WriteLine("An exception of type " + e.GetType() + " was encountered.");
                    return false;
                }
            }

            Console.WriteLine("Connection closed.");
            return false;
        }

        public List<Cuenta> obtenerCuentas(int idCliente)
        {
            List<Cuenta> cuentas = new List<Cuenta>();
            Usuario usr = consultarUsuario(idCliente);

            if ( open() )
            {
                try
                {
                    string query = "SELECT * FROM ACCOUNT WHERE idUser=?id;";
                    MySqlCommand cmd = new MySqlCommand(query, conex);
                    cmd.Parameters.Add("?id", MySqlDbType.Int16).Value = idCliente;

                    MySqlDataReader dataReader = cmd.ExecuteReader();

                    while ( dataReader.Read() )
                    {
                        int idCuenta = dataReader.GetInt16(0);
                        int tipo = dataReader.GetInt16(2);
                        double balance = dataReader.GetDouble(3);
                        double credit;
                        if (tipo == 1)
                            { credit = dataReader.GetDouble(4); }
                        else
                            { credit = 0; }
                        
                        Cuenta aux = new Cuenta(idCuenta, usr, tipo, balance, credit);
                        cuentas.Add(aux);
                    }

                    dataReader.Close();
                    close();

                    return cuentas;
                }
                catch (Exception e)
                {
                    Console.WriteLine("An exception of type " + e.GetType() + " was encountered.");
                    close();
                    return null;
                }
            }

            Console.WriteLine("Connection closed.");
            return cuentas;

        }

        // Son tres: los movimientos, las transferencias hacia él y desde él
        public List<Movimiento> consultarMovimientos(int idCliente)
        {
            List<Movimiento> movimientos = new List<Movimiento>();
            List<Cuenta> cuentas = obtenerCuentas(idCliente);

            

            //if ( open() )
            {
                try
                {
                    foreach (Cuenta cuenta in cuentas)
                    {
                        // Primero los movimientos--------------------------------------------
                        open();
                        string query = "SELECT * FROM movement WHERE idAccount=?id;";
                        MySqlCommand cmd = new MySqlCommand(query, conex);
                        cmd.Parameters.Add("?id", MySqlDbType.Int16).Value = cuenta.idCuenta;

                        //Console.WriteLine("ID: " + cuenta.idCuenta);

                        MySqlDataReader dataReader = cmd.ExecuteReader();
                        while ( dataReader.Read() )
                        {
                            Console.WriteLine("ID: " + cuenta.idCuenta);

                            int idMovimiento = dataReader.GetInt16(0);
                            DateTime fecha = dataReader.GetDateTime(2);
                            Double monto = dataReader.GetDouble(3);
                            int tipo;

                            if (cuenta.tipo == 1) //Crédito
                            {
                                if (monto >= 0)  { tipo = 3; } // Pago
                                else             { tipo = 4; } // Cargo
                            }
                            else // Ahorros
                            {
                                if (monto >= 0)     { tipo = 5; } // Depósito
                                else                { tipo = 6; } // Retiro
                            }

                            Movimiento aux = new Movimiento(idMovimiento, cuenta, -1, fecha, monto, tipo);
                            movimientos.Add(aux);
                        }
                        dataReader.Close();
                        close();
                        //Console.WriteLine("Movimientos");

                        // Luego las transferencias en que soy origen----------------------------------------
                        open();
                        query = "select idTransfer, idUser1, idUser2, date, amount, users.idUser "
                            + " from Transfers, account, users where Transfers.idUser2=account.idAccount and account.idUser=users.idUser "
                            + " and transfers.idUser1=?id;";
                        cmd = new MySqlCommand(query, conex);
                        cmd.Parameters.Add("?id", MySqlDbType.Int16).Value = cuenta.idCuenta;

                        dataReader = cmd.ExecuteReader();
                        while ( dataReader.Read() )
                        {
                            int idTransferencia = dataReader.GetInt16(0);
                            int origen = dataReader.GetInt16(1);
                            int destino = dataReader.GetInt16(2);
                            DateTime fecha = dataReader.GetDateTime(3);
                            double monto = -dataReader.GetDouble(4);
                            double otro = dataReader.GetInt16(5);
                            int tipo;

                            // Transferencia interna
                            if (cuenta.dueno.idCliente == otro)  
                                { tipo = 2; }
                            // Transferencia externa enviada
                            else
                                { tipo = 0; }
                            
                            Movimiento aux = new Movimiento(idTransferencia, cuenta, destino, fecha, monto, tipo);
                            movimientos.Add(aux);
                        }
                        dataReader.Close();
                        close();
                        //Console.WriteLine("Origen");

                        // Finalmente las transferencias en que soy destino----------------------------------------
                        open();
                        query = "select idTransfer, idUser1, idUser2, date, amount, users.idUser "
                            + " from Transfers, account, users where Transfers.idUser1=account.idAccount and account.idUser=users.idUser "
                            + " and transfers.idUser2=?id;";
                        cmd = new MySqlCommand(query, conex);
                        cmd.Parameters.Add("?id", MySqlDbType.Int16).Value = cuenta.idCuenta;

                        dataReader = cmd.ExecuteReader();
                        while (dataReader.Read())
                        {
                            int idTransferencia = dataReader.GetInt16(0);
                            int origen = dataReader.GetInt16(1);
                            int destino = dataReader.GetInt16(2);
                            DateTime fecha = dataReader.GetDateTime(3);
                            double monto = dataReader.GetDouble(4);
                            double otro = dataReader.GetInt16(5);
                            int tipo;

                            // Transferencia interna
                            if (cuenta.dueno.idCliente == otro)
                                { tipo = 1; }
                            // Transferencia externa recibida
                            else
                                { tipo = 2; }

                            Movimiento aux = new Movimiento(idTransferencia, cuenta, origen, fecha, monto, tipo);
                            movimientos.Add(aux);
                        }
                        dataReader.Close();
                        close();
                        //Console.WriteLine("Destino");
                    }
                    close();
                    return movimientos;
                }
                catch (Exception e)
                {
                    Console.WriteLine("An exception of type " + e.GetType() + " was encountered.");
                    close();
                    return movimientos;
                }
            }

            Console.WriteLine("Connection closed.");
            return movimientos;
        }

        public bool hacerTransferencia(Transferencia te)
        {
            //MySqlTransaction myTrans;
            //myTrans = conex.BeginTransaction();

            actualizarBalance(te.destino.idCuenta,te.monto);
            actualizarBalance(te.origen.idCuenta, -te.monto);

            if ( open() )
            {
                try
                {
                    string query = "INSERT INTO transfers(idUser1, idUser2, amount) values (?id1 , ?id2 , ?mon);";
                    MySqlCommand cmd = new MySqlCommand(query, conex);

                    cmd.Parameters.Add("?id1", MySqlDbType.Int16).Value = te.origen.idCuenta;
                    cmd.Parameters.Add("?id2", MySqlDbType.Int16).Value = te.destino.idCuenta;
                    cmd.Parameters.Add("?mon", MySqlDbType.Int16).Value = te.monto;

                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception e)
                {
                    /*try
                        { myTrans.Rollback(); }
                    catch (SqlException ex)
                    {
                        if ( myTrans.Connection != null )
                        {
                            Console.WriteLine("An exception of type " + ex.GetType() +
                            " was encountered while attempting to roll back the transaction.");
                        }
                    }*/

                    Console.WriteLine("An exception of type " + e.GetType() +
                    " was encountered while inserting the data.");
                }
                finally
                    { close(); }
            }

            Console.WriteLine("Connection closed.");
            return false;
        }

        private bool open()
        {
            try
            {
                conex.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        Console.WriteLine("Cannot connect to server.  Contact administrator");
                        break;
                    case 1045:
                        Console.WriteLine("Invalid username/password, please try again");
                        break;
                    default:
                        Console.WriteLine("Unidentified error please try again");
                        break;
                }
                return false;
            }
        }

        //Close connection
        public bool close()
        {
            try                           { conex.Close(); return true; }
            catch (MySqlException ex)     { Console.WriteLine(ex.Message); return false; }
        }
    }
}
