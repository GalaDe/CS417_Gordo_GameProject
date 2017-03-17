using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree : MonoBehaviour {

    public GameObject GreenTree;
    public float delay = 0.10f;


    // Use this for initialization
    void Start () {
        StartCoroutine(TreeSpawn());
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public IEnumerator TreeSpawn()
    {
        for (int i = 0; i < 10; i++)
        {
            yield return new WaitForSeconds(delay);
            Vector3 treePos = new Vector3(transform.position.x + i * 20, transform.position.y, transform.position.z);
            GameObject tree = Instantiate(GreenTree, treePos, Quaternion.identity) as GameObject;
        }
    }
}
