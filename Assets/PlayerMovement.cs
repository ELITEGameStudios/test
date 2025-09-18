using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float speed = 5;
    public bool grounded;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(speed * InputManager.instance.GetMovement() * Time.fixedTime);
    }

    void OnCollisionEnter(Collision collision){
        if (collision.gameObject.layer == LayerMask.NameToLayer("Ground")){
            grounded = true;
        }
    }
    
    void OnCollisionExit(Collision collision){
        if (collision.gameObject.layer == LayerMask.NameToLayer("Ground")){
            grounded = false;
        }
    }
}
