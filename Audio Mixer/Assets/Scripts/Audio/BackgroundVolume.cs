public class BackgroundVolume : VolumeHandler<BackgroundVolume>
{
    public void ChangeVolume(float volume)
    {
        ChangeVolume(volume, "Background");
    }
}
