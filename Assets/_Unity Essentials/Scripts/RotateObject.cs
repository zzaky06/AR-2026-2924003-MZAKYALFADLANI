using UnityEngine;
public class RotateObject : MonoBehaviour
{
public float speed = 120f;
void Update()
{
transform.Rotate(0f, speed * Time.deltaTime, 0f);
}
}