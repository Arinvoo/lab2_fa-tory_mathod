using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2_faсtory_mathod
{
    public partial class MainForm : Form
    {
        private TrackCreator _trackCreator;

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnCreateRubberTrack_Click(object sender, EventArgs e)
        {
            _trackCreator = new RubberTrackCreator();
            ITrack track = _trackCreator.CreateTrack();
            lblTrackType.Text = $"Track: {track.GetTrackType()}";
        }

        private void btnCreatePlasticTrack_Click(object sender, EventArgs e)
        {
            _trackCreator = new PlasticTrackCreator();
            ITrack track = _trackCreator.CreateTrack();
            lblTrackType.Text = $"Track: {track.GetTrackType()}";
        }
    }
}
