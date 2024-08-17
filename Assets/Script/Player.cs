using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    [SerializeField] float jumpSpeed;
    [SerializeField] GameObject bird_Sprite;
    [SerializeField] GameObject start_UI;
    [SerializeField] GameObject gameOver_UI;
    Rigidbody2D rb;
    Spawner spawner;
    ScoreCounter score_Counter;
    int score_Count;
    Animator animator;
    AudioManager audioManager;
    [SerializeField] bool start_Game_bool;
    [SerializeField] bool do_Controlls_Work = true;



    void Start()
    {
        
        rb = GetComponent<Rigidbody2D>();
        spawner = FindFirstObjectByType<Spawner>();
        score_Counter = FindFirstObjectByType<ScoreCounter>();
        animator = GetComponentInChildren<Animator>();
        audioManager = FindFirstObjectByType<AudioManager>();
        rb.gravityScale = 0;
      
      
    }

   
    void Update()
    {
        Movement();
        StartGame();
        GameOver();
        
    }

    void GameOver()
    {
        if (start_Game_bool && !do_Controlls_Work)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Time.timeScale = 1;
                SceneManager.LoadScene(0);
                start_Game_bool = false;
               
            }
        }

    }

    void StartGame()
    {
        if (!start_Game_bool)
        {
            if (Input.GetMouseButtonDown(0))
            {
                rb.linearVelocity = Vector2.up * jumpSpeed;
                audioManager.PlayJumpClip();
                do_Controlls_Work = true;
                start_Game_bool = true;
                start_UI.SetActive(false);
                rb.gravityScale = 1f;
                spawner.can_Spawn = true;
                Debug.Log("Start");
            }
        }
        else
        { return; }
    }
    private void Movement()
    {
        if (do_Controlls_Work)
        {
            if (Input.GetMouseButtonDown(0))
            {
                rb.linearVelocity = Vector2.up * jumpSpeed;
                audioManager.PlayJumpClip();
            }


        }
        bird_Sprite.transform.rotation = Quaternion.Euler(0, 0, rb.linearVelocity.y * jumpSpeed);

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Pipes")
        {
            do_Controlls_Work = false;
            animator.enabled = false;
            audioManager.PlayDieClip();
            gameOver_UI.SetActive(true); 
            Time.timeScale = 0;
        }
       
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Score")
        {
            if (do_Controlls_Work)
            {
                score_Counter.Score_Count++;
                audioManager.PlayScoreClip();
            }
        }
    }
}
