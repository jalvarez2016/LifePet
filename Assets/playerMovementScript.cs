using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovementScript : MonoBehaviour {
    public Vector3 rightMovement;
    public Vector3 leftMovement;
    public Vector3 upMovement;
    public Animator animator;
    public GameObject treat;
    public GameObject catToy;
    public GameObject catToyCorpsePrefab;
    public AudioClip bark;
    public AudioClip cry;
    public float time;
    public float barkTimer;
    public int stance;
	// Use this for initialization
	void Start () {
        //set this in a timer to randomly move the animal
        //and put it into the update function
        // Debug.Log(Mathf.Floor(5 * Random.value));
        stance = Mathf.RoundToInt(Mathf.Floor(5 * Random.value));
        Debug.Log(stance);
        AudioSource.PlayClipAtPoint(bark, Vector3.zero);
	}
	
	// Update is called once per frame
	void Update () {
        time += Time.deltaTime;
        barkTimer += Time.deltaTime;

        if(time >= 2){
            stance = Mathf.RoundToInt(Mathf.Floor(5 * Random.value));
            Debug.Log(stance);
            time = 0;
        }
         
        if(barkTimer >= 23){
            float noise;
            noise = Mathf.Floor(2 * Random.value);
            if(noise > 1){
                AudioSource.PlayClipAtPoint(bark, Vector3.zero);
                barkTimer = 0;
            } else {
                AudioSource.PlayClipAtPoint(cry, Vector3.zero);
                barkTimer = 0;
            }
        }

        if(stance == 0){
            GetComponent<Transform>().position += leftMovement;
            animator.SetBool("LeftWalk", true);
        } else {
            animator.SetBool("LeftWalk", false);
        }

        if(stance == 1){
            GetComponent<Transform>().position += rightMovement;
            animator.SetBool("RightWalk", true);
        } else {
            animator.SetBool("RightWalk", false);
        }

        if(stance == 3){
            GetComponent<Transform>().position += upMovement;
            animator.SetBool("Jump", true);
        } else {
            animator.SetBool("Jump", false);
        }

	}

    private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.name.Contains("cat"))
        {
             Vector3 pos = other.gameObject.transform.position;
            Destroy(other.gameObject);
            Instantiate(catToyCorpsePrefab, pos, Quaternion.identity);
        }
        else if (other.gameObject.name.Contains("treat"))
        {
           
            Destroy(other.gameObject);
            
        }
    }


}
