using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;


namespace Collisions_with_Circular_Hitboxes
{
    struct Circle
    {
        // Center of the circle used for collision
        public Vector2 Center { get; set; }

        // Radius of the circle
        public float Radius { get; set; }

        public Circle(Vector2 center, float radius)
        {
            Center = center;
            Radius = radius;
        }


        // Will return true if a circle contains 'point'
        public bool Contains(Vector2 point)
        {
            return ((point - Center).Length() <= Radius);
        }


        // Will return True if a circle contains 'other'
        public bool Contains(Circle other)
        {
            return ((other.Center - Center).Length() < (other.Radius - Radius));
        }

        // Will return true if there is any overlab between two circles
        public bool Intersects(Circle other)
        {
            return ((other.Center - Center).Length() < (other.Radius + Radius));
        }


        //
        // These two properties can be passed to the Spritebatch Draw() method when specifying the location so that a texture will be drawn in the right spot
        //

        // Rectangle of top left bound for drawing the texture scaled to fit a size based on the radius
        public Rectangle DrawRect
        {
            get
            {
                return new Rectangle((int)(Center.X - Radius), (int)(Center.Y - Radius), (int)Radius * 2, (int)Radius * 2);
            }
        }

        // Vector2 of the top left bound for drawing.  When drawn the size will be that of the texture,
        // not necessarily the collision circle.
        public Vector2 DrawLocation
        {
            get
            {
                return new Vector2(Center.X - Radius, Center.Y - Radius);
            }
        }



    }
}
