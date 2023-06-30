using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ENTITY;
using BLL;

namespace PresentacionNomina
{
    public partial class FrmRegistros : Form
    {
        public FrmRegistros()
        {
            InitializeComponent();
        }



        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DocenteService service = new DocenteService();
            if (ValidarCampos() && ValidarComboSeleccionado())
            {
                MessageBox.Show(service.Guardar(RegistrarDocente()));
                if (ValidarCampos() && ValidarComboSeleccionado())
                {
                    txtCedula.Text = txtNombre.Text = txtApellido.Text = cmbCargo.Text = cmbPosgrado.Text = cmbGrupo.Text = txtSalario.Text = cmbMT.Text = txtNomina.Text = "";
                }
            }
        }


        private Docente RegistrarDocente()
        {
            docente.Cedula = txtCedula.Text;
            docente.Nombres = txtNombre.Text;
            docente.Apellidos = txtApellido.Text;
            docente.Cargo = cmbCargo.Text;
            docente.Posgrado = cmbPosgrado.Text;
            docente.Grupo = cmbGrupo.Text;
            docente.Contrato = txtContrato.Text;
            if (!cmbMT.Text.Equals(""))
            {
                docente.MesesTrabajados = Int32.Parse(cmbMT.Text);
            }
            return docente;
        }

        #region Validar

        private bool ValidarCampos()
        {
            bool validar = true;
            if (txtCedula.Text == string.Empty)
            {
                validar = false;
                MessageBox.Show("CAMPO VACIO, DIGITE CEDULA");
            }
            else if (txtNombre.Text == string.Empty)
            {
                validar = false;
                MessageBox.Show("CAMPO VACIO, DIGITE NOMBRES");
            }
            else if (txtApellido.Text == string.Empty)
            {
                validar = false;
                MessageBox.Show("CAMPO VACIO, DIGITE APELLIDOS");
            }
            else if (cmbCargo.Text == string.Empty)
            {
                validar = false;
                MessageBox.Show("CAMPO VACIO, ESCOJA UN CARGO");
            }
            else if (cmbPosgrado.Text == string.Empty)
            {
                validar = false;
                MessageBox.Show("CAMPO VACIO, ESCOJA UN POSGRADO");
            }
            else if (cmbGrupo.Text == string.Empty)
            {
                validar = false;
                MessageBox.Show("CAMPO VACIO, ESCOJA UN GRUPO");
            }
            else if (txtSalario.Text == string.Empty)
            {
                validar = false;
                MessageBox.Show("CAMPO VACIO, DIGITE SALARIO");
            }
            else if (cmbMT.Text == string.Empty)
            {
                validar = false;
                MessageBox.Show("CAMPO VACIO, DIGITE LOS MESES TRABAJADOS");
            }
            else if (txtNomina.Text == string.Empty)
            {
                validar = false;
                MessageBox.Show("CAMPO VACIO, LLENE LOS DATOS");
            }
            return validar;
        }

        private bool ValidarComboSeleccionado()
        {
            bool validar1 = true;
            if (cmbCargo.Text == string.Empty)
            {
                MessageBox.Show("Seleccione el cargo", "Campo vacío");
                validar1 = false;
            }
            else if (cmbPosgrado.Text == string.Empty)
            {
                MessageBox.Show("Seleccione el postgrado", "Campo vacío");
                validar1 = false;
            }
            else if (cmbGrupo.Text == string.Empty)
            {
                MessageBox.Show("Seleccione el grupo", "Campo vacío");
                validar1 = false;
            }
            else if (cmbMT.Text.Equals(""))
            {
                MessageBox.Show("Seleccione los meses trabajados", "Campo vacío");
                validar1 = false;
            }
            return validar1;
        }

        private void txtCedula_TextChanged(object sender, EventArgs e)
        {
            foreach (char caracter in txtCedula.Text)
            {
                if (char.IsLetter(caracter))
                {

                    errorProviderRegistro.SetError(txtCedula, "No se admiten letras");
                    break;
                }
                else
                    errorProviderRegistro.Clear();
            }
        }

        private void txtSalario_TextChanged(object sender, EventArgs e)
        {
            foreach (char caracter in txtSalario.Text)
            {
                if (char.IsLetter(caracter))
                {

                    errorProviderRegistro.SetError(txtSalario, "No se admiten letras");
                    break;
                }
                else
                    errorProviderRegistro.Clear();
            }
        }
        #endregion

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCedula.Text = txtNombre.Text = txtApellido.Text = txtNomina.Text = txtSalario.Text = cmbCargo.Text = cmbGrupo.Text = cmbMT.Text = cmbPosgrado.Text = "";
        }

        Docente docente = new Docente();
        double Salario = 0, BonificacionPostGrado = 0, BonificacionPorGrupo = 0;

        private void cmbCargo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int categoria;
            categoria = cmbCargo.SelectedIndex;
            switch (categoria)
            {
                case 0:
                    cmbCargo.Text = "Auxiliar de tiempo completo";
                    txtSalario.Text = docente.CalcularSalarioAuxiliarTC().ToString();
                    break;
                case 1:
                    cmbCargo.Text = "Auxiliar de medio tiempo";
                    txtSalario.Text = docente.CalcularSalarioAuxiliarMT().ToString();
                    break;
                case 2:
                    cmbCargo.Text = "Asistente de tiempo completo";
                    txtSalario.Text = docente.CalcularSalarioAsistenteTC().ToString();
                    break;
                case 3:
                    cmbCargo.Text = "Asistente de medio tiempo";
                    txtSalario.Text = docente.CalcularSalarioAsistenteMT().ToString();
                    break;
                case 4:
                    cmbCargo.Text = "Asociado de tiempo completo";
                    txtSalario.Text = docente.CalcularSalarioAsociadoTC().ToString();
                    break;
                case 5:
                    cmbCargo.Text = "Asociado de medio tiempo";
                    txtSalario.Text = docente.CalcularSalarioAsociadoMT().ToString();
                    break;
                case 6:
                    cmbCargo.Text = "Titular de tiempo completo";
                    txtSalario.Text = docente.CalcularSalarioTitularTC().ToString();
                    break;
                case 7:
                    cmbCargo.Text = "Titular de medio tiempo";
                    txtSalario.Text = docente.CalcularSalarioTitularMT().ToString();
                    break;
            }
            Salario = Convert.ToDouble(txtSalario.Text);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (ValidarComboSeleccionado())
            {
                var docente = RegistrarDocente();
                txtNomina.Text = (docente.CalcularNomina(Salario, BonificacionPostGrado, BonificacionPorGrupo).ToString());
            }            
        }

        

        private void cmbMT_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtContrato.Text = "Catedratico";
            if (int.Parse(cmbMT.Text) > 12)
            {
                txtContrato.Text = "Catedratico";
            }
            else
                txtContrato.Text = "Ocasional";

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void cmbPosgrado_SelectedIndexChanged(object sender, EventArgs e)
        {
            int nivel;
            nivel = cmbPosgrado.SelectedIndex;
            switch (nivel)
            {
                case 0:
                    cmbPosgrado.Text = "Especializacion";
                    BonificacionPostGrado = docente.BonificacionPostGradoEspecializacion();
                    break;
                case 1:
                    cmbPosgrado.Text = "Maestria";
                    BonificacionPostGrado = docente.BonificacionPostGradoMaestria();
                    break;
                case 2:
                    cmbPosgrado.Text = "Doctorado";
                    BonificacionPostGrado = docente.BonificacionPostGradoDoctorado();
                    break;
                case 3:
                    cmbPosgrado.Text = "Postdoctorado";
                    BonificacionPostGrado = docente.BonificacionPostGradoPostDoctorado();
                    break;
            }
            docente.BonificacionPostGrado = BonificacionPostGrado;
        }

        private void cmbGrupo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int grupo;
            grupo = cmbGrupo.SelectedIndex;
            switch (grupo)
            {
                case 0:
                    cmbGrupo.Text = "A1";
                    BonificacionPorGrupo = docente.BonificacionGrupoA1();
                    break;
                case 1:
                    cmbGrupo.Text = "A";
                    BonificacionPorGrupo = docente.BonificacionGrupoA();
                    break;
                case 2:
                    cmbGrupo.Text = "B";
                    BonificacionPorGrupo = docente.BonificacionGrupoB();
                    break;
                case 3:
                    cmbGrupo.Text = "C";
                    BonificacionPorGrupo = docente.BonificacionGrupoC();
                    break;
                case 4:
                    cmbGrupo.Text = "Reconocidos por colciencias";
                    BonificacionPorGrupo = docente.BonificacionGrupoReconocidoColCiencias();
                    break;
                case 5:
                    cmbGrupo.Text = "Semillero";
                    BonificacionPorGrupo = docente.BonificacionGrupoSemillero();
                    break;
            }

            docente.BonificacionPorGrupo = BonificacionPorGrupo;
        }
    }
}
