using System.Numerics;

namespace SoftEngine;

public class Camera
{  
    // Position of Camera Object in the World Space. i.e. Model Matrix of Camera Object
    public Vector3 Position { get; set; }
    // The Direction where Camera Looks
    public Vector3 Target { get; set; }
}


