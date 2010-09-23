﻿namespace RedBadger.Xpf.Adapters.Xna
{
    using RedBadger.Xpf.Graphics;
    using RedBadger.Xpf.Media;

    internal struct SpriteFontJob : ISpriteJob
    {
        private readonly Brush brush;

        private readonly Vector position;

        private readonly ISpriteFont spriteFont;

        private readonly string text;

        public SpriteFontJob(ISpriteFont spriteFont, string text, Vector position, Brush brush)
        {
            this.spriteFont = spriteFont;
            this.text = text;
            this.position = position;
            this.brush = brush;
        }

        public void Draw(ISpriteBatch spriteBatch, Vector offset)
        {
            var solidColorBrush = this.brush as SolidColorBrush;
            spriteBatch.DrawString(
                this.spriteFont, 
                this.text, 
                this.position + offset, 
                solidColorBrush != null ? solidColorBrush.Color : Colors.Magenta);
        }
    }
}