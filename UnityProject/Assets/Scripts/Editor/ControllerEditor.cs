using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(Controller))]
public class ControllerEditor : Editor
{
    public SerializedProperty distanceBetweenSpheres;

    public void OnEnable()
    {
        distanceBetweenSpheres = serializedObject.FindProperty("distanceBetweenSpheres");
    }

    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        // Update the serializedProperty - always do this in the beginning of OnInspectorGUI.
        serializedObject.Update();
        
        //TODO verificar como desabilitar quando simular um jogo
        //var displacement = distanceBetweenSpheres.floatValue / 2;
        //var controller = GameObject.Find(target.name).GetComponent<Controller>();
        //DisplaceInX(controller.leftSphere.transform, newX: -displacement);
        //DisplaceInX(controller.rightSphere.transform, newX: displacement);

        // Apply changes to the serializedProperty - always do this in the end of OnInspectorGUI.
        serializedObject.ApplyModifiedProperties();
    }

    private void DisplaceInX(Transform transform, float newX)
    {
        transform.position = new Vector3(newX, transform.position.y, transform.position.z);
    }
}
