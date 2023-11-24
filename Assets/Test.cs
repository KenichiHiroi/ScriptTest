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
            Debug.Log("魔法攻撃をした。残りMPは" + mp + "。");
        }
        else
        {
            Debug.Log("MPが足りないため、魔法が使えない。");
        }
    }
}

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        int[] array = {10, 20, 30, 40, 50};

        //配列の各要素を順番に表示
        for(int i = 0;i < array.Length;i++)
        {
            Debug.Log(array[i]);
        }

        //配列の要素を逆順に表示
        for (int i = array.Length - 1; i >= 0; i--)
        {
            Debug.Log(array[i]);
        }

        //発展課題
        Boss bossLesson = new Boss();

        for(int i =0;i<=15;i++)
        {
            int turnCount = i + 1;
            Debug.Log("ターン" + turnCount);
            bossLesson.Magic();
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
