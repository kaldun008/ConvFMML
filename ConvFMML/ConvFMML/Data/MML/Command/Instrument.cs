﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvFMML.Data.MML.Command
{
    public abstract class Instrument : ControlCommand
    {
        protected Instrument(int value, MMLCommandRelation relation) : base(value, relation) { }

        protected abstract override string GenerateString(Settings settings, SoundModule module);
    }
}
