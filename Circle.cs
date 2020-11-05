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

        // Vector of top left bound for drawing the texture
        public Vector2 DrawLocation
        {
            get
            {
                return new Vector2(Center.X - Radius, Center.Y - Radius);
            }
        }

        public Circle(Vector2 center, float radius)
        {
            Center = center;
            Radius = radius;
        }

        public bool Contains(Vector2 point)
        {
            return ((point - Center).Length() <= Radius);
        }

        public bool Intersects(Circle other)
        {
            return ((other.Center - Center).Length() < (other.Radius - Radius));
        }

    }
}
