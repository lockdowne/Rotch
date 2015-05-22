﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using oEngine.Controls;
using oEngine.Common;
using oEngine.Factories;
using oEngine.Screens;



namespace oGame
{
    public class zTestActionMenu : GameScreen
    {
        Texture2D background;
        Rectangle backgroundRectangle;

        public zTestActionMenu()
            :base()
        {
            IsSoftPopup = true;
            TransitionOnTime = TimeSpan.FromSeconds(0);
            TransitionOffTime = TimeSpan.FromSeconds(0);
        }

        public override void LoadContent()
        {
            try
            {
                base.LoadContent();
                ContentManager content = new ContentManager(ScreenFactory.Game.Services, "Content");

                background = content.Load<Texture2D>("TestActionMenu");
                backgroundRectangle = new Rectangle((ScreenFactory.TitleSafeArea.Right / 4 * 3), (ScreenFactory.TitleSafeArea.Bottom / 4), background.Width, background.Height);

            }
            catch (Exception exception)
            {
                Logger.Log("ztestActionMenu", "LoadContent", exception);
            }
        }

        public override void HandleInput(oEngine.Inputs.InputState input)
        {
            base.HandleInput(input);

            // is mouse position within Bounds of the Menu
            if (backgroundRectangle.Contains(new Point(Convert.ToInt32(input.Position.X), Convert.ToInt32(input.Position.Y))))
            {

                if (IsSoftPopup && input.LeftClick)
                {
                    IsSoftPopup = false;
                }
                //put controls here
            }
            else
            {
                //release focus
                if (!IsSoftPopup)
                {
                    IsSoftPopup = true;
                }
            }

            if (input.RightClick)
            {
                ExitScreen();
            }


        }

        public override void Update(GameTime gameTime, bool otherScreenHasFocus, bool coveredByOtherScreen)
        {
            base.Update(gameTime, otherScreenHasFocus, coveredByOtherScreen);
        }

        public override void Draw(GameTime gameTime)
        {
            base.Draw(gameTime);

            ScreenFactory.SpriteBatch.Begin();

            ScreenFactory.SpriteBatch.Draw(background, backgroundRectangle, Color.White);

            ScreenFactory.SpriteBatch.End();
        }
    }
}
