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

        Debug.Log("distanceBetweenSpheres is null" + (distanceBetweenSpheres == null));
        //EditorGUILayout.PropertyField(distanceBetweenSpheres);

        var displacement = distanceBetweenSpheres.floatValue / 2;
        var controller = GameObject.Find(target.name).GetComponent<Controller>();
        DisplaceBy(controller.leftSphere.transform, x: -displacement);
        DisplaceBy(controller.rightSphere.transform, x: displacement);


        // Apply changes to the serializedProperty - always do this in the end of OnInspectorGUI.
        serializedObject.ApplyModifiedProperties();
    }

    private void DisplaceBy(Transform transform, float x)
    {
        transform.position = new Vector3(x, transform.position.y, transform.position.z);
    }
}
