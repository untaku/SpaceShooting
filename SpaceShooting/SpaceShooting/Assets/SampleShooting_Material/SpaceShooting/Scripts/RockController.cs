using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RockController : MonoBehaviour
{
    float fallSpeed;
    float rotSpeed;
    // Start is called before the first frame update
    void Start()
    {
        //隕石の落下速度
        this.fallSpeed = Random.Range(7f, 12f); 
        //隕石の回転速度
        this.rotSpeed = 3f + 1f * Random.value;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -fallSpeed*Time.deltaTime, 0, Space.World);
        transform.Rotate(0, 0, rotSpeed);

        if (transform.position.y < -5.5f)
        {
            //ｙ座標-5.5f以下に隕石が落ちたらゲームオーバーシーン出す
            GameObject.Find("Canvas").GetComponent<UIController>().GameOver();
            //Destroy(gameObject);
            StartCoroutine(GameOver());
        }
    }
    IEnumerator GameOver()
    {
        //２秒後スタートシーンへ遷移
        yield return new WaitForSeconds(2);

        SceneManager.LoadScene("StartScene");
    }
}
