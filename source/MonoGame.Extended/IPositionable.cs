using Microsoft.Xna.Framework;

namespace MonoGame.Extended
{
    public interface IPositionable
    {
        Vector2 Position { get; set; }
    }

    public interface IMovable : IPositionable
    {
        public float Speed { get; }
        public void Move(Vector2 direction);
    }
}
