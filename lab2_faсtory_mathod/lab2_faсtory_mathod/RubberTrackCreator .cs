using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_faсtory_mathod
{
    public class RubberTrackCreator : TrackCreator
    {
        public override ITrack CreateTrack() => new RubberTrack();
    }
}
