
namespace WindowsFormsAppHero
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelNom = new System.Windows.Forms.Label();
            this.labelPrenom = new System.Windows.Forms.Label();
            this.labelSpecialite = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelClassHero = new System.Windows.Forms.Label();
            this.labelLvl = new System.Windows.Forms.Label();
            this.labelPuissance = new System.Windows.Forms.Label();
            this.labelReputation = new System.Windows.Forms.Label();
            this.labelNbMissionReussi = new System.Windows.Forms.Label();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.textBoxPrenom = new System.Windows.Forms.TextBox();
            this.textBoxSpecialite = new System.Windows.Forms.TextBox();
            this.textBoxClassHero = new System.Windows.Forms.TextBox();
            this.numericUpDownLvl = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownPuissance = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownNbMissionReussi = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownReputation = new System.Windows.Forms.NumericUpDown();
            this.labelNomObj = new System.Windows.Forms.Label();
            this.labelLvlObjet = new System.Windows.Forms.Label();
            this.labelQuantiteObj = new System.Windows.Forms.Label();
            this.labelDessc = new System.Windows.Forms.Label();
            this.labelPrix = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxNomObj = new System.Windows.Forms.TextBox();
            this.textBoxDesc = new System.Windows.Forms.TextBox();
            this.numericUpDownLvlObj = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownQuantiteObj = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownPrix = new System.Windows.Forms.NumericUpDown();
            this.dataGridViewHero = new System.Windows.Forms.DataGridView();
            this.dataGridViewSacoche = new System.Windows.Forms.DataGridView();
            this.buttonAddHero = new System.Windows.Forms.Button();
            this.buttonUpdateHero = new System.Windows.Forms.Button();
            this.buttonDelHero = new System.Windows.Forms.Button();
            this.buttonAddObj = new System.Windows.Forms.Button();
            this.buttonUpdateObj = new System.Windows.Forms.Button();
            this.buttonDelObj = new System.Windows.Forms.Button();
            this.gUILDEHERODataSet = new WindowsFormsAppHero.GUILDEHERODataSet();
            this.heroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.heroTableAdapter = new WindowsFormsAppHero.GUILDEHERODataSetTableAdapters.HeroTableAdapter();
            this.gUILDEHERODataSet1 = new WindowsFormsAppHero.GUILDEHERODataSet1();
            this.sacocheBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sacocheTableAdapter = new WindowsFormsAppHero.GUILDEHERODataSet1TableAdapters.SacocheTableAdapter();
            this.labelTabHero = new System.Windows.Forms.Label();
            this.labelTabSacoche = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLvl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPuissance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNbMissionReussi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownReputation)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLvlObj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantiteObj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSacoche)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gUILDEHERODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gUILDEHERODataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sacocheBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(3, 0);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(29, 13);
            this.labelNom.TabIndex = 0;
            this.labelNom.Text = "Nom";
            // 
            // labelPrenom
            // 
            this.labelPrenom.AutoSize = true;
            this.labelPrenom.Location = new System.Drawing.Point(3, 27);
            this.labelPrenom.Name = "labelPrenom";
            this.labelPrenom.Size = new System.Drawing.Size(43, 13);
            this.labelPrenom.TabIndex = 1;
            this.labelPrenom.Text = "Prénom";
            // 
            // labelSpecialite
            // 
            this.labelSpecialite.AutoSize = true;
            this.labelSpecialite.Location = new System.Drawing.Point(3, 54);
            this.labelSpecialite.Name = "labelSpecialite";
            this.labelSpecialite.Size = new System.Drawing.Size(53, 13);
            this.labelSpecialite.TabIndex = 2;
            this.labelSpecialite.Text = "Spécialité";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.07143F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.92857F));
            this.tableLayoutPanel1.Controls.Add(this.labelNom, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelPrenom, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelSpecialite, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelClassHero, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelLvl, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelPuissance, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.labelReputation, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.labelNbMissionReussi, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.textBoxNom, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxPrenom, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxSpecialite, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxClassHero, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDownLvl, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDownPuissance, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDownNbMissionReussi, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDownReputation, 1, 7);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(153, 72);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(280, 234);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // labelClassHero
            // 
            this.labelClassHero.AutoSize = true;
            this.labelClassHero.Location = new System.Drawing.Point(3, 80);
            this.labelClassHero.Name = "labelClassHero";
            this.labelClassHero.Size = new System.Drawing.Size(84, 13);
            this.labelClassHero.TabIndex = 4;
            this.labelClassHero.Text = "Classse du Héro";
            // 
            // labelLvl
            // 
            this.labelLvl.AutoSize = true;
            this.labelLvl.Location = new System.Drawing.Point(3, 109);
            this.labelLvl.Name = "labelLvl";
            this.labelLvl.Size = new System.Drawing.Size(33, 13);
            this.labelLvl.TabIndex = 5;
            this.labelLvl.Text = "Level";
            // 
            // labelPuissance
            // 
            this.labelPuissance.AutoSize = true;
            this.labelPuissance.Location = new System.Drawing.Point(3, 138);
            this.labelPuissance.Name = "labelPuissance";
            this.labelPuissance.Size = new System.Drawing.Size(61, 13);
            this.labelPuissance.TabIndex = 6;
            this.labelPuissance.Text = "Puisssance";
            // 
            // labelReputation
            // 
            this.labelReputation.AutoSize = true;
            this.labelReputation.Location = new System.Drawing.Point(3, 203);
            this.labelReputation.Name = "labelReputation";
            this.labelReputation.Size = new System.Drawing.Size(59, 13);
            this.labelReputation.TabIndex = 8;
            this.labelReputation.Text = "Réputation";
            // 
            // labelNbMissionReussi
            // 
            this.labelNbMissionReussi.AutoSize = true;
            this.labelNbMissionReussi.Location = new System.Drawing.Point(3, 171);
            this.labelNbMissionReussi.Name = "labelNbMissionReussi";
            this.labelNbMissionReussi.Size = new System.Drawing.Size(126, 13);
            this.labelNbMissionReussi.TabIndex = 7;
            this.labelNbMissionReussi.Text = "Nombre de mission réussi";
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(146, 3);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(120, 20);
            this.textBoxNom.TabIndex = 9;
            // 
            // textBoxPrenom
            // 
            this.textBoxPrenom.Location = new System.Drawing.Point(146, 30);
            this.textBoxPrenom.Name = "textBoxPrenom";
            this.textBoxPrenom.Size = new System.Drawing.Size(120, 20);
            this.textBoxPrenom.TabIndex = 10;
            // 
            // textBoxSpecialite
            // 
            this.textBoxSpecialite.Location = new System.Drawing.Point(146, 57);
            this.textBoxSpecialite.Name = "textBoxSpecialite";
            this.textBoxSpecialite.Size = new System.Drawing.Size(120, 20);
            this.textBoxSpecialite.TabIndex = 11;
            // 
            // textBoxClassHero
            // 
            this.textBoxClassHero.Location = new System.Drawing.Point(146, 83);
            this.textBoxClassHero.Name = "textBoxClassHero";
            this.textBoxClassHero.Size = new System.Drawing.Size(120, 20);
            this.textBoxClassHero.TabIndex = 12;
            // 
            // numericUpDownLvl
            // 
            this.numericUpDownLvl.Location = new System.Drawing.Point(146, 112);
            this.numericUpDownLvl.Name = "numericUpDownLvl";
            this.numericUpDownLvl.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownLvl.TabIndex = 13;
            // 
            // numericUpDownPuissance
            // 
            this.numericUpDownPuissance.Location = new System.Drawing.Point(146, 141);
            this.numericUpDownPuissance.Name = "numericUpDownPuissance";
            this.numericUpDownPuissance.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownPuissance.TabIndex = 14;
            // 
            // numericUpDownNbMissionReussi
            // 
            this.numericUpDownNbMissionReussi.Location = new System.Drawing.Point(146, 174);
            this.numericUpDownNbMissionReussi.Name = "numericUpDownNbMissionReussi";
            this.numericUpDownNbMissionReussi.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownNbMissionReussi.TabIndex = 15;
            // 
            // numericUpDownReputation
            // 
            this.numericUpDownReputation.Location = new System.Drawing.Point(146, 206);
            this.numericUpDownReputation.Name = "numericUpDownReputation";
            this.numericUpDownReputation.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownReputation.TabIndex = 16;
            // 
            // labelNomObj
            // 
            this.labelNomObj.AutoSize = true;
            this.labelNomObj.Location = new System.Drawing.Point(3, 0);
            this.labelNomObj.Name = "labelNomObj";
            this.labelNomObj.Size = new System.Drawing.Size(29, 13);
            this.labelNomObj.TabIndex = 9;
            this.labelNomObj.Text = "Nom";
            // 
            // labelLvlObjet
            // 
            this.labelLvlObjet.AutoSize = true;
            this.labelLvlObjet.Location = new System.Drawing.Point(3, 32);
            this.labelLvlObjet.Name = "labelLvlObjet";
            this.labelLvlObjet.Size = new System.Drawing.Size(33, 13);
            this.labelLvlObjet.TabIndex = 10;
            this.labelLvlObjet.Text = "Level";
            // 
            // labelQuantiteObj
            // 
            this.labelQuantiteObj.AutoSize = true;
            this.labelQuantiteObj.Location = new System.Drawing.Point(3, 66);
            this.labelQuantiteObj.Name = "labelQuantiteObj";
            this.labelQuantiteObj.Size = new System.Drawing.Size(47, 13);
            this.labelQuantiteObj.TabIndex = 11;
            this.labelQuantiteObj.Text = "Quantité";
            // 
            // labelDessc
            // 
            this.labelDessc.AutoSize = true;
            this.labelDessc.Location = new System.Drawing.Point(3, 100);
            this.labelDessc.Name = "labelDessc";
            this.labelDessc.Size = new System.Drawing.Size(60, 13);
            this.labelDessc.TabIndex = 12;
            this.labelDessc.Text = "Description";
            // 
            // labelPrix
            // 
            this.labelPrix.AutoSize = true;
            this.labelPrix.Location = new System.Drawing.Point(3, 132);
            this.labelPrix.Name = "labelPrix";
            this.labelPrix.Size = new System.Drawing.Size(24, 13);
            this.labelPrix.TabIndex = 13;
            this.labelPrix.Text = "Prix";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.labelNomObj, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelPrix, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.labelLvlObjet, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.labelDessc, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.labelQuantiteObj, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.textBoxNomObj, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBoxDesc, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.numericUpDownLvlObj, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.numericUpDownQuantiteObj, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.numericUpDownPrix, 1, 4);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(153, 494);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.48485F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.51515F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(280, 168);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // textBoxNomObj
            // 
            this.textBoxNomObj.Location = new System.Drawing.Point(143, 3);
            this.textBoxNomObj.Name = "textBoxNomObj";
            this.textBoxNomObj.Size = new System.Drawing.Size(120, 20);
            this.textBoxNomObj.TabIndex = 14;
            // 
            // textBoxDesc
            // 
            this.textBoxDesc.Location = new System.Drawing.Point(143, 103);
            this.textBoxDesc.Name = "textBoxDesc";
            this.textBoxDesc.Size = new System.Drawing.Size(120, 20);
            this.textBoxDesc.TabIndex = 15;
            // 
            // numericUpDownLvlObj
            // 
            this.numericUpDownLvlObj.Location = new System.Drawing.Point(143, 35);
            this.numericUpDownLvlObj.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownLvlObj.Name = "numericUpDownLvlObj";
            this.numericUpDownLvlObj.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownLvlObj.TabIndex = 16;
            // 
            // numericUpDownQuantiteObj
            // 
            this.numericUpDownQuantiteObj.Location = new System.Drawing.Point(143, 69);
            this.numericUpDownQuantiteObj.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownQuantiteObj.Name = "numericUpDownQuantiteObj";
            this.numericUpDownQuantiteObj.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownQuantiteObj.TabIndex = 17;
            // 
            // numericUpDownPrix
            // 
            this.numericUpDownPrix.Location = new System.Drawing.Point(143, 135);
            this.numericUpDownPrix.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownPrix.Name = "numericUpDownPrix";
            this.numericUpDownPrix.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownPrix.TabIndex = 18;
            // 
            // dataGridViewHero
            // 
            this.dataGridViewHero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHero.Location = new System.Drawing.Point(474, 72);
            this.dataGridViewHero.Name = "dataGridViewHero";
            this.dataGridViewHero.Size = new System.Drawing.Size(930, 324);
            this.dataGridViewHero.TabIndex = 5;
            this.dataGridViewHero.SelectionChanged += new System.EventHandler(this.dataGridViewHero_SelectionChanged);
            // 
            // dataGridViewSacoche
            // 
            this.dataGridViewSacoche.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSacoche.Location = new System.Drawing.Point(474, 495);
            this.dataGridViewSacoche.Name = "dataGridViewSacoche";
            this.dataGridViewSacoche.Size = new System.Drawing.Size(846, 311);
            this.dataGridViewSacoche.TabIndex = 6;
            this.dataGridViewSacoche.SelectionChanged += new System.EventHandler(this.dataGridViewSacoche_SelectionChanged);
            // 
            // buttonAddHero
            // 
            this.buttonAddHero.Location = new System.Drawing.Point(1444, 181);
            this.buttonAddHero.Name = "buttonAddHero";
            this.buttonAddHero.Size = new System.Drawing.Size(75, 23);
            this.buttonAddHero.TabIndex = 7;
            this.buttonAddHero.Text = "Ajouter";
            this.buttonAddHero.UseVisualStyleBackColor = true;
            this.buttonAddHero.Click += new System.EventHandler(this.buttonAddHero_Click);
            // 
            // buttonUpdateHero
            // 
            this.buttonUpdateHero.Location = new System.Drawing.Point(1444, 211);
            this.buttonUpdateHero.Name = "buttonUpdateHero";
            this.buttonUpdateHero.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdateHero.TabIndex = 8;
            this.buttonUpdateHero.Text = "Modifier";
            this.buttonUpdateHero.UseVisualStyleBackColor = true;
            this.buttonUpdateHero.Click += new System.EventHandler(this.buttonUpdateHero_Click);
            // 
            // buttonDelHero
            // 
            this.buttonDelHero.Location = new System.Drawing.Point(1444, 242);
            this.buttonDelHero.Name = "buttonDelHero";
            this.buttonDelHero.Size = new System.Drawing.Size(75, 23);
            this.buttonDelHero.TabIndex = 9;
            this.buttonDelHero.Text = "Supprimer";
            this.buttonDelHero.UseVisualStyleBackColor = true;
            this.buttonDelHero.Click += new System.EventHandler(this.buttonDelHero_Click);
            // 
            // buttonAddObj
            // 
            this.buttonAddObj.Location = new System.Drawing.Point(1359, 602);
            this.buttonAddObj.Name = "buttonAddObj";
            this.buttonAddObj.Size = new System.Drawing.Size(75, 23);
            this.buttonAddObj.TabIndex = 10;
            this.buttonAddObj.Text = "Ajouter";
            this.buttonAddObj.UseVisualStyleBackColor = true;
            this.buttonAddObj.Click += new System.EventHandler(this.buttonAddObj_Click);
            // 
            // buttonUpdateObj
            // 
            this.buttonUpdateObj.Location = new System.Drawing.Point(1359, 633);
            this.buttonUpdateObj.Name = "buttonUpdateObj";
            this.buttonUpdateObj.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdateObj.TabIndex = 11;
            this.buttonUpdateObj.Text = "Modifier";
            this.buttonUpdateObj.UseVisualStyleBackColor = true;
            this.buttonUpdateObj.Click += new System.EventHandler(this.buttonUpdateObj_Click);
            // 
            // buttonDelObj
            // 
            this.buttonDelObj.Location = new System.Drawing.Point(1359, 664);
            this.buttonDelObj.Name = "buttonDelObj";
            this.buttonDelObj.Size = new System.Drawing.Size(75, 23);
            this.buttonDelObj.TabIndex = 12;
            this.buttonDelObj.Text = "Supprimer";
            this.buttonDelObj.UseVisualStyleBackColor = true;
            this.buttonDelObj.Click += new System.EventHandler(this.buttonDelObj_Click);
            // 
            // gUILDEHERODataSet
            // 
            this.gUILDEHERODataSet.DataSetName = "GUILDEHERODataSet";
            this.gUILDEHERODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // heroBindingSource
            // 
            this.heroBindingSource.DataMember = "Hero";
            this.heroBindingSource.DataSource = this.gUILDEHERODataSet;
            // 
            // heroTableAdapter
            // 
            this.heroTableAdapter.ClearBeforeFill = true;
            // 
            // gUILDEHERODataSet1
            // 
            this.gUILDEHERODataSet1.DataSetName = "GUILDEHERODataSet1";
            this.gUILDEHERODataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sacocheBindingSource
            // 
            this.sacocheBindingSource.DataMember = "Sacoche";
            this.sacocheBindingSource.DataSource = this.gUILDEHERODataSet1;
            // 
            // sacocheTableAdapter
            // 
            this.sacocheTableAdapter.ClearBeforeFill = true;
            // 
            // labelTabHero
            // 
            this.labelTabHero.AutoSize = true;
            this.labelTabHero.Font = new System.Drawing.Font("Showcard Gothic", 20F);
            this.labelTabHero.Location = new System.Drawing.Point(471, 23);
            this.labelTabHero.Name = "labelTabHero";
            this.labelTabHero.Size = new System.Drawing.Size(241, 33);
            this.labelTabHero.TabIndex = 13;
            this.labelTabHero.Text = "Table des héros";
            // 
            // labelTabSacoche
            // 
            this.labelTabSacoche.AutoSize = true;
            this.labelTabSacoche.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTabSacoche.Location = new System.Drawing.Point(471, 450);
            this.labelTabSacoche.Name = "labelTabSacoche";
            this.labelTabSacoche.Size = new System.Drawing.Size(255, 33);
            this.labelTabSacoche.TabIndex = 14;
            this.labelTabSacoche.Text = "Sacoche du Héro";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1884, 946);
            this.Controls.Add(this.labelTabSacoche);
            this.Controls.Add(this.labelTabHero);
            this.Controls.Add(this.buttonDelObj);
            this.Controls.Add(this.buttonUpdateObj);
            this.Controls.Add(this.buttonAddObj);
            this.Controls.Add(this.buttonDelHero);
            this.Controls.Add(this.buttonUpdateHero);
            this.Controls.Add(this.buttonAddHero);
            this.Controls.Add(this.dataGridViewSacoche);
            this.Controls.Add(this.dataGridViewHero);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLvl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPuissance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNbMissionReussi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownReputation)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLvlObj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantiteObj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSacoche)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gUILDEHERODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gUILDEHERODataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sacocheBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Label labelPrenom;
        private System.Windows.Forms.Label labelSpecialite;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelClassHero;
        private System.Windows.Forms.Label labelLvl;
        private System.Windows.Forms.Label labelPuissance;
        private System.Windows.Forms.Label labelNbMissionReussi;
        private System.Windows.Forms.Label labelReputation;
        private System.Windows.Forms.Label labelNomObj;
        private System.Windows.Forms.Label labelLvlObjet;
        private System.Windows.Forms.Label labelQuantiteObj;
        private System.Windows.Forms.Label labelDessc;
        private System.Windows.Forms.Label labelPrix;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.TextBox textBoxPrenom;
        private System.Windows.Forms.TextBox textBoxSpecialite;
        private System.Windows.Forms.TextBox textBoxClassHero;
        private System.Windows.Forms.NumericUpDown numericUpDownLvl;
        private System.Windows.Forms.NumericUpDown numericUpDownPuissance;
        private System.Windows.Forms.NumericUpDown numericUpDownNbMissionReussi;
        private System.Windows.Forms.NumericUpDown numericUpDownReputation;
        private System.Windows.Forms.TextBox textBoxNomObj;
        private System.Windows.Forms.TextBox textBoxDesc;
        private System.Windows.Forms.NumericUpDown numericUpDownLvlObj;
        private System.Windows.Forms.NumericUpDown numericUpDownQuantiteObj;
        private System.Windows.Forms.NumericUpDown numericUpDownPrix;
        private System.Windows.Forms.DataGridView dataGridViewHero;
        private System.Windows.Forms.DataGridView dataGridViewSacoche;
        private System.Windows.Forms.Button buttonAddHero;
        private System.Windows.Forms.Button buttonUpdateHero;
        private System.Windows.Forms.Button buttonDelHero;
        private System.Windows.Forms.Button buttonAddObj;
        private System.Windows.Forms.Button buttonUpdateObj;
        private System.Windows.Forms.Button buttonDelObj;
        private GUILDEHERODataSet gUILDEHERODataSet;
        private System.Windows.Forms.BindingSource heroBindingSource;
        private GUILDEHERODataSetTableAdapters.HeroTableAdapter heroTableAdapter;
        private GUILDEHERODataSet1 gUILDEHERODataSet1;
        private System.Windows.Forms.BindingSource sacocheBindingSource;
        private GUILDEHERODataSet1TableAdapters.SacocheTableAdapter sacocheTableAdapter;
        private System.Windows.Forms.Label labelTabHero;
        private System.Windows.Forms.Label labelTabSacoche;
    }
}

