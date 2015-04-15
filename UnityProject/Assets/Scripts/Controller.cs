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
	        float rotation;
         
	        var mousePosition = Input.mousePosition;
            if (mousePosition.x < middleOfScreen)
	        {
	            rotation = rotationVelocity * Time.deltaTime;
	        }
	        else
	        {
                rotation = -rotationVelocity * Time.deltaTime;
	        }

            //var x = transform.rotation.eulerAngles.x;
            //var y = (transform.rotation.eulerAngles.y);
            //var z = transform.rotation.eulerAngles.z + rotation;
            //transform.rotation = Quaternion.Euler(x, y, z);

            var x = transform.rotation.eulerAngles.x;
            var y = (transform.rotation.eulerAngles.y);
            var z = transform.rotation.eulerAngles.z + rotation;
	        var targetRotation = Quaternion.Euler(x, y, z);
	        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime*100);

            // Smoothly rotates towards target 
            //var targetPoint = targetPosition.transform.position;
            //var targetRotation = Quaternion.LookRotation(targetPoint - transform.position, Vector3.up);
            //transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * 2.0);
	    }
        

        if (leftSphere && rightSphere)
            Debug.DrawLine(leftSphere.transform.position, rightSphere.transform.position, Color.green, 0.1f);
	}

    private static bool IsTouchingScreen()
    {
        return Input.GetMouseButton(0);
    }
}
