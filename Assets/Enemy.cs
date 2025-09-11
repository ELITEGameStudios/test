using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] Vector2 moveInput;
    [SerializeField] Rigidbody rb;



    // Update is called once per frame
    void FixedUpdate()
    {
        moveInput = (Player.main.transform.position - transform.position).normalized;
        rb.AddForce(moveInput * speed * Time.fixedDeltaTime, ForceMode.Force);
    }
}
