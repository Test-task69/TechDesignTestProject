using UnityEngine;

public class HeroHitController : MonoBehaviour
{
    [SerializeField] private AudioClip _actionSound;
    [SerializeField] private string _actionTrigger = "Attack";

    private Animator _animator;
    private AudioSource _audioSource;

    void Start()
    {
        _animator = GetComponent<Animator>();
        _audioSource = GetComponent<AudioSource>();
    }

    private void OnMouseDown()
    {
        _animator.SetTrigger(_actionTrigger);
        _audioSource.clip = _actionSound;
        _audioSource.Play();
    }
}
