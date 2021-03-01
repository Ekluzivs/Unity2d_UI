using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class vardaparadisana : MonoBehaviour
{
    string teksts;
    public GameObject ievadlauks;
    public GameObject cauvins;
 public void uzgabatTekstu(){
     teksts=ievadlauks.GetComponent<Text>().text;
     cauvins.GetComponent<Text>().text="Sveiks "+teksts.ToUpper()+"!";
 }
}