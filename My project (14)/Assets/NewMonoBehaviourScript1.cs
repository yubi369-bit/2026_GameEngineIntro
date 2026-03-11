using UnityEngine;
using UnityEngine.InputSystem;

public class NewMonoBehaviourScript1 : MonoBehaviour
{
    private Vector2 MoveInput;
    public float moveSpeed = 7f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    public void OnMove(InputValue Value)
    {
     MoveInput = Value.Get<Vector2>();
    }
    // Update is called once per frame
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
        transform.Translate(Vector3.right * moveSpeed * MoveInput. x * Time.deltaTime);
    }   
}
