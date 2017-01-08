using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour {

    public Vector3 angle;

    // Use this for initialization
    void Start () {
        Debug.Log("testes");
    }
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(angle * Time.deltaTime);	
	}
}
