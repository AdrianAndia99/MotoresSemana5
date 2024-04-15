using UnityEngine;
using Cinemachine;

public class CamaraShake : MonoBehaviour
{
    public static CamaraShake Instance;
    private CinemachineVirtualCamera VirtualCamera;
    private float TimeShake;

    private void Awake()
    {
        Instance = this;
        VirtualCamera = GetComponent<CinemachineVirtualCamera>();
    }

    public void Shake(float intensity, float time)
    {
        CinemachineBasicMultiChannelPerlin cinemachine = VirtualCamera.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>();
        cinemachine.m_AmplitudeGain = intensity;
        TimeShake = time;
    }

    private void FixedUpdate()
    {
        if(TimeShake > 0)
        {
            TimeShake = TimeShake - Time.deltaTime;
            if(TimeShake <= 0f)
            {
                CinemachineBasicMultiChannelPerlin cinemachine = VirtualCamera.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>();
                cinemachine.m_AmplitudeGain = 0f;
            }
        }
    }
}