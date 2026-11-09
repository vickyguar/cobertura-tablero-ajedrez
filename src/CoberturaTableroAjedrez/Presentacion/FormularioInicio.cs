using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoberturaTableroAjedrez.Aplicacion;

namespace CoberturaTableroAjedrez.Presentacion;

public partial class FormularioInicio : Form
{
    public FormularioInicio()
    {
        InitializeComponent();
    }

    private async void btnGenerarSoluciones_Click(object sender, EventArgs e)
    {
        btnGenerarSoluciones.Enabled = false;
        btnGenerarSoluciones.Text = "Generando soluciones...";

        try
        {
            var cronometro = Stopwatch.StartNew();
            var listaSoluciones = await Task.Run(GeneradorDeSoluciones.Generar);
            cronometro.Stop();
            var formularioSoluciones = new FormularioSoluciones(listaSoluciones, this, cronometro.Elapsed);
            formularioSoluciones.Show();
            Hide();
        }
        finally
        {
            btnGenerarSoluciones.Enabled = true;
            btnGenerarSoluciones.Text = "Generar soluciones";
        }
    }
}
