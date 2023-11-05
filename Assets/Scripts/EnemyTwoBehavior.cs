using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTwoBehavior : MonoBehaviour
{
	
	private int randNum;
    // Start is called before the first frame update
    void Start()
    {
        randNum = Random.Range(-1,2);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(randNum, -1, 0) * Time.deltaTime * 3);
        if (transform.position.y < -8f)
        {
            Destroy(this.gameObject);
        }
    }
}