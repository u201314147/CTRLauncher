namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtGamekey = new System.Windows.Forms.TextBox();
            this.txtNickName = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbServer = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.texto11 = new System.Windows.Forms.Label();
            this.texto1 = new System.Windows.Forms.Label();
            this.chkStartCTR = new System.Windows.Forms.CheckBox();
            this.btnOffline = new System.Windows.Forms.Button();
            this.lblOtherJuego = new System.Windows.Forms.Label();
            this.btnBuscarJuego = new System.Windows.Forms.Button();
            this.txtCue = new System.Windows.Forms.TextBox();
            this.btnComandos = new System.Windows.Forms.Button();
            this.btnChat = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbGames = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtGamekey
            // 
            this.txtGamekey.Location = new System.Drawing.Point(12, 318);
            this.txtGamekey.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtGamekey.Name = "txtGamekey";
            this.txtGamekey.Size = new System.Drawing.Size(385, 22);
            this.txtGamekey.TabIndex = 0;
            this.txtGamekey.Text = "1234";
            // 
            // txtNickName
            // 
            this.txtNickName.Location = new System.Drawing.Point(12, 366);
            this.txtNickName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNickName.Name = "txtNickName";
            this.txtNickName.Size = new System.Drawing.Size(386, 22);
            this.txtNickName.TabIndex = 1;
            this.txtNickName.Text = "nickname";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(268, 422);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(139, 25);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Iniciar Online!";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 298);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre de la partida (gamekey):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 347);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tu nick (Nombre):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 249);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nombre del servidor:";
            // 
            // cmbServer
            // 
            this.cmbServer.FormattingEnabled = true;
            this.cmbServer.Location = new System.Drawing.Point(10, 268);
            this.cmbServer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbServer.Name = "cmbServer";
            this.cmbServer.Size = new System.Drawing.Size(360, 24);
            this.cmbServer.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(2, 535);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(413, 22);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 2);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(373, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Hecho por AlEdu5/AlexNewbie378/Jugando CTR Online 2021";
            // 
            // texto11
            // 
            this.texto11.AutoSize = true;
            this.texto11.Location = new System.Drawing.Point(4, 446);
            this.texto11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.texto11.Name = "texto11";
            this.texto11.Size = new System.Drawing.Size(226, 16);
            this.texto11.TabIndex = 11;
            this.texto11.Text = "unos 5 a 10 segundos, se paciente c:";
            this.texto11.Visible = false;
            this.texto11.Click += new System.EventHandler(this.texto11_Click);
            // 
            // texto1
            // 
            this.texto1.AutoSize = true;
            this.texto1.Location = new System.Drawing.Point(8, 430);
            this.texto1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.texto1.Name = "texto1";
            this.texto1.Size = new System.Drawing.Size(231, 16);
            this.texto1.TabIndex = 10;
            this.texto1.Text = "Al hacer click por primera vez, tardará";
            this.texto1.Visible = false;
            this.texto1.Click += new System.EventHandler(this.texto1_Click);
            // 
            // chkStartCTR
            // 
            this.chkStartCTR.AutoSize = true;
            this.chkStartCTR.Location = new System.Drawing.Point(12, 187);
            this.chkStartCTR.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkStartCTR.Name = "chkStartCTR";
            this.chkStartCTR.Size = new System.Drawing.Size(183, 20);
            this.chkStartCTR.TabIndex = 12;
            this.chkStartCTR.Text = "Iniciar Juego de esta lista:";
            this.chkStartCTR.UseVisualStyleBackColor = true;
            this.chkStartCTR.CheckedChanged += new System.EventHandler(this.chkStartCTR_CheckedChanged);
            // 
            // btnOffline
            // 
            this.btnOffline.Location = new System.Drawing.Point(268, 396);
            this.btnOffline.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOffline.Name = "btnOffline";
            this.btnOffline.Size = new System.Drawing.Size(139, 25);
            this.btnOffline.TabIndex = 13;
            this.btnOffline.Text = "Iniciar Offline";
            this.btnOffline.UseVisualStyleBackColor = true;
            this.btnOffline.Click += new System.EventHandler(this.btnOffline_Click);
            // 
            // lblOtherJuego
            // 
            this.lblOtherJuego.AutoSize = true;
            this.lblOtherJuego.Location = new System.Drawing.Point(12, 137);
            this.lblOtherJuego.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOtherJuego.Name = "lblOtherJuego";
            this.lblOtherJuego.Size = new System.Drawing.Size(108, 16);
            this.lblOtherJuego.TabIndex = 14;
            this.lblOtherJuego.Text = "Iniciar otro juego:";
            // 
            // btnBuscarJuego
            // 
            this.btnBuscarJuego.Location = new System.Drawing.Point(301, 156);
            this.btnBuscarJuego.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscarJuego.Name = "btnBuscarJuego";
            this.btnBuscarJuego.Size = new System.Drawing.Size(100, 28);
            this.btnBuscarJuego.TabIndex = 15;
            this.btnBuscarJuego.Text = "Buscar";
            this.btnBuscarJuego.UseVisualStyleBackColor = true;
            this.btnBuscarJuego.Click += new System.EventHandler(this.btnBuscarJuego_Click);
            // 
            // txtCue
            // 
            this.txtCue.Enabled = false;
            this.txtCue.Location = new System.Drawing.Point(12, 158);
            this.txtCue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCue.Name = "txtCue";
            this.txtCue.Size = new System.Drawing.Size(278, 22);
            this.txtCue.TabIndex = 16;
            this.txtCue.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnComandos
            // 
            this.btnComandos.Location = new System.Drawing.Point(7, 396);
            this.btnComandos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnComandos.Name = "btnComandos";
            this.btnComandos.Size = new System.Drawing.Size(125, 30);
            this.btnComandos.TabIndex = 17;
            this.btnComandos.Text = "Ver comandos";
            this.btnComandos.UseVisualStyleBackColor = true;
            this.btnComandos.Click += new System.EventHandler(this.btnComandos_Click);
            // 
            // btnChat
            // 
            this.btnChat.Location = new System.Drawing.Point(140, 398);
            this.btnChat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnChat.Name = "btnChat";
            this.btnChat.Size = new System.Drawing.Size(114, 30);
            this.btnChat.TabIndex = 18;
            this.btnChat.Text = "Chat Opcional";
            this.btnChat.UseVisualStyleBackColor = true;
            this.btnChat.Click += new System.EventHandler(this.btnChat_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 476);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(222, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "Cualquier consulta escribenos aqui!:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 496);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(203, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "Grupo para coordinar partidas :D";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 514);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 16);
            this.label7.TabIndex = 21;
            this.label7.Text = "Grupo de discord :3";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(243, 476);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(163, 16);
            this.linkLabel1.TabIndex = 22;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Pagina de FB (Streams :3)";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(243, 497);
            this.linkLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(135, 16);
            this.linkLabel2.TabIndex = 23;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Coordinar Partidas :D";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Location = new System.Drawing.Point(237, 515);
            this.linkLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(164, 16);
            this.linkLabel3.TabIndex = 24;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Chat de voz y mas weas ;3";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(268, 446);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 26);
            this.button1.TabIndex = 25;
            this.button1.Text = "Configurar Emu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbGames
            // 
            this.cmbGames.FormattingEnabled = true;
            this.cmbGames.Location = new System.Drawing.Point(10, 209);
            this.cmbGames.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbGames.Name = "cmbGames";
            this.cmbGames.Size = new System.Drawing.Size(395, 24);
            this.cmbGames.TabIndex = 26;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(376, 268);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(30, 27);
            this.button2.TabIndex = 27;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.bag123;
            this.pictureBox1.Location = new System.Drawing.Point(3, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(193, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.logo;
            this.pictureBox2.Location = new System.Drawing.Point(195, 2);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(317, 126);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(414, 563);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cmbGames);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.linkLabel3);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnChat);
            this.Controls.Add(this.btnComandos);
            this.Controls.Add(this.txtCue);
            this.Controls.Add(this.btnBuscarJuego);
            this.Controls.Add(this.lblOtherJuego);
            this.Controls.Add(this.btnOffline);
            this.Controls.Add(this.chkStartCTR);
            this.Controls.Add(this.texto11);
            this.Controls.Add(this.texto1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmbServer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtNickName);
            this.Controls.Add(this.txtGamekey);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Quick Launcher v3.3 beta (audio/video multiple)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGamekey;
        private System.Windows.Forms.TextBox txtNickName;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbServer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label texto11;
        private System.Windows.Forms.Label texto1;
        private System.Windows.Forms.CheckBox chkStartCTR;
        private System.Windows.Forms.Button btnOffline;
        private System.Windows.Forms.Label lblOtherJuego;
        private System.Windows.Forms.Button btnBuscarJuego;
        private System.Windows.Forms.TextBox txtCue;
        private System.Windows.Forms.Button btnComandos;
        private System.Windows.Forms.Button btnChat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbGames;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

