using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.NetworkInformation;
using CapaLogica;
using BIT;
using InicioSesion;
using CapaDatos;
using ConsultasInteligentes;
using DLL__Reporteador;
using CrystalDecisions.CrystalReports.Engine;


namespace CapaDiseno
{
    public partial class Navegador : UserControl
    {

        InicioSesion.Usuario inicioSesion = new InicioSesion.Usuario();




        private int sBanIngresar = 0;
        private int nControl;
        static int cantidadCampos = 0;
        static int cantidadAcciones = 0;
        static int[] columnas;
        static string tabla;
        static string tablaData;
        static DataGridView dgrData;
        static string estado;
        static string[] camposTabla;
        static string[] camposTabla3;
        static bool existEstatus = false;
        Logica lo = new Logica();
        Flechas fle = new Flechas();


        //Ayuda nombre CHM
        string sNombrechm;
        [Description("Nombre de la Forma")]
        [DisplayName("Nombre CHM")]
        [Category("Objeto Navegador")]
        public string pubNombrechm
        {
            get { return sNombrechm; }
            set { sNombrechm = value; }
        }

        string sNombrehtml;
        [Description("Nombre de la Forma")]
        [DisplayName("Nombre HTML")]
        [Category("Objeto Navegador")]
        public string pubNombreHtml
        {
            get { return sNombrehtml; }
            set { sNombrehtml = value; }
        }

        //PEDIR NOMBRE DE LA FORMA
        static Form forma;
        static int userCD = 0;
        static int appCD = 0;
        static DataTable dtRefresco;
        static ReportDocument rptRefresco;

        /*[Description("Nombre de la Forma")]
        [DisplayName("Form")]
        [Category("Objeto Navegador")]
        public Form Forma
        {
            get { return forma; }
            set { forma = value; }
        }*/

        //PEDIR NOMBRE DE LOS PROCEDIMIENTOS--------------------------------RAMAS-----
        // comentario....
        string procedimiento;
        [Description("Nombre del Procedimiento")]
        [DisplayName("Procedimiento")]
        [Category("Objeto Navegador")]
        public string Procedimiento
        {
            get { return procedimiento; }
            set { procedimiento = value; }
        }

        //DATAGRID----------------------------------------------------------------
        static DataGridView dataGr;
        [Description("Nombre del DataGridView")]
        [DisplayName("DataGridView")]
        [Category("Objeto Navegador")]
        public DataGridView DataGr
        {
            get { return dataGr; }
            set { dataGr = value; }
        }
        /*public int userCD;
        public int appCD;*/

        ///private string[] list;
        public Navegador(/*int userCC, int appCC*/)
        {
            InitializeComponent();
            /*MessageBox.Show(userCD + "**" + appCD);
            MessageBox.Show("::" + tabla + "::");*/
            Btn_guardar.Enabled = false;
            Btn_cancelar.Enabled = false;
            //MessageBox.Show("load");
            getPermisos(userCD, appCD);
            

        }

        /*public int userCD = 0;
        public int appCD = 0;*/

        public void getReporteApp(string appCode)
        {
            bool flag;
            Logica lg = new Logica();
            flag = lg.getTFReportApp(appCode);
            if(flag == true)
            {
                MessageBox.Show("Hay reporte");
            }
            else
            {
                MessageBox.Show("No hay reporte");
            }
        }


        public void getPermisos(int userCode, int appCode)
        {
            Permiso permisos = new Permiso();
            /*userCD = userCode;
            appCD = appCode;*/
            try
            {
                /*MessageBox.Show("/-" + appCode.ToString());
                MessageBox.Show("//-" + appCD.ToString());*/
                permisos = inicioSesion.obtenerPermisos(userCode, appCode);

                //btn ingresar
                if (permisos.ingresar == false)
                {
                    Btn_ingresar.Enabled = false;
                }
                else
                {
                    Btn_ingresar.Enabled = true;
                }


                //btn editar
                if (permisos.editar == false)
                {
                    Btn_editar.Enabled = false;
                }
                else
                {
                    Btn_editar.Enabled = true;
                }

                /*//btn guardar
                if (permisos.guardar == false)
                {
                    Btn_guardar.Enabled = false;
                }
                else
                {
                    Btn_guardar.Enabled = true;
                }*/


                //btn borrar
                if (permisos.borrar == false)
                {
                    Btn_borrar.Enabled = false;
                }
                else
                {
                    Btn_borrar.Enabled = true;
                }


                //btn buscar
                if (permisos.consultar == false)
                {
                    Btn_consultar.Enabled = false;
                }
                else
                {
                    Btn_consultar.Enabled = true;
                }

                //btn imprimir
                if (permisos.consultar == false)
                {
                    Btn_imprimir.Enabled = false;
                }
                else
                {
                    Btn_imprimir.Enabled = true;
                }

                //MessageBox.Show(permisos.ingresar.ToString() + "-" + permisos.editar.ToString() + "-" + permisos.borrar.ToString() + "-" + permisos.consultar.ToString());

                //MessageBox.Show("realizo");

            }
            catch (Exception e)
            {
                Btn_ingresar.Enabled = false;
                Btn_editar.Enabled = false;
                Btn_borrar.Enabled = false;
                Btn_consultar.Enabled = false;
                Btn_imprimir.Enabled = false;
                //MessageBox.Show("no realizo");
            }
        }


        public void nombreForm(Form fm)
        {
           // MessageBox.Show("Forma: "+fm);
            forma = fm;
        }

        public void getDatosReportes(DataTable dt, ReportDocument rpt)
        {
            dtRefresco = dt;
            rptRefresco = rpt;
        }

        public void getDatos(int usd, int appd)
        {
            userCD = usd;
            appCD = appd;
            //MessageBox.Show(userCD + "==" + appCD);
        }

        public void deshabilitarComponentes()
        {
            foreach (Control componente in forma.Controls)
            {
                if ((componente is TextBox) || (componente is ComboBox) || (componente is DateTimePicker))
                {
                    componente.Enabled = false;
                }
            }
        }


        private void button14_Click(object sender, EventArgs e)
        {
            if (forma.CanSelect)
            {
                Help.ShowHelp(this, "C:\\Ayuda\\" + sNombrechm, sNombrehtml);
                //MessageBox.Show(sNombrechm);
            }
        }
        public void dgv_datos(DataGridView aux)
        {
            dataGr = aux;
            this.cargarCampos();
        }


        static int x = 0, y = 0;
        static string[] tablas= new string[100];
        static Control[,] camposT= new Control[100,100];
        static int banderaOtras = 0;
        static int banderaData = 0;
        
        public void otrasTablas(string tbl, params Control[] cmps)
        {
            banderaOtras = 1;
            tablas[x] = tbl;
            y = cmps.Length;
           // MessageBox.Show("cantidad: " + y);
            for(int i=0; i<cmps.Length; i++)
            {
               // MessageBox.Show("Texto: " + x +" "+cmps[i].Name);
                camposT[x,i] = cmps[i];
            }
            x++;    
        }

        public void insertData(string tbl, DataGridView dtgr, params int[] col)
        {
            banderaData = 1;
            tablaData = tbl;
            dgrData = dtgr;
            columnas = col;
            List<string> camposTabla2 = new List<string>();
            DataTable table2 = lo.pubObtenerCampos(tbl);
            for (int i = 0; i < table2.Rows.Count; i++)
            {
                camposTabla2.Add(table2.Rows[i][0].ToString());
            }
            camposTabla3 = camposTabla2.ToArray();
            dtgr.Enabled = false;
        }

        public void ingresarTabla(string table)
        {
            camposTabla = null;
            existEstatus = false;
            cantidadCampos = 0;
            tabla = table;
            List<string> camposTabla2 = new List<string>();
            DataTable table2 = lo.pubObtenerCampos(tabla);
            for (int i = 0; i < table2.Rows.Count; i++)
            {
                camposTabla2.Add(table2.Rows[i][0].ToString());
            }
            camposTabla = camposTabla2.ToArray();
            for (int i = 0; i < camposTabla.Length; i++)
            {
                if (camposTabla[i].Equals("status"))
                {
                    existEstatus = true;
                    cantidadCampos = camposTabla.Length - 1;
                }
                else
                {
                    cantidadCampos = camposTabla.Length;
                }
            }
            deshabilitarComponentes();
        }

        private void priInsertar()
        {
            List<string> campos = new List<string>();
            sBanIngresar = 1;
            lo.insertar(tabla, camposTabla);
            bool verificarIngreso = true;
            int j = 0, auxI;
            foreach (Control componente in forma.Controls)
            {
                auxI = 0;
                if ((componente is TextBox) || (componente is ComboBox) || (componente is DateTimePicker))
                {
                    string aux = "";
                    if (componente.Tag != null)
                    {
                        aux = componente.Tag.ToString();
                    }
                    if (!aux.Equals(""))
                    {
                        auxI = Convert.ToInt32(aux);
                    }
                    if (auxI > 0 && auxI <= 999)
                    {
                       
                        campos.Add("");
                        j++;
                    }
                }
            }
            nControl = j;
            string[] arrayCampos = campos.ToArray();
            
            foreach (Control componente in forma.Controls)
            {
                auxI = 0;
                if ((componente is TextBox) || (componente is ComboBox) || (componente is DateTimePicker))
                {
                    string aux = "";
                    if (componente.Tag != null)
                    {
                        aux = componente.Tag.ToString();
                    }
                    if (!aux.Equals(""))
                    {
                        auxI = Convert.ToInt32(aux);
                    }
                    if (auxI > 0 && auxI <= 999)
                    {
                        try
                        {
                            if (componente is DateTimePicker)
                            {

                                //Conversion a Formato fecha requerido (YEAR-MONTH-DAY)

                                int numero = Convert.ToInt32(componente.Tag.ToString()) - 1;
                                DateTime date = Convert.ToDateTime(componente.Text.ToString());
                                string Sfecha = date.Year + "-" + date.Month + "-" + date.Day;
                                arrayCampos[numero] = Sfecha;


                            }

                            else
                            {

                                string num = componente.Tag.ToString();
                                int numero = Convert.ToInt32(num) - 1;
                                arrayCampos[numero] = componente.Text;
                                componente.Text = "";

                            }
                        }
                        catch (Exception)
                        {
                            verificarIngreso = false;
                            MessageBox.Show("No se ha ingresado el Tag del elemento " + componente.Name);
                        }
                    }
                }
            }

            for (int i = 0; i < arrayCampos.Length; i++)
            {
                lo.insertarCampos(arrayCampos[i]);
                arrayCampos[i] = "";

            }

            if (verificarIngreso)
            {
                if (existEstatus)
                {
                    lo.terminarSentencia();
                    MessageBox.Show("Registro creado correctamente!!!");
                }
                else
                {
                    lo.terminarSentenciaSinEstatus();
                    MessageBox.Show("Registro creado correctamente!!!");
                }
            }

        }
        private void Btn_ingresar_Click(object sender, EventArgs e)
        {
            int j = 0;
            sBanIngresar = 1;
            Btn_ingresar.Enabled = false;
            foreach (Control componente in forma.Controls)
            { 
                if ((componente is TextBox) || (componente is ComboBox) || (componente is DateTimePicker) || (componente is DataGridView))
                {
                    componente.Text = "";
                    componente.Enabled = true;
                    j++;
                }
            }
            nControl = j;
                estado = "insertar";
                Btn_guardar.Enabled = true;
                Btn_cancelar.Enabled = true;

                Btn_editar.Enabled = false;
                Btn_borrar.Enabled = false;
                Btn_consultar.Enabled = false;
                Btn_imprimir.Enabled = false;
                Btn_refrescar.Enabled = false;
                Btn_inicio.Enabled = false;
                Btn_anterior.Enabled = false;
                Btn_siguiente.Enabled = false;
                Btn_final.Enabled = false;
        }

        private void priGuardar()
        {
            IPHostEntry host;
            string localIP = "";
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily.ToString() == "InterNetwork")
                {
                    localIP = ip.ToString();
                }
            }
            sBanIngresar = 0;
            try
            {
                lo.pubInsertarDatos();
                if (cantidadAcciones == 1)
                {
                    MessageBox.Show("Guardado Exitosamente");
                }
                cantidadAcciones++;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }
        private void priSentenciaOtras(string tbl, params string[] cmps)
        {
             string sql=sentenciaInsertar(tbl, cmps);
             lo.ejecutarQuery(sql);
        }
        private void priGuardarOtras()
        {
            if (banderaOtras == 1)
            {
                for (int i = 0; i <x; i++)          //filas
                {
                    String[] cmpss = new String[y];
                    for (int ii=0; ii<y; ii++)         //columnas
                    {
                        if ((camposT[i, ii] != null) && (!camposT[i, ii].Equals("")))
                        {
                            if ((camposT[i, ii] is TextBox) || (camposT[i, ii] is ComboBox) || (camposT[i, ii] is DateTimePicker))
                            {
                                if (camposT[i, ii] is DateTimePicker)
                                {
                                    /*string fecha = camposT[i, ii].Text;
                                    string dia = fecha.Substring(0, fecha.IndexOf('/'));
                                    string complemento = fecha.Substring((fecha.IndexOf('/') + 1), 7);
                                    string mes = complemento.Substring(0, complemento.IndexOf('/'));
                                    string resto = complemento.Substring((complemento.IndexOf('/') + 1), (complemento.Length - 3));
                                    string anio = resto.Substring(0, resto.Length);

                                    if (dia.Length == 1)
                                    {
                                        dia = "0" + dia;
                                    }
                                    string fechaFinal = anio + mes + dia;
                                    cmpss[ii] = fechaFinal;*/

                                    /*int numero = Convert.ToInt32(componente.Tag.ToString()) - 1;


                                    DateTime date = Convert.ToDateTime(componente.Text.ToString());
                                    string fecha = date.Day + "/" + date.Month + "/" + date.Year;
                                    arrayCampos[numero] = fecha;*/

                                    MessageBox.Show("Entra aqui");



                                }
                                else
                                {
                                    cmpss[ii] = camposT[i, ii].Text;
                                }
                            }
                        }   
                    }
                    if (!cmpss[0].Equals("")){
                        priSentenciaOtras(tablas[i], cmpss);
                    }
                    for (int ii = 0; ii < y; ii++)         //columnas
                    {
                        camposT[i, ii].Text = "";
                    }
                }     
            }

        }
        private void priEditarOtras()
        {
            if (banderaOtras == 1)
            {
                for (int i = 0; i < x; i++)          //filas
                {
                    String[] cmpss = new String[y];
                    for (int ii = 0; ii < y; ii++)         //columnas
                    {
                        if ((camposT[i, ii] != null) && (!camposT[i, ii].Equals("")))
                        {
                            if ((camposT[i, ii] is TextBox) || (camposT[i, ii] is ComboBox) || (camposT[i, ii] is DateTimePicker))
                            {
                                if (camposT[i, ii] is DateTimePicker)
                                {
                                    string fecha = camposT[i, ii].Text;
                                    string dia = fecha.Substring(0, fecha.IndexOf('/'));
                                    string complemento = fecha.Substring((fecha.IndexOf('/') + 1), 7);
                                    string mes = complemento.Substring(0, complemento.IndexOf('/'));
                                    string resto = complemento.Substring((complemento.IndexOf('/') + 1), (complemento.Length - 3));
                                    string anio = resto.Substring(0, resto.Length);

                                    if (dia.Length == 1)
                                    {
                                        dia = "0" + dia;
                                    }
                                    string fechaFinal = anio + mes + dia;
                                    cmpss[ii] = fechaFinal;
                                }
                                else
                                {
                                    cmpss[ii] = camposT[i, ii].Text;
                                }
                            }
                        }
                    }
                    priSentenciaEOtras(tablas[i], cmpss);
                }

            }
        }
        private void priSentenciaEOtras(string tbl, params string[] cmps)
        {
            string nuevaTabla = tbl;
            string[] camposTable;
            List<string> camposTable2 = new List<string>();
            DataTable table2 = lo.pubObtenerCampos(nuevaTabla);
            for (int i = 0; i < table2.Rows.Count; i++)
            {
                camposTable2.Add(table2.Rows[i][0].ToString());
            }
            camposTable = camposTable2.ToArray();

            lo.actualizar(tbl, camposTable);
            for (int i=1; i < cmps.Length; i++)
            {
                    lo.modificarCampos(cmps[i]);     
            }
            lo.terminarSentenciaModificar(cmps[0]);
            lo.pubInsertarDatos();
        }

        private void priguardarData()
        {
            if (banderaData == 1)
            {
                lo.guardarDatagrid(tablaData, camposTabla3, dgrData, columnas);
                dgrData.Enabled = false;
            }
        }
        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            if (estado.Equals("insertar"))
            {
                priInsertar();
                priGuardar();
                priGuardarOtras();


                Btn_guardar.Enabled = false;
                Btn_cancelar.Enabled = false;

                Btn_ingresar.Enabled = true;
                Btn_editar.Enabled = true;
                Btn_borrar.Enabled = true;
                Btn_consultar.Enabled = true;
                Btn_imprimir.Enabled = true;
                Btn_refrescar.Enabled = true;
                Btn_inicio.Enabled = true;
                Btn_anterior.Enabled = true;
                Btn_siguiente.Enabled = true;
                Btn_final.Enabled = true;
                getPermisos(userCD, appCD);
                deshabilitarComponentes();
            }else if (estado.Equals("editar")){
                priEditar();
                priGuardar();
                priEditarOtras();

                Btn_guardar.Enabled = false;
                Btn_cancelar.Enabled = false;

                Btn_ingresar.Enabled = true;
                Btn_editar.Enabled = true;
                Btn_borrar.Enabled = true;
                Btn_consultar.Enabled = true;
                Btn_imprimir.Enabled = true;
                Btn_refrescar.Enabled = true;
                Btn_inicio.Enabled = true;
                Btn_anterior.Enabled = true;
                Btn_siguiente.Enabled = true;
                Btn_final.Enabled = true;
                getPermisos(userCD, appCD);
                deshabilitarComponentes();
            }
            cantidadAcciones = 0;
        }

        private void priEditar()
        {
            string dato = "";
            List<string> campos = new List<string>();
            lo.actualizar(null, null);
            lo.actualizar(tabla, camposTabla);
            bool verificarIngreso = true;
            int j = 0, auxI;
            foreach (Control componente in forma.Controls)
            {
                auxI = 0;
                if ((componente is TextBox) || (componente is ComboBox) || (componente is DateTimePicker))
                {
                    string aux = "";
                    if (componente.Tag != null)
                    {
                        aux = componente.Tag.ToString();
                    }
                    if (!aux.Equals(""))
                    {
                        auxI = Convert.ToInt32(aux);
                    }
                    if (auxI > 0 && auxI <= 999)
                    {
                        campos.Add("");
                        j++;
                    }
                }
            }
            nControl = j;
            if (j == cantidadCampos)
            {
                string[] arrayCampos = campos.ToArray();

                foreach (Control componente in forma.Controls)
                {
                    auxI = 0;
                    if ((componente is TextBox) || (componente is ComboBox) || (componente is DateTimePicker))
                    {
                        string aux = "";
                        if (componente.Tag != null)
                        {
                            aux = componente.Tag.ToString();
                        }
                        if (!aux.Equals(""))
                        {
                            auxI = Convert.ToInt32(aux);
                        }
                        if (auxI > 0 && auxI <= 999)
                        {
                            try
                            {
                                if (componente is DateTimePicker)
                                {
                                        

                                    //Conversion a Formato fecha requerido (YEAR-MONTH-DAY)

                                    int numero = Convert.ToInt32(componente.Tag.ToString()) -1;
                                    DateTime date = Convert.ToDateTime(componente.Text.ToString());
                                    string Sfecha = date.Year + "-" + date.Month + "-" + date.Day;
                                    arrayCampos[numero] = Sfecha;

                                }
                                else
                                {
                                    string num = componente.Tag.ToString();
                                    int numero = Convert.ToInt32(num) - 1;
                                    arrayCampos[numero] = componente.Text;
                                    componente.Text = "";
                                }
                            }
                            catch (Exception)
                            {
                                verificarIngreso = false;
                                MessageBox.Show("No se ha ingresado el Tag del elemento " + componente.Name);
                            }
                        }
                    }
                }

                for (int i = 0; i < arrayCampos.Length; i++)
                {
                    if (i == 0)
                    {
                        dato = arrayCampos[i];
                        arrayCampos[i] = "";
                    }
                    else
                    {
                        lo.modificarCampos(arrayCampos[i]);
                        arrayCampos[i] = "";
                    }
                }

                if (verificarIngreso)
                {
                    lo.terminarSentenciaModificar(dato);
                    MessageBox.Show("Registro modificado Exitosamente!");
                }
            }
            else
            {
                MessageBox.Show("La cantidad de parametros no es igual a la cantidad de campos");
            }
        }

        private void Btn_editar_Click(object sender, EventArgs e)
        {
#pragma warning disable CS0219 // La variable 'auxI' está asignada pero su valor nunca se usa
            int j = 0, auxI;
#pragma warning restore CS0219 // La variable 'auxI' está asignada pero su valor nunca se usa
            sBanIngresar = 1;
            Btn_editar.Enabled = false;
            foreach (Control componente in forma.Controls)
            {
                auxI = 0;
                if ((componente is TextBox) || (componente is ComboBox) || (componente is DateTimePicker))
                {
                    
                        j++;
                        componente.Enabled = true;
                    
                }
            }
            nControl = j;
                estado = "editar";
                Btn_guardar.Enabled = true;
                Btn_cancelar.Enabled = true;
                
                Btn_ingresar.Enabled = false;
                Btn_borrar.Enabled = false;
                Btn_consultar.Enabled = false;
                Btn_imprimir.Enabled = false;
                Btn_refrescar.Enabled = false;
                Btn_inicio.Enabled = false;
                Btn_anterior.Enabled = false;
                Btn_siguiente.Enabled = false;
                Btn_final.Enabled = false;
        }





        private void Btn_salir_Click(object sender, EventArgs e)
        {
            if (sBanIngresar == 1)
            {
                DialogResult res = MessageBox.Show("¿Desea guardar los datos?", "Salir", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
                if (res == DialogResult.Yes)
                {
                    if (estado.Equals("insertar"))
                    {
                        priInsertar();
                        priGuardar();
                        Btn_guardar.Enabled = false;
                        Btn_cancelar.Enabled = false;

                        Btn_editar.Enabled = true;
                        Btn_borrar.Enabled = true;
                        Btn_consultar.Enabled = true;
                        Btn_imprimir.Enabled = true;
                        Btn_refrescar.Enabled = true;
                        Btn_inicio.Enabled = true;
                        Btn_anterior.Enabled = true;
                        Btn_siguiente.Enabled = true;
                        Btn_final.Enabled = true;
                        getPermisos(userCD, appCD);
                    }
                    else if (estado.Equals("editar"))
                    {
                        priEditar();
                        priGuardar();
                        Btn_guardar.Enabled = false;
                        Btn_cancelar.Enabled = false;

                        Btn_ingresar.Enabled = true;
                        Btn_borrar.Enabled = true;
                        Btn_consultar.Enabled = true;
                        Btn_imprimir.Enabled = true;
                        Btn_refrescar.Enabled = true;
                        Btn_inicio.Enabled = true;
                        Btn_anterior.Enabled = true;
                        Btn_siguiente.Enabled = true;
                        Btn_final.Enabled = true;
                        getPermisos(userCD, appCD);
                    }
                    forma.Close();
                    forma = null;
                    banderaOtras = 0;
                    banderaData = 0;
                    dgrData = null;
                    x = 0;
                    y = 0;
                }
                else if (res == DialogResult.No)
                {
                    sBanIngresar = 0;
                    forma.Close();
                    forma = null;
                    banderaOtras = 0;
                    banderaData = 0;
                    dgrData = null;
                    x = 0;
                    y = 0;
                }               
            }else
            {
                forma.Close();
                forma = null;
                banderaOtras = 0;
                banderaData = 0;
                dgrData = null;
                x = 0;
                y = 0;
            }

            dataGr.DataSource = null;
            DataTable dt = cargarDatos(tabla);
            dataGr.DataSource = dt;

        }

        private void Btn_anterior_Click(object sender, EventArgs e)
        {
            //Manda el número de flecha al que pertenece este botón para saber hacia donde moverse.
            int flecha = 2, auxI;
            fle.movimiento(flecha,dataGr);
            int fila = DataGr.CurrentRow.Index;
            
            foreach (Control componente in forma.Controls)
            {
                auxI = 0;
                if ((componente is TextBox) || (componente is ComboBox) || (componente is DateTimePicker))
                {
                    string aux = "";
                    if (componente.Tag != null)
                    {
                        aux = componente.Tag.ToString();
                    }
                    if (!aux.Equals(""))
                    {
                        auxI = Convert.ToInt32(aux);
                    }
                    if (auxI > 0 && auxI <= 999)
                    {
                        string num = componente.Tag.ToString();
                        int numero = Convert.ToInt32(num) - 1;
                        componente.Text = dataGr.Rows[fila].Cells[numero].Value.ToString();
                    }
                }
            }
        }

        private void Btn_siguiente_Click(object sender, EventArgs e)
        {
            int flecha = 1, auxI;
            fle.movimiento(flecha, dataGr);
            int fila = DataGr.CurrentRow.Index;
          
            foreach (Control componente in forma.Controls)
            {
                auxI = 0;
                if ((componente is TextBox) || (componente is ComboBox) || (componente is DateTimePicker))
                {
                    string aux = "";
                    if (componente.Tag != null)
                    {
                        aux = componente.Tag.ToString();
                    }
                    if (!aux.Equals(""))
                    {
                        auxI = Convert.ToInt32(aux);
                    }
                    if (auxI > 0 && auxI <= 999)
                    {
                        string num = componente.Tag.ToString();
                        int numero = Convert.ToInt32(num) - 1;
                        componente.Text = dataGr.Rows[fila].Cells[numero].Value.ToString();
                    }
                }
            }
        }

        private void Btn_final_Click(object sender, EventArgs e)
        {
            int flecha = 3, auxI;
            fle.movimiento(flecha,dataGr);
            int fila = DataGr.CurrentRow.Index;
            foreach (Control componente in forma.Controls)
            {
                auxI = 0;
                if ((componente is TextBox) || (componente is ComboBox) || (componente is DateTimePicker))
                {
                    string aux = "";

                    if (componente.Tag != null)
                    {
                        aux = componente.Tag.ToString();
                    }
                    if (!aux.Equals(""))
                    {
                        auxI = Convert.ToInt32(aux);
                    }
                    if (auxI > 0 && auxI <= 999)
                    {
                        string num = componente.Tag.ToString();
                        int numero = Convert.ToInt32(num) - 1;
                        componente.Text = dataGr.Rows[fila].Cells[numero].Value.ToString();
                    }
                }
            }
        }

        private void Btn_inicio_Click(object sender, EventArgs e)
        {
            int flecha = 0, auxI;
            fle.movimiento(flecha,dataGr);
            int fila = DataGr.CurrentRow.Index;
            foreach (Control componente in forma.Controls)
            {
                auxI = 0;
                if ((componente is TextBox) || (componente is ComboBox) || (componente is DateTimePicker))
                {
                    string aux = "";
                    if (componente.Tag != null)
                    {
                        aux = componente.Tag.ToString();
                    }
                    if (!aux.Equals(""))
                    {
                        auxI = Convert.ToInt32(aux);
                    }
                    if (auxI > 0 && auxI <= 999)
                    {
                        string num = componente.Tag.ToString();
                        int numero = Convert.ToInt32(num) - 1;
                        componente.Text = dataGr.Rows[fila].Cells[numero].Value.ToString();
                    }
                }
            }
        }

        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            Btn_guardar.Enabled = false;
       
            
            DialogResult res = MessageBox.Show("¿Desea cancelar la accion?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (res == DialogResult.Yes)
            {
                Btn_cancelar.Enabled = false;
                Btn_ingresar.Enabled = true;
                Btn_editar.Enabled = true;
                Btn_borrar.Enabled = true;
                Btn_consultar.Enabled = true;
                Btn_imprimir.Enabled = true;
                Btn_refrescar.Enabled = true;
                Btn_inicio.Enabled = true;
                Btn_anterior.Enabled = true;
                Btn_siguiente.Enabled = true;
                Btn_final.Enabled = true;
                getPermisos(userCD, appCD);
                sBanIngresar = 0;
                foreach (Control componente in forma.Controls)
                {

                    if ((componente is TextBox) || (componente is ComboBox) || (componente is DateTimePicker) || (componente is DataGridView))
                    {
                        componente.Text = "";
                    }
                }
                deshabilitarComponentes();
                MessageBox.Show("Accion Cancelada");
            }
            else if (res == DialogResult.No)
            {

            }
        }

        private void Btn_imprimir_Click(object sender, EventArgs e)
        {
            AdministradorDeReportes frm = new AdministradorDeReportes();
            frm.getDatosNecesariosParaReportes(appCD);
            frm.getDatosNecesariosParaReportes2(dtRefresco, rptRefresco);
            frm.ShowDialog();
            /*Administrador reportes = new Administrador();
            reportes.AbrirAdministrador();
            Reporteador frmMSG = new Reporteador();
            frmMSG.Show();*/
        }


        public int findSelectedItem(string Nid, string table, string campo, string search)
        {
            return lo.pubSelectedCombo(Nid, table, campo, search);
        }


        private void Btn_borrar_Click(object sender, EventArgs e)
        {

            DialogResult res = MessageBox.Show("¿Esta seguro de eliminar el registro?", "Salir", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
            if (res == DialogResult.Yes)
            {

                int fila = DataGr.CurrentRow.Index;
                string id = dataGr.Rows[fila].Cells[0].Value.ToString();
                if (existEstatus)
                {
                    lo.pubEliminar(tabla, id, camposTabla);
                    MessageBox.Show("Registro eliminado exitosamente!!!");
                }
                else
                {
                    MessageBox.Show("Error al eliminar el registro (Campo status faltante)");
                }
            }


        }


        private void Btn_refrescar_Click(object sender, EventArgs e)
        {
            if (existEstatus)
            {
                DataTable table = lo.refrescar(tabla, camposTabla);
                DataGr.DataSource = table;
            }
            else
            {
                DataTable table = lo.refrescarSinEstatus(tabla, camposTabla);
                DataGr.DataSource = table;
            }
        }

        private void Btn_consultar_Click(object sender, EventArgs e)
        {
            String[] tablas = { "tbl_operador", "tbl_tipo_operador","tbl_agencias","tbl_empleado","tbl_bancos_externos" };
            Consulta cn = new Consulta("1",tablas);
            cn.abrir();
        }

        public DataTable cargarDatos(string table)
        {
            bool existEstatus2 = false;
            string nuevaTabla = table;
            string[] camposTable;
            List<string> camposTable2 = new List<string>();
            DataTable table2 = lo.pubObtenerCampos(nuevaTabla);
            DataTable nuevaTabla2;
            for (int i = 0; i < table2.Rows.Count; i++)
            {
                camposTable2.Add(table2.Rows[i][0].ToString());
            }
            camposTable = camposTable2.ToArray();
            for (int i = 0; i < camposTable.Length; i++)
            {
                string comparar = camposTable[i];
                if (comparar.Equals("status"))
                {
                    existEstatus2 = true;
                }
            }
            if (existEstatus2)
            {
                nuevaTabla2 = lo.refrescar(nuevaTabla, camposTable);
               
            }
            else
            {
                nuevaTabla2 = lo.refrescarSinEstatus(nuevaTabla, camposTable);
            }
            return nuevaTabla2;
        }


        public void cargarCampos()
        {
            int fila = dataGr.CurrentRow.Index, auxI;
            foreach (Control componente in forma.Controls)
            {
                auxI = 0;
                if ((componente is TextBox) || (componente is ComboBox) || (componente is DateTimePicker))
                {

                    string aux = "";
                    if (componente.Tag != null)
                    {
                        aux = componente.Tag.ToString();
                    }
                    if (!aux.Equals(""))
                    {
                        auxI = Convert.ToInt32(aux);
                    }
                    if (auxI > 0 && auxI <= 999)
                    {
                        string num = componente.Tag.ToString();
                        int numero = Convert.ToInt32(num) - 1;
                        componente.Text = dataGr.Rows[fila].Cells[numero].Value.ToString();
                    }
                }
            }
        }


        public string sentenciaInsertar(string tbl, params string[] cmps)
        {
            string nuevaTabla = tbl;
            string sql = "";
            string[] camposTable;
            bool existEst = false;
            List<string> camposTable2 = new List<string>();
            DataTable table2 = lo.pubObtenerCampos(nuevaTabla);
            for (int i = 0; i < table2.Rows.Count; i++)
            {
                camposTable2.Add(table2.Rows[i][0].ToString());
            }
            camposTable = camposTable2.ToArray();
            for (int i = 0; i < camposTable.Length; i++)
            {
                string comparar = camposTable[i];
                if (comparar.Equals("estatus"))
                {
                    existEst = true;
                }
            }
            if (!existEst)
            {
                sql = "INSERT INTO " + nuevaTabla + " (";
                for (int i = 0; i < camposTable.Length; i++)
                {
                    sql = sql + camposTable[i] + ", ";
                }
                char[] quitar = { ',', ' ' };
                sql = sql.TrimEnd(quitar);
                sql = sql + ") VALUES (";

                for (int i = 0; i < cmps.Length; i++)
                {
                    if (cmps[i] != null)
                    {
                        sql = sql + "'" + cmps[i] + "', ";
                    }
                }
                sql = sql.TrimEnd(quitar);
                sql = sql + ");";
            }
            else
            {
                sql = "INSERT INTO " + nuevaTabla + " (";
                for (int i = 0; i < camposTable.Length; i++)
                {
                    sql = sql + camposTable[i] + ", ";
                }
                char[] quitar = { ',', ' ' };
                sql = sql.TrimEnd(quitar);
                sql = sql + ") VALUES (";

                for (int i = 0; i < cmps.Length; i++)
                {
                    if (cmps[i] != null)
                    {
                        sql = sql + "'" + cmps[i] + "', ";
                    }
                }
                sql = sql + "'0');";
            }
            return sql;
        }

        private void Btn_ingresar_EnabledChanged(object sender, EventArgs e)
        {

            if (Btn_ingresar.Enabled == true)
            {
                Btn_ingresar.BackColor = Color.FromArgb(32, 51, 84);
                Btn_ingresar.FlatAppearance.BorderColor = Color.FromArgb(32, 51, 84);
            }
            else
            {
                Btn_ingresar.BackColor = Color.FromArgb(144, 12, 62);
                Btn_ingresar.FlatAppearance.BorderColor = Color.FromArgb(120, 10, 52);
            }
           
            
        }

        private void Btn_editar_EnabledChanged(object sender, EventArgs e)
        {
            if (Btn_editar.Enabled == true)
            {
                Btn_editar.BackColor = Color.FromArgb(32, 51, 84);
                Btn_editar.FlatAppearance.BorderColor = Color.FromArgb(32, 51, 84);
            }
            else
            {
                Btn_editar.BackColor = Color.FromArgb(144, 12, 62);
                Btn_editar.FlatAppearance.BorderColor = Color.FromArgb(120, 10, 52);
            }
        }

        private void Btn_guardar_EnabledChanged(object sender, EventArgs e)
        {
            if (Btn_guardar.Enabled == true)
            {
                Btn_guardar.BackColor = Color.FromArgb(32, 51, 84);
                Btn_guardar.FlatAppearance.BorderColor = Color.FromArgb(32, 51, 84);
            }
            else
            {
                Btn_guardar.BackColor = Color.FromArgb(144, 12, 62);
                Btn_guardar.FlatAppearance.BorderColor = Color.FromArgb(120, 10, 52);
            }
        }

        private void Btn_cancelar_EnabledChanged(object sender, EventArgs e)
        {
            if (Btn_cancelar.Enabled == true)
            {
                Btn_cancelar.BackColor = Color.FromArgb(32, 51, 84);
                Btn_cancelar.FlatAppearance.BorderColor = Color.FromArgb(32, 51, 84);
            }
            else
            {
                Btn_cancelar.BackColor = Color.FromArgb(144, 12, 62);
                Btn_cancelar.FlatAppearance.BorderColor = Color.FromArgb(120, 10, 52);
            }

        }

        private void Btn_borrar_EnabledChanged(object sender, EventArgs e)
        {
            if (Btn_borrar.Enabled == true)
            {
                Btn_borrar.BackColor = Color.FromArgb(32, 51, 84);
                Btn_borrar.FlatAppearance.BorderColor = Color.FromArgb(32, 51, 84);
            }
            else
            {
                Btn_borrar.BackColor = Color.FromArgb(144, 12, 62);
                Btn_borrar.FlatAppearance.BorderColor = Color.FromArgb(120, 10, 52);
            }
        }

        private void Btn_consultar_EnabledChanged(object sender, EventArgs e)
        {
            if (Btn_consultar.Enabled == true)
            {
                Btn_consultar.BackColor = Color.FromArgb(32, 51, 84);
                Btn_consultar.FlatAppearance.BorderColor = Color.FromArgb(32, 51, 84);
            }
            else
            {
                Btn_consultar.BackColor = Color.FromArgb(144, 12, 62);
                Btn_consultar.FlatAppearance.BorderColor = Color.FromArgb(120, 10, 52);
            }
        }

        private void Btn_imprimir_EnabledChanged(object sender, EventArgs e)
        {

            if (Btn_imprimir.Enabled == true)
            {
                Btn_imprimir.BackColor = Color.FromArgb(32, 51, 84);
                Btn_imprimir.FlatAppearance.BorderColor = Color.FromArgb(32, 51, 84);
            }
            else
            {
                Btn_imprimir.BackColor = Color.FromArgb(144, 12, 62);
                Btn_imprimir.FlatAppearance.BorderColor = Color.FromArgb(120, 10, 52);
            }

        }

        private void Btn_refrescar_EnabledChanged(object sender, EventArgs e)
        {

            if (Btn_refrescar.Enabled == true)
            {
                Btn_refrescar.BackColor = Color.FromArgb(32, 51, 84);
                Btn_refrescar.FlatAppearance.BorderColor = Color.FromArgb(32, 51, 84);
            }
            else
            {
                Btn_refrescar.BackColor = Color.FromArgb(144, 12, 62);
                Btn_refrescar.FlatAppearance.BorderColor = Color.FromArgb(120, 10, 52);
            }

        }

        private void Btn_inicio_EnabledChanged(object sender, EventArgs e)
        {

            if (Btn_inicio.Enabled == true)
            {
                Btn_inicio.BackColor = Color.FromArgb(32, 51, 84);
                Btn_inicio.FlatAppearance.BorderColor = Color.FromArgb(32, 51, 84);
            }
            else
            {
                Btn_inicio.BackColor = Color.FromArgb(144, 12, 62);
                Btn_inicio.FlatAppearance.BorderColor = Color.FromArgb(120, 10, 52);
            }

        }

        private void Btn_anterior_EnabledChanged(object sender, EventArgs e)
        {

            if (Btn_anterior.Enabled == true)
            {
                Btn_anterior.BackColor = Color.FromArgb(32, 51, 84);
                Btn_anterior.FlatAppearance.BorderColor = Color.FromArgb(32, 51, 84);
            }
            else
            {
                Btn_anterior.BackColor = Color.FromArgb(144, 12, 62);
                Btn_anterior.FlatAppearance.BorderColor = Color.FromArgb(120, 10, 52);
            }

        }

        private void Btn_siguiente_EnabledChanged(object sender, EventArgs e)
        {

            if (Btn_siguiente.Enabled == true)
            {
                Btn_siguiente.BackColor = Color.FromArgb(32, 51, 84);
                Btn_siguiente.FlatAppearance.BorderColor = Color.FromArgb(32, 51, 84);
            }
            else
            {
                Btn_siguiente.BackColor = Color.FromArgb(144, 12, 62);
                Btn_siguiente.FlatAppearance.BorderColor = Color.FromArgb(120, 10, 52);
            }

        }

        private void Btn_final_EnabledChanged(object sender, EventArgs e)
        {

            if (Btn_final.Enabled == true)
            {
                Btn_final.BackColor = Color.FromArgb(32, 51, 84);
                Btn_final.FlatAppearance.BorderColor = Color.FromArgb(32, 51, 84);
            }
            else
            {
                Btn_final.BackColor = Color.FromArgb(144, 12, 62);
                Btn_final.FlatAppearance.BorderColor = Color.FromArgb(120, 10, 52);
            }

        }

        private void Btn_ayuda_EnabledChanged(object sender, EventArgs e)
        {
            if (Btn_ayuda.Enabled == true)
            {
                Btn_ayuda.BackColor = Color.FromArgb(32, 51, 84);
                Btn_ayuda.FlatAppearance.BorderColor = Color.FromArgb(32, 51, 84);
            }
            else
            {
                Btn_ayuda.BackColor = Color.FromArgb(144, 12, 62);
                Btn_ayuda.FlatAppearance.BorderColor = Color.FromArgb(120, 10, 52);
            }
        }

        private void Btn_salir_EnabledChanged(object sender, EventArgs e)
        {
            if (Btn_salir.Enabled == true)
            {
                Btn_salir.BackColor = Color.FromArgb(32, 51, 84);
                Btn_salir.FlatAppearance.BorderColor = Color.FromArgb(32, 51, 84);
            }
            else
            {
                Btn_salir.BackColor = Color.FromArgb(144, 12, 62);
                Btn_salir.FlatAppearance.BorderColor = Color.FromArgb(120, 10, 52);
            }
        }

        private void Navegador_Load(object sender, EventArgs e)
        {
        }

        public DataSet cargarCombobox(string tbl, params string[] cmps)
        {
            DataSet dt =  lo.cargarCombobox(tbl, cmps);
            return dt;
        }


    }    
}
