using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation3 : MonoBehaviour
{
    private Animator anim;
    public float intervalMin = 60.0f; // 最小の間隔（秒）
    public float intervalMax = 120.0f; // 最大の間隔（秒）

    void Start()
    {
        anim = GetComponent<Animator>();
        StartCoroutine(PlayRandomAnimationWithInterval());
    }

    IEnumerator PlayRandomAnimationWithInterval()
    {
        while (true)
        {
            // デフォルトのアニメーション再生
            anim.SetTrigger("WALK00_R");

            // 1フレーム待機
            yield return new WaitForEndOfFrame();

            int interval = 5;
            yield return new WaitForSeconds(interval);

            // ランダムな間隔を設定
            /*float interval = Random.Range(intervalMin, intervalMax);
            yield return new WaitForSeconds(interval);*/

            // ランダムな別のアニメーション再生
            anim.SetTrigger("Random");
        }
    }
}
