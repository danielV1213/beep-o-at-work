using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundsMenu : MonoBehaviour
{
    public AudioSource source;
    public AudioClip  audioClipList;


 

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Laser"))
        {
            if (source.isPlaying)
            {
                source.Stop();
                source.PlayOneShot(audioClipList);
            }
            else
            {
                source.PlayOneShot(audioClipList);
            }
           

            //switch (this.gameObject.name)
            //{
            //    case "Historia":
            //        source.PlayOneShot(audioClipList);
            //        break;
            //    case "Creativo":
            //        source.PlayOneShot(audioClipList[1]);
            //        break;
            //    case "Conf":
            //        source.PlayOneShot(audioClipList[2]);
            //        break;
              
            //    default:
            //        Debug.Log("NOT FOUND SOUND");
            //        break;

            //}

        }

    }
}
