using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject pipe_Prefabs;
    float spawn_Distance;
    GameObject player;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating(nameof(SpawingPipes), 1, 1);
        player = GameObject.Find("Player");
        spawn_Distance = player.transform.position.x + 5;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawingPipes()
    {
        float random_Y = Random.Range(-0.2f, 2.17f);

        GameObject newPipes = Instantiate(pipe_Prefabs, new Vector3(spawn_Distance, random_Y, 0), Quaternion.identity);

        Destroy(newPipes, 6f);
    }
}
