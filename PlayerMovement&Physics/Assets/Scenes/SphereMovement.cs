using UnityEngine;

public class SphereMovement : MonoBehaviour
{
    //Sets the ball to its Starting position every time the game starts
    void Start(){

        float xStart = 0;
        float yStart = 0;
        float zStart = 200;

        Vector3 StartPos = new Vector3(xStart, zStart, yStart);

        transform.position = StartPos;
    }

    //some floats that will be used later in the
    public float speed = 0.1f;
    public float z = 0f;

    //gets the status of the input keys and converts them to object movement
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");


        //BROKEN!!!!!
        if(Input.GetKey("space")){
            z += 1;
        }
        if(Input.GetKey(KeyCode.LeftShift) && z <= 0){
            z -= 1;
        }

        Vector3 moveDirection = new Vector3(x, z, y);

        transform.position += moveDirection * speed;
    }
}
