using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//���C�u�����̒ǉ�
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class startButton : MonoBehaviour
{
    //�n�܂������Ɏ��s����֐�
    void Start()
    {
        //�{�^���������ꂽ���AStartGame�֐������s
        gameObject.GetComponent<Button>().onClick.AddListener(StartGame);
    }
    //StartGame�֐�
    void StartGame()
    {
        //SampleScene�����[�h
        SceneManager.LoadScene("SampleScene");
    }
    // Update is called once per frame
    void Update()
    {
        EndGame();
    }

    //�Q�[���I��
    private void EndGame()
    {
        //Esc�������ꂽ��
        if (Input.GetKey(KeyCode.Escape))
        {
            #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;//�Q�[���v���C�I��
            #else
            Application.Quit(); //�Q�[���v���C�I��
            #endif
        }
    }
}