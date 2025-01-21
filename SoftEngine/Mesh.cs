using System.Numerics;

namespace SoftEngine;

public class Mesh
{
    public String Name { get; set; }
    public Vector3[] Vertices { get; set; }
    public Vector3 Position { get; set; }
    public Vector3 Rotation { get; set; }

    public Mesh(String name, int verticesCount)
    { 
        Vertices = new Vector3[verticesCount];
        Name = name;
    }
}