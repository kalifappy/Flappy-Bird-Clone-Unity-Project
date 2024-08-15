using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    [SerializeField] float jumpSpeed;
    [SerializeField] GameObject bird_Sprite;
    [SerializeField] Collider2D col;
    void Start()
    {
       rb = GetComponentInChildren<Rigidbody2D>();
       col = GetComponentInChildren<Collider2D>();
    }

   
    void Update()
    {
        if(Input.GetMouseButtonDown(0)) 
        {
            rb.linearVelocity = Vector2.up * jumpSpeed;
        }

        bird_Sprite.transform.rotation = Quaternion.Euler(0, 0, rb.linearVelocity.y * jumpSpeed);
  
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
    }
}
