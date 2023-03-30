using System.Collections;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class CharacterBlend : MonoBehaviour
{
    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void Start()
    {
        StartCoroutine(ChangeAnimation());
    }

    IEnumerator ChangeAnimation()
    {
        while (true)
        {
            yield return new WaitForSeconds(5);
            float random = Random.Range(0, 2);
            animator.SetFloat("action", random);
        }
    }
}
