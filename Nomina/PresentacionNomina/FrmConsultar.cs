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
    public partial class FrmConsultar : Form
    {
        public FrmConsultar()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            DocenteService service = new DocenteService();
            var response = service.Consultar();
            if (response.Error)
            {
                MessageBox.Show(response.Mensaje, "Error");
            }
            else
            {
                dtgConsultar.DataSource = response.Docentes;
            }

        }

        
    }
}
