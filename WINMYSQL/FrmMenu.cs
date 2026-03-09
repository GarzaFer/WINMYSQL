using WINMYSQL.LISTAS;
using WINMYSQL.VISTAS;

namespace WINMYSQL
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void materiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMaterias materias = new FrmMaterias();
            materias.ShowDialog();
        }

        private void alumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAlumnos alumnos = new FrmAlumnos();
            alumnos.ShowDialog();
        }

        private void profesorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProfesores profesores = new FrmProfesores();
            profesores.ShowDialog();
        }
    }
}
