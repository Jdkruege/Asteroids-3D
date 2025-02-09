﻿using BEPUphysics.Entities;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Asteroids
{
    class Asteroid
    {
        private Drawable _drawObj;
        public Entity entity;
        public enum Size { Large, Medium, Small };
        public Size size;

        public Asteroid(Game game, Size size, Entity e,  Model model, Texture2D texture)
        {
            _drawObj = new Drawable(game, model, texture);
            entity = e;
            this.size = size;
        }

        public void Draw(Matrix viewMat)
        {
            Matrix worldMat = MatrixHelpers.MatrixToMatrix(entity.WorldTransform);

            _drawObj.Draw(worldMat, viewMat);
        }
    }
}
