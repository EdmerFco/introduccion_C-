using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ConsumWebServiceASMX.WSAlumnosASMX;
using Newtonsoft.Json;

namespace Presentacion.Alumnos
{
    public partial class Details : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                int id;

                id = Convert.ToString(Request.QueryString["id"]) == null ? 1 : Convert.ToInt32(Request.QueryString["id"]);

                NAlumno oAlumno = new NAlumno();
                NEstado oEstado = new NEstado();
                NEstatusAlumno oEstatusAlumno = new NEstatusAlumno();
                Alumno oEAlumno = oAlumno.Consultar(id);
                List<Estado> lstEstados = oEstado.Consultar(-1);
                List<EstatusAlumno> lstEstatus = oEstatusAlumno.Consultar(-1);

                Estado oestado = lstEstados.Find(estado => estado.id == oEAlumno.idEstado);
                EstatusAlumno oEEstatus = lstEstatus.Find(estatus => estatus.id == oEAlumno.idEstatus);

                lblID.Text = id.ToString();
                lblNombre.Text = oEAlumno.nombre;
                lblPrimerApellido.Text = oEAlumno.primerApellido;
                lblSegundoApellido.Text = oEAlumno.segundoApellido;
                lblFechaNacimiento.Text = oEAlumno.fechaNacimiento.ToString("yyyy-MM-dd");
                lblCURP.Text = oEAlumno.curp;
                lblCorreo.Text = oEAlumno.correo;
                lblTelefono.Text = oEAlumno.telefono;
                lblSueldoMensual.Text = oEAlumno.sueldoMensual.ToString();
                lblEstado.Text = oestado.nombre;
                lblEstatus.Text = oEEstatus.nombre;
            }
            catch (Exception ex)
            {
                lblMensajes.Text = "Error al consultar: " + ex.Message;
            }
        }

        protected void btnISR_Click(object sender, EventArgs e)
        {
            try
            {
                //creando objeto web services
                WSAlumnos wSAlumnos = new WSAlumnos();

                //invocando el metodo calcular ISR
                ConsumWebServiceASMX.WSAlumnosASMX.ItemTablaISR ISR = wSAlumnos.CalcularISR(Convert.ToInt32(lblID.Text));

                string Json = JsonConvert.SerializeObject(ISR);
                Entidades.ItemTablaISR tablaISR = JsonConvert.DeserializeObject<Entidades.ItemTablaISR>(Json);

                MostrarISR(tablaISR);
           
            }
            catch (Exception)
            {
                NAlumno nAlumno = new NAlumno();
                //ItemTablaISR tablaISR = nAlumno.CalcularISR(Convert.ToDecimal(lblSueldoMensual.Text) / 2);
                Entidades.ItemTablaISR tablaISR = nAlumno.CalcularISR(Convert.ToInt32(lblID.Text));
                MostrarISR(tablaISR);
            }         
           

       
        }

        protected void btnIMSS_Click(object sender, EventArgs e)
        {
            //NAlumno nAlumno = new NAlumno();
            //AportacionesIMSS imss = nAlumno.CalcularIMSS(Convert.ToDecimal(lblSueldoMensual.Text)/2);
            //lblEnfermedades.Text = imss.EnfermedadesMaternidad.ToString("C2");
            //lblCesantia.Text = imss.Cesantia.ToString("C2");
            //lblInvalidez.Text = imss.InvalidezVida.ToString("C2");
            //lblRetiro.Text = imss.Retiro.ToString("C2");
            //lblInfonavit.Text = imss.Infonavit.ToString("C2");
            //mpeModal.Show();

        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            //mpeModal.Hide();
        }

        protected void btnCerrarISR_Click(object sender, EventArgs e)
        {
            mpeModalISR.Hide();
        }

        private void MostrarISR(Entidades.ItemTablaISR tablaISR) 
        {
            lblLimInf.Text = tablaISR.LimInf.ToString("C2");
            lblLimSup.Text = tablaISR.LimSup.ToString("C2");
            lblCuotaFija.Text = tablaISR.CuotaFija.ToString("C2");
            lblExcedente.Text = tablaISR.ExcedLimInf.ToString("C2");
            lblSubsidio.Text = tablaISR.Subsidio.ToString("C2");
            lblImpuesto.Text = tablaISR.Impuesto.ToString("C2");
            mpeModalISR.Show();
        }
    }
}