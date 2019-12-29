using Ryujinx.Graphics.GAL;

namespace Ryujinx.Graphics.Gpu.Image
{
    enum TextureComponent
    {
        Zero  = 0,
        Red   = 2,
        Green = 3,
        Blue  = 4,
        Alpha = 5,
        OneSI = 6,
        OneF  = 7
    }

    static class TextureComponentConverter
    {
        public static SwizzleComponent Convert(this TextureComponent component)
        {
            switch (component)
            {
                case TextureComponent.Zero:  return SwizzleComponent.Zero;
                case TextureComponent.Red:   return SwizzleComponent.Red;
                case TextureComponent.Green: return SwizzleComponent.Green;
                case TextureComponent.Blue:  return SwizzleComponent.Blue;
                case TextureComponent.Alpha: return SwizzleComponent.Alpha;
                case TextureComponent.OneSI:
                case TextureComponent.OneF:
                    return SwizzleComponent.One;
            }

            return SwizzleComponent.Zero;
        }
    }
}