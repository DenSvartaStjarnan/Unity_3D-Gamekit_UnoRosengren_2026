using UnityEngine;
using UnityEngine.Events;

public class WS1 : MonoBehaviour
{
    
    
    
    public int myNumber = 0;

    public UnityEvent onStart;
    
    private Rigidbody2D rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        onStart.Invoke();
        
        myNumber = Random.Range(0, 10);

        string playerName = "Uno";
        playerName = "Den Svarta Stjärnan";
        
        rb = GetComponent<Rigidbody2D>();

        for (int counter = 0; counter < 10; counter++)
        {
            Debug.Log(counter);

            //if (counter == 7) ;

        }
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
        if (myNumber == 1)
        {
            rb.linearVelocityY = 3f;
        }

        else
        {
            Debug.Log(myNumber);
        }
    }
}
