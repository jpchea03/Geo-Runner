using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float jumpForce;

    [SerializeField]
    bool isGrounded = false;

    Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isGrounded)
            {
                rb.AddForce(Vector2.up * jumpForce);
                isGrounded = false;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("ground"))
        {
            if(!isGrounded)
            {
                isGrounded=true;
            }
        }
    }
}
