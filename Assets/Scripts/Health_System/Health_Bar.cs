using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class Health_Bar : MonoBehaviour
{

    public Sprite m_Sprite; 

    // Start is called before the first frame update
    void Start()
    {

        SetUp();
        print(m_Sprite);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SetUp()
    {
        m_Sprite = Resources.Load<Sprite>("0000000000000000f000000000000000");

        var canvas = new GameObject("canvas", typeof(Canvas));
        canvas.transform.position = gameObject.transform.position;
        canvas.transform.parent = gameObject.transform;
        var slider = new GameObject("slider", typeof(Slider));
        slider.transform.position = canvas.transform.position;
        slider.transform.parent = canvas.transform;

        var background = new GameObject("Background", typeof(CanvasRenderer), typeof(Image));
        background.transform.parent = slider.transform;
        background.transform.position = slider.transform.position;

        var Fill_Area = new GameObject("Fill Area", typeof(RectTransform));
        Fill_Area.transform.parent = slider.transform;
        Fill_Area.transform.position = slider.transform.position;

        var Fill = new GameObject("Fill", typeof(CanvasRenderer), typeof(Image));
        Fill.transform.parent = Fill_Area.transform;
        Fill.transform.position = Fill_Area.transform.position;

        var Handle_Slide_Area = new GameObject("Handle Slide Area", typeof(RectTransform));
        Handle_Slide_Area.transform.parent = slider.transform;
        Handle_Slide_Area.transform.position = slider.transform.position;

        var Handle = new GameObject("Handle", typeof(CanvasRenderer), typeof(Image));
        Handle.transform.parent = Handle_Slide_Area.transform;
        Handle.transform.position = Handle_Slide_Area.transform.position;

        Handle.GetComponent<UnityEngine.UI.Image>().sprite = null;

    }



}
