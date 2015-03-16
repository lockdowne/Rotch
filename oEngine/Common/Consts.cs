﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace oEngine.Common
{
    public static class Consts
    {
        public static class OscPaths
        {
            public static readonly string MainDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Osc\Game";
            public static readonly string ExceptionLog = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Osc\Game\Log.txt";
            public static readonly string EditorSettings = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Osc\Game\EditorSettings.xml";
        }

        public static class Repositories
        {
            public static readonly string Scenes = "Scenes.xml";
            public static readonly string Characters = "Characters.xml";
        }

        public static class Nodes
        {
            public const string Scene = "Scene";
            public const string Character = "Character";            
        }


        public const int MaxSounds = 16;
        public const int LogWidth = 128;
    }
}
