using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public GameObject explosionPrefab; //爆発エフェクトのPrefab

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0.2f, 0);

        if (transform.position.y > 5)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D coll)
    {//衝突した時にスコアを更新する
        GameObject.Find("Canvas").GetComponent<UIController>().Addscore();

        //爆発エフェクトを生成する
        GameObject effect = Instantiate(explosionPrefab, transform.position, Quaternion.identity) as GameObject;
        Destroy(effect, 1.0f);

        Destroy(coll.gameObject);
        Destroy(gameObject);
    }
}
