using UnityEngine;
using UnityEngine.Audio;

public class VolumeHandler<T> : MonoBehaviour
{
    [SerializeField] private AudioMixerGroup _audioMixerGroup;

    public void ChangeVolume(float volume, string parameterName)
    {
        _audioMixerGroup.audioMixer.SetFloat(parameterName, Mathf.Log10(volume) * 20);
    }
}
