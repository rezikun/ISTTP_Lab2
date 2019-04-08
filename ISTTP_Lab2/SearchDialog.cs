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
    public partial class SearchDialog : Form
    {
        private FCDataEF.DBFClubsEntities ctx_club;
        BindingSource source;
        public SearchDialog(BindingSource clubSource)
        {
            InitializeComponent();
            ctx_club = new FCDataEF.DBFClubsEntities();
            source = clubSource;
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            ctx_club.Dispose();
            ctx_club = new FCDataEF.DBFClubsEntities();
            var query = (from c in ctx_club.Clubs select c);
            if (!String.IsNullOrWhiteSpace(ClubNameTB.Text))
            {
                query = query.Where(c => c.ClubName.Contains(ClubNameTB.Text));
            }
            if (!String.IsNullOrWhiteSpace(DescriptionTB.Text))
            {
                query = query.Where(c => c.Description.Contains(DescriptionTB.Text));
            }
            if (minTrackBar.Value < maxTrackBar.Value)
            {
                query = query.Where(c => c.YearOfFoundation > minTrackBar.Value && c.YearOfFoundation < maxTrackBar.Value);
            }
            query.Load();
            source.DataSource = ctx_club.Clubs.Local.ToBindingList();

        }
    }
}
