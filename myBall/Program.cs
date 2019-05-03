using System;

namespace myBall
{
    class Ball
    {
        // Instance variables
        private Color color;
        private float radius;
        public int TimesThrown { get; private set; } = 0;

        // Constructors
        public Ball(Color color, float radius)
        {
            this.color = color;
            this.radius = radius;
        }

        // Operational methods this si a bit borin help
        public void Pop()
        {
            radius = 0;
        }

        public void Throw()
        {
            if (radius > 0)
            {
                TimesThrown++;
            }
        }

    }
    class Color
    {
        // Instance variables
        public byte Red { get; set; }
        public byte Green { get; set; }
        public byte Blue { get; set; }
        public byte Alpha { get; set; }

        public byte Grayscale => (byte)((Red + Green + Blue) / 3);

        // Constructors
        public Color(byte red, byte green, byte blue, byte alpha)
        {
            Red = red;
            Green = green;
            Blue = blue;
            Alpha = alpha;
        }

        public Color(byte red, byte green, byte blue)
        {
            Red = red;
            Green = green;
            Blue = blue;
            Alpha = 255;
        }
    }
}
