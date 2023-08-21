using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Default : MonoBehaviour
{
    private Animator anim;
    public float defaultAnimationInterval = 5.0f; // デフォルトアニメーションの再生間隔（秒）
    public float randomAnimationIntervalMin = 10.0f; // ランダムなアニメーション再生の最小間隔（秒）
    public float randomAnimationIntervalMax = 30.0f; // ランダムなアニメーション再生の最大間隔（秒）

    void Start()
    {
        anim = GetComponent<Animator>();
        StartCoroutine(PlayDefaultAnimationWithRandomIntervals());
    }

    IEnumerator PlayDefaultAnimationWithRandomIntervals()
    {
        while (true)
        {
            // デフォルトのアニメーション再生
            anim.SetTrigger("WALK00_R");

            // デフォルトアニメーションの再生間隔待機
            yield return new WaitForSeconds(defaultAnimationInterval);

            // ランダムな間隔で別のアニメーションを再生
            float randomInterval = Random.Range(randomAnimationIntervalMin, randomAnimationIntervalMax);
            yield return new WaitForSeconds(randomInterval);

            // ランダムな別のアニメーション再生
            anim.SetTrigger("Random");
        }
    }
}
