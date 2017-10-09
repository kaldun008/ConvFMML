﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConvFMML.Data.Intermediate.Event;
using ConvFMML.Data.MML.Command.MXDRV;

namespace ConvFMML.Modifier
{
    public class MXDRVMusicDataModifier : MusicDataModifier
    {
        protected override ChangeEventSet CreateInstrumentSet(Instrument i)
        {
            return new ChangeEventSet(i, new MXDRVInstrument((i.Value + 1), MMLCommandRelation.Clear));
        }

        protected override ChangeEventSet CreatePanSet(Pan p)
        {
            return new ChangeEventSet(p, new MXDRVPan(p.Value, MMLCommandRelation.Clear));
        }

        protected override TempoSet CreateTempoSet(Tempo t)
        {
            return new TempoSet(t, new MXDRVTempo(t.Value, MMLCommandRelation.Clear));
        }

        protected override ChangeEventSet CreateVolumeSet(Volume v)
        {
            return new ChangeEventSet(v, new MXDRVVolume(v.Value, MMLCommandRelation.Clear));
        }
    }
}
