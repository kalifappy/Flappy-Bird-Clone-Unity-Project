using UnityEngine;

public class ScrollEnvironment : MonoBehaviour
{

    [SerializeField] Material scroll_Matt;
    [SerializeField] float scroll_Speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       scroll_Matt.mainTextureOffset = new Vector2 (scroll_Speed *Time.time , 0);
    }
}
