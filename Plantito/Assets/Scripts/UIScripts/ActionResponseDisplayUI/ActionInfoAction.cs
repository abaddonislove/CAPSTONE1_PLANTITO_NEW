using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionInfoAction : MonoBehaviour
{
    private void Awake()
    {
        StartCoroutine(Die());
    }

    IEnumerator Die()
    {
        yield return new WaitForSeconds(2.0f);
        Destroy(this.gameObject);
    }
}
