using UnityEngine;

public class Player : MonoBehaviour
{


    [SerializeField] float speed;
    [SerializeField] Vector2 moveInput;
    [SerializeField] Rigidbody rb;
    [SerializeField] GameObject endScreen;

    public static Player main { get; private set; }

    void Awake()
    {
        if (main == null) { main = this; }
        else if (main != this) { Destroy(this); }
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        moveInput = new Vector2(
            Input.GetAxis("Horizontal"),
            Input.GetAxis("Vertical")
        );

        rb.linearVelocity = moveInput * speed;
    }

    void OnCollisionEnter(Collision collision)
    {
        EndGame();
    }

    void EndGame()
    {
        endScreen.SetActive(true);
        Destroy(gameObject);
    }
}
