using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class atteluparadisana : MonoBehaviour
{
    public GameObject bean;
    public GameObject lacuks;
    public GameObject tante;
    public GameObject masina;
    public GameObject mainigaisAttels;
    public Sprite[] atteluMasivs;
    public GameObject slaideris;
    public AudioSource skanasavots;
    public AudioClip skanakoatskanot;

public void binaAttelosana(bool vertiba){
    bean.SetActive(vertiba);
}
public void lacisAttelosana(bool vertiba){
    lacuks.SetActive(vertiba);
}
public void masinaAttelosana(bool vertiba){
    masina.SetActive(vertiba);
}
public void tanteAttelosana(bool vertiba){
    tante.SetActive(vertiba);
}
public void paKreisiBins()
{
    bean.transform.localScale = new Vector2(1, 1);
}
public void paLabiBins()
{
    bean.transform.localScale = new Vector2(-1, 1);
}
public void izkritosais(int skaitlis){
    if(skaitlis==0){
        mainigaisAttels.GetComponent<Image>().sprite = atteluMasivs[0];
    }else if (skaitlis==1){
        mainigaisAttels.GetComponent<Image>().sprite = atteluMasivs[1];
    }else if (skaitlis==2){
        mainigaisAttels.GetComponent<Image>().sprite = atteluMasivs[2];
    }
}
public void mainitLielumu(){
    float pasreizejaVertiba = slaideris.GetComponent<Slider>().value;
    mainigaisAttels.transform.localScale = new Vector2(1F * pasreizejaVertiba, 1F * pasreizejaVertiba);
    }
    public void uzbiditsuzattela(){
        skanasavots.PlayOneShot(skanakoatskanot);
    }
        public void kursorsnobiditsnoattela(){
        skanasavots.Stop();
    }
}