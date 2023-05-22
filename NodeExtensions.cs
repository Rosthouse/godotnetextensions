

using Godot;

public static class NodeExtensions
{
  public static Godot.Collections.Array<T> GetChildren<[MustBeVariant] T>(this Node n, bool includeInternal = false) where T : Node
  {
    var arr = new Godot.Collections.Array<T>();
    foreach (var c in n.GetChildren(includeInternal))
    {
      if (c is T t)
      {
        arr.Add(t);
      }
    }
    return arr;
  }

  public static bool HasChild<[MustBeVariant] T>(this Node n, bool includeInternal = false) where T : Node
  {
    foreach (var c in n.GetChildren(includeInternal))
    {
      if (c is T)
      {
        return true;
      }
    }
    return false;
  }
}