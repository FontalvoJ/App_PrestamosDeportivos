using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class frm_prestamo : Form
    {
        public frm_prestamo()
        {
            InitializeComponent();
        }

        private void txt_descripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void frm_prestamo_Load(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            txt_cantidad_prestamo.Clear();
            txt_id.Clear();
            txt_codigo.Clear();
            txt_descripcion.Clear();
            txt_cantidad_prestamo.Clear();
            txt_observaciones.Clear();
            txt_nombre_implemento.Clear();
            txt_nombre.Clear();
            dtg_prestamo.DataSource = null;

        }
    }
}
