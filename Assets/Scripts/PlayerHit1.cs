using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHit1 : MonoBehaviour
{
    public GameObject healthBar;
    public static float HP = 100;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.GetComponent<Image>().fillAmount = HP / 100;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "1")
        {
            Debug.Log("oh");
            HP -= 20;
            Destroy(other);
        }
    }
}
