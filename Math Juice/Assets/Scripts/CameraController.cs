using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

    public GameObject followTarget; //Generic game object that the camera can follow. In Unity, the player is made the follow target
    private Vector3 targetPos;
    public float moveSpeed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        targetPos = new Vector3(followTarget.transform.position.x, followTarget.transform.position.y, transform.position.z);
        transform.position = Vector3.Lerp(transform.position, targetPos, moveSpeed * Time.deltaTime);
	}
}
