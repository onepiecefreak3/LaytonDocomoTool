﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic.Domain.MidiManagement.Contract.DataClasses.Events;

namespace Logic.Domain.MidiManagement.Contract.DataClasses.Events.Midi
{
    public sealed class MidiTrackControllerEventData : MidiTrackMidiEventData
    {
        public int Controller { get; set; }
        public int Value { get; set; }
    }
}
