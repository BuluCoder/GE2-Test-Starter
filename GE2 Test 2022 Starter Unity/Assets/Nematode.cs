using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nematode : MonoBehaviour
{
    public int length;

    public Material material;

    void Awake()
    {
        for (int i = 0; i < length; i++)
        {
            GameObject nema = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            nema.transform.position = new Vector3(0, 0, -i);

            float width = 1.5f - (i / (float)length);
            float height = 1.5f - (i / (float)length);

            nema.transform.localScale = new Vector3(width, height, 1);
            nema.transform.parent = this.transform;

            nema.GetComponent<Renderer>().material.color = Color.HSVToRGB(i / (float)length, 1, 1);

            if (i == 0)
            {
                nema.AddComponent(typeof(NoiseWander));
            }

        }
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
