﻿using Osc.Rotch.Editor.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osc.Rotch.Editor.Controllers
{
    public class ProjectController : IProjectController
    {
        private readonly IProjectView view;

        public ProjectController(IProjectView projectView)
        {
            this.view = projectView;
        }
    }
}
