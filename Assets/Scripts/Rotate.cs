using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float rotSpeed = 50f;

    void Update()
    {
        transform.Rotate(Vector3.up * Time.deltaTime * -rotSpeed);
    }
}