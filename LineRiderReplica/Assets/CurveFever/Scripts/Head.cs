using UnityEngine;

public class Head : MonoBehaviour {
    public float speed = 0f;
    public float rotSpeed = 0f;

    private float horizontal;

    private void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
    }
    private void FixedUpdate()
    {

        transform.Translate(Vector2.up* speed * Time.deltaTime, Space.Self);
        transform.Rotate(Vector3.forward * rotSpeed * Time.deltaTime, Space.Self);
    }

}
