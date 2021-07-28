using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppHero
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gUILDEHERODataSet1.Sacoche'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            //this.sacocheTableAdapter.Fill(this.gUILDEHERODataSet1.Sacoche);
            // TODO: cette ligne de code charge les données dans la table 'gUILDEHERODataSet.Hero'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            //this.heroTableAdapter.Fill(this.gUILDEHERODataSet.Hero);

            GUILDEHEROEntities entite = new GUILDEHEROEntities();

            List<Hero> listHeros = entite.Hero.ToList();
            dataGridViewHero.DataSource = listHeros;

            labelTabSacoche.Hide();
            tableLayoutPanel2.Hide();
            dataGridViewSacoche.Hide();
            buttonAddObj.Hide();
            buttonDelObj.Hide();
            buttonUpdateObj.Hide();
        }

        private void buttonAddHero_Click(object sender, EventArgs e)
        {
            Hero hero = new Hero();
            hero.nom = textBoxNom.Text;
            hero.prenom = textBoxPrenom.Text;
            hero.specialite = textBoxSpecialite.Text;
            hero.classHero = textBoxClassHero.Text;
            hero.lvl = (int)numericUpDownLvl.Value;
            hero.puissance = (int)numericUpDownPuissance.Value;
            hero.missionReussi = (int)numericUpDownNbMissionReussi.Value;
            hero.reputation = (int)numericUpDownReputation.Value;

            GUILDEHEROEntities entite = new GUILDEHEROEntities();
            entite.Hero.Add(hero);
            entite.SaveChanges();

            this.refreshDataHero();

            viderLesChampsHero();
        }

        private void buttonUpdateHero_Click(object sender, EventArgs e)
        {
            if (dataGridViewHero.Rows.GetRowCount(DataGridViewElementStates.Selected) > 0)
            {
                GUILDEHEROEntities entite = new GUILDEHEROEntities();
                int idHero = int.Parse(dataGridViewHero.SelectedRows[0].Cells[8].Value.ToString());
                Console.WriteLine(idHero);

                Hero heroAUpdate = entite.Hero.Where(a => a.id_hero == idHero).FirstOrDefault();

                heroAUpdate.nom = textBoxNom.Text;
                heroAUpdate.prenom = textBoxPrenom.Text;
                heroAUpdate.specialite = textBoxSpecialite.Text;
                heroAUpdate.classHero = textBoxClassHero.Text;
                heroAUpdate.lvl = (int)numericUpDownLvl.Value;
                heroAUpdate.puissance = (int)numericUpDownPuissance.Value;
                heroAUpdate.missionReussi = (int)numericUpDownNbMissionReussi.Value;
                heroAUpdate.reputation = (int)numericUpDownReputation.Value;

                entite.Hero.AddOrUpdate(heroAUpdate);
                entite.SaveChanges();

                refreshDataHero();
                viderLesChampsHero();
            }
        }

        private void buttonDelHero_Click(object sender, EventArgs e)
        {
            if (dataGridViewHero.Rows.GetRowCount(DataGridViewElementStates.Selected) > 0)
            {
                GUILDEHEROEntities entite = new GUILDEHEROEntities();
                int idHero = int.Parse(dataGridViewHero.SelectedRows[0].Cells[8].Value.ToString());
                Console.WriteLine(idHero);

                List<Sacoche> getSacocheHero = entite.Sacoche.Where(a => a.id_hero == idHero).ToList();

                foreach (Sacoche sacocheDelete in getSacocheHero)
                {
                    entite.Sacoche.Remove(sacocheDelete);
                }

                Hero heroDelete = entite.Hero.Where(a => a.id_hero == idHero).FirstOrDefault();
                entite.Hero.Remove(heroDelete);
                entite.SaveChanges();
                refreshDataHero();
                dataGridViewSacoche.DataSource = null;
                viderLesChampsHero();
                viderLesChampsSacoche();
            }
        }

        private void viderLesChampsHero()
        {
            textBoxNom.Text = "";
            textBoxPrenom.Text = "";
            textBoxSpecialite.Text = "";
            textBoxClassHero.Text = "";
            numericUpDownLvl.Value = 0;
            numericUpDownPrix.Value = 0;
            numericUpDownPuissance.Value = 0;
            numericUpDownNbMissionReussi.Value = 0;
            numericUpDownReputation.Value = 0;
        }

        private void refreshDataHero()
        {
            dataGridViewHero.DataSource = null;
            GUILDEHEROEntities entite = new GUILDEHEROEntities();
            List<Hero> listHeros = entite.Hero.ToList();
            dataGridViewHero.DataSource = listHeros;
        }

        private void buttonAddObj_Click(object sender, EventArgs e)
        {
            GUILDEHEROEntities entite = new GUILDEHEROEntities();
            int idHero = int.Parse(dataGridViewHero.SelectedRows[0].Cells[8].Value.ToString());

            Sacoche sacoche = new Sacoche();

            sacoche.nom = textBoxNomObj.Text;
            sacoche.lvlObj = (int)numericUpDownLvlObj.Value;
            sacoche.quantite = (int)numericUpDownQuantiteObj.Value;
            sacoche.description = textBoxDesc.Text;
            sacoche.prix = (float)numericUpDownPrix.Value;
            sacoche.id_hero = idHero;

            entite.Sacoche.Add(sacoche);
            entite.SaveChanges();

            this.refreshDataSacoche();

            viderLesChampsSacoche();
        }

        private void buttonUpdateObj_Click(object sender, EventArgs e)
        {
            if (dataGridViewSacoche.Rows.GetRowCount(DataGridViewElementStates.Selected) > 0)
            {
                GUILDEHEROEntities entite = new GUILDEHEROEntities();
                int idSacoche = int.Parse(dataGridViewSacoche.SelectedRows[0].Cells[5].Value.ToString());
                Console.WriteLine(idSacoche);

                Sacoche sacocheAUpdate = entite.Sacoche.Where(a => a.id_sacoche == idSacoche).FirstOrDefault();

                sacocheAUpdate.nom = textBoxNomObj.Text;
                sacocheAUpdate.lvlObj = (int)numericUpDownLvlObj.Value;
                sacocheAUpdate.quantite = (int)numericUpDownQuantiteObj.Value;
                sacocheAUpdate.description = textBoxDesc.Text;
                sacocheAUpdate.prix = (float)numericUpDownPrix.Value;

                entite.Sacoche.AddOrUpdate(sacocheAUpdate);
                entite.SaveChanges();

                refreshDataSacoche();
                viderLesChampsSacoche();
            }
        }

        private void buttonDelObj_Click(object sender, EventArgs e)
        {
            if (dataGridViewSacoche.Rows.GetRowCount(DataGridViewElementStates.Selected) > 0)
            {
                GUILDEHEROEntities entite = new GUILDEHEROEntities();
                int idSacoche = int.Parse(dataGridViewSacoche.SelectedRows[0].Cells[5].Value.ToString());
                Console.WriteLine(idSacoche);

                Sacoche sacocheDelete = entite.Sacoche.Where(a => a.id_sacoche == idSacoche).FirstOrDefault();
                entite.Sacoche.Remove(sacocheDelete);
                entite.SaveChanges();
                refreshDataSacoche();
                viderLesChampsSacoche();
            }
        }

        private void viderLesChampsSacoche()
        {
            textBoxNomObj.Text = "";
            numericUpDownLvlObj.Value = 0;
            numericUpDownQuantiteObj.Value = 0;
            textBoxDesc.Text = "";
            numericUpDownPrix.Value = 0;
        }

        private void refreshDataSacoche()
        {
            dataGridViewSacoche.DataSource = null;
            GUILDEHEROEntities entite = new GUILDEHEROEntities();

            int idHero = int.Parse(dataGridViewHero.SelectedRows[0].Cells[8].Value.ToString());

            List<Sacoche> getSacocheHero = entite.Sacoche.Where(a => a.id_hero == idHero).ToList();
            dataGridViewSacoche.DataSource = getSacocheHero;
        }

        // fonction

        private void dataGridViewHero_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewHero.Rows.GetRowCount(DataGridViewElementStates.Selected) > 0)
            {
                textBoxNom.Text = dataGridViewHero.SelectedRows[0].Cells[0].Value.ToString();
                textBoxPrenom.Text = dataGridViewHero.SelectedRows[0].Cells[1].Value.ToString();
                textBoxSpecialite.Text = dataGridViewHero.SelectedRows[0].Cells[2].Value.ToString();
                textBoxClassHero.Text = dataGridViewHero.SelectedRows[0].Cells[3].Value.ToString();
                numericUpDownLvl.Value = decimal.Parse(dataGridViewHero.SelectedRows[0].Cells[4].Value.ToString());
                numericUpDownPuissance.Value = decimal.Parse(dataGridViewHero.SelectedRows[0].Cells[5].Value.ToString());
                numericUpDownNbMissionReussi.Value = decimal.Parse(dataGridViewHero.SelectedRows[0].Cells[6].Value.ToString());
                numericUpDownReputation.Value = decimal.Parse(dataGridViewHero.SelectedRows[0].Cells[7].Value.ToString());

                labelTabSacoche.Show();
                tableLayoutPanel2.Show();
                dataGridViewSacoche.Show();
                buttonAddObj.Show();
                buttonDelObj.Show();
                buttonUpdateObj.Show();

                GUILDEHEROEntities entite = new GUILDEHEROEntities();
                int idHero = int.Parse(dataGridViewHero.SelectedRows[0].Cells[8].Value.ToString());

                List<Sacoche> getSacocheHero = entite.Sacoche.Where(a => a.id_hero == idHero).ToList();
                dataGridViewSacoche.DataSource = getSacocheHero;

                viderLesChampsSacoche();
            }


        }

        private void dataGridViewSacoche_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewSacoche.Rows.GetRowCount(DataGridViewElementStates.Selected) > 0)
            {
                textBoxNomObj.Text = dataGridViewSacoche.SelectedRows[0].Cells[0].Value.ToString();
                numericUpDownLvlObj.Value = decimal.Parse(dataGridViewSacoche.SelectedRows[0].Cells[1].Value.ToString());
                numericUpDownQuantiteObj.Value = decimal.Parse(dataGridViewSacoche.SelectedRows[0].Cells[2].Value.ToString());
                textBoxDesc.Text = dataGridViewSacoche.SelectedRows[0].Cells[3].Value.ToString();
                numericUpDownPrix.Value = decimal.Parse(dataGridViewSacoche.SelectedRows[0].Cells[4].Value.ToString());
            }
        }
    }
}
