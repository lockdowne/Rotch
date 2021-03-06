﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Osc.Rotch.Engine.Common;

namespace Osc.Rotch.Engine.Controls
{
    public class Button : Control
    {
        /// <summary>
        /// Occurs when the control is clicked
        /// HandleClick must be listened to in update loop
        /// </summary>
        public event Action Clicked;

        /// <summary>
        /// Gets or sets the controls text
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// Gets or sets the controls texture
        /// </summary>
        public Texture2D Texture { get; set; }

        /// <summary>
        /// Gets or sets the controls font
        /// </summary>
        public SpriteFont Font { get; set; }

        /// <summary>
        /// Gets or sets the color of the text
        /// </summary>
        public Color TextColor { get; set; }

        /// <summary>
        /// Gets or sets the cameras linear interpoliation amount
        /// </summary>
        public float LerpAmount { get; set; }

        /// <summary>
        /// Gets or Sets whether or not the control will be drawn and updated
        /// </summary>
        public bool IsActive { get; set; }

        /// <summary>
        /// Checks if point is within bounds of control
        /// Triggers event when true
        /// </summary>
        /// <param name="point"></param>
        /// <returns></returns>
        public bool HandleClick(Vector2 point)
        {
            if (Bounds.Intersects(point.ToRectangle()) && IsActive)
            {
                OnClick();

                return true;
            }

            return false;
        }

        /// <summary>
        /// Checks if point is within bounds of control
        /// Does not trigger event when true
        /// </summary>
        /// <param name="point"></param>
        /// <returns></returns>
        public bool HandleEntered(Vector2 point)
        {
            return Bounds.Intersects(point.ToRectangle());
        }

        /// <summary>
        /// Draw button
        /// </summary>
        /// <param name="spriteBatch"></param>
        public override void Draw(SpriteBatch spriteBatch)
        {
            if (!IsActive)
                return;

            if (Texture != null)
                spriteBatch.Draw(Texture, Bounds, null, Tint * Alpha, Rotation, Vector2.Zero, SpriteEffects.None, 0.0f);

            if (Font != null)
                spriteBatch.DrawString(Font, Text, Position, TextColor * Alpha);
        }


        private void OnClick()
        {
            if (Clicked != null)
                Clicked();
        }

        public void UpdatePosition(Vector2 position, Vector2 min, Vector2 max)
        {
            if (LerpAmount != 0)
                Position = Vector2.Clamp(new Vector2((int)Vector2.Lerp(Position, position, LerpAmount).X, (int)Vector2.Lerp(Position, position, LerpAmount).Y), min, max);

        }
    }
}
