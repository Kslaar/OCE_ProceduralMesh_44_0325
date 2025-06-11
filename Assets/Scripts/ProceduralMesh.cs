using UnityEngine;

public class ProceduralMesh : MonoBehaviour
{
    void Start()
    {
        GenerateMesh();
    }

    public void GenerateMesh()
    {
        Mesh mesh = new Mesh();
        mesh.name = "CustomMesh";

        mesh.vertices = new Vector3[]
        {
            new Vector3(0,0,0), // 0
            new Vector3(0,1,0), // 1
            new Vector3(1,0,0), // 2
            new Vector3(1,1,0), // 3
        };

        mesh.triangles = new int[]
        {
            0, 1, 2,
            2, 1, 3,
        };

        // mesh.normals = new Vector3[]
        // {
        //     new (x:0, y:0 , z:-1),
        //     new (x:0, y:0 , z:-1),
        //     new (x:0, y:0 , z:-1),
        //     new (x:0, y:0 , z:-1),
        // };

        mesh.RecalculateNormals();

        GetComponent<MeshFilter>().mesh = mesh;
    }
}
