using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//ライブラリの追加
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class startButton : MonoBehaviour
{
    //始まった時に実行する関数
    void Start()
    {
        //ボタンが押された時、StartGame関数を実行
        gameObject.GetComponent<Button>().onClick.AddListener(StartGame);
    }
    //StartGame関数
    void StartGame()
    {
        //SampleSceneをロード
        SceneManager.LoadScene("SampleScene");
    }
    // Update is called once per frame
    void Update()
    {
        EndGame();
    }

    //ゲーム終了
    private void EndGame()
    {
        //Escが押された時
        if (Input.GetKey(KeyCode.Escape))
        {
            #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;//ゲームプレイ終了
            #else
            Application.Quit(); //ゲームプレイ終了
            #endif
        }
    }
}