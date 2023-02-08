using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rb;

    public float forwardForce;
    public float sidewaysForce; // punem f la sfarsit doar la float
	
	// Update is called once per frame
	void FixedUpdate () // folosim FixedUpdate cand facem modificari la nivel fizic(forte,gravitatie, etc)
    {
        // Time.deltaTime = nr de secunde de la ultimul frame
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        
        if(Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(rb.position.y<-1)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
