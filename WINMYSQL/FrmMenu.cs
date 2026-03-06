using WINMYSQL.LISTAS;

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
    }
}
