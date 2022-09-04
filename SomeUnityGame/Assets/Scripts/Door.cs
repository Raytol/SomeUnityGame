using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    private bool _isOpened;
    private AudioSource _audiosource;
    [SerializeField] private Animator _animator;

    private void Start()
    {
        _audiosource = GetComponent<AudioSource>();
        _isOpened = true;
    }
    public void Open()
    {
        print(_isOpened);
        _animator.SetBool("IsOpened", _isOpened);
        _audiosource.Play();
        _isOpened = !_isOpened;
    }
}
