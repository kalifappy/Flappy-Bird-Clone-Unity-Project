using UnityEngine;

public class MovingPipes : MonoBehaviour
{
    [SerializeField] float pipes_Moving_Speed = 1.0f;
   

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-pipes_Moving_Speed * Time.deltaTime, 0, 0);
    }
  
}
