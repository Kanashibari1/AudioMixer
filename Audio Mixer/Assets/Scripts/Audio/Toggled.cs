using UnityEngine;
using UnityEngine.Audio;

public class Toggled : MonoBehaviour
{
    [SerializeField] private AudioMixerGroup _audioMixerGroup;

    private bool _isMuted = false;
    private float _lastVolume = 0f;

    public void Toggle()
    {
        _isMuted = _isMuted != true;

        if (_isMuted)
        {
            _audioMixerGroup.audioMixer.GetFloat("Master", out _lastVolume);
            _audioMixerGroup.audioMixer.SetFloat("Master", -80);
        }
        else
        {
            _audioMixerGroup.audioMixer.SetFloat("Master", _lastVolume);
        }
    }
}
