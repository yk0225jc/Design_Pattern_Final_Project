//Written by Jiameng Zhou
using System.Linq;
using System.Text;
using UnityEngine;

public abstract class AbstractAssembleCar : MonoBehaviour
{
    public abstract void BuildBody();
    public abstract void BuildFrontBumper();
    public abstract void BuildTire();

    public abstract Product GetResult(); 


}
