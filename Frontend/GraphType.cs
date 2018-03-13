﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frontend
{
    public enum GraphType
    {
        Frametimes,
        Misses,
        Reprojections,
        FrameDetail
    }

    public enum Metric
    {
        MissedFrames,
        AvgFPS,
        AvgFrameTimes,
        AvgReprojections,
        NinetyninthPerc
    }
}
