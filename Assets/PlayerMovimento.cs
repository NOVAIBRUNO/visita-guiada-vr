using UnityEngine;

public class PlayerMovimento : MonoBehaviour
{
    public float velocidade = 5f;

    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 movimento = transform.right * x + transform.forward * z;
        transform.position += movimento * velocidade * Time.deltaTime;
    }
}