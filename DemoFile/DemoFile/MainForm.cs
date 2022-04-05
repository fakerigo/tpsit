using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace DemoFile
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        // -------------------- classe FileStream		
        private void btnLeggiFile_Click(object sender, EventArgs e)
        {
            if (ofdApriFile.ShowDialog() == DialogResult.OK)
            {
                lblContenutoFile.Text = $"Dump file ({ofdApriFile.FileName}):";

                FileStream fs;

                // crea il riferimento al file utilizzando il file indicato:
                // apre in lettura il file permettendo ad altri programmi di
                // utilizzarlo ma solo in lettura (livello di condivisione FileShare.Read)
                fs = new FileStream(ofdApriFile.FileName, FileMode.Open, FileAccess.Read, FileShare.Read);

                // si posiziona ai bytes specificati dall'inizio del file
                int.TryParse(txtSeekN.Text, out int daByteN);
                fs.Seek(daByteN, SeekOrigin.Begin);

                // imposta la toolStrip alla lunghezza del file in byte
                int lunghezza = (int)fs.Length - daByteN;
                tlsCaricamento.Maximum = lunghezza / 16;
                tlsCaricamento.Step = 1;
                tlsCaricamento.Value = 0;

                lblBytesTotali.Text = $"Byte totali: {lunghezza}";
                lblBytesLetti.Text = "";

                lbxContenutoFile.Items.Clear();
                byte dato; // è la variabile che conterrà il byte letto dal file
                string dumpHexString = "", dumpCharString = "";
                try
                {
                    lbxContenutoFile.BeginUpdate(); // evita il ridisegno del controllo fino a quando non viene chiamato EndUpdate
                    for (int i = 0; i < lunghezza; i++)
                    {
                        dato = (byte)fs.ReadByte(); // legge un byte dal file                  

                        dumpHexString += Convert.ToString(dato, 16).PadLeft(2, '0').ToUpper()
                                    + " ";
                        if (dato >= 32)
                            dumpCharString += Convert.ToChar(dato);
                        else
                            dumpCharString += '?';

                        if ((i + 1) % 16 == 0 || i == lunghezza - 1)
                        {
                            lbxContenutoFile.Items.Add($"{dumpHexString}{i,10} {dumpCharString}");
                            dumpHexString = "";
                            dumpCharString = "";
                            tlsCaricamento.PerformStep();
                            lblBytesLetti.Text = $"Byte letti: {i + 1}";
                            Application.DoEvents();
                        }
                    }
                }
                finally
                {
                    lbxContenutoFile.EndUpdate();
                }
                fs.Close(); // chiude il file 
            }
        }

        // -------------------- classi BinaryReader e BinaryWriter
        private void btnBinaryReader_Click(object sender, EventArgs e)
        {
            if (ofdApriFile.ShowDialog() == DialogResult.OK)
            {
                /*
                FileStream fs = new FileStream(ofdApriFile.FileName, FileMode.Open,
                    FileAccess.Read, FileShare.Read);

                // crea il reader e lo associa al file
                BinaryReader br = new BinaryReader(fs);

                int CodRegione;
                string DescrRegione;
                lbxDump1.Items.Clear();

                // legge fino alla fine del file             
                while (br.BaseStream.Position < br.BaseStream.Length)
                {
                    CodRegione = br.ReadInt32();
                    DescrRegione = br.ReadString();
                    lbxDump1.Items.Add($"{CodRegione,4} {DescrRegione}");
                }
                br.Close();
                */
                // versione con using()
                using (BinaryReader br = new BinaryReader(new FileStream(ofdApriFile.FileName, FileMode.Open,
                    FileAccess.Read, FileShare.Read)))
                {
                    int CodRegione;
                    string DescrRegione;
                    lbxDump1.Items.Clear();

                    // legge fino alla fine del file             
                    while (br.BaseStream.Position < br.BaseStream.Length)
                    {
                        CodRegione = br.ReadInt32();
                        DescrRegione = br.ReadString();
                        lbxDump1.Items.Add($"{CodRegione,4} {DescrRegione}");
                    }
                }

                // oppure con la classe File
                using (BinaryReader br = new BinaryReader(File.Open(ofdApriFile.FileName, FileMode.Open,
                    FileAccess.Read, FileShare.Read)))
                {
                    // ...
                }
            }
        }

        private void btnBinaryWriter_Click(object sender, EventArgs e)
        {
            if (sfdSalvaFile.ShowDialog() == DialogResult.OK)
            {
                // apre il file in append (se non esiste lo crea)
                FileStream fs = new FileStream(sfdSalvaFile.FileName, FileMode.Append,
                    FileAccess.Write, FileShare.Read);

                // crea il writer e lo associa al file
                BinaryWriter wr = new BinaryWriter(fs);

                int CodRegione = Convert.ToInt32(txtCodRegione.Text);
                string DescrRegione = txtDescrRegione.Text;

                wr.Write(CodRegione);
                wr.Write(DescrRegione);
                wr.Close();
            }
        }

        // ------------------------------- classi StreamReader e StreamWriter		
        private void btnStreamReader_Click(object sender, EventArgs e)
        {
            if (ofdApriFile.ShowDialog() == DialogResult.OK)
            {
                // uno stream reader crea automaticamente il FileStream di appoggio
                StreamReader sr = new StreamReader(ofdApriFile.FileName);

                string linea;
                lbxDump1.Items.Clear();

                // legge fino alla fine del file
                while ((linea = sr.ReadLine()) != null)  // linea è null quando il file è finito
                    lbxDump1.Items.Add(linea);

                // Altri modi per leggere da file:                
                sr.BaseStream.Position = 0;
                linea = sr.ReadToEnd();  // legge tutto il file come unica stringa

                sr.BaseStream.Position = 0;
                // legge fino alla fine del file
                while (!sr.EndOfStream)
                {
                    linea = sr.ReadLine();
                    // elaborazione di linea
                }
                sr.Close();
            }
        }

        private void btnStreamWriter_Click(object sender, EventArgs e)
        {
            if (sfdSalvaFile.ShowDialog() == DialogResult.OK)
            {
                // uno stream writer crea automaticamente il FileStream di appoggio
                // (il secondo parametro indica che si deve aprire in append)
                StreamWriter sw = new StreamWriter(sfdSalvaFile.FileName, true);
                sw.WriteLine(txtLinea.Text);
                sw.Close();
            }
        }

        // -------------------- classi per la gestione del file system
        private void btnListDirectory_Click(object sender, EventArgs e)
        {
            if (fbdScegliCartella.ShowDialog() == DialogResult.OK)
            {
                string[] listaDir;
                MessageBox.Show($"Percorso selezionato: {fbdScegliCartella.SelectedPath}");

                // ottiene l'elenco dei file contenuti nella directory
                listaDir = Directory.GetFiles(fbdScegliCartella.SelectedPath);

                /* in alternativa a sopra per leggere ricorsivamente anche le sotto cartelle usare:                
                    List<string> listaDir = LetturaRicorsivaDirectory(folderBrowserDialog1.SelectedPath);
                */
                string[] colonne = new string[5];
                listView1.Items.Clear();
                foreach (string entryDir in listaDir)
                {
                    // FileInfo contiene metodi analoghi alla classe File 
                    // (la usiamo perchè permette di ottenere la dimensione del file)
                    FileInfo fInfo = new FileInfo(entryDir);

                    colonne[0] = fInfo.Name;
                    colonne[1] = fInfo.Length.ToString();
                    colonne[2] = fInfo.Extension;
                    colonne[3] = fInfo.LastWriteTime.ToString("dd/MM/yyyy HH:mm:ss");
                    colonne[4] = fInfo.CreationTime.ToString("dd/MM/yyyy HH:mm:ss");

                    listView1.Items.Add(new ListViewItem(colonne));
                }
            }
        }

        // Legge ricorsivamente una directory producendo una lista di tutti i nomi dei file contenuti
        private List<string> LetturaRicorsivaDirectory(string nomeDir)
        {
            List<string> listaFile = new List<string>();
            listaFile.AddRange(Directory.GetFiles(nomeDir));

            string[] listaDir = Directory.GetDirectories(nomeDir);
            foreach (string dir in listaDir)
                listaFile.AddRange(LetturaRicorsivaDirectory(dir));

            return listaFile;
        }

        private async void btnLeggiAsync_Click(object sender, EventArgs e)
        {
            // lettura asincrona del file
            // N.B.: ReadAsync deve essere usato con l'istruzione await (attendi) e il metodo in cui è inserita deve essere dichiarato async
            byte[] dati = null;
            int daByteN = Convert.ToInt32(txtSeekN.Text);

            if (ofdApriFile.ShowDialog() == DialogResult.OK)
                using (FileStream fs = new FileStream(ofdApriFile.FileName, FileMode.Open))
                {

                    dati = new byte[fs.Length - daByteN];
                    await fs.ReadAsync(dati, daByteN, (int)fs.Length - daByteN);
                }

            // analogo ciclo della versione senza async per produrre l'output
            if (dati != null)
            {
                // imposta la toolStrip alla lunghezza del file in byte
                int lunghezza = dati.Length - daByteN;
                tlsCaricamento.Maximum = lunghezza / 16;
                tlsCaricamento.Step = 1;
                tlsCaricamento.Value = 0;

                lblBytesTotali.Text = $"Byte totali: {lunghezza}";
                lblBytesLetti.Text = "";

                lbxContenutoFile.Items.Clear();
                byte dato; // è la variabile che conterrà il byte letto dal file
                string dumpHexString = "", dumpCharString = "";

                try
                {
                    lbxContenutoFile.BeginUpdate();
                    for (int i = 0; i < lunghezza; i++)
                    {
                        dato = dati[i];

                        dumpHexString += Convert.ToString(dato, 16).PadLeft(2, '0').ToUpper()
                                    + " ";
                        if (dato >= 32)
                            dumpCharString += Convert.ToChar(dato);
                        else
                            dumpCharString += '?';

                        if ((i + 1) % 16 == 0 || i == lunghezza - 1)
                        {
                            lbxContenutoFile.Items.Add($"{dumpHexString}{i,10} {dumpCharString}");
                            dumpHexString = "";
                            dumpCharString = "";
                            tlsCaricamento.PerformStep();
                            lblBytesLetti.Text = $"Byte letti: {i + 1}";
                            Application.DoEvents();
                        }
                    }
                }
                finally
                {
                    lbxContenutoFile.EndUpdate();
                }
            }
            /* if (ofdApriFile.ShowDialog() == DialogResult.OK)
                using (FileStream fs = new FileStream(ofdApriFile.FileName, FileMode.Open))
                {
                    byte[] dati;
                    dati = new byte[fs.Length];
                    fs.Read(dati, 0, (int)fs.Length);
                    MessageBox.Show(System.Text.Encoding.ASCII.GetString(dati));
                } */
        }
    }               
}