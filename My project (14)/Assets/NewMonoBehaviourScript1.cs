using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class NewMonoBehaviourScript1 : MonoBehaviour
{
    private Rigidbody2D rb;
    private Vector2 MoveInput;
    public float moveSpeed = 7f;
    public float jumpforce = 24f;
    private Animator myanimator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        myanimator = GetComponent<Animator>();
        myanimator.SetBool("move", false);
        myanimator.SetBool("jump", false);
    }
    public void OnMove(InputValue Value)
    {
     MoveInput = Value.Get<Vector2>();
    }
    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "door")
            Destroy(collision.gameObject);
    }
    public void OnJump(InputValue value)
    {
        if (value.isPressed)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpforce);
        }
    }
    void Update()
    {
        if(MoveInput.x > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
        else if(MoveInput.x < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
     
        }
        if(MoveInput.magnitude > 0 )
        {
            myanimator.SetBool("move", true);
        }
        else
        {
            myanimator.SetBool("move", false);
        }
        if (MoveInput.magnitude > 0)
        {
            myanimator.SetBool("jump", true);
        }
        else
        {
            myanimator.SetBool("jump", false);
        }
            transform.Translate(Vector3.right * moveSpeed * MoveInput.x * Time.deltaTime);
    }   
}
