/*
 * This file is part of the Buildings and Habitats object Model (BHoM)
 * Copyright (c) 2015 - 2019, the respective contributors. All rights reserved.
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
using BH.oM.Graphics.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BH.oM.Graphics.Components
{
    public class Container : BHoMObject, IComponent
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/

        public virtual Dataset Dataset { get; set; } = null;
        public virtual List<IComponent> Children { get; set; } = new List<IComponent>();

        public virtual double X { get; set; } = 0;

        public virtual double Y { get; set; } = 0;

        public virtual double Width { get; set; } = 0;

        public virtual double Height { get; set; } = 0;

        public virtual double Opacity { get; set; } = 1.0;

        /***************************************************/
    }
}
