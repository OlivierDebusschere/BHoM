﻿using BH.oM.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BH.oM.Analytical.Fragments
{
    public class InputsFragment : IDependencyFragment
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/
        public virtual List<Guid> Inputs { get; set; } = new List<Guid>();
        /***************************************************/
    }
}