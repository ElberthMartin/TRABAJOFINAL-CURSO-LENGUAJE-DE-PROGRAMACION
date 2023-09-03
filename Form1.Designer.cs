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
            panel_slide = new Panel();
            panel_logo = new Panel();
            button_std = new Button();
            panel_stdsubmenu = new Panel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            panel_slide.SuspendLayout();
            panel_stdsubmenu.SuspendLayout();
            SuspendLayout();
            // 
            // panel_slide
            // 
            panel_slide.BackColor = Color.Blue;
            panel_slide.Controls.Add(panel_stdsubmenu);
            panel_slide.Controls.Add(button_std);
            panel_slide.Controls.Add(panel_logo);
            panel_slide.Dock = DockStyle.Left;
            panel_slide.Location = new Point(0, 0);
            panel_slide.Name = "panel_slide";
            panel_slide.Size = new Size(112, 336);
            panel_slide.TabIndex = 0;
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
            // button_std
            // 
            button_std.Dock = DockStyle.Top;
            button_std.FlatStyle = FlatStyle.Flat;
            button_std.ForeColor = SystemColors.ButtonHighlight;
            button_std.Location = new Point(0, 63);
            button_std.Name = "button_std";
            button_std.Padding = new Padding(10, 0, 0, 0);
            button_std.Size = new Size(112, 37);
            button_std.TabIndex = 1;
            button_std.Text = "STUDIANTES";
            button_std.TextAlign = ContentAlignment.MiddleLeft;
            button_std.UseVisualStyleBackColor = true;
            // 
            // panel_stdsubmenu
            // 
            panel_stdsubmenu.Controls.Add(button4);
            panel_stdsubmenu.Controls.Add(button3);
            panel_stdsubmenu.Controls.Add(button2);
            panel_stdsubmenu.Controls.Add(button1);
            panel_stdsubmenu.Dock = DockStyle.Top;
            panel_stdsubmenu.Location = new Point(0, 100);
            panel_stdsubmenu.Name = "panel_stdsubmenu";
            panel_stdsubmenu.Size = new Size(112, 126);
            panel_stdsubmenu.TabIndex = 1;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Top;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Padding = new Padding(35, 0, 0, 0);
            button1.Size = new Size(112, 26);
            button1.TabIndex = 1;
            button1.Text = "REGISTRAR";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Top;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(0, 26);
            button2.Name = "button2";
            button2.Padding = new Padding(35, 0, 0, 0);
            button2.Size = new Size(112, 26);
            button2.TabIndex = 2;
            button2.Text = "GESTION";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Top;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(0, 52);
            button3.Name = "button3";
            button3.Padding = new Padding(35, 0, 0, 0);
            button3.Size = new Size(112, 26);
            button3.TabIndex = 3;
            button3.Text = "ESTADO";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Dock = DockStyle.Top;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(0, 78);
            button4.Name = "button4";
            button4.Padding = new Padding(35, 0, 0, 0);
            button4.Size = new Size(112, 26);
            button4.TabIndex = 4;
            button4.Text = "PRINT";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(571, 336);
            Controls.Add(panel_slide);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel_slide.ResumeLayout(false);
            panel_stdsubmenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_slide;
        private Panel panel_logo;
        private Button button_std;
        private Panel panel_stdsubmenu;
        private Button button1;
        private Button button4;
        private Button button3;
        private Button button2;
    }
}