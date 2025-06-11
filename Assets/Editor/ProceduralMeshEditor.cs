using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(ProceduralMesh))]
public class ProceduralMeshEditor : Editor
{
    public override void OnInspectorGUI()
    {
        ProceduralMesh procmesh = (ProceduralMesh)target;

        DrawDefaultInspector();

        bool pressed = GUILayout.Button("Generate");
        if (pressed)
        {
            procmesh.GenerateMesh();
        }

    }
}
