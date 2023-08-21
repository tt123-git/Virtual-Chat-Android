using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RamdomAnimation : MonoBehaviour
{
    
    private Animator anim;
    public int switchInterval = 3; // アニメーションを切り替える回数の間隔

    IEnumerator Start()
    {
        anim = GetComponent<Animator>();
        int count = 0;

        while (true)
        {
            // アニメーションを再生
            anim.SetInteger("RandomIndex", Random.Range(1, 22));
            anim.SetTrigger("Random");

            // 回数をカウント
            count++;

            // 指定の回数が経過したらリセット
            if (count >= switchInterval)
            {
                count = 0;
                // 切り替える回数の間隔待機
                yield return new WaitForSeconds(1);
            }
        }
    }

  

}
