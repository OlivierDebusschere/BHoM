﻿using BH.oM.Geometry.Curve;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BH.oM.Geometry.Surface
{
    public interface ISurface : IBHoMGeometry
    {
        List<ICurve> GetExternalEdges();

        List<ICurve> GetInternalEdges();
    }
}
