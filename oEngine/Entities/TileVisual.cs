﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace oEngine.Entities
{
    public class TileVisual : ITile
    {
        /// <summary>
        /// Gets or sets the unique ID of entity
        /// NOTE: Unused for tile, since tiles are identified by their location in the layer
        /// </summary>
        public Guid ID { get; set; }

        /// <summary>
        /// Gets or sets the name of entity
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the description of Entity
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Name of tileset tile should be drawn from
        /// </summary>
        public string TilesetName { get; set; }

        /// <summary>
        /// Gets or sets the location of the tileset to draw based off of tile dimensions compared to the tileset image
        /// </summary>
        public int TilesetIndex { get; set; }

        /// <summary>
        /// Gets or sets the height of tile represented in tilemap 
        /// Does not represent height in pixels
        /// </summary>
        public float Height { get; set; }


    }
}