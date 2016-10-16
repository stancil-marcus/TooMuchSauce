using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public float moveSpeed; //the speed in which the player moves

    private Animator anim; //a reference to the animator

    private bool playerMoving; //Variable to see if player is moving or not

    private Vector2 lastMove; //Stores our last moves
    // Use this for initialization

	void Start () {
        anim = GetComponent<Animator>(); //Make player controller script find animator
	}
	
	// Update is called once per frame
	void Update () {

        playerMoving = false;

	    if (Input.GetAxisRaw("Horizontal") > 0.5f || Input.GetAxisRaw("Horizontal") < -0.5f) //checks if player is trying to go left or right
        {
            transform.Translate (new Vector3(Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime, 0f, 0f)); //makes x value the speed you move in horizontal direction; 0 for both y and z values because we're only focusing on x value
            playerMoving = true;
            lastMove = new Vector2(Input.GetAxisRaw("Horizontal"), 0f); //Records last move when player is moving horizontally
        }

        if (Input.GetAxisRaw("Vertical") > 0.5f || Input.GetAxisRaw("Vertical") < -0.5f) //checks if the player is trying gto go up or down
        {
            transform.Translate(new Vector3(0f, Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime, 0f)); //makes x and values zero and  makes y = vertical values * moveSpeed * time duration to move. The y value represents how fast you are moving in the horizontal direction.
            playerMoving = true;
            lastMove = new Vector2(0f, Input.GetAxisRaw("Vertical")); //Records last move when player is moving vertically
        }


        anim.SetFloat("MoveX", Input.GetAxisRaw("Horizontal")); //This allocates your horizontal move value to variable MoveX in Unity, which conrtols the animating when you move horizontally
        anim.SetFloat("MoveY", Input.GetAxisRaw("Vertical")); //This allocates your vertically move value to variable MoveY in Unity, which conrtols the animating when you move vertically
        anim.SetBool("PlayerMoving", playerMoving); //Sends information to animator as to whether the player is moving or not
        anim.SetFloat("LastMoveX", lastMove.x);
        anim.SetFloat("LastMoveY", lastMove.y);
    }
}
