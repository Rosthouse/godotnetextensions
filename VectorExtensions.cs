

using Godot;

public static class VectorExtensions
{

  public static Vector2I RountToInt(this Vector2 v)
  {
    return new Vector2I(Mathf.RoundToInt(v.X), Mathf.RoundToInt(v.Y));
  }
}