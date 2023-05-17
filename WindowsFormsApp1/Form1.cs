using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace WindowsFormsApp1
{


    public partial class Form1 : Form
    {


        public Form1()
        {

            InitializeComponent();
            loadpreferences();
            loadGames();
            loadServers();
        }

        private void loadServers()
        {

            try
            {
                List<String> lines = new List<string>();

                // Read and show each line from the file.
                string line = "";
                using (StreamReader sr = new StreamReader("serverlist.txt"))
                {
                    while ((line = sr.ReadLine()) != null)
                    {
                        lines.Add(line);
                    }


                    foreach (string lin in lines) cmbServer.Items.Add(lin);


                }

            }
            catch(Exception e)

            {

            }
            }
        private void loadGames()
        {
            string path = System.Reflection.Assembly.GetExecutingAssembly().Location;
            var directory = System.IO.Path.GetDirectoryName(path);

            try
            {
                List<String> files = Directory.GetFiles(directory + "\\games\\").Where(name => !name.EndsWith(".bin",StringComparison.OrdinalIgnoreCase)).ToList();
                foreach (String filePath in files) cmbGames.Items.Add(Path.GetFileName(filePath));
            }
            catch(Exception e)
            {

            }
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            string path = System.Reflection.Assembly.GetExecutingAssembly().Location;
            var directory = System.IO.Path.GetDirectoryName(path);

            string customgame = txtCue.Text;
            string fullPath = directory + "\\games\\" + cmbGames.Text;
            string server = "\"" + cmbServer.Text + "\"";
            string gamekey = "\"" + txtGamekey.Text+ "\"";
            string nick = "\"" + txtNickName.Text+ "\"";
            string nick2 = "\"" + txtNickName.Text + " audio" + "\"";

            ProcessStartInfo processtartinfo = new ProcessStartInfo();
            ProcessStartInfo processtartinfo2 = new ProcessStartInfo();

            if (chkStartCTR.Checked == true)
            {   
            processtartinfo.WorkingDirectory = Path.GetDirectoryName(fullPath);
                processtartinfo.Arguments = "-netplay.gamekey "+ gamekey + " -netplay.host " + server +" -netplay.nick " + nick + " -connect " + "\"" + fullPath;
            processtartinfo.WindowStyle = ProcessWindowStyle.Hidden;

                processtartinfo2.WorkingDirectory = Path.GetDirectoryName(fullPath);
                processtartinfo2.Arguments = "-netplay.gamekey " + gamekey + " -netplay.host " + server + " -netplay.nick " + nick2 + " -connect " + "\"" + fullPath;
                processtartinfo2.WindowStyle = ProcessWindowStyle.Hidden;
            }
            else
            {
                processtartinfo.Arguments = "-netplay.gamekey " + gamekey + " -netplay.host " + server + " -netplay.nick " + nick + " -connect " + "\"" + customgame;
                processtartinfo.WindowStyle = ProcessWindowStyle.Hidden;

                processtartinfo2.Arguments = "-netplay.gamekey " + gamekey + " -netplay.host " + server + " -netplay.nick " + nick + " -connect " + "\"" + customgame;
                processtartinfo2.WindowStyle = ProcessWindowStyle.Hidden;

            }
            //string path = System.Reflection.Assembly.GetExecutingAssembly().Location;

            //To get the location the assembly normally resides on disk or the install directory

            processtartinfo.FileName = directory + "\\" + "mednafen.exe";
            processtartinfo2.FileName = directory + "\\" + "audio\\mednafen.exe";


            try
            {
                System.Diagnostics.Process.Start(processtartinfo2);
               
                texto1.Visible = true;
                texto11.Visible = true;
                Thread.Sleep(1000);
            }
            catch(Exception g)
            {
                MessageBox.Show("No se pudo iniciar mednafen.exe :(, el launcher no esta en la carpeta raiz de mednafen o debes instalar el parche de 32 bits :0");
           
            }
            try
            {
                System.Diagnostics.Process.Start(processtartinfo);

                texto1.Visible = true;
                texto11.Visible = true;
            }
            catch (Exception g)
            {
                MessageBox.Show("No se pudo iniciar mednafen.exe :(, el launcher no esta en la carpeta raiz de mednafen o debes instalar el parche de 32 bits :0");

            }

            savepreferences();
           
        }

        void savepreferences()
        {
            try
            {
                string[] names = new string[] { cmbServer.Text, txtGamekey.Text, txtNickName.Text, txtCue.Text , chkStartCTR.Enabled.ToString(), cmbGames.Text };

                using (StreamWriter sw = new StreamWriter("launchercfg.txt"))
                {

                    foreach (string s in names)
                    {
                        sw.WriteLine(s);
                    }
                }

               
            }
            catch (Exception h)
            {
                MessageBox.Show("No se pudo guardar preferencias, verifique el archivo launchercfg.txt en la ubicacion del launcher" + h.ToString());
            }

        }

        void loadpreferences()
        {
            try
            {
                List<String> lines = new List<string>();

                // Read and show each line from the file.
                string line = "";
                using (StreamReader sr = new StreamReader("launchercfg.txt"))
                {
                    while ((line = sr.ReadLine()) != null)
                    {
                        lines.Add(line);
                     }

                }

                cmbServer.Text = lines.ElementAt(0);
                txtGamekey.Text = lines.ElementAt(1);
                txtNickName.Text = lines.ElementAt(2);
                txtCue.Text = lines.ElementAt(3);

                try
                {
                    cmbGames.Text = lines.ElementAt(5);

                }
                catch(Exception e)
                {

                }
                if(lines.ElementAt(4) == "False")
                chkStartCTR.Checked = false;

                if (lines.ElementAt(4) == "True")
                    chkStartCTR.Checked = true;

            }
            catch (Exception h)
            {
                MessageBox.Show("No se pudo cargar launchercfg.txt en la ubicacion del launcher, se iniciará configuracion por defecto");
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscarJuego_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "C# Corner Open File Dialog";
            fdlg.InitialDirectory = @"c:\";
            fdlg.Filter = "All files (*.*)|*.*|All files (*.*)|*.*";
            fdlg.FilterIndex = 2;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                txtCue.Text = fdlg.FileName;
            }
        }

        private void chkStartCTR_CheckedChanged(object sender, EventArgs e)
        {
            if(chkStartCTR.Checked ==true)
            txtCue.Enabled = false ;
            else
                txtCue.Enabled = true;

        }

        private void btnOffline_Click(object sender, EventArgs e)
        {

            string path = System.Reflection.Assembly.GetExecutingAssembly().Location;
            var directory = System.IO.Path.GetDirectoryName(path);

            string customgame = txtCue.Text;

            string fullPath = directory + "\\games\\" + cmbGames.Text;
         

            ProcessStartInfo processtartinfo = new ProcessStartInfo();
            if (chkStartCTR.Checked == true)
            {
                processtartinfo.WorkingDirectory = Path.GetDirectoryName(fullPath);
                processtartinfo.Arguments = "\"" + fullPath;
                processtartinfo.WindowStyle = ProcessWindowStyle.Hidden;
            }
            else
            {
                processtartinfo.Arguments = "\"" + customgame;
                processtartinfo.WindowStyle = ProcessWindowStyle.Hidden;

            }
            processtartinfo.FileName = directory + "\\" + "mednafen.exe";


            try
            {
                System.Diagnostics.Process.Start(processtartinfo);
                texto1.Visible = true;
                texto11.Visible = true;
            }
            catch (Exception g)
            {
                MessageBox.Show("No se pudo iniciar mednafen.exe :(, el launcher no esta en la carpeta raiz de mednafen o debes instalar el parche de 32 bits :0");

            }

         


            savepreferences();


        }

        private void btnComandos_Click(object sender, EventArgs e)
        {
            ComandosForm form = new ComandosForm();
            form.Show();
        }

        private void texto11_Click(object sender, EventArgs e)
        {

        }

        private void texto1_Click(object sender, EventArgs e)
        {

        }

        private void btnChat_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/CTROnlineOficial/");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/groups/JugandoCTROnline/");

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/6VuSfeZ");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = System.Reflection.Assembly.GetExecutingAssembly().Location;
            var directory = System.IO.Path.GetDirectoryName(path);

            ProcessStartInfo processtartinfo = new ProcessStartInfo();

            processtartinfo.FileName = directory + "\\" + "mednaffe.exe";
            System.Diagnostics.Process.Start(processtartinfo);
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
                File.AppendAllText("serverlist.txt", "\n" + cmbServer.Text);

            cmbServer.Items.Add(cmbServer.Text);

        }
    }
}

