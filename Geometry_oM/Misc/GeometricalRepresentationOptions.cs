/*
 * This file is part of the Buildings and Habitats object Model (BHoM)
 * Copyright (c) 2015 - 2021, the respective contributors. All rights reserved.
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

using BH.oM.Base;
using System.ComponentModel;

namespace BH.oM.Geometry
{
    public class GeometricalRepresentationOptions : IRepresentationOptions
    {
        [Description("Scale of the Geometrical representation. E.g. for a Point, the scale of the resulting sphere.")]
        public virtual int Scale { get; set; } = 1;

        [Description("Cap 1D elements, if applicable.\nE.g. for a Line, this caps the computed Pipe.\nFor discipline-specific objects, it may e.g. cap the Extrusions of their cross section.")]
        public virtual bool Cap1DElements { get; set; } = false;
    }
}

