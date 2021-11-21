using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{
    // �{�[����������\���̂���Z���̍ő�l
    private float visiblePosZ = -6.5f;

    // �Q�[���I�[�o�[��\������e�L�X�g
    private GameObject gameoverText;


        // Start is called before the first frame update
        void Start()
    {
        // �V�[������GemeOverText�I�u�W�F�N�g���擾
        this.gameoverText = GameObject.Find("GameOverText");
    }

        // Update is called once per frame
        void Update()
    {

        // �{�[������ʊO�ɏo���ꍇ
        if (this.transform.position.z < this.visiblePosZ)
        {
            // GameoverText�ɃQ�[���I�[�o�[��\��
            this.gameoverText.GetComponent<Text>().text = "Game Over";
        }
    }
}