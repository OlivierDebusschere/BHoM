﻿using System.Collections.Generic;
using BH.oM.Base;

namespace BH.oM.Structural.Loads
{

    /// <summary>
    /// Nodal load class. Use NodalLoad() to construct an empty instance, then use the Set methods to set forces, moments etc. A second
    /// constructor allows for a default force and moment nodal load instance.
    /// </summary>
    public abstract class Load<T> : BHoMObject, ILoad where T : IObject
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/

        public Loadcase Loadcase { get; set; }

        public List<T> Objects { get; set; } = new List<T>();

        public LoadAxis Axis { get; set; } = LoadAxis.Global;

        public bool Projected { get; set; } = false;


        /***************************************************/
    }
}






