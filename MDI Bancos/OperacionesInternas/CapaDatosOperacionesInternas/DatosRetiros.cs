using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Data;

namespace CapaDatosOperacionesInternas
{
    public class DatosRetiros
    {
        Conexion cn = new Conexion();

        //OBTIENE CUENTAS
        public DataSet getCuentas()
        {
            DataSet ds = new DataSet();
            string Query = "SELECT numero_de_cuenta FROM tbl_cuenta";
            try
            {
                OdbcDataAdapter dt = new OdbcDataAdapter(Query, cn.Conectar());
                dt.Fill(ds);
                cn.Desconectar();

                return ds;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            return ds;
        }



        //OBTIENE ID DE CUENTA
        public int getCuentaId(string name)
        {

            OdbcCommand cmd = new OdbcCommand();
            OdbcDataReader dr;
            int ID = 0;
            try
            {
                cmd.CommandText = "SELECT id_cuenta FROM tbl_cuenta WHERE numero_de_cuenta = '" + name + "'";
                cmd.Connection = cn.Conectar();
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    ID = dr.GetInt32(0);
                }


                dr.Close();
                cn.Desconectar();

                return ID;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            return ID;
        }



        //OBTENER SALDO
        public int obtenerSaldoCuenta(int cuentaId)
        {

            OdbcCommand cmd = new OdbcCommand();
            OdbcDataReader dr;
            int saldoCuenta = 0;
            try
            {
                cmd.CommandText = "SELECT saldo FROM tbl_cuenta WHERE id_cuenta = '" + cuentaId + "'";
                cmd.Connection = cn.Conectar();
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    saldoCuenta = dr.GetInt32(0);
                }

                dr.Close();
                cn.Desconectar();
                return saldoCuenta;



            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            return saldoCuenta;

        }


        //VERIFICAR FONDOS
        public bool verificaFondos(int cuentaId, int monto)
        {

            OdbcCommand cmd = new OdbcCommand();
            OdbcDataReader dr;
            int saldoCuenta = 0;
            try
            {
                cmd.CommandText = "SELECT saldo FROM tbl_cuenta WHERE id_cuenta = '" + cuentaId + "'";
                cmd.Connection = cn.Conectar();
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    saldoCuenta = dr.GetInt32(0);

                }

                dr.Close();
                cn.Desconectar();

                if (saldoCuenta >= monto)
                {
                    return true;
                }



            }
            catch (Exception e)
            {
                 Console.WriteLine(e.ToString());
               
            }

            return false;

        }





        //AJUSTE DE CUENTAS
        public bool ajusteCuentas(int cuentaID, int monto)
        {

            OdbcCommand cmd = new OdbcCommand();

            int saldo = obtenerSaldoCuenta(cuentaID);
            int nuevoSaldo = saldo - monto;

            try
            {
                cmd.CommandText = "UPDATE tbl_cuenta SET saldo = '" + nuevoSaldo + "' WHERE id_cuenta = '" + cuentaID + "' ";
                cmd.Connection = cn.Conectar();
                cmd.ExecuteNonQuery();
                cn.Desconectar();

                return true;
            }
            catch (Exception e)
            {
                 Console.WriteLine(e.ToString());
            }

            return false;

        }



        //REGISTRAR MOVIMIENTO
        public bool registrarMovimiento(string tipoMovimiento, int importe, string fecha, int cuentaId, int tipoPagoId)
        {
            OdbcCommand cmd = new OdbcCommand();
            try
            {

                cmd.CommandText = "INSERT INTO tbl_movimientos_cuenta VALUES ('', '" + tipoMovimiento + "', '" + importe + "', '" + fecha + "', '" + cuentaId + "', '" + tipoPagoId + "')";
                cmd.Connection = cn.Conectar();
                cmd.ExecuteNonQuery();
                cn.Desconectar();

                return true;
            }
            catch (Exception e)
            {
                 Console.WriteLine(e.ToString());
            }

            return false;

        }
    }
}
