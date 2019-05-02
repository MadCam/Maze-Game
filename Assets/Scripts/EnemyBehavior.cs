using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour {
    
    public enum dir {Horizontal,Vertical}
    public dir direction = dir.Horizontal;
    public float movmag = .5f;
    

    public float speed = 1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        switch (direction)
        {
            case dir.Vertical:
                // move up and down over time
                gameObject.transform.Translate(Vector3.forward * Mathf.Cos(Time.timeSinceLevelLoad) * movmag);
                break;

            case dir.Horizontal:
                // move up and down over time
                gameObject.transform.Translate(Vector3.right * Mathf.Cos(Time.timeSinceLevelLoad) * movmag);
                break;
        }
        transform.rotation = Quaternion.identity;
        
    }

     void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player") {
            // Applies damage killing player
            collision.gameObject.GetComponent<Health>().applyDamage(1);
        }
    }
}
