/*
 * This file is part of the Buildings and Habitats object Model (BHoM)
 * Copyright (c) 2015 - 2020, the respective contributors. All rights reserved.
 *
 * Each contributor holds copyright over their respective contributions.
 * The project versioning (Git) records all such contribution source information.
 *                                           
 *                                                                              
 * The BHoM is free software: you can redistribute it and/or modify         
 * it under the terms of the GNU Lesser General Public License as published by  
 * the Free Software Foundation, either version 3.0 of the License, or          
 * (at your option) any later version.                                          
 *                                                                              
 * The BHoM is distributed in the hope that it will be useful,              
 * but WITHOUT ANY WARRANTY; without even the implied warranty of               
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the                 
 * GNU Lesser General Public License for more details.                          
 *                                                                            
 * You should have received a copy of the GNU Lesser General Public License     
 * along with this code. If not, see <https://www.gnu.org/licenses/lgpl-3.0.html>.      
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BH.oM.Base;
using BH.oM.Geometry;
using BH.oM.Quantities.Attributes;
using System.ComponentModel;

namespace BH.oM.Physical.Materials
{
    [Description("An object which defines a collection of materials and their ratios.")]
    public class MaterialComposition : BHoMObject, IPhysical, IImmutable
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/

        [Description("The materials in the MaterialComposition, their order in the list is related to the order of the ratios.")]
        public IReadOnlyList<Material> Materials { get; } = new List<Material>();

        [Ratio]
        [Description("The ratios of the Materials, the sum of which equals one")]
        public IReadOnlyList<double> Ratios { get; } = new List<double>();


        /***************************************************/
        /**** Constructors                              ****/
        /***************************************************/

        [Description("The base constructor for MaterialComposition, assigns the properties to the read-only lists.")]
        public MaterialComposition(IEnumerable<Material> materials, IEnumerable<double> ratios)
        {
            if (materials == null || ratios == null)
            {
                throw new ArgumentNullException();
            }
            else if (materials.Count() == ratios.Count())
            {
                throw new Exception("MaterialComposition requires equal length list input");
            }
            else if (Math.Abs(1 - ratios.Sum()) > Tolerance.Distance)
            {
                throw new Exception("MaterialComposition requires its ratios sum to equal 1");
            }
            else
            {
                Materials = materials.ToList();
                Ratios = ratios.ToList();
            }
        }

        /***************************************************/
        /**** Explicit Casting                          ****/
        /***************************************************/

        public static explicit operator MaterialComposition(Material material)
        {
            return new MaterialComposition(new List<Material>() { material }, new double[] { 1 });
        }

        /***************************************************/

    }
}

