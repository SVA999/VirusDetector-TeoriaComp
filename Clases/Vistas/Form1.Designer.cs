namespace VirusDetectorJS
{
    partial class FormVentana
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
            buttonBuscar = new Button();
            buttonAnalizar = new Button();
            labelTitulo1 = new Label();
            textBoxRuta = new TextBox();
            textBoxBytes = new TextBox();
            labelVirus = new Label();
            labelVirusEncontrados = new Label();
            labelEstadoFinal = new Label();
            labelEstado = new Label();
            SuspendLayout();
            // 
            // buttonBuscar
            // 
            buttonBuscar.Location = new Point(594, 41);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(91, 23);
            buttonBuscar.TabIndex = 0;
            buttonBuscar.Text = "Buscar";
            buttonBuscar.UseVisualStyleBackColor = true;
            buttonBuscar.Click += button1_Click;
            // 
            // buttonAnalizar
            // 
            buttonAnalizar.Location = new Point(594, 399);
            buttonAnalizar.Name = "buttonAnalizar";
            buttonAnalizar.Size = new Size(194, 39);
            buttonAnalizar.TabIndex = 1;
            buttonAnalizar.Text = "Analizar";
            buttonAnalizar.UseVisualStyleBackColor = true;
            buttonAnalizar.Click += buttonAnalizar_Click;
            // 
            // labelTitulo1
            // 
            labelTitulo1.AutoSize = true;
            labelTitulo1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitulo1.Location = new Point(12, 9);
            labelTitulo1.Name = "labelTitulo1";
            labelTitulo1.Size = new Size(113, 30);
            labelTitulo1.TabIndex = 2;
            labelTitulo1.Text = "Anti-Virus";
            // 
            // textBoxRuta
            // 
            textBoxRuta.Enabled = false;
            textBoxRuta.Location = new Point(12, 42);
            textBoxRuta.Name = "textBoxRuta";
            textBoxRuta.Size = new Size(576, 23);
            textBoxRuta.TabIndex = 3;
            // 
            // textBoxBytes
            // 
            textBoxBytes.Enabled = false;
            textBoxBytes.Location = new Point(12, 71);
            textBoxBytes.Multiline = true;
            textBoxBytes.Name = "textBoxBytes";
            textBoxBytes.Size = new Size(576, 367);
            textBoxBytes.TabIndex = 4;
            textBoxBytes.TextChanged += textBox2_TextChanged;
            // 
            // labelVirus
            // 
            labelVirus.AutoSize = true;
            labelVirus.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelVirus.Location = new Point(594, 71);
            labelVirus.Name = "labelVirus";
            labelVirus.Size = new Size(46, 21);
            labelVirus.TabIndex = 5;
            labelVirus.Text = "Virus";
            // 
            // labelVirusEncontrados
            // 
            labelVirusEncontrados.AutoSize = true;
            labelVirusEncontrados.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelVirusEncontrados.Location = new Point(594, 92);
            labelVirusEncontrados.Name = "labelVirusEncontrados";
            labelVirusEncontrados.Size = new Size(111, 21);
            labelVirusEncontrados.TabIndex = 6;
            labelVirusEncontrados.Text = "Nombre Virus";
            labelVirusEncontrados.Visible = false;
            // 
            // labelEstadoFinal
            // 
            labelEstadoFinal.AutoSize = true;
            labelEstadoFinal.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelEstadoFinal.Location = new Point(657, 366);
            labelEstadoFinal.Name = "labelEstadoFinal";
            labelEstadoFinal.Size = new Size(130, 21);
            labelEstadoFinal.TabIndex = 8;
            labelEstadoFinal.Text = "Estado detenido";
            labelEstadoFinal.Visible = false;
            // 
            // labelEstado
            // 
            labelEstado.AutoSize = true;
            labelEstado.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelEstado.Location = new Point(594, 366);
            labelEstado.Name = "labelEstado";
            labelEstado.Size = new Size(59, 21);
            labelEstado.TabIndex = 7;
            labelEstado.Text = "Estado";
            // 
            // FormVentana
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelEstadoFinal);
            Controls.Add(labelEstado);
            Controls.Add(labelVirusEncontrados);
            Controls.Add(labelVirus);
            Controls.Add(textBoxBytes);
            Controls.Add(textBoxRuta);
            Controls.Add(labelTitulo1);
            Controls.Add(buttonAnalizar);
            Controls.Add(buttonBuscar);
            Name = "FormVentana";
            Text = "DELTA Virus";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonBuscar;
        private Button buttonAnalizar;
        private Label labelTitulo1;
        private TextBox textBoxRuta;
        private TextBox textBoxBytes;
        private Label labelVirus;
        private Label labelVirusEncontrados;
        private Label labelEstadoFinal;
        private Label labelEstado;
    }
}
