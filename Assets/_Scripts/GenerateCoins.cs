using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GenerateCoins : MonoBehaviour {

    public Text ScoreText;
    public GameObject Coin;
    public float delay = 0.10f;
    public PlayerControl player;
    public bool collision = false;

    // Use this for initialization
    void Start () {
            StartCoroutine(CoinSpawn());
	}
	
	// Update is called once per frame
	void Update () {
        ScoreText.text = player.score.ToString();
        //if (player.score == 100)
        //    StopCoroutine(CoinSpawn());
	}

    public IEnumerator CoinSpawn()
    {
            for (int i = 0; i < 11; i++)
            {
                yield return new WaitForSeconds(delay);
                Vector3 coinPos = new Vector3(transform.position.x + i * 12, transform.position.y, transform.position.z);
                GameObject coin = Instantiate(Coin, coinPos, Quaternion.identity) as GameObject;
            }
     }
 


}
