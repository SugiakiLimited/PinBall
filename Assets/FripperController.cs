using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FripperController : MonoBehaviour
{
    //HingeJoint�R���|�[�l���g������
    private HingeJoint myHingeJoint;

    // �����̌X��
    private float defaultAngle = 20;
    // �͂��������̌X��
    private float flickAngle = -20;

    // Start is called before the first frame update
    void Start()
    {
        //HingeJoint�R���|�[�l���g�擾
        this.myHingeJoint = GetComponent<HingeJoint>();

        //�t���b�p�[�̌X����ݒ�
        SetAngle(this.defaultAngle);        
    }

    // Update is called once per frame
    void Update()
    {
        // �����L�[�AA�L�[�AS�L�[�������������t���b�p�[�𓮂���
        if ((Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow)) && tag == "LeftFripperTag")
        {
            SetAngle(this.flickAngle);
        }
        // �E���L�[�AD�L�[�AS�L�[�����������E�t���b�p�[�𓮂���
        if ((Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow)) && tag == "RightFripperTag")
        {
            SetAngle(this.flickAngle);
        }

        // ���L�[���������t���b�p�[�����ɖ߂�
        if ((Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.DownArrow)) && tag == "LeftFripperTag")
        {
            SetAngle(this.defaultAngle);
        }
        if ((Input.GetKeyUp(KeyCode.RightArrow) || Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.DownArrow)) && tag == "RightFripperTag")
        {
            SetAngle(this.defaultAngle);
        }
    }
    // �t���b�p�[�̌X����ݒ�
    public void SetAngle (float angle)
    {
        JointSpring jointSpr = this.myHingeJoint.spring;
        jointSpr.targetPosition = angle;
        this.myHingeJoint.spring = jointSpr;
    }
}
