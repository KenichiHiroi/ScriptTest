using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Boss
{
    int mp = 53;

    public void Magic()
    {
        if(mp >= 5)
        {
            mp = mp - 5;
            Debug.Log("���@�U���������B�c��MP��" + mp + "�B");
        }
        else
        {
            Debug.Log("MP������Ȃ����߁A���@���g���Ȃ��B");
        }
    }
}

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        int[] array = {10, 20, 30, 40, 50};

        //�z��̊e�v�f�����Ԃɕ\��
        for(int i = 0;i < array.Length;i++)
        {
            Debug.Log(array[i]);
        }

        //�z��̗v�f���t���ɕ\��
        for (int i = array.Length - 1; i >= 0; i--)
        {
            Debug.Log(array[i]);
        }

        //���W�ۑ�
        Boss bossLesson = new Boss();

        for(int i =0;i<=15;i++)
        {
            int turnCount = i + 1;
            Debug.Log("�^�[��" + turnCount);
            bossLesson.Magic();
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
