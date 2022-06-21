using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public GameObject bulletPrefab;

    // Update is called once per frame
    void Update()
    {
        //左へ進む
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-0.1f, 0, 0);
        }
        //右へ進む
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(0.1f, 0, 0);
        }
        //弾発射
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bulletPrefab, transform.position, Quaternion.identity);
        }

        float moveX = Input.GetAxis("Horizontal") * Time.deltaTime;
        float moveY = Input.GetAxis("Vertical") * Time.deltaTime;
        transform.position = new Vector2(
             //エリア指定して移動する、moveXは初期座標固定
             Mathf.Clamp(transform.position.x + moveX, -2.5f, 2.5f),
             Mathf.Clamp(transform.position.y + moveY, -4, -4)
             );
    }
}
