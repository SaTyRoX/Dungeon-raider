using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drop : MonoBehaviour
{
    public GameObject TargetToEnable;
    
    void OnDestroy()
    {
        TargetToEnable.SetActive(true);
    }
}
