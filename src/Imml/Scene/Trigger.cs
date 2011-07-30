﻿//-----------------------------------------------------------------------
//VastPark is a lightweight extensible virtual world platform 
//and this file is a program released under the GPL.
//Copyright (C) 2009 VastPark
//This program is free software; you can redistribute it and/or
//modify it under the terms of the GNU General Public License
//as published by the Free Software Foundation; either version 2
//of the License, or (at your option) any later version.
//This program is distributed in the hope that it will be useful,
//but WITHOUT ANY WARRANTY; without even the implied warranty of
//MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
//GNU General Public License for more details.
//You should have received a copy of the GNU General Public License
//along with this program; if not, write to the Free Software
//Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA 02110-1301, USA.
//-----------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Imml.Scene
{
    /// <summary>
    /// Provides hooks between events and the logic to execute when an event is invoked.
    /// </summary>
    public class Trigger : ImmlElement
    {
        /// <summary>
        /// Type of event the trigger is associated with
        /// </summary>
        public virtual EventType Event { get; set; }

        /// <summary>
        /// Name of target triggerable element
        /// </summary>
        public virtual string Target { get; set; }

        /// <summary>
        /// When true, events that cause the trigger to invoke should be executed
        /// </summary>
        public virtual bool Enabled { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Trigger"/> class.
        /// </summary>
        public Trigger()
        {
            this.Enabled = true;
        }
    }
}
