namespace Trabajo_final_LENGUAJE_DE_PROGRAMACIÓN
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel_scoresubmenu = new Panel();
            panel_stdsubmenu = new Panel();
            button_stdprint = new Button();
            button_stdestado = new Button();
            button_gestion = new Button();
            button_registrar = new Button();
            button_estudiante = new Button();
            panel_logo = new Panel();
            button_curso = new Button();
            button_cursoprint = new Button();
            button_cursoestado = new Button();
            button_cursomanage = new Button();
            button_cursonuevo = new Button();
            button_score = new Button();
            button_scoreprint = new Button();
            button_scoremanage = new Button();
            button_scorenuevo = new Button();
            button11 = new Button();
            panel_scoresubmenu.SuspendLayout();
            panel_stdsubmenu.SuspendLayout();
            SuspendLayout();
            // 
            // panel_scoresubmenu
            // 
            panel_scoresubmenu.BackColor = Color.Blue;
            panel_scoresubmenu.Controls.Add(button11);
            panel_scoresubmenu.Controls.Add(button_scoreprint);
            panel_scoresubmenu.Controls.Add(button_scoremanage);
            panel_scoresubmenu.Controls.Add(button_scorenuevo);
            panel_scoresubmenu.Controls.Add(button_score);
            panel_scoresubmenu.Controls.Add(button_cursoprint);
            panel_scoresubmenu.Controls.Add(button_cursoestado);
            panel_scoresubmenu.Controls.Add(button_cursomanage);
            panel_scoresubmenu.Controls.Add(button_cursonuevo);
            panel_scoresubmenu.Controls.Add(button_curso);
            panel_scoresubmenu.Controls.Add(panel_stdsubmenu);
            panel_scoresubmenu.Controls.Add(button_estudiante);
            panel_scoresubmenu.Controls.Add(panel_logo);
            panel_scoresubmenu.Dock = DockStyle.Left;
            panel_scoresubmenu.Location = new Point(0, 0);
            panel_scoresubmenu.Name = "panel_scoresubmenu";
            panel_scoresubmenu.Size = new Size(112, 536);
            panel_scoresubmenu.TabIndex = 0;
            // 
            // panel_stdsubmenu
            // 
            panel_stdsubmenu.Controls.Add(button_stdprint);
            panel_stdsubmenu.Controls.Add(button_stdestado);
            panel_stdsubmenu.Controls.Add(button_gestion);
            panel_stdsubmenu.Controls.Add(button_registrar);
            panel_stdsubmenu.Dock = DockStyle.Top;
            panel_stdsubmenu.Location = new Point(0, 100);
            panel_stdsubmenu.Name = "panel_stdsubmenu";
            panel_stdsubmenu.Size = new Size(112, 108);
            panel_stdsubmenu.TabIndex = 1;
            // 
            // button_stdprint
            // 
            button_stdprint.Dock = DockStyle.Top;
            button_stdprint.FlatStyle = FlatStyle.Flat;
            button_stdprint.ForeColor = SystemColors.ButtonHighlight;
            button_stdprint.Location = new Point(0, 78);
            button_stdprint.Name = "button_stdprint";
            button_stdprint.Padding = new Padding(35, 0, 0, 0);
            button_stdprint.Size = new Size(112, 26);
            button_stdprint.TabIndex = 4;
            button_stdprint.Text = "PRINT";
            button_stdprint.TextAlign = ContentAlignment.MiddleLeft;
            button_stdprint.UseVisualStyleBackColor = true;
            // 
            // button_stdestado
            // 
            button_stdestado.Dock = DockStyle.Top;
            button_stdestado.FlatStyle = FlatStyle.Flat;
            button_stdestado.ForeColor = SystemColors.ButtonHighlight;
            button_stdestado.Location = new Point(0, 52);
            button_stdestado.Name = "button_stdestado";
            button_stdestado.Padding = new Padding(35, 0, 0, 0);
            button_stdestado.Size = new Size(112, 26);
            button_stdestado.TabIndex = 3;
            button_stdestado.Text = "ESTADO";
            button_stdestado.TextAlign = ContentAlignment.MiddleLeft;
            button_stdestado.UseVisualStyleBackColor = true;
            button_stdestado.Click += button3_Click;
            // 
            // button_gestion
            // 
            button_gestion.Dock = DockStyle.Top;
            button_gestion.FlatStyle = FlatStyle.Flat;
            button_gestion.ForeColor = SystemColors.ButtonHighlight;
            button_gestion.Location = new Point(0, 26);
            button_gestion.Name = "button_gestion";
            button_gestion.Padding = new Padding(35, 0, 0, 0);
            button_gestion.Size = new Size(112, 26);
            button_gestion.TabIndex = 2;
            button_gestion.Text = "GESTION";
            button_gestion.TextAlign = ContentAlignment.MiddleLeft;
            button_gestion.UseVisualStyleBackColor = true;
            button_gestion.Click += button2_Click;
            // 
            // button_registrar
            // 
            button_registrar.Dock = DockStyle.Top;
            button_registrar.FlatStyle = FlatStyle.Flat;
            button_registrar.ForeColor = SystemColors.ButtonHighlight;
            button_registrar.Location = new Point(0, 0);
            button_registrar.Name = "button_registrar";
            button_registrar.Padding = new Padding(35, 0, 0, 0);
            button_registrar.Size = new Size(112, 26);
            button_registrar.TabIndex = 1;
            button_registrar.Text = "REGISTRAR";
            button_registrar.TextAlign = ContentAlignment.MiddleLeft;
            button_registrar.UseVisualStyleBackColor = true;
            // 
            // button_estudiante
            // 
            button_estudiante.Dock = DockStyle.Top;
            button_estudiante.FlatStyle = FlatStyle.Flat;
            button_estudiante.ForeColor = SystemColors.ButtonHighlight;
            button_estudiante.Location = new Point(0, 63);
            button_estudiante.Name = "button_estudiante";
            button_estudiante.Padding = new Padding(10, 0, 0, 0);
            button_estudiante.Size = new Size(112, 37);
            button_estudiante.TabIndex = 1;
            button_estudiante.Text = "STUDIANTES";
            button_estudiante.TextAlign = ContentAlignment.MiddleLeft;
            button_estudiante.UseVisualStyleBackColor = true;
            // 
            // panel_logo
            // 
            panel_logo.Dock = DockStyle.Top;
            panel_logo.Location = new Point(0, 0);
            panel_logo.Name = "panel_logo";
            panel_logo.Size = new Size(112, 63);
            panel_logo.TabIndex = 1;
            panel_logo.Paint += panel_logo_Paint;
            // 
            // button_curso
            // 
            button_curso.Dock = DockStyle.Top;
            button_curso.FlatStyle = FlatStyle.Flat;
            button_curso.ForeColor = SystemColors.ButtonHighlight;
            button_curso.Location = new Point(0, 208);
            button_curso.Name = "button_curso";
            button_curso.Padding = new Padding(10, 0, 0, 0);
            button_curso.Size = new Size(112, 37);
            button_curso.TabIndex = 2;
            button_curso.Text = "CURSO";
            button_curso.TextAlign = ContentAlignment.MiddleLeft;
            button_curso.UseVisualStyleBackColor = true;
            // 
            // button_cursoprint
            // 
            button_cursoprint.Dock = DockStyle.Top;
            button_cursoprint.FlatStyle = FlatStyle.Flat;
            button_cursoprint.ForeColor = SystemColors.ButtonHighlight;
            button_cursoprint.Location = new Point(0, 323);
            button_cursoprint.Name = "button_cursoprint";
            button_cursoprint.Padding = new Padding(35, 0, 0, 0);
            button_cursoprint.Size = new Size(112, 26);
            button_cursoprint.TabIndex = 8;
            button_cursoprint.Text = "PRINT";
            button_cursoprint.TextAlign = ContentAlignment.MiddleLeft;
            button_cursoprint.UseVisualStyleBackColor = true;
            // 
            // button_cursoestado
            // 
            button_cursoestado.Dock = DockStyle.Top;
            button_cursoestado.FlatStyle = FlatStyle.Flat;
            button_cursoestado.ForeColor = SystemColors.ButtonHighlight;
            button_cursoestado.Location = new Point(0, 297);
            button_cursoestado.Name = "button_cursoestado";
            button_cursoestado.Padding = new Padding(35, 0, 0, 0);
            button_cursoestado.Size = new Size(112, 26);
            button_cursoestado.TabIndex = 7;
            button_cursoestado.Text = "ESTADO";
            button_cursoestado.TextAlign = ContentAlignment.MiddleLeft;
            button_cursoestado.UseVisualStyleBackColor = true;
            // 
            // button_cursomanage
            // 
            button_cursomanage.Dock = DockStyle.Top;
            button_cursomanage.FlatStyle = FlatStyle.Flat;
            button_cursomanage.ForeColor = SystemColors.ButtonHighlight;
            button_cursomanage.Location = new Point(0, 271);
            button_cursomanage.Name = "button_cursomanage";
            button_cursomanage.Padding = new Padding(35, 0, 0, 0);
            button_cursomanage.Size = new Size(112, 26);
            button_cursomanage.TabIndex = 6;
            button_cursomanage.Text = "MANAGECURSO";
            button_cursomanage.TextAlign = ContentAlignment.MiddleLeft;
            button_cursomanage.UseVisualStyleBackColor = true;
            // 
            // button_cursonuevo
            // 
            button_cursonuevo.Dock = DockStyle.Top;
            button_cursonuevo.FlatStyle = FlatStyle.Flat;
            button_cursonuevo.ForeColor = SystemColors.ButtonHighlight;
            button_cursonuevo.Location = new Point(0, 245);
            button_cursonuevo.Name = "button_cursonuevo";
            button_cursonuevo.Padding = new Padding(35, 0, 0, 0);
            button_cursonuevo.Size = new Size(112, 26);
            button_cursonuevo.TabIndex = 5;
            button_cursonuevo.Text = "NUEVO CURSO";
            button_cursonuevo.TextAlign = ContentAlignment.MiddleLeft;
            button_cursonuevo.UseVisualStyleBackColor = true;
            // 
            // button_score
            // 
            button_score.Dock = DockStyle.Top;
            button_score.FlatStyle = FlatStyle.Flat;
            button_score.ForeColor = SystemColors.ButtonHighlight;
            button_score.Location = new Point(0, 349);
            button_score.Name = "button_score";
            button_score.Padding = new Padding(10, 0, 0, 0);
            button_score.Size = new Size(112, 37);
            button_score.TabIndex = 9;
            button_score.Text = "SCORE";
            button_score.TextAlign = ContentAlignment.MiddleLeft;
            button_score.UseVisualStyleBackColor = true;
            // 
            // button_scoreprint
            // 
            button_scoreprint.Dock = DockStyle.Top;
            button_scoreprint.FlatStyle = FlatStyle.Flat;
            button_scoreprint.ForeColor = SystemColors.ButtonHighlight;
            button_scoreprint.Location = new Point(0, 438);
            button_scoreprint.Name = "button_scoreprint";
            button_scoreprint.Padding = new Padding(35, 0, 0, 0);
            button_scoreprint.Size = new Size(112, 26);
            button_scoreprint.TabIndex = 12;
            button_scoreprint.Text = "PRINT";
            button_scoreprint.TextAlign = ContentAlignment.MiddleLeft;
            button_scoreprint.UseVisualStyleBackColor = true;
            // 
            // button_scoremanage
            // 
            button_scoremanage.Dock = DockStyle.Top;
            button_scoremanage.FlatStyle = FlatStyle.Flat;
            button_scoremanage.ForeColor = SystemColors.ButtonHighlight;
            button_scoremanage.Location = new Point(0, 412);
            button_scoremanage.Name = "button_scoremanage";
            button_scoremanage.Padding = new Padding(35, 0, 0, 0);
            button_scoremanage.Size = new Size(112, 26);
            button_scoremanage.TabIndex = 11;
            button_scoremanage.Text = "MANAGE";
            button_scoremanage.TextAlign = ContentAlignment.MiddleLeft;
            button_scoremanage.UseVisualStyleBackColor = true;
            // 
            // button_scorenuevo
            // 
            button_scorenuevo.Dock = DockStyle.Top;
            button_scorenuevo.FlatStyle = FlatStyle.Flat;
            button_scorenuevo.ForeColor = SystemColors.ButtonHighlight;
            button_scorenuevo.Location = new Point(0, 386);
            button_scorenuevo.Name = "button_scorenuevo";
            button_scorenuevo.Padding = new Padding(35, 0, 0, 0);
            button_scorenuevo.Size = new Size(112, 26);
            button_scorenuevo.TabIndex = 10;
            button_scorenuevo.Text = "NUEVO";
            button_scorenuevo.TextAlign = ContentAlignment.MiddleLeft;
            button_scorenuevo.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            button11.Dock = DockStyle.Top;
            button11.FlatStyle = FlatStyle.Flat;
            button11.ForeColor = SystemColors.ButtonHighlight;
            button11.Location = new Point(0, 464);
            button11.Name = "button11";
            button11.Padding = new Padding(10, 0, 0, 0);
            button11.Size = new Size(112, 37);
            button11.TabIndex = 13;
            button11.Text = "EXIT";
            button11.TextAlign = ContentAlignment.MiddleLeft;
            button11.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(571, 536);
            Controls.Add(panel_scoresubmenu);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel_scoresubmenu.ResumeLayout(false);
            panel_stdsubmenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_scoresubmenu;
        private Panel panel_logo;
        private Button button_estudiante;
        private Panel panel_stdsubmenu;
        private Button button_registrar;
        private Button button_stdprint;
        private Button button_stdestado;
        private Button button_gestion;
        private Button button_scoreprint;
        private Button button_scoremanage;
        private Button button_scorenuevo;
        private Button button_score;
        private Button button_cursoprint;
        private Button button_cursoestado;
        private Button button_cursomanage;
        private Button button_cursonuevo;
        private Button button_curso;
        private Button button11;
    }
}