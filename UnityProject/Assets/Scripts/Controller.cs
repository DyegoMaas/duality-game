using UnityEngine;

public class Controller : MonoBehaviour
{
    public GameObject leftSphere, rightSphere;
    public float distanceBetweenSpheres = 2f;
    public float rotationVelocity = 1f;

    private readonly float middleOfScreen = Screen.width/2f;

    // Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if (IsTouchingScreen())
	    {
	        var rotation = 0f;
         
	        var mousePosition = Input.mousePosition;
            if (mousePosition.x < middleOfScreen)
	        {
	            rotation += rotationVelocity * Time.deltaTime;
	        }
	        else
	        {
                rotation -= rotationVelocity * Time.deltaTime;
	        }

            if(rotation != 0f)
                transform.Rotate(0,0,rotation);
	    }

        if (leftSphere && rightSphere)
            Debug.DrawLine(leftSphere.transform.position, rightSphere.transform.position, Color.green, 0.1f);
	}

    private static bool IsTouchingScreen()
    {
        return Input.GetMouseButton(0);
    }
}
