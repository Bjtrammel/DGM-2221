using UnityEngine;
using System.Collections;

public class Move3d : MonoBehaviour
{
    public float moveSpeed;
    public float rotateSpeed;
    public float jumpHeight;

    void FixedUpdate()
    {
        var y = Input.GetAxis("Horizontal") * Time.deltaTime * rotateSpeed;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        var j = Input.GetAxis("Jump") * Time.deltaTime * moveSpeed;

        transform.Rotate(0, y, 0);
        transform.Translate(0, 0, z);
        transform.Translate(0, j, 0);
    }
}