using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Strategy : MonoBehaviour
{
    public interface ISpeed
    {
        int speed(int speed);
    }
}
