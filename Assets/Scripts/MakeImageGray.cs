using UnityEngine;
using UnityEngine.UI;

public class MakeImageGray : MonoBehaviour
{
    private Image image;
    // Start is called before the first frame update
    void Start()
    {
        image = GameObject.Find("Canvas/Image").transform.GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            UIUtils.SetImgGary(image,true);
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            UIUtils.SetImgGary(image,false);
        }
    }
}
