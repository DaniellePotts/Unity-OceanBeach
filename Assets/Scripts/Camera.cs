using UnityEngine;

public class Camera : MonoBehaviour
{

    private float speed = 5f;
    private float yaw = 0.0f;
    private float pitch = 0.0f;

    [SerializeField]
    private GameObject camera;

	void Update ()
	{
	    yaw += speed * Input.GetAxis("Mouse X");
	    pitch -= speed * Input.GetAxis("Mouse Y");

	    camera.transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
	}
}
