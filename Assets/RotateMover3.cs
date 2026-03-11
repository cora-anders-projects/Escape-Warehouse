using UnityEngine;

public class OscillatingRotation : MonoBehaviour
{
    [Header("Rotation Settings")]
    [Tooltip("The total angle the object will rotate (e.g., 90)")]
    public float RotationAngle = 90.0f;

    [Tooltip("How fast the object rotates")]
    public float RotationSpeed = 1.0f;

    [Tooltip("The axis to rotate around")]
    public Vector3 RotationAxis = Vector3.up; // Standard Y-axis rotation

    private Quaternion _startRotation;

    void Start()
    {
        // Store the rotation the object starts with in the editor
        _startRotation = transform.rotation;
    }

    void Update()
    {
        // PingPong returns a value between 0 and 1 that goes back and forth
        float time = Mathf.PingPong(Time.time * RotationSpeed, 1.0f);

        // Use SmoothStep to make the start and end of the rotation feel "heavy" and organic
        float smoothTime = Mathf.SmoothStep(0f, 1f, time);

        // Calculate the target rotation based on the start point
        Quaternion targetRotation = Quaternion.Euler(RotationAxis * (RotationAngle * smoothTime));

        // Apply it relative to the starting rotation
        transform.rotation = _startRotation * targetRotation;
    }
}