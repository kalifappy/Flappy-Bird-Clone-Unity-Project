using UnityEngine;

public class MovingPipes : MonoBehaviour
{
    [SerializeField] public  float pipes_Moving_Speed = 1.0f;
    [SerializeField] public  bool can_Move;


    private void Start()
    {
        can_Move = true;
    }
    // Update is called once per frame
    void Update()
    {
        if (can_Move)
        {
            transform.Translate(-pipes_Moving_Speed * Time.deltaTime, 0, 0);

        }
        else
        {
            return;
        }
    }
  
}
