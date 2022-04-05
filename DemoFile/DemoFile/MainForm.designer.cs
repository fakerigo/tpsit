namespace DemoFile
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ofdApriFile = new System.Windows.Forms.OpenFileDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tlsCaricamento = new System.Windows.Forms.ToolStripProgressBar();
            this.lblBytesTotali = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblBytesLetti = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnLeggiAsync = new System.Windows.Forms.Button();
            this.txtSeekN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbxContenutoFile = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblContenutoFile = new System.Windows.Forms.Label();
            this.btnLeggiFile = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtLinea = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnStreamWriter = new System.Windows.Forms.Button();
            this.btnStreamReader = new System.Windows.Forms.Button();
            this.btnBinaryWriter = new System.Windows.Forms.Button();
            this.txtDescrRegione = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCodRegione = new System.Windows.Forms.TextBox();
            this.lbxDump1 = new System.Windows.Forms.ListBox();
            this.btnBinaryReader = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.colNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDim = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTipo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDataUltimaModifica = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDataCreazione = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnListDirectory = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.sfdSalvaFile = new System.Windows.Forms.SaveFileDialog();
            this.fbdScegliCartella = new System.Windows.Forms.FolderBrowserDialog();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ofdApriFile
            // 
            this.ofdApriFile.Filter = "Tutti i file|*.*|File CSV|*.csv|File MP3|*.mp3|File C#|*.cs";
            this.ofdApriFile.InitialDirectory = ".\\";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsCaricamento,
            this.lblBytesTotali,
            this.lblBytesLetti});
            this.statusStrip1.Location = new System.Drawing.Point(0, 547);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(923, 27);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tlsCaricamento
            // 
            this.tlsCaricamento.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tlsCaricamento.AutoSize = false;
            this.tlsCaricamento.Name = "tlsCaricamento";
            this.tlsCaricamento.Size = new System.Drawing.Size(267, 21);
            // 
            // lblBytesTotali
            // 
            this.lblBytesTotali.Name = "lblBytesTotali";
            this.lblBytesTotali.Size = new System.Drawing.Size(0, 22);
            this.lblBytesTotali.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBytesLetti
            // 
            this.lblBytesLetti.Name = "lblBytesLetti";
            this.lblBytesLetti.Size = new System.Drawing.Size(0, 22);
            this.lblBytesLetti.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(923, 547);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnLeggiAsync);
            this.tabPage1.Controls.Add(this.txtSeekN);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.lbxContenutoFile);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.lblContenutoFile);
            this.tabPage1.Controls.Add(this.btnLeggiFile);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(915, 518);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "FileStream";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnLeggiAsync
            // 
            this.btnLeggiAsync.Location = new System.Drawing.Point(16, 287);
            this.btnLeggiAsync.Name = "btnLeggiAsync";
            this.btnLeggiAsync.Size = new System.Drawing.Size(96, 31);
            this.btnLeggiAsync.TabIndex = 13;
            this.btnLeggiAsync.Text = "Leggi async";
            this.btnLeggiAsync.UseVisualStyleBackColor = true;
            this.btnLeggiAsync.Click += new System.EventHandler(this.btnLeggiAsync_Click);
            // 
            // txtSeekN
            // 
            this.txtSeekN.Location = new System.Drawing.Point(15, 215);
            this.txtSeekN.Margin = new System.Windows.Forms.Padding(4);
            this.txtSeekN.Name = "txtSeekN";
            this.txtSeekN.Size = new System.Drawing.Size(95, 22);
            this.txtSeekN.TabIndex = 12;
            this.txtSeekN.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 196);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "da byte n.";
            // 
            // lbxContenutoFile
            // 
            this.lbxContenutoFile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbxContenutoFile.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxContenutoFile.FormattingEnabled = true;
            this.lbxContenutoFile.ItemHeight = 16;
            this.lbxContenutoFile.Location = new System.Drawing.Point(119, 139);
            this.lbxContenutoFile.Margin = new System.Windows.Forms.Padding(4);
            this.lbxContenutoFile.Name = "lbxContenutoFile";
            this.lbxContenutoFile.Size = new System.Drawing.Size(787, 372);
            this.lbxContenutoFile.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(11, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(891, 92);
            this.label2.TabIndex = 7;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // lblContenutoFile
            // 
            this.lblContenutoFile.AutoSize = true;
            this.lblContenutoFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContenutoFile.Location = new System.Drawing.Point(115, 112);
            this.lblContenutoFile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContenutoFile.Name = "lblContenutoFile";
            this.lblContenutoFile.Size = new System.Drawing.Size(111, 13);
            this.lblContenutoFile.TabIndex = 6;
            this.lblContenutoFile.Text = "Contenuto del file:";
            // 
            // btnLeggiFile
            // 
            this.btnLeggiFile.Location = new System.Drawing.Point(14, 139);
            this.btnLeggiFile.Margin = new System.Windows.Forms.Padding(4);
            this.btnLeggiFile.Name = "btnLeggiFile";
            this.btnLeggiFile.Size = new System.Drawing.Size(97, 31);
            this.btnLeggiFile.TabIndex = 4;
            this.btnLeggiFile.Text = "Leggi file";
            this.btnLeggiFile.UseVisualStyleBackColor = true;
            this.btnLeggiFile.Click += new System.EventHandler(this.btnLeggiFile_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtLinea);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.btnStreamWriter);
            this.tabPage2.Controls.Add(this.btnStreamReader);
            this.tabPage2.Controls.Add(this.btnBinaryWriter);
            this.tabPage2.Controls.Add(this.txtDescrRegione);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.txtCodRegione);
            this.tabPage2.Controls.Add(this.lbxDump1);
            this.tabPage2.Controls.Add(this.btnBinaryReader);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(915, 518);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Writer e Reader";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtLinea
            // 
            this.txtLinea.Location = new System.Drawing.Point(11, 384);
            this.txtLinea.Margin = new System.Windows.Forms.Padding(4);
            this.txtLinea.Name = "txtLinea";
            this.txtLinea.Size = new System.Drawing.Size(216, 22);
            this.txtLinea.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 364);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "Linea";
            // 
            // btnStreamWriter
            // 
            this.btnStreamWriter.Location = new System.Drawing.Point(11, 416);
            this.btnStreamWriter.Margin = new System.Windows.Forms.Padding(4);
            this.btnStreamWriter.Name = "btnStreamWriter";
            this.btnStreamWriter.Size = new System.Drawing.Size(217, 31);
            this.btnStreamWriter.TabIndex = 17;
            this.btnStreamWriter.Text = "Scrivi file con StreamWriter";
            this.btnStreamWriter.UseVisualStyleBackColor = true;
            this.btnStreamWriter.Click += new System.EventHandler(this.btnStreamWriter_Click);
            // 
            // btnStreamReader
            // 
            this.btnStreamReader.Location = new System.Drawing.Point(11, 454);
            this.btnStreamReader.Margin = new System.Windows.Forms.Padding(4);
            this.btnStreamReader.Name = "btnStreamReader";
            this.btnStreamReader.Size = new System.Drawing.Size(217, 31);
            this.btnStreamReader.TabIndex = 16;
            this.btnStreamReader.Text = "Leggi file con StreamReader";
            this.btnStreamReader.UseVisualStyleBackColor = true;
            this.btnStreamReader.Click += new System.EventHandler(this.btnStreamReader_Click);
            // 
            // btnBinaryWriter
            // 
            this.btnBinaryWriter.Location = new System.Drawing.Point(11, 267);
            this.btnBinaryWriter.Margin = new System.Windows.Forms.Padding(4);
            this.btnBinaryWriter.Name = "btnBinaryWriter";
            this.btnBinaryWriter.Size = new System.Drawing.Size(217, 31);
            this.btnBinaryWriter.TabIndex = 15;
            this.btnBinaryWriter.Text = "Scrivi file con BinaryWriter";
            this.btnBinaryWriter.UseVisualStyleBackColor = true;
            this.btnBinaryWriter.Click += new System.EventHandler(this.btnBinaryWriter_Click);
            // 
            // txtDescrRegione
            // 
            this.txtDescrRegione.Location = new System.Drawing.Point(11, 235);
            this.txtDescrRegione.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescrRegione.Name = "txtDescrRegione";
            this.txtDescrRegione.Size = new System.Drawing.Size(216, 22);
            this.txtDescrRegione.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 215);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Descrizione regione";
            // 
            // txtCodRegione
            // 
            this.txtCodRegione.Location = new System.Drawing.Point(11, 187);
            this.txtCodRegione.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodRegione.Name = "txtCodRegione";
            this.txtCodRegione.Size = new System.Drawing.Size(87, 22);
            this.txtCodRegione.TabIndex = 12;
            // 
            // lbxDump1
            // 
            this.lbxDump1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbxDump1.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxDump1.FormattingEnabled = true;
            this.lbxDump1.ItemHeight = 16;
            this.lbxDump1.Location = new System.Drawing.Point(240, 167);
            this.lbxDump1.Margin = new System.Windows.Forms.Padding(4);
            this.lbxDump1.Name = "lbxDump1";
            this.lbxDump1.Size = new System.Drawing.Size(667, 340);
            this.lbxDump1.TabIndex = 11;
            // 
            // btnBinaryReader
            // 
            this.btnBinaryReader.Location = new System.Drawing.Point(11, 305);
            this.btnBinaryReader.Margin = new System.Windows.Forms.Padding(4);
            this.btnBinaryReader.Name = "btnBinaryReader";
            this.btnBinaryReader.Size = new System.Drawing.Size(217, 31);
            this.btnBinaryReader.TabIndex = 10;
            this.btnBinaryReader.Text = "Leggi file con BinaryReader";
            this.btnBinaryReader.UseVisualStyleBackColor = true;
            this.btnBinaryReader.Click += new System.EventHandler(this.btnBinaryReader_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 167);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Codice regione";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(11, 12);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(889, 151);
            this.label4.TabIndex = 8;
            this.label4.Text = resources.GetString("label4.Text");
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.listView1);
            this.tabPage3.Controls.Add(this.btnListDirectory);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage3.Size = new System.Drawing.Size(915, 518);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Accesso al file system";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.AllowColumnReorder = true;
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colNome,
            this.colDim,
            this.colTipo,
            this.colDataUltimaModifica,
            this.colDataCreazione});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(149, 134);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(758, 376);
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // colNome
            // 
            this.colNome.Text = "Nome";
            this.colNome.Width = 200;
            // 
            // colDim
            // 
            this.colDim.Text = "Dimensione";
            this.colDim.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colDim.Width = 78;
            // 
            // colTipo
            // 
            this.colTipo.Text = "Tipo";
            this.colTipo.Width = 47;
            // 
            // colDataUltimaModifica
            // 
            this.colDataUltimaModifica.Text = "Data ultima modifica";
            this.colDataUltimaModifica.Width = 114;
            // 
            // colDataCreazione
            // 
            this.colDataCreazione.Text = "Data creazione";
            this.colDataCreazione.Width = 119;
            // 
            // btnListDirectory
            // 
            this.btnListDirectory.Location = new System.Drawing.Point(14, 134);
            this.btnListDirectory.Margin = new System.Windows.Forms.Padding(4);
            this.btnListDirectory.Name = "btnListDirectory";
            this.btnListDirectory.Size = new System.Drawing.Size(125, 33);
            this.btnListDirectory.TabIndex = 10;
            this.btnListDirectory.Text = "Lista";
            this.btnListDirectory.UseVisualStyleBackColor = true;
            this.btnListDirectory.Click += new System.EventHandler(this.btnListDirectory_Click);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(11, 12);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(891, 103);
            this.label8.TabIndex = 9;
            this.label8.Text = resources.GetString("label8.Text");
            // 
            // sfdSalvaFile
            // 
            this.sfdSalvaFile.Filter = "Tutti i file|*.*|File CSV|*.csv|File MP3|*.mp3|File C#|*.cs";
            this.sfdSalvaFile.InitialDirectory = ".\\";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 574);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Demo File & File System";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ofdApriFile;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblBytesTotali;
        private System.Windows.Forms.ToolStripProgressBar tlsCaricamento;
        private System.Windows.Forms.ToolStripStatusLabel lblBytesLetti;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblContenutoFile;
        private System.Windows.Forms.Button btnLeggiFile;
        private System.Windows.Forms.ListBox lbxContenutoFile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBinaryReader;
        private System.Windows.Forms.ListBox lbxDump1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCodRegione;
        private System.Windows.Forms.SaveFileDialog sfdSalvaFile;
        private System.Windows.Forms.TextBox txtDescrRegione;
        private System.Windows.Forms.Button btnBinaryWriter;
        private System.Windows.Forms.TextBox txtLinea;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnStreamWriter;
        private System.Windows.Forms.Button btnStreamReader;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader colNome;
        private System.Windows.Forms.ColumnHeader colDim;
        private System.Windows.Forms.Button btnListDirectory;
        private System.Windows.Forms.ColumnHeader colTipo;
        private System.Windows.Forms.ColumnHeader colDataUltimaModifica;
        private System.Windows.Forms.ColumnHeader colDataCreazione;
        private System.Windows.Forms.FolderBrowserDialog fbdScegliCartella;
        private System.Windows.Forms.TextBox txtSeekN;
        private System.Windows.Forms.Button btnLeggiAsync;
    }
}

