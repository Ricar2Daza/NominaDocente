using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidad;
using Logica;
namespace PresentacionGUI
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private bool validarCampos()
        {
            bool is_valid = true;
            if (textBoxCedula.Text == string.Empty)
            {
                is_valid = false;
                errorProviderRegistro.SetError(textBoxCedula, "Digite su cedula");
            }
            if (textBoxNombres.Text == string.Empty)
            {
                is_valid = false;
                errorProviderRegistro.SetError(textBoxNombres, "Digite sus nombres");
            }
            if (textBoxApellidos.Text == string.Empty)
            {
                is_valid = false;
                errorProviderRegistro.SetError(textBoxApellidos, "Digite sus apellidos");
            }
            if (comboBoxCargo.Text == string.Empty)
            {
                is_valid = false;
                errorProviderRegistro.SetError(comboBoxCargo, "Selecione un cargo");
            }
            if (comboBoxPosgrado.Text == string.Empty)
            {
                is_valid = false;
                errorProviderRegistro.SetError(comboBoxCargo, "Selecione un Posgrado");
            }
            if (comboBoxGrupo.Text == string.Empty)
            {
                is_valid = false;
                errorProviderRegistro.SetError(comboBoxGrupo, "Selecione un grupo");
            }
            if (textBoxSalario.Text == string.Empty)
            {
                is_valid = false;
                errorProviderRegistro.SetError(textBoxSalario, "Llene los datos personales");
            }
            if (comboBoxMT.Text == string.Empty)
            {
                is_valid = false;
                errorProviderRegistro.SetError(comboBoxMT, "Llene los datos personales");
            }
            if (textBoxNomina.Text == string.Empty)
            {
                is_valid = false;
                errorProviderRegistro.SetError(textBoxNomina, "Llene los datos personales");
            }
            return is_valid;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            ServiceDocente service = new ServiceDocente();
            Docente docente = new Docente();
            docente.Cedula = textBoxCedula.Text;
            docente.Nombres = textBoxNombres.Text;
            docente.Apellidos = textBoxApellidos.Text;
            docente.Cargo = comboBoxCargo.Text;
            docente.Posgrado = comboBoxPosgrado.Text;
            docente.Grupo = comboBoxGrupo.Text;
            docente.MesesTrabajados = Int32.Parse(comboBoxMT.Text);
            if (!comboBoxMT.Text.Equals(""))
            {
                textBoxNomina.Text = (docente.CalcularNomina(salario, bonificacion, bonificacionGrupo)).ToString();
            }
            if (validarCampos())
            {
                MessageBox.Show(service.Guardar(docente));
                textBoxCedula.Text = textBoxNombres.Text = textBoxApellidos.Text = comboBoxCargo.Text = comboBoxPosgrado.Text = comboBoxGrupo.Text = textBoxSalario.Text = comboBoxMT.Text = textBoxNomina.Text = "";
            }
            else
            {
                MessageBox.Show("Error, Llene los campos.");
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            ServiceDocente service = new ServiceDocente();
            var response = service.Consultar();
            if (response.Error)
            {
                MessageBox.Show(response.Message, "Error");
            }
            else
            {
                dgvListado.DataSource = response.Docentes;
            }
        }
        double salario = 0;
        private void comboBoxCargo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Docente docente = new Docente();
            int categoria;
            categoria = comboBoxCargo.SelectedIndex;
            switch (categoria)
            {
                case 0: comboBoxCargo.Text = "Auxiliar de tiempo completo";
                    textBoxSalario.Text = docente.CalcularSalarioAuxiliarTC().ToString();
                    break;
                case 1: comboBoxCargo.Text = "Auxiliar de medio tiempo";
                    textBoxSalario.Text = docente.CalcularSalarioAuxiliarMT().ToString();
                    break;
                case 2: comboBoxCargo.Text = "Asistente de tiempo completo";
                    textBoxSalario.Text = docente.CalcularSalarioAsistenteTC().ToString();
                    break;
                case 3: comboBoxCargo.Text = "Asistente de medio tiempo";
                    textBoxSalario.Text = docente.CalcularSalarioAsistenteMT().ToString();
                    break;
                case 4:
                    comboBoxCargo.Text = "Asociado de tiempo completo";
                    textBoxSalario.Text = docente.CalcularSalarioAsociadoTC().ToString();
                    break;
                case 5:
                    comboBoxCargo.Text = "Asociado de medio tiempo";
                    textBoxSalario.Text = docente.CalcularSalarioAsociadoMT().ToString();
                    break;
                case 6:
                    comboBoxCargo.Text = "Titular de tiempo completo";
                    textBoxSalario.Text = docente.CalcularSalarioTitularTC().ToString();
                    break;
                case 7:
                    comboBoxCargo.Text = "Titular de medio tiempo";
                    textBoxSalario.Text = docente.CalcularSalarioTitularMT().ToString();
                    break;
            }
            salario = Convert.ToDouble (textBoxSalario.Text);
        }
        double bonificacion = 0;
        private void comboBoxPosgrado_SelectedIndexChanged(object sender, EventArgs e)
        {
            Docente docente = new Docente();
            int nivel;
            nivel = comboBoxPosgrado.SelectedIndex;
            switch (nivel)
            {
                case 0: comboBoxPosgrado.Text = "Especializacion";
                    bonificacion = docente.BonificacionEspecializacion();
                    break;
                case 1: comboBoxPosgrado.Text = "Maestria";
                    bonificacion = docente.BonificacionMaestria();
                    break;
                case 2: comboBoxPosgrado.Text = "Doctorado";
                    bonificacion = docente.BonificacionDoctorado();
                    break;
                case 3: comboBoxPosgrado.Text = "Postdoctorado";
                    bonificacion = docente.BonificacionPostDoctorado();
                    break;
            }
            docente.bonificacionPosgrado = bonificacion;
        }

        double bonificacionGrupo = 0;

        private void comboBoxGrupo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Docente docente = new Docente();
            int grupo;
            grupo = comboBoxGrupo.SelectedIndex;
            switch (grupo)
            {
                case 0: comboBoxGrupo.Text = "A1";
                    bonificacionGrupo = docente.BonificacionGrupoA1();
                    break;
                case 1: comboBoxGrupo.Text = "A";
                    bonificacionGrupo = docente.BonificacionGrupoA();
                    break;
                case 2: comboBoxGrupo.Text = "B";
                    bonificacionGrupo = docente.BonificacionGrupoB();
                    break;
                case 3: comboBoxGrupo.Text = "C";
                    bonificacionGrupo = docente.BonificacionGrupoC();
                    break;
                case 4: comboBoxGrupo.Text = "Reconocidos por colciencias";
                    bonificacionGrupo = docente.BonificacionGrupoReconocido();
                    break;
                case 5: comboBoxGrupo.Text = "Semillero";
                    bonificacionGrupo = docente.BonificacionGrupoSemillero();
                    break;
            }

            docente.bonificacionGrupo = bonificacionGrupo;
        }
    }
}
