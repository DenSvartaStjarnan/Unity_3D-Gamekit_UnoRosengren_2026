using UnityEngine;

public class WS1 : MonoBehaviour
{
    
    
    
    public int myNumber;

    private Rigidbody2D rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        myNumber = Random.Range(0, 10);

        string playerName = "Sebbe";
        playerName = "Sebastian";
        
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            YSpeed();
        }
    }
    
    void YSpeed()
    {
        if (myNumber == 39)
        {
            rb.linearVelocityY = 3f;
        }

        else
        {
            Debug.Log(myNumber);
        }
    }
}
