using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // Drag objek Player ke sini
    public Vector3 offset = new Vector3(0, 5, -5); // Jarak/posisi kamera relatif terhadap player
    public float smoothSpeed = 0.125f; // Kehalusan gerakan kamera

    void LateUpdate()
    {
        if (target != null)
        {
            Vector3 desiredPosition = target.position + offset;
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
            transform.position = smoothedPosition;

            transform.LookAt(target); // Menghadap langsung ke player
        }
    }
}