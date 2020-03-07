namespace WindowsFormsApp1
{
    partial class ComandosForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComandosForm));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "**COMANDOS ONLINE (Al presionar dentro del juego T)**",
            "",
            "/connect nombreservidor (Conectarte directamente a un servidor sin guardarlo)",
            "/server nombreservidor (Conectarte y guardar nombre del servidor)",
            "/server (conectarse al servidor)",
            "/ping (Ver la latencia al servidor)",
            "/list (lista de todos los jugadores en la partida)",
            "/swap A B (cambiar de orden entre jugadores, donde A es el jugador origen y B el " +
                "de destino)",
            "/dupe A (tomar mando pero aun mantener el mando actual, util si se desea activar " +
                "otro mando previamente ya configurado)",
            "/drop A (dejar de tomar el mando)",
            "/take A (tomar el mando de un jugador, donde A es el jugador a tomar posesión)",
            "/nick nombrejugador (Cambiar de nombre o nickname en la partida)",
            "/quit (salir de la partida)",
            "F5: Guardar Partida (Savestate) *Nota: seleccionar Slot presionando del 1 al 10",
            "F7: Cargar Partida (Loadstate) *Nota: seleccionar Slot presionando del 1 al 10",
            "F10: Hardware Reset",
            "ALT+SHIFT+1: configurar mando 1 (el cual se usa en el online)",
            "F1: Menu de ayuda",
            "F9: Tomar foto captura (se guarda en snaps dentro del emu)"});
            this.listBox1.Location = new System.Drawing.Point(13, 25);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(587, 264);
            this.listBox1.TabIndex = 0;
            // 
            // ComandosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 308);
            this.Controls.Add(this.listBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ComandosForm";
            this.Text = "Comandos";
            this.Load += new System.EventHandler(this.ComandosForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
    }
}