using UnityEngine;

public class MovingMover1 : MonoBehaviour
{
    // Adjust these in the Inspector to control speed and range
    public float speed = 2.0f;
    public float range = 4.0f;

    private Vector3 startPosition;

    void Start()
    {
        // Store the starting position of the object
        startPosition = transform.position;
    }

    void Update()
    {
        // Calculate the new position using Mathf.PingPong
        // Time.time * speed provides the incrementing value
        // range defines the total distance the object will travel from the start position
        float pingPongValue = Mathf.PingPong(Time.time * speed, range);

        // Calculate the new X position and apply it, keeping Y and Z the same
        // For movement along a different axis (e.g., Y or Z), change which coordinate uses pingPongValue
        //transform.position = new Vector3(startPosition.x + pingPongValue, startPosition.y, startPosition.z);
        transform.position = new Vector3(startPosition.x, startPosition.y, startPosition.z + pingPongValue);
    }
}
