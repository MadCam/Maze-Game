using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {

    private int healthpoints = 1;
    private Vector3 respawnPosition;
    private Quaternion respawnRotation;
    public GameObject explosionPrefab;

    // Use this for initialization
    void Start () {
        respawnPosition = transform.position;
        respawnRotation = transform.rotation;
    }
	
	// Update is called once per frame
	void Update () {
        if (healthpoints <= 0)
        {
            if (explosionPrefab != null)
            {
                Instantiate(explosionPrefab, transform.position, Quaternion.identity);
            }
            transform.position = respawnPosition;
            transform.rotation = respawnRotation;
            healthpoints = 1;

        }
    }

    public void applyDamage(int dam) {
        healthpoints = healthpoints - dam;
    }
}
