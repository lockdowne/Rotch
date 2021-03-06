﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Osc.Rotch.Engine.Common
{
    public class Enums
    {
        public enum WorldNodeTypes
        {
            Populated,
            Cleared,
            Uncleared,
            Unexplored,
        }

        public enum TileTypes
        {
            None,
            Passable,
            Impassable,
        }

        /// <summary>
        /// Enum describes the screen transition state.
        /// </summary>
        public enum ScreenState
        {
            TransitionOn,
            Active,
            TransitionOff,
            Hidden,
        }



        /// <summary>
        /// Enum describes entity types in oEditor
        /// </summary>
        public enum EntityTypes
        {
            Characters,
            Items,
            Quests,
            Tilemaps,
            Nodes,
            BattleScenes,
            FreeRoamScenes,
            RandomBattleScenes,
        }

        public enum PlacementTypes
        {
            None,
            Player,
            Enemy,
            Ally,
            Neutral,
        }

        public enum SelectionModes
        {
            Orthogonal,
            Isometric,
        }

        public enum LogTypes
        {
            Error,
            Debug,
            Info,
        }

        public enum TilemapStates
        {
            Selection,
            Draw,
            Fill,
            Erase,
            Collision,
            HeightMap,
        }

        public enum BattleScreenSequences
        {
            Placement,
            Battle,
        }

        public enum BattlePhases
        {
            Selecting,
            Targetting,
            Confirming,
        }

        public enum CurrentOperation
        {
            Move,
            Action,
            Wait,
        }
    }
}
