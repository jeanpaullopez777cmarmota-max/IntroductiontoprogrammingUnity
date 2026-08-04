using UnityEngine;

public class PlayerMovement : MonoBehaviour //this class denotes where we'll carry out all changes to our current script
{
    // variables


    public float height = 1.84f;
    public int edad = 30;
    public string nombre = "Roberto";
    public bool cantheyvote = true;

    public GameObject gameObject;
    public Rigidbody2D rigidbody2D; //responsible for game physics
    public Collider2D collider2D;  //does it have collision? 
    public SpriteRenderer spriteRenderer;
    public Transform transformoormove;

    private void Start()
    {
        Debug.Log("LEROLERO LERO ELROROROROR: " + nombre + " your age is: " + edad + " let's see if your a manlet: " + height); //to print stuff on console 
        rigidbody2D.simulated = false; //after the dot you write the property you wanna tweak. 
        spriteRenderer.color = Color.green; //capital C letter indicative of it being a function
        transformoormove.position = new Vector3(4f, 0f, 0f); //each number corresponds to xyz respectively. -x and x go from left to right, -y and y signals upward or downward movement and -z and z is 
                                                              // for movement either forward or backward 
    }

    private void Update()
    {
        
    }
}
  
