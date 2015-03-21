﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI.Docking;
using oEngine.Entities;
using oEngine.Common;

namespace oEditor.Views
{
    public class TilemapView : DocumentWindow, ITabbedView, ITilemapView
    {
        private Controls.TilemapRender tilemapRender;

        // Send over mouse interaction of graphics control to presenter
        public event MouseEventHandler SceneMouseDown;
        public event MouseEventHandler SceneMouseUp;
        public event MouseEventHandler SceneMouseMove;
        public event MouseEventHandler SceneMouseWheel;

        public Guid ID { get; set; }

        public Enums.EditorEntities EntityType { get; set; }

        public Tilemap Tilemap
        {
            get { return tilemapRender.Tilemap; }
            set { tilemapRender.Tilemap = value; }
        }

        public string SceneText
        {
            get { return this.Text; }
            set { this.Text = value; }
        }
    
        public TilemapView()
        {
            this.Text = "Tilemap";

            InitializeComponent();            

            tilemapRender.RenderMouseDown += (sender, e) =>
            {
                if (SceneMouseDown != null)
                    SceneMouseDown(sender, e);
            };

            tilemapRender.RenderMouseUp += (sender, e) =>
            {
                if (SceneMouseUp != null)
                    SceneMouseUp(sender, e);
            };

            tilemapRender.RenderMouseMove += (sender, e) =>
            {
                if (SceneMouseMove != null)
                    SceneMouseMove(sender, e);
            };

            tilemapRender.RenderMouseWheel += (sender, e) =>
            {
                if (SceneMouseWheel != null)
                    SceneMouseWheel(sender, e);
            };

            
            
        }

        private void InitializeComponent()
        {
            this.tilemapRender = new oEditor.Controls.TilemapRender();            
            this.SuspendLayout();
            // 
            // tilemapRender
            // 
            this.tilemapRender.Location = new System.Drawing.Point(0, 0);
            this.tilemapRender.Name = "tilemapRender";
            this.tilemapRender.Size = new System.Drawing.Size(150, 150);
            this.tilemapRender.TabIndex = 0;
            this.tilemapRender.Tilemap = null;
            this.tilemapRender.Dock = DockStyle.Fill;

            this.Controls.Add(tilemapRender);
            this.ResumeLayout(false);

        }

    
    }
}