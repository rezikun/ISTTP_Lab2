using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;


namespace ISTTP_Lab2
{
    public partial class DBUIForm : Form
    {
        private FCDataEF.DBFClubsEntities ctx;
        public DBUIForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            ctx = new FCDataEF.DBFClubsEntities();
            ctx.Clubs.Load();
            clubBindingSource.DataSource = ctx.Clubs.Local.ToBindingList();
            ctx.Leagues.Load();
            leagueBindingSource.DataSource = ctx.Leagues.Local.ToBindingList();
            ctx.Titles.Load();
            titleBindingSource.DataSource = ctx.Titles.Local.ToBindingList();
            ctx.Contracts.Load();
            contractBindingSource.DataSource = ctx.Contracts.Local.ToBindingList();
            ctx.Federations.Load();
            federationBindingSource.DataSource = ctx.Federations.Local.ToBindingList();
            ctx.Countries.Load();
            countryBindingSource.DataSource = ctx.Countries.Local.ToBindingList();
            ctx.Players.Load();
            playerBindingSource.DataSource = ctx.Players.Local.ToBindingList();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            ctx.Dispose();
        }

        private void DBUIForm_Load(object sender, EventArgs e)
        {

        }

        private void saveClubBtn_Click(object sender, EventArgs e)
        {
            ctx.SaveChanges();
        }

        private void deleteClubBtn_Click(object sender, EventArgs e)
        {
            try
            {
                
                FCDataEF.Club club = (FCDataEF.Club)dGVClubs.CurrentRow.DataBoundItem;
                var b = (from c in ctx.Contracts where c.ClubID == club.ClubID select c).Any();
                if (b)
                {
                    MessageBox.Show("Can't delete the club", "Has Contract");
                }
                else
                {
                    clubBindingSource.RemoveCurrent();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Failed deleting the row", "Error");
                throw;
            }
        }

        private void dGVClubs_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void playersSaveBtn_Click(object sender, EventArgs e)
        {
            ctx.SaveChanges();
        }

        private void titlesSaveBtn_Click(object sender, EventArgs e)
        {
            ctx.SaveChanges();
        }

        private void leaguesSaveBtn_Click(object sender, EventArgs e)
        {
            ctx.SaveChanges();
        }

        private void playersDeleteBtn_Click(object sender, EventArgs e)
        {
            playerBindingSource.RemoveCurrent();
        }

        private void titlesDeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {

                FCDataEF.Title title = (FCDataEF.Title)dGVTitles.CurrentRow.DataBoundItem;
                var b = (from c in ctx.ClubHasTitles where c.TitleID == title.TitleID select c).Any();
                var d = (from c in ctx.PlayerHasTitles where c.TitleID == title.TitleID select c).Any();
                if (b)
                {
                    MessageBox.Show("Can't delete the title", "A club has it");
                }
                else
                {
                    if (d)
                    {
                        MessageBox.Show("Can't delete the title", "A player has it");
                    }
                    else
                    {
                        titleBindingSource.RemoveCurrent();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Failed deleting the row", "Error");
                throw;
            }
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void clubsSearchBtn_Click_2(object sender, EventArgs e)
        {
            SearchDialog searchDialog = new SearchDialog(clubBindingSource);
            searchDialog.ShowDialog();
        }
    }
}
