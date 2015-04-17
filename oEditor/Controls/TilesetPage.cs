﻿using oEditor.Aggregators;
using oEngine.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.WinControls.UI;

namespace oEditor.Controls
{
    public class TilesetPage : RadPageViewPage
    {
        private readonly IEventAggregator eventAggregator;

        private TilesetRender tilesetRender;

        public Tileset Tileset
        {
            get { return tilesetRender.Tileset; }
            set { tilesetRender.Tileset = value; }
        }

        public TilesetPage(IEventAggregator eventAggregator)
        {
            this.eventAggregator = eventAggregator;

            InitializeComponent();
            
        }

 

        private void InitializeComponent()
        {
            this.tilesetRender = new oEditor.Controls.TilesetRender();
            this.SuspendLayout();
            // 
            // tilesetRender
            // 
            this.tilesetRender.Location = new System.Drawing.Point(0, 0);
            this.tilesetRender.Name = "tilesetRender";
            this.tilesetRender.Size = new System.Drawing.Size(150, 150);
            this.tilesetRender.TabIndex = 0;
            this.tilesetRender.Tileset = null;
            this.tilesetRender.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ResumeLayout(false);
            this.Controls.Add(tilesetRender);

        }
    }
}