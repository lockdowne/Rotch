﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using Telerik.WinControls.UI.Docking;

namespace oEditor.Events
{
    public class OnTilemapMouseDown
    {
        public MouseEventArgs MouseEvent { get; set; }
    }

    public class OnTilemapMouseUp
    {
        public MouseEventArgs MouseEvent { get; set; }
    }

    public class OnTilemapMouseMove
    {
        public MouseEventArgs MouseEvent { get; set; }
    }

    public class OnTilemapMouseWheel
    {
        public MouseEventArgs MouseEvent { get; set; }
    }

    public class OnAddTilemapLayer
    {
        public EventArgs Args { get; set; }
    }

    public class OnRemoveTilemapLayer
    {
        public ListViewDataItem Item { get; set; }
    }

    public class OnMoveTilemapLayerUp
    {
        public ListViewDataItem Item { get; set; }
    }

    public class OnMoveTilemapLayerDown
    {
        public ListViewDataItem Item { get; set; }
    }
       
    public class OnMergeLayer
    {
        public ListViewDataItem Item1 { get; set; }
        public ListViewDataItem Item2 { get; set; }
    }

    public class OnRenameTilemapLayer
    {
        public ListViewDataItem Item { get; set; }
    }

    public class OnTilemapDocumentChanged
    {
        public DockWindow Window { get; set; }
    }

    public class OnTilemapSelectionBoxClicked
    {
        
    }

    public class OnTilemapDrawClicked
    {

    }

    public class OnTilemapFillClicked
    {

    }

    public class OnTilemapEraseClicked
    {

    }

    public class OnTilemapCollisionClicked
    {

    }

    public class OnTilemapCopyClicked
    {

    }

    public class OnTilemapCutClicked
    {

    }

    public class OnTilemapPropertiesClicked
    {

    }

    public class OnTilemapGridClicked
    {

    }
}
