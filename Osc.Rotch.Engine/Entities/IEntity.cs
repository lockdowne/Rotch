﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osc.Rotch.Engine.Entities
{
    public interface IEntity
    {
        /// <summary>
        /// Gets or sets the unique ID of entity
        /// </summary>
        Guid ID { get; set; }

        /// <summary>
        /// Gets or sets the name of entity
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Gets or sets the description of Entity
        /// </summary>
        string Description { get; set; }
    }
}
