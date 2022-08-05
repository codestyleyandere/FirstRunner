using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(RawImage))]

public class Parallax : MonoBehaviour
{
    [SerializeField] private float _speed;

    private RawImage _image;
    private float _imagePosition;

    private void Start()
    {
        _image = GetComponent<RawImage>();
        _imagePosition = _image.uvRect.x;
    }

    private void Update()
    {
        _imagePosition += _speed * Time.deltaTime;

        if(_imagePosition > 1)
        {
            _imagePosition = 0;
        }

        _image.uvRect = new Rect(_imagePosition,0,_image.uvRect.width,_image.uvRect.height);
    }
}
