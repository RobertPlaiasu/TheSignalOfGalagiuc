using UnityEngine;

public class CamraFollow : MonoBehaviour
{
    public Transform player;
    public float speed;
    public Vector3 offset;
    
    void FixedUpdate()
    {
        Vector3 desiredPosition = player.position + offset;
        Vector3 smoothPosition = Vector3.Lerp(transform.position, desiredPosition, speed);
        transform.position = smoothPosition;

        transform.LookAt(player);
    }
}
