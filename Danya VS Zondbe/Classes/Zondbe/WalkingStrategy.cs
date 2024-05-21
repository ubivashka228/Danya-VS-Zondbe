using System.Drawing;

namespace Danya_VS_Zondbe
{
    public abstract class WalkingStrategy
    {
        public abstract Point Move(Point playerPosition, Point zondbePosition, int movement);
    }

    public class SimpleWalkingStrategy : WalkingStrategy
    {
        public override Point Move(Point playerPosition, Point zondbePosition, int movement)
        {
            var direction = new Vector((playerPosition.X - zondbePosition.X), (playerPosition.Y - zondbePosition.Y));
            var shift = new Vector(movement, 0).Rotate(direction.Angle);
            return new Point((int)shift.X + zondbePosition.X, (int)shift.Y + zondbePosition.Y);
        }
    }

    public class ShooterWalkingStrategy : WalkingStrategy
    {
        public override Point Move(Point playerPosition, Point zondbePosition, int movement)
        {
            const int shootRange = 500;
            var direction = new Vector((playerPosition.X - zondbePosition.X), (playerPosition.Y - zondbePosition.Y));
            if (direction.Length < shootRange) return zondbePosition;
        
            var shift = new Vector(movement, 0).Rotate(direction.Angle);
            return new Point((int)shift.X + zondbePosition.X, (int)shift.Y + zondbePosition.Y);
        }
    }
}