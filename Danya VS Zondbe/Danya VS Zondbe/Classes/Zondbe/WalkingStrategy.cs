namespace Danya_VS_Zondbe;

public abstract class WalkingStrategy
{
    public abstract Point Move(Point playerPosition, Point zondbePosition, int movement);
}

public class SimpleWalkingStrategy : WalkingStrategy
{
    public override Point Move(Point playerPosition, Point zondbePosition, int movement)
    {
        var direction = new Vector((playerPosition - zondbePosition).X, (playerPosition - zondbePosition).Y);
        var shift = new Vector(movement, 0).Rotate(direction.Angle);
        return zondbePosition + new Point((int)shift.X, (int)shift.Y);
    }
}

public class ShooterWalkingStrategy : WalkingStrategy
{
    public override Point Move(Point playerPosition, Point zondbePosition, int movement)
    {
        const int shootRange = 400;
        var direction = new Vector((playerPosition - zondbePosition).X, (playerPosition - zondbePosition).Y);
        if (direction.Length < shootRange) return new Point(0, 0);
        
        var shift = new Vector(movement, 0).Rotate(direction.Angle);
        return zondbePosition + new Point((int)shift.X, (int)shift.Y);
        throw new NotImplementedException();
    }
}