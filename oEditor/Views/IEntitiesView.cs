﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.WinControls.UI;

namespace oEditor.Views
{
    public interface IEntitiesView
    {
        RadTreeNode SelectedNode { get; set; }

        RadTreeNodeCollection NodeCollection { get; }

        event Action AddEntityClicked;
        event Action DeleteEntityClicked;
        event Action EditEntityClicked;
        event Action NodeDoubleClicked;
    }
}