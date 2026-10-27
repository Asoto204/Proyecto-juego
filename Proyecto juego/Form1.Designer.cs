namespace Proyecto_juego
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            pInicio = new Panel();
            label3 = new Label();
            rbIndividual = new RadioButton();
            rbDos = new RadioButton();
            lblJ1 = new Label();
            txtJ1 = new TextBox();
            lblJ2 = new Label();
            txtJ2 = new TextBox();
            lblErrorInicio = new Label();
            btnIniciar = new Button();
            btnVerRanking = new Button();
            pJuego = new Panel();
            lblTurno = new Label();
            lblNivel = new Label();
            label2 = new Label();
            n1 = new Label();
            operador = new Label();
            n2 = new Label();
            reslt = new Label();
            tresultado = new TextBox();
            button1 = new Button();
            lblFeedback = new Label();
            lblMarcador = new Label();
            label6 = new Label();
            lerrores = new Label();
            label5 = new Label();
            Laciertos = new Label();
            btnTerminar = new Button();
            pResultados = new Panel();
            lblResumen = new Label();
            lstRanking = new ListBox();
            lblBuscar = new Label();
            txtBuscar = new TextBox();
            btnBuscar = new Button();
            lblBusqueda = new Label();
            btnVolver = new Button();
            label1 = new Label();
            pInicio.SuspendLayout();
            pJuego.SuspendLayout();
            pResultados.SuspendLayout();
            SuspendLayout();
            // 
            // pInicio
            // 
            pInicio.BackColor = Color.White;
            pInicio.Controls.Add(label3);
            pInicio.Controls.Add(rbIndividual);
            pInicio.Controls.Add(rbDos);
            pInicio.Controls.Add(lblJ1);
            pInicio.Controls.Add(txtJ1);
            pInicio.Controls.Add(lblJ2);
            pInicio.Controls.Add(txtJ2);
            pInicio.Controls.Add(lblErrorInicio);
            pInicio.Controls.Add(btnIniciar);
            pInicio.Controls.Add(btnVerRanking);
            pInicio.Location = new Point(50, 85);
            pInicio.Name = "pInicio";
            pInicio.Size = new Size(800, 520);
            pInicio.TabIndex = 0;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(30, 58, 138);
            label3.Location = new Point(0, 30);
            label3.Name = "label3";
            label3.Size = new Size(800, 40);
            label3.TabIndex = 0;
            label3.Text = "Cantidad de jugadores";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // rbIndividual
            // 
            rbIndividual.AutoSize = true;
            rbIndividual.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbIndividual.ForeColor = Color.FromArgb(37, 99, 235);
            rbIndividual.Location = new Point(250, 85);
            rbIndividual.Name = "rbIndividual";
            rbIndividual.Size = new Size(140, 34);
            rbIndividual.TabIndex = 1;
            rbIndividual.TabStop = true;
            rbIndividual.Text = "Un jugador";
            rbIndividual.UseVisualStyleBackColor = true;
            // 
            // rbDos
            // 
            rbDos.AutoSize = true;
            rbDos.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbDos.ForeColor = Color.FromArgb(37, 99, 235);
            rbDos.Location = new Point(430, 85);
            rbDos.Name = "rbDos";
            rbDos.Size = new Size(160, 34);
            rbDos.TabIndex = 2;
            rbDos.TabStop = true;
            rbDos.Text = "Dos jugadores";
            rbDos.UseVisualStyleBackColor = true;
            rbDos.CheckedChanged += rbDos_CheckedChanged;
            // 
            // lblJ1
            // 
            lblJ1.AutoSize = true;
            lblJ1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblJ1.ForeColor = Color.FromArgb(30, 58, 138);
            lblJ1.Location = new Point(190, 155);
            lblJ1.Name = "lblJ1";
            lblJ1.Size = new Size(110, 30);
            lblJ1.TabIndex = 3;
            lblJ1.Text = "Jugador 1:";
            // 
            // txtJ1
            // 
            txtJ1.BorderStyle = BorderStyle.FixedSingle;
            txtJ1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtJ1.Location = new Point(330, 152);
            txtJ1.MaxLength = 15;
            txtJ1.Name = "txtJ1";
            txtJ1.Size = new Size(280, 36);
            txtJ1.TabIndex = 4;
            // 
            // lblJ2
            // 
            lblJ2.AutoSize = true;
            lblJ2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblJ2.ForeColor = Color.FromArgb(30, 58, 138);
            lblJ2.Location = new Point(190, 210);
            lblJ2.Name = "lblJ2";
            lblJ2.Size = new Size(110, 30);
            lblJ2.TabIndex = 5;
            lblJ2.Text = "Jugador 2:";
            // 
            // txtJ2
            // 
            txtJ2.BorderStyle = BorderStyle.FixedSingle;
            txtJ2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtJ2.Location = new Point(330, 207);
            txtJ2.MaxLength = 15;
            txtJ2.Name = "txtJ2";
            txtJ2.Size = new Size(280, 36);
            txtJ2.TabIndex = 6;
            // 
            // lblErrorInicio
            // 
            lblErrorInicio.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblErrorInicio.ForeColor = Color.FromArgb(220, 38, 38);
            lblErrorInicio.Location = new Point(150, 260);
            lblErrorInicio.Name = "lblErrorInicio";
            lblErrorInicio.Size = new Size(500, 30);
            lblErrorInicio.TabIndex = 7;
            lblErrorInicio.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnIniciar
            // 
            btnIniciar.BackColor = Color.FromArgb(37, 99, 235);
            btnIniciar.Cursor = Cursors.Hand;
            btnIniciar.FlatAppearance.BorderSize = 0;
            btnIniciar.FlatAppearance.MouseOverBackColor = Color.FromArgb(29, 78, 216);
            btnIniciar.FlatStyle = FlatStyle.Flat;
            btnIniciar.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIniciar.ForeColor = Color.White;
            btnIniciar.Location = new Point(250, 305);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(300, 60);
            btnIniciar.TabIndex = 8;
            btnIniciar.Text = "Iniciar juego";
            btnIniciar.UseVisualStyleBackColor = false;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // btnVerRanking
            // 
            btnVerRanking.BackColor = Color.White;
            btnVerRanking.Cursor = Cursors.Hand;
            btnVerRanking.FlatAppearance.BorderColor = Color.FromArgb(37, 99, 235);
            btnVerRanking.FlatAppearance.BorderSize = 2;
            btnVerRanking.FlatAppearance.MouseOverBackColor = Color.FromArgb(219, 234, 254);
            btnVerRanking.FlatStyle = FlatStyle.Flat;
            btnVerRanking.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVerRanking.ForeColor = Color.FromArgb(37, 99, 235);
            btnVerRanking.Location = new Point(250, 385);
            btnVerRanking.Name = "btnVerRanking";
            btnVerRanking.Size = new Size(300, 50);
            btnVerRanking.TabIndex = 9;
            btnVerRanking.Text = "Ver clasificación";
            btnVerRanking.UseVisualStyleBackColor = false;
            btnVerRanking.Click += btnVerRanking_Click;
            // 
            // pJuego
            // 
            pJuego.BackColor = Color.White;
            pJuego.Controls.Add(lblTurno);
            pJuego.Controls.Add(lblNivel);
            pJuego.Controls.Add(label2);
            pJuego.Controls.Add(n1);
            pJuego.Controls.Add(operador);
            pJuego.Controls.Add(n2);
            pJuego.Controls.Add(reslt);
            pJuego.Controls.Add(tresultado);
            pJuego.Controls.Add(button1);
            pJuego.Controls.Add(lblFeedback);
            pJuego.Controls.Add(lblMarcador);
            pJuego.Controls.Add(label6);
            pJuego.Controls.Add(lerrores);
            pJuego.Controls.Add(label5);
            pJuego.Controls.Add(Laciertos);
            pJuego.Controls.Add(btnTerminar);
            pJuego.Location = new Point(50, 85);
            pJuego.Name = "pJuego";
            pJuego.Size = new Size(800, 520);
            pJuego.TabIndex = 1;
            // 
            // lblTurno
            // 
            lblTurno.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTurno.ForeColor = Color.FromArgb(37, 99, 235);
            lblTurno.Location = new Point(0, 15);
            lblTurno.Name = "lblTurno";
            lblTurno.Size = new Size(800, 42);
            lblTurno.TabIndex = 0;
            lblTurno.Text = "Turno";
            lblTurno.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNivel
            // 
            lblNivel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNivel.ForeColor = Color.FromArgb(100, 116, 139);
            lblNivel.Location = new Point(0, 58);
            lblNivel.Name = "lblNivel";
            lblNivel.Size = new Size(800, 28);
            lblNivel.TabIndex = 1;
            lblNivel.Text = "Nivel";
            lblNivel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(30, 58, 138);
            label2.Location = new Point(0, 100);
            label2.Name = "label2";
            label2.Size = new Size(800, 36);
            label2.TabIndex = 2;
            label2.Text = "Digite el resultado de la operacion";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // n1
            // 
            n1.BackColor = Color.FromArgb(241, 245, 249);
            n1.BorderStyle = BorderStyle.FixedSingle;
            n1.Font = new Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            n1.ForeColor = Color.FromArgb(30, 58, 138);
            n1.Location = new Point(195, 150);
            n1.Name = "n1";
            n1.Size = new Size(100, 75);
            n1.TabIndex = 3;
            n1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // operador
            // 
            operador.BackColor = Color.FromArgb(241, 245, 249);
            operador.BorderStyle = BorderStyle.FixedSingle;
            operador.Font = new Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            operador.ForeColor = Color.FromArgb(37, 99, 235);
            operador.Location = new Point(305, 150);
            operador.Name = "operador";
            operador.Size = new Size(80, 75);
            operador.TabIndex = 4;
            operador.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // n2
            // 
            n2.BackColor = Color.FromArgb(241, 245, 249);
            n2.BorderStyle = BorderStyle.FixedSingle;
            n2.Font = new Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            n2.ForeColor = Color.FromArgb(30, 58, 138);
            n2.Location = new Point(395, 150);
            n2.Name = "n2";
            n2.Size = new Size(100, 75);
            n2.TabIndex = 5;
            n2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // reslt
            // 
            reslt.BackColor = Color.FromArgb(241, 245, 249);
            reslt.BorderStyle = BorderStyle.FixedSingle;
            reslt.Font = new Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            reslt.ForeColor = Color.FromArgb(100, 116, 139);
            reslt.Location = new Point(505, 150);
            reslt.Name = "reslt";
            reslt.Size = new Size(100, 75);
            reslt.TabIndex = 6;
            reslt.Text = "=?";
            reslt.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tresultado
            // 
            tresultado.BorderStyle = BorderStyle.FixedSingle;
            tresultado.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tresultado.ForeColor = Color.FromArgb(30, 58, 138);
            tresultado.Location = new Point(300, 250);
            tresultado.Name = "tresultado";
            tresultado.Size = new Size(200, 43);
            tresultado.TabIndex = 7;
            tresultado.TextAlign = HorizontalAlignment.Center;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(37, 99, 235);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(29, 78, 216);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(300, 312);
            button1.Name = "button1";
            button1.Size = new Size(200, 55);
            button1.TabIndex = 8;
            button1.Text = "Responder";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // lblFeedback
            // 
            lblFeedback.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFeedback.Location = new Point(100, 378);
            lblFeedback.Name = "lblFeedback";
            lblFeedback.Size = new Size(600, 45);
            lblFeedback.TabIndex = 9;
            lblFeedback.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMarcador
            // 
            lblMarcador.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMarcador.ForeColor = Color.FromArgb(30, 58, 138);
            lblMarcador.Location = new Point(30, 435);
            lblMarcador.Name = "lblMarcador";
            lblMarcador.Size = new Size(330, 65);
            lblMarcador.TabIndex = 10;
            lblMarcador.Text = "Puntaje";
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(220, 38, 38);
            label6.Location = new Point(400, 435);
            label6.Name = "label6";
            label6.Size = new Size(90, 25);
            label6.TabIndex = 11;
            label6.Text = "Errores";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lerrores
            // 
            lerrores.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lerrores.ForeColor = Color.FromArgb(220, 38, 38);
            lerrores.Location = new Point(400, 460);
            lerrores.Name = "lerrores";
            lerrores.Size = new Size(90, 40);
            lerrores.TabIndex = 12;
            lerrores.Text = "0";
            lerrores.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(22, 163, 74);
            label5.Location = new Point(510, 435);
            label5.Name = "label5";
            label5.Size = new Size(90, 25);
            label5.TabIndex = 13;
            label5.Text = "Aciertos";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Laciertos
            // 
            Laciertos.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Laciertos.ForeColor = Color.FromArgb(22, 163, 74);
            Laciertos.Location = new Point(510, 460);
            Laciertos.Name = "Laciertos";
            Laciertos.Size = new Size(90, 40);
            Laciertos.TabIndex = 14;
            Laciertos.Text = "0";
            Laciertos.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnTerminar
            // 
            btnTerminar.BackColor = Color.White;
            btnTerminar.Cursor = Cursors.Hand;
            btnTerminar.FlatAppearance.BorderColor = Color.FromArgb(37, 99, 235);
            btnTerminar.FlatAppearance.BorderSize = 2;
            btnTerminar.FlatAppearance.MouseOverBackColor = Color.FromArgb(219, 234, 254);
            btnTerminar.FlatStyle = FlatStyle.Flat;
            btnTerminar.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTerminar.ForeColor = Color.FromArgb(37, 99, 235);
            btnTerminar.Location = new Point(625, 450);
            btnTerminar.Name = "btnTerminar";
            btnTerminar.Size = new Size(150, 45);
            btnTerminar.TabIndex = 15;
            btnTerminar.Text = "Terminar";
            btnTerminar.UseVisualStyleBackColor = false;
            btnTerminar.Click += btnTerminar_Click;
            // 
            // pResultados
            // 
            pResultados.BackColor = Color.White;
            pResultados.Controls.Add(lblResumen);
            pResultados.Controls.Add(lstRanking);
            pResultados.Controls.Add(lblBuscar);
            pResultados.Controls.Add(txtBuscar);
            pResultados.Controls.Add(btnBuscar);
            pResultados.Controls.Add(lblBusqueda);
            pResultados.Controls.Add(btnVolver);
            pResultados.Location = new Point(50, 85);
            pResultados.Name = "pResultados";
            pResultados.Size = new Size(800, 520);
            pResultados.TabIndex = 2;
            // 
            // lblResumen
            // 
            lblResumen.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResumen.ForeColor = Color.FromArgb(30, 58, 138);
            lblResumen.Location = new Point(30, 10);
            lblResumen.Name = "lblResumen";
            lblResumen.Size = new Size(740, 100);
            lblResumen.TabIndex = 0;
            lblResumen.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lstRanking
            // 
            lstRanking.BackColor = Color.FromArgb(248, 250, 252);
            lstRanking.BorderStyle = BorderStyle.FixedSingle;
            lstRanking.Font = new Font("Consolas", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstRanking.ForeColor = Color.FromArgb(30, 58, 138);
            lstRanking.FormattingEnabled = true;
            lstRanking.IntegralHeight = false;
            lstRanking.Location = new Point(30, 115);
            lstRanking.Name = "lstRanking";
            lstRanking.Size = new Size(740, 230);
            lstRanking.TabIndex = 1;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBuscar.ForeColor = Color.FromArgb(30, 58, 138);
            lblBuscar.Location = new Point(30, 372);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(150, 28);
            lblBuscar.TabIndex = 2;
            lblBuscar.Text = "Buscar jugador:";
            // 
            // txtBuscar
            // 
            txtBuscar.BorderStyle = BorderStyle.FixedSingle;
            txtBuscar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscar.Location = new Point(190, 369);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(230, 34);
            txtBuscar.TabIndex = 3;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.White;
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.FlatAppearance.BorderColor = Color.FromArgb(37, 99, 235);
            btnBuscar.FlatAppearance.BorderSize = 2;
            btnBuscar.FlatAppearance.MouseOverBackColor = Color.FromArgb(219, 234, 254);
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.ForeColor = Color.FromArgb(37, 99, 235);
            btnBuscar.Location = new Point(435, 366);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(120, 40);
            btnBuscar.TabIndex = 4;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // lblBusqueda
            // 
            lblBusqueda.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBusqueda.ForeColor = Color.FromArgb(100, 116, 139);
            lblBusqueda.Location = new Point(30, 412);
            lblBusqueda.Name = "lblBusqueda";
            lblBusqueda.Size = new Size(740, 30);
            lblBusqueda.TabIndex = 5;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.FromArgb(37, 99, 235);
            btnVolver.Cursor = Cursors.Hand;
            btnVolver.FlatAppearance.BorderSize = 0;
            btnVolver.FlatAppearance.MouseOverBackColor = Color.FromArgb(29, 78, 216);
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVolver.ForeColor = Color.White;
            btnVolver.Location = new Point(250, 455);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(300, 50);
            btnVolver.TabIndex = 6;
            btnVolver.Text = "Volver al inicio";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(30, 58, 138);
            label1.Location = new Point(0, 15);
            label1.Name = "label1";
            label1.Size = new Size(900, 60);
            label1.TabIndex = 3;
            label1.Text = "JUEGO DE ARITMETICA";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(238, 242, 249);
            ClientSize = new Size(900, 640);
            Controls.Add(pInicio);
            Controls.Add(pJuego);
            Controls.Add(pResultados);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Juego de aritmetica";
            Load += Form1_Load;
            pInicio.ResumeLayout(false);
            pInicio.PerformLayout();
            pJuego.ResumeLayout(false);
            pResultados.ResumeLayout(false);
            pResultados.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pInicio;
        private Label label3;
        private RadioButton rbIndividual;
        private RadioButton rbDos;
        private Label lblJ1;
        private TextBox txtJ1;
        private Label lblJ2;
        private TextBox txtJ2;
        private Label lblErrorInicio;
        private Button btnIniciar;
        private Button btnVerRanking;

        private Panel pJuego;
        private Label lblTurno;
        private Label lblNivel;
        private Label label2;
        private Label n1;
        private Label operador;
        private Label n2;
        private Label reslt;
        private TextBox tresultado;
        private Button button1;
        private Label lblFeedback;
        private Label lblMarcador;
        private Label label6;
        private Label lerrores;
        private Label label5;
        private Label Laciertos;
        private Button btnTerminar;

        private Panel pResultados;
        private Label lblResumen;
        private ListBox lstRanking;
        private Label lblBuscar;
        private TextBox txtBuscar;
        private Button btnBuscar;
        private Label lblBusqueda;
        private Button btnVolver;

        private Label label1;
    }
}
