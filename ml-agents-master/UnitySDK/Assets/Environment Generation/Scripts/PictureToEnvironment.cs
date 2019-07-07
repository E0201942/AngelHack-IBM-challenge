using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.AI;

public class PictureToEnvironment : MonoBehaviour
{
    public List<NavMeshSurface> surfaces;
    [SerializeField]
    private Texture2D image;
    public GameObject road;
    // Start is called before the first frame update
    void Start()
    {

        // Do some processing
        Color[] pix = image.GetPixels();
        for(int i = 0; i< pix.Length; i++)
        {
            if (!(pix[i].r > 0.4 && pix[i].r <1 && pix[i].g >0.4 && pix[i].g < 0.87 && pix[i].b > 0.4 && pix[i].b < 0.87))
            {
                int x = i % 256;
                int y = i / 256;
       
               Instantiate(road, new Vector3(x, 0, y), Quaternion.identity);
              


            }

        }
  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
