using Godot;

//sources https://docs.godotengine.org/cs/4.x/tutorials/physics/ray-casting.html
public partial class CharacterCollisionRayCast : RayCast2D
{
    
    public override void _PhysicsProcess(double delta)
{
    var spaceRid = GetWorld2D().Space;
    var spaceState = PhysicsServer2D.SpaceGetDirectState(spaceRid);
    var query = PhysicsRayQueryParameters2D.Create(Vector2.Zero, new Vector2(50, 100));
    var result = spaceState.IntersectRay(query);
    if (result.Count > 0)
{
    GD.Print("Hit at point: ", result["position"]);
}
}

}
