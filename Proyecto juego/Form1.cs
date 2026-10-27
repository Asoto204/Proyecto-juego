namespace Proyecto_juego
{
    public partial class Form1 : Form
    {
        //VARIABLES DE LA OPERACION
        int a = 0, b = 0, resultado = 0;
        char operador1 = ' ';

        // VARIABLES DE LA PARTIDA
        const int VIDAS_INICIALES = 3;
        int numJugadores = 1;
        int turno = 0;
        bool partidaActiva = false;
        string[] jugador = new string[2];
        int[] puntos = new int[2];
        int[] aciertos = new int[2];
        int[] vidas = new int[2];

        //HISTORIAL DE LA SESION
        string[] nombres = new string[50];
        int[] puntajes = new int[50];
        int cantidad = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lstRanking.Font = new Font("Consolas", 13);
            rbIndividual.Checked = true;
            txtJ2.Enabled = false;
            lblJ2.Enabled = false;
            MostrarPanel(pInicio);
        }

        //CAMBIO DE PANTALLAS
        private void MostrarPanel(Panel p)
        {
            pInicio.Visible = (p == pInicio);
            pJuego.Visible = (p == pJuego);
            pResultados.Visible = (p == pResultados);

            // Enter activa el boton principal de cada pantalla
            if (p == pInicio) AcceptButton = btnIniciar;
            else if (p == pJuego) AcceptButton = button1;
            else AcceptButton = btnVolver;
        }

       
        //  LOGICA MATEMATICA
     
        private int CalcularNivel(int cantAciertos)
        {
            int nivel = cantAciertos / 3 + 1;     // sube de nivel cada 3 aciertos
            if (nivel > 10) nivel = 10;
            return nivel;
        }

        private int LimiteNumerico(int nivel)
        {
            return 5 + nivel * 5;                 
        }

        private string TextoOperaciones(int nivel)
        {
            if (nivel == 1) return "+";
            if (nivel == 2) return "+ -";
            if (nivel == 3) return "+ - *";
            return "+ - * /";
        }

        // Llena a, b, operador1 y resultado segun el nivel
        private void GenerarOperacion(int nivel)
        {
            int limite = LimiteNumerico(nivel);
            int limiteMult = 5 + nivel;           
            if (limiteMult > 12) limiteMult = 12;

            int tipos = nivel;                   
            if (tipos > 4) tipos = 4;
            int op = Random.Shared.Next(1, tipos + 1);

            switch (op)
            {
                case 1:
                    operador1 = '+';
                    a = Random.Shared.Next(1, limite + 1);
                    b = Random.Shared.Next(1, limite + 1);
                    resultado = a + b;
                    break;
                case 2:
                    operador1 = '-';
                    a = Random.Shared.Next(1, limite + 1);
                    b = Random.Shared.Next(1, limite + 1);
                    if (nivel < 5 && a < b)       // sin negativos en niveles bajos
                    {
                        int temp = a;
                        a = b;
                        b = temp;
                    }
                    resultado = a - b;
                    break;
                case 3:
                    operador1 = '*';
                    a = Random.Shared.Next(2, limiteMult + 1);
                    b = Random.Shared.Next(2, limiteMult + 1);
                    resultado = a * b;
                    break;
                default:
                    operador1 = '/';              // division siempre exacta
                    b = Random.Shared.Next(2, limiteMult + 1);
                    int cociente = Random.Shared.Next(1, limiteMult + 1);
                    a = b * cociente;
                    resultado = cociente;
                    break;
            }
        }

        // Decide quien juega despues. Devuelve false si la partida termino.
        private bool AvanzarTurno()
        {
            if (numJugadores == 2)
            {
                int otro = 1 - turno;
                if (vidas[otro] > 0)
                {
                    turno = otro;
                    return true;
                }
            }
            return vidas[turno] > 0;
        }

        //HISTORIAL
        private void RegistrarPuntaje(string nombre, int puntaje)
        {
            if (cantidad < 50)
            {
                nombres[cantidad] = nombre;
                puntajes[cantidad] = puntaje;
                cantidad++;
                return;
            }

            // Si esta lleno, reemplaza el peor puntaje (solo si el nuevo es mejor)
            int peor = 0;
            for (int i = 1; i < cantidad; i++)
            {
                if (puntajes[i] < puntajes[peor]) peor = i;
            }
            if (puntaje > puntajes[peor])
            {
                nombres[peor] = nombre;
                puntajes[peor] = puntaje;
            }
        }

        private void MostrarRanking()
        {
            // Copias para ordenar sin alterar el historial original
            string[] n = new string[cantidad];
            int[] p = new int[cantidad];
            for (int i = 0; i < cantidad; i++)
            {
                n[i] = nombres[i];
                p[i] = puntajes[i];
            }

            // Ordenamiento burbuja de mayor a menor
            for (int i = 0; i < cantidad - 1; i++)
            {
                for (int j = 0; j < cantidad - 1 - i; j++)
                {
                    if (p[j] < p[j + 1])
                    {
                        int tempP = p[j];
                        p[j] = p[j + 1];
                        p[j + 1] = tempP;

                        string tempN = n[j];
                        n[j] = n[j + 1];
                        n[j + 1] = tempN;
                    }
                }
            }

            lstRanking.Items.Clear();
            if (cantidad == 0)
            {
                lstRanking.Items.Add("(aun no hay partidas registradas)");
                return;
            }
            for (int i = 0; i < cantidad; i++)
            {
                lstRanking.Items.Add((i + 1) + ". " + n[i].PadRight(16) + p[i].ToString().PadLeft(6) + " pts");
            }
        }

        //PANTALLA DE JUEGO
        private void SiguienteOperacion()
        {
            int nivel = CalcularNivel(aciertos[turno]);
            GenerarOperacion(nivel);

            n1.Text = a.ToString();
            operador.Text = operador1.ToString();
            n2.Text = b.ToString();
            reslt.Text = "=?";

            if (numJugadores == 2)
                lblTurno.Text = "Turno de: " + jugador[turno];
            else
                lblTurno.Text = "Jugador: " + jugador[0];

            lblNivel.Text = "Nivel " + nivel + "  |  Numeros hasta " + LimiteNumerico(nivel)
                          + "  |  Operaciones: " + TextoOperaciones(nivel);

            string marcador = "";
            for (int i = 0; i < numJugadores; i++)
            {
                marcador += jugador[i] + ": " + puntos[i] + " pts   Vidas: " + vidas[i];
                if (i < numJugadores - 1) marcador += "\n";
            }
            lblMarcador.Text = marcador;

            Laciertos.Text = aciertos[turno].ToString();
            lerrores.Text = (VIDAS_INICIALES - vidas[turno]).ToString();

            tresultado.Clear();
            tresultado.Focus();
        }

        private void FinalizarPartida()
        {
            partidaActiva = false;

            for (int i = 0; i < numJugadores; i++)
            {
                RegistrarPuntaje(jugador[i], puntos[i]);
            }

            string resumen = "FIN DEL JUEGO\n";
            for (int i = 0; i < numJugadores; i++)
            {
                resumen += jugador[i] + ": " + puntos[i] + " pts (" + aciertos[i] + " aciertos)\n";
            }
            if (numJugadores == 2)
            {
                if (puntos[0] > puntos[1]) resumen += "Ganador: " + jugador[0];
                else if (puntos[1] > puntos[0]) resumen += "Ganador: " + jugador[1];
                else resumen += "Empate!";
            }

            lblResumen.Text = resumen;
            lblBusqueda.Text = "";
            MostrarRanking();
            MostrarPanel(pResultados);
        }

        //  EVENTOS
        private void rbDos_CheckedChanged(object sender, EventArgs e)
        {
            txtJ2.Enabled = rbDos.Checked;
            lblJ2.Enabled = rbDos.Checked;
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            string nombre1 = txtJ1.Text.Trim();
            string nombre2 = txtJ2.Text.Trim();
            if (rbDos.Checked) numJugadores = 2;
            else numJugadores = 1;

            if (nombre1.Length == 0 || (numJugadores == 2 && nombre2.Length == 0))
            {
                lblErrorInicio.Text = "Escribe el nombre de cada jugador.";
                return;
            }
            if (numJugadores == 2 && string.Equals(nombre1, nombre2, StringComparison.OrdinalIgnoreCase))
            {
                lblErrorInicio.Text = "Los jugadores deben tener nombres distintos.";
                return;
            }
            lblErrorInicio.Text = "";

            // Reinicia TODO el estado para que no queden datos de otra partida
            jugador[0] = nombre1;
            if (numJugadores == 2) jugador[1] = nombre2;
            else jugador[1] = "";

            for (int i = 0; i < 2; i++)
            {
                puntos[i] = 0;
                aciertos[i] = 0;
                if (i < numJugadores) vidas[i] = VIDAS_INICIALES;
                else vidas[i] = 0;
            }
            turno = 0;
            partidaActiva = true;
            lblFeedback.Text = "";

            MostrarPanel(pJuego);
            SiguienteOperacion();
        }

        private void btnVerRanking_Click(object sender, EventArgs e)
        {
            lblResumen.Text = "Clasificacion de la sesion";
            lblBusqueda.Text = "";
            MostrarRanking();
            MostrarPanel(pResultados);
        }

        // Boton "Responder"
        private void button1_Click(object sender, EventArgs e)
        {
            if (!partidaActiva) return;

            // Si esta vacio o no es numero: avisa y NO quita vida ni se cierra
            if (!int.TryParse(tresultado.Text.Trim(), out int respuestaUsuario))
            {
                lblFeedback.ForeColor = Color.DarkOrange;
                lblFeedback.Text = "Escribe un numero entero valido (no pierdes vida).";
                tresultado.SelectAll();
                tresultado.Focus();
                return;
            }

            string quien = jugador[turno];
            int nivelAntes = CalcularNivel(aciertos[turno]);
            string mensaje;

            if (respuestaUsuario == resultado)
            {
                aciertos[turno]++;
                puntos[turno] += 10 * nivelAntes;
                mensaje = "Correcto!";

                int nivelDespues = CalcularNivel(aciertos[turno]);
                if (nivelDespues > nivelAntes)
                    mensaje += " Subes al nivel " + nivelDespues + "!";
                lblFeedback.ForeColor = Color.ForestGreen;
            }
            else
            {
                vidas[turno]--;
                mensaje = "Incorrecto. La respuesta era " + resultado + ".";
                lblFeedback.ForeColor = Color.Firebrick;
            }

            if (!AvanzarTurno())
            {
                FinalizarPartida();
                return;
            }

            if (numJugadores == 2) lblFeedback.Text = quien + ": " + mensaje;
            else lblFeedback.Text = mensaje;

            SiguienteOperacion();
        }

        private void btnTerminar_Click(object sender, EventArgs e)
        {
            if (partidaActiva) FinalizarPartida();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string buscado = txtBuscar.Text.Trim();
            if (buscado.Length == 0)
            {
                lblBusqueda.Text = "Escribe un nombre para buscar.";
                return;
            }

            // Busqueda lineal del mejor puntaje de ese jugador
            int mejor = -1;
            for (int i = 0; i < cantidad; i++)
            {
                if (string.Equals(nombres[i], buscado, StringComparison.OrdinalIgnoreCase) && puntajes[i] > mejor)
                {
                    mejor = puntajes[i];
                }
            }

            if (mejor < 0) lblBusqueda.Text = "'" + buscado + "' no aparece en la clasificacion.";
            else lblBusqueda.Text = "Mejor puntaje de " + buscado + ": " + mejor + " pts";
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            MostrarPanel(pInicio);
        }
    }
}