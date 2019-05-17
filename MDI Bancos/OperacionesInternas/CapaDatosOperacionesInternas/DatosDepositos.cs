using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;

namespace CapaDatosOperacionesInternas
{
    public class DatosDepositos
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



        //OBTIENE EMPLEADOS
        public DataSet getEmpleados()
        {
            DataSet ds = new DataSet();
            DataTable lTable = new DataTable("emp");
            DataColumn lName = new DataColumn("empleados", typeof(string));
            lTable.Columns.Add(lName);

            OdbcCommand cmd = new OdbcCommand();
            try
            {
                cmd.CommandText = "SELECT nombre, apellido_1, apellido_2 FROM tbl_empleado";
                cmd.Connection = cn.Conectar();
                OdbcDataReader dr = cmd.ExecuteReader();



                while (dr.Read())
                {
                    DataRow lLang = lTable.NewRow();
                    lLang["empleados"] = dr.GetString(0) + " - " + dr.GetString(1) + " " + dr.GetString(2);
                    lTable.Rows.Add(lLang);
                }

                ds.Tables.Add(lTable);

                dr.Close();
                cn.Desconectar();
                return ds;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            return ds;
        }

        //OBTIENE TIPO DE TRANSFERENCIA
        public DataSet getTipoTransferencia()
        {
            DataSet ds = new DataSet();
            string Query = "SELECT nombre FROM tbl_tipo_transferencia";
            try
            {
                OdbcDataAdapter dt = new OdbcDataAdapter(Query, cn.Conectar());
                dt.Fill(ds);


                /*cmb.DataSource = ds.Tables[0];
                cmb.DisplayMember = "name";
                cmb.ValueMember = "nombre";*/

                cn.Desconectar();

                return ds;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            return ds;
        }



        //OBTIENE ID DE EMPLEADO
        public int getEmpleadoId(string name)
        {

            OdbcCommand cmd = new OdbcCommand();
            OdbcDataReader dr;
            int ID = 0;

            string nombre, apellidos, apellido_1, apellido_2;

            string[] words = name.Split('-');
            nombre = words[0].Substring(0, words[0].Length - 1);
            apellidos = words[1].Substring(1, words[1].Length - 1);


            string[] words2 = apellidos.Split(' ');
            apellido_1 = words2[0];
            apellido_2 = words2[1];

            //SENTENCIA

            try
            {
                cmd.CommandText = "SELECT id_empleado FROM tbl_empleado WHERE nombre = '" + nombre + "' AND  apellido_1 = '" + apellido_1 + "' AND apellido_2 = '" + apellido_2 + "' ";
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



        //OBTIENE ID DE AGENCIA DEL EMPLEADO
        public int getAgenciaEmpleadoId(int empleadoId)
        {

            OdbcCommand cmd = new OdbcCommand();
            OdbcDataReader dr;
            int ID = 0;
            try
            {
                cmd.CommandText = "SELECT FK_id_agencia FROM tbl_agencia_has_tbl_empleado WHERE FK_id_empleado = '" + empleadoId + "'";
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



        //OBTIENE TIPO DE PAGO
       
        public DataSet getTipoPago()
        {
            DataSet ds = new DataSet();
            string Query = "SELECT descripcion FROM tbl_tipo_pago";
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


        //OBTIENE ID DE TIPO DE PAGO
        public int getTipoPagoId(string name)
        {

            OdbcCommand cmd = new OdbcCommand();
            OdbcDataReader dr;
            int ID = 0;
            try
            {
                cmd.CommandText = "SELECT id_tipo_pago FROM tbl_tipo_pago WHERE descripcion = '" + name + "'";
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





        //AJUSTE DE CUENTAS
        public bool ajusteCuentas(int cuentaID, int monto)
        {

            OdbcCommand cmd = new OdbcCommand();

            int saldo = obtenerSaldoCuenta(cuentaID);
            int nuevoSaldo = saldo + monto;

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
