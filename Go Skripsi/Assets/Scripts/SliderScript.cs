using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderScript : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] GameObject finish;

    float startDistance;


    // Start is called before the first frame update
    void Start()
    {
        startDistance = player.transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.GetComponent<Slider>().value = Mathf.InverseLerp(startDistance, finish.transform.position.x, player.transform.position.x);
    }
}
