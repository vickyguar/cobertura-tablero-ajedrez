using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using CoberturaTableroAjedrez.Dominio;

namespace CoberturaTableroAjedrez.Presentacion
{
    public partial class FormularioSoluciones : Form
    {
        List<Tablero> ListaSoluciones;
        List<Tablero> ListaFiltrada;

        FormularioInicio Llamado;
        private readonly TimeSpan TiempoGeneracion;
        private readonly Image ImagenTransparente;

        public FormularioSoluciones(List<Tablero> ListaSoluciones_, FormularioInicio _Llamado, TimeSpan tiempoGeneracion)
        {
            InitializeComponent();

            ImagenTransparente = Ficha.LoadImage("Transparente.png");
            ListaSoluciones = ListaSoluciones_;
            Llamado = _Llamado;
            TiempoGeneracion = tiempoGeneracion;
            ListaFiltrada = FiltrarSolucionesFatales(ListaSoluciones); //filtramos las soluciones obtenidas

            //visibilidad de los botones
            btn_next.Visible = true;
            btn_back.Visible = false;
            btn_fatales.Visible = true;
            btn_next_fatal.Visible = false;
            btn_back_fatal.Visible = false;
            btn_time.Visible = true;
            btn_exit.Visible = true;

            ImprimirSiguiente(ListaSoluciones); //se imprime la primera solución
        }

        #region IMPRIMIR DTG
        private void ImprimirSiguiente(List<Tablero> Lista, bool fatales = false)
        {
            if (Lista.Count == 0)
                return;

            Barra.Maximum = Lista.Count;

            if (Barra.Value < Lista.Count)
            {
                if (fatales)
                    btn_next_fatal.Visible = true;
                else
                    btn_next.Visible = true;

                if (Barra.Value != 0)
                {
                    Dtg.Rows.Clear();
                    Dtg.Refresh();
                }

                ImprimirTablero(Lista[Barra.Value], fatales);
                Barra.Increment(1);


                if (Barra.Value == Lista.Count) //si ya se imprimieron todas las soluciones
                {
                    if (fatales)
                        btn_next_fatal.Visible = false;
                    else
                        btn_next.Visible = false;
                }
            }
            return;
        }

        private void ImprimirAnterior(List<Tablero> Lista, bool fatales = false)
        {
            if (Barra.Value > 1)
            {
                Barra.Value = Barra.Value - 2;
                //Limpiar tablero
                Dtg.Rows.Clear();
                Dtg.Refresh();

                ImprimirTablero(Lista[Barra.Value], fatales);
            }
            Barra.Increment(1);
            return;
        }

        private void ImprimirTablero(Tablero tablero, bool resaltarAtaquesFuertes)
        {
            Dtg.ColumnCount = ConfiguracionTablero.Dimension;
            Dtg.RowCount = ConfiguracionTablero.Dimension;

            for (int i = 0; i < ConfiguracionTablero.Dimension; ++i)
            {
                for (int j = 0; j < ConfiguracionTablero.Dimension; ++j)
                {
                    Casilla casilla = tablero.Matriz[i, j];
                    var celdaImagen = new DataGridViewImageCell
                    {
                        ImageLayout = DataGridViewImageCellLayout.Zoom,
                        Value = casilla.Fichita?.Imagen ?? ImagenTransparente
                    };
                    Dtg[i, j] = celdaImagen;

                    Color colorBase = casilla.Colour == ColorCasilla.NEGRO ? Color.Gray : Color.White;
                    if (resaltarAtaquesFuertes && casilla.GetAtacadaFatalmente())
                        colorBase = casilla.Colour == ColorCasilla.NEGRO ? Color.IndianRed : Color.LightCoral;

                    Dtg.Rows[j].Cells[i].Style.BackColor = colorBase;
                    Dtg.Rows[j].Cells[i].Style.SelectionBackColor = colorBase;
                }
            }

            Dtg.ClearSelection();
        }

        #endregion
        private void btn_next_Click(object sender, EventArgs e)
        {
            if (Barra.Value > 0) //si me movi para adelante
                btn_back.Visible = true; //habilito el botón de back
            ImprimirSiguiente(ListaSoluciones);
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
            Llamado.Close();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            if (Barra.Value == 2) //si soy la primera solucion
                btn_back.Visible = false; //no puedo ir para atrás

            if (Barra.Value < ListaSoluciones.Count + 1) //si no llegue al final
            {
                btn_next.Visible = true;
            }

            ImprimirAnterior(ListaSoluciones);
        }

        private void btn_fatales_Click(object sender, EventArgs e)
        {
            if (ListaFiltrada.Count == 0)
            {
                MessageBox.Show("No se encontró ningún tablero fatal.", "Filtrar fatales", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Barra.Value = 0;
            Dtg.Rows.Clear();
            Dtg.Refresh();
            btn_back.Visible = false;
            btn_next.Visible = false;
            btn_next_fatal.Visible = true;
            btn_back_fatal.Visible = false;
            ImprimirSiguiente(ListaFiltrada, fatales: true);
        }

        //Va con el boton de filtrar
        static List<Tablero> FiltrarSolucionesFatales(List<Tablero> ListaSoluciones)
        {
            List<Tablero> ListaFatales = new List<Tablero>();

            #region FILTRAR FATALES

            foreach (Tablero Solucion in ListaSoluciones)
                if (Solucion.Type == TipoCobertura.FATAL)
                    ListaFatales.Add(Solucion);
            #endregion

            return ListaFatales;
        }
        private void btn_next_fatal_Click(object sender, EventArgs e)
        {
            if (Barra.Value > 0)
                btn_back_fatal.Visible = true;

            ImprimirSiguiente(ListaFiltrada, fatales: true);
        }

        private void btn_back_fatal_Click(object sender, EventArgs e)
        {
            if (Barra.Value == 2)
                btn_back_fatal.Visible = false;

            if (Barra.Value < ListaFiltrada.Count + 1)
                btn_next_fatal.Visible = true;

            ImprimirAnterior(ListaFiltrada, fatales: true);
        }

        private void btn_time_Click(object sender, EventArgs e)
        {
            string tiempo = TiempoGeneracion.ToString(@"hh\:mm\:ss\.fff");
            MessageBox.Show(
                $"Tiempo de generación: {tiempo}\n\nLa búsqueda es aleatoria; el tiempo puede variar entre ejecuciones.",
                "Tiempo de ejecución",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
