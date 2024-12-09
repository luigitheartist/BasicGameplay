using UnityEngine;

public class DOOB : MonoBehaviour
{
    private float topBound = 30;
    private float lowBound = -10;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z>topBound)
        {
            Destroy(gameObject);
        } else if (transform.position.z<lowBound)
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }
    }
}
