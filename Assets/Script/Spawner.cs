using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject pipe_Prefabs;
    float spawn_Distance;
    GameObject player;
    [SerializeField] public bool can_Spawn;
    public GameObject newPipes;
    [SerializeField] public float spawner_Rate;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawner_Rate = 1f;
        InvokeRepeating(nameof(SpawingPipes), 1, spawner_Rate);
        player = GameObject.Find("Player");
        spawn_Distance = player.transform.position.x + 5;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawingPipes()
    {
        if (can_Spawn)
        {
            float random_Y = Random.Range(-0.2f, 2.17f);

            newPipes = Instantiate(pipe_Prefabs, new Vector3(spawn_Distance, random_Y, 0), Quaternion.identity);

            Destroy(newPipes,5);
          
        }
        else
        {
            return;
        }
       
    }

   
}
