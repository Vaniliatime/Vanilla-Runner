
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Achivements : MonoBehaviour
{
    //General

    public GameObject AchivementsList;
    public bool AchivementsActive = false;
    public GameObject AchTitle;
    public GameObject AchDesc;
// Time Achivs
  

    //Achivement 01 Coin 5
    public GameObject Ach01Image;
    public static int Ach01Count;
    public int Ach01Trigger = 5;
    public int Ach01Code;
     //Achivement 02 Coin 15
    public GameObject Ach02Image;
    public static int Ach02Count;
    public int Ach02Trigger = 15;
    public int Ach02Code;
    //Achivement 03 Coin 50
    public GameObject Ach03Image;
    public static int Ach03Count;
    public int Ach03Trigger = 50;
    public int Ach03Code;
     //Achivement 04 Coin 100
    public GameObject Ach04Image;
    public static int Ach04Count;
    public int Ach04Trigger = 100;
    public int Ach04Code;
    //Achivement 05 Coin 500
    public GameObject Ach05Image;
    public static int Ach05Count;
    public int Ach05Trigger = 500;
    public int Ach05Code;
    //Achivement 06 Death 1
    public GameObject Ach06Image;
    public static int Ach06Count;
    public int Ach06Trigger = 1;
    public int Ach06Code;
    //Achivement 07 Death 5
    public GameObject Ach07Image;
    public static int Ach07Count;
    public int Ach07Trigger = 5;
    public int Ach07Code;
    //Achivement 08 Death 10
    public GameObject Ach08Image;
    public static int Ach08Count;
    public int Ach08Trigger = 10;
    public int Ach08Code;
    //Achivement 09 Death 15
    public GameObject Ach09Image;
    public static int Ach09Count;
    public int Ach09Trigger = 15;
    public int Ach09Code;
    //Achivement 10 Death 20
    public GameObject Ach10Image;
    public static int Ach10Count;
    public int Ach10Trigger = 20;
    public int Ach10Code;

     //Achivement 11 Time 30
    public GameObject Ach11Image;
       //Achivement 12 Time 1m
    public GameObject Ach12Image;
       //Achivement 13 Time 5m
    public GameObject Ach13Image;
       //Achivement 14 Time 10m
    public GameObject Ach14Image;
       //Achivement 15 Time 15m
    public GameObject Ach15Image;


   
   
    void Start()
        {
            StartCoroutine(Ach11Time(30));
            StartCoroutine(Ach12Time(60));
            StartCoroutine(Ach13Time(300));
            StartCoroutine(Ach14Time(600));
            StartCoroutine(Ach15Time(900));



         }




    void Update()
    {
        Ach01Code = PlayerPrefs.GetInt("Achivement01");
        if (Ach01Count == Ach01Trigger && 15 != 0)
        {
             StartCoroutine(Trigger01Ach());
        }

         Ach02Code = PlayerPrefs.GetInt("Achivement02");
        if (Ach02Count == Ach02Trigger && 20 != 0)
        {
             StartCoroutine(Trigger02Ach());
        }

         Ach03Code = PlayerPrefs.GetInt("Achivement03");
        if (Ach03Count == Ach03Trigger && 55 != 0)
        {
             StartCoroutine(Trigger03Ach());
        }

         Ach04Code = PlayerPrefs.GetInt("Achivement04");
        if (Ach04Count == Ach04Trigger && 105 != 0)
        {
             StartCoroutine(Trigger04Ach());
        }

         Ach05Code = PlayerPrefs.GetInt("Achivement05");
        if (Ach05Count == Ach05Trigger && 505 != 0)
        {
             StartCoroutine(Trigger05Ach());
        }

          Ach06Code = PlayerPrefs.GetInt("Achivement06");
        if (Ach06Count == Ach06Trigger && 22 != 0)
        {
             StartCoroutine(Trigger06Ach());
        }
            Ach07Code = PlayerPrefs.GetInt("Achivement07");
        if (Ach07Count == Ach07Trigger && 51 != 0)
        {
             StartCoroutine(Trigger07Ach());
        }
              Ach08Code = PlayerPrefs.GetInt("Achivement08");
        if (Ach08Count == Ach08Trigger && 11 != 0)
        {
             StartCoroutine(Trigger08Ach());
        }

              Ach09Code = PlayerPrefs.GetInt("Achivement09");
        if (Ach09Count == Ach09Trigger && 155 != 0)
        {
             StartCoroutine(Trigger09Ach());
        }

               Ach10Code = PlayerPrefs.GetInt("Achivement10");
        if (Ach10Count == Ach10Trigger && 222 != 0)
        {
             StartCoroutine(Trigger10Ach());
        }

       
          
          
          
   
      
   


           

           
    }
    //Achivement 01
    IEnumerator Trigger01Ach()
    {
        AchivementsActive = true;
        Ach01Code = 1234567; 
        PlayerPrefs.SetInt("Achivement01",15);
        PlayerPrefs.Save();
        Ach01Image.SetActive(true);
        AchTitle.GetComponent<Text>().text = "Collect 5 coins";
        AchDesc.GetComponent<Text>().text = "Collect your first 5 coins in the game";
        AchivementsList.SetActive(true);
        yield return new WaitForSeconds(5);

        //Reseting UI
        AchivementsList.SetActive(false);
        Ach01Image.SetActive(false);
        AchTitle.GetComponent<Text>().text = "";
        AchDesc.GetComponent<Text>().text = "";
        AchivementsActive = false;
    }

  //Achivement 02
    IEnumerator Trigger02Ach()
    {
        AchivementsActive = true;
        Ach02Code = 2134567; 
        PlayerPrefs.SetInt("Achivement02",20);
        PlayerPrefs.Save();
        Ach02Image.SetActive(true);
        AchTitle.GetComponent<Text>().text = "Collect 15 coins";
        AchDesc.GetComponent<Text>().text = "Collect your first 10 coins in the game";
        AchivementsList.SetActive(true);
        yield return new WaitForSeconds(5);

        //Reseting UI
        AchivementsList.SetActive(false);
        Ach02Image.SetActive(false);
        AchTitle.GetComponent<Text>().text = "";
        AchDesc.GetComponent<Text>().text = "";
        AchivementsActive = false;
    }

     //Achivement 03
    IEnumerator Trigger03Ach()
    {
        AchivementsActive = true;
        Ach03Code = 32135; 
        PlayerPrefs.SetInt("Achivement03",35);
        PlayerPrefs.Save();
        Ach03Image.SetActive(true);
        AchTitle.GetComponent<Text>().text = "Collect 50 coins";
        AchDesc.GetComponent<Text>().text = "Collect your first 50 coins in the game";
        AchivementsList.SetActive(true);
        yield return new WaitForSeconds(5);

        //Reseting UI
        AchivementsList.SetActive(false);
        Ach03Image.SetActive(false);
        AchTitle.GetComponent<Text>().text = "";
        AchDesc.GetComponent<Text>().text = "";
        AchivementsActive = false;
    }

          //Achivement 04
    IEnumerator Trigger04Ach()
    {
        AchivementsActive = true;
        Ach04Code = 132135; 
        PlayerPrefs.SetInt("Achivement04",55);
        PlayerPrefs.Save();
        Ach04Image.SetActive(true);
        AchTitle.GetComponent<Text>().text = "Collect 100 coins";
        AchDesc.GetComponent<Text>().text = "Collect your first 100 coins in the game";
        AchivementsList.SetActive(true);
        yield return new WaitForSeconds(5);

        //Reseting UI
        AchivementsList.SetActive(false);
        Ach04Image.SetActive(false);
        AchTitle.GetComponent<Text>().text = "";
        AchDesc.GetComponent<Text>().text = "";
        AchivementsActive = false;
    }
           //Achivement 05
    IEnumerator Trigger05Ach()
    {
        AchivementsActive = true;
        Ach05Code = 132135; 
        PlayerPrefs.SetInt("Achivement05",105);
        PlayerPrefs.Save();
        Ach05Image.SetActive(true);
        AchTitle.GetComponent<Text>().text = "Collect 500 coins";
        AchDesc.GetComponent<Text>().text = "Collect your first 500 coins in the game";
        AchivementsList.SetActive(true);
        yield return new WaitForSeconds(5);

        //Reseting UI
        AchivementsList.SetActive(false);
        Ach05Image.SetActive(false);
        AchTitle.GetComponent<Text>().text = "";
        AchDesc.GetComponent<Text>().text = "";
        AchivementsActive = false;
    }

          //Achivement 06
    IEnumerator Trigger06Ach()
    {
        AchivementsActive = true;
        Ach06Code = 1321395; 
        PlayerPrefs.SetInt("Achivement06",22);
        PlayerPrefs.Save();
        Ach06Image.SetActive(true);
        AchTitle.GetComponent<Text>().text = "Die for 1st time";
        AchDesc.GetComponent<Text>().text = "Congrats. Try Again";
        AchivementsList.SetActive(true);
        yield return new WaitForSeconds(5);

        //Reseting UI
        AchivementsList.SetActive(false);
        Ach06Image.SetActive(false);
        AchTitle.GetComponent<Text>().text = "";
        AchDesc.GetComponent<Text>().text = "";
        AchivementsActive = false;
    }

    
          //Achivement 07
    IEnumerator Trigger07Ach()
    {
        AchivementsActive = true;
        Ach07Code = 13214385; 
        PlayerPrefs.SetInt("Achivement07",51);
        PlayerPrefs.Save();
        Ach07Image.SetActive(true);
        AchTitle.GetComponent<Text>().text = "Die 5 times";
        AchDesc.GetComponent<Text>().text = "Come on u can do better";
        AchivementsList.SetActive(true);
        yield return new WaitForSeconds(5);

        //Reseting UI
        AchivementsList.SetActive(false);
        Ach07Image.SetActive(false);
        AchTitle.GetComponent<Text>().text = "";
        AchDesc.GetComponent<Text>().text = "";
        AchivementsActive = false;
    }

          //Achivement 08
    IEnumerator Trigger08Ach()
    {
        AchivementsActive = true;
        Ach08Code = 1231; 
        PlayerPrefs.SetInt("Achivement08",113);
        PlayerPrefs.Save();
        Ach08Image.SetActive(true);
        AchTitle.GetComponent<Text>().text = "Die 10 times";
        AchDesc.GetComponent<Text>().text = "Oh. Srsly ?!";
        AchivementsList.SetActive(true);
        yield return new WaitForSeconds(5);

        //Reseting UI
        AchivementsList.SetActive(false);
        Ach08Image.SetActive(false);
        AchTitle.GetComponent<Text>().text = "";
        AchDesc.GetComponent<Text>().text = "";
        AchivementsActive = false;
    }
      //Achivement 09
    IEnumerator Trigger09Ach()
    {
        AchivementsActive = true;
        Ach09Code = 1321635; 
        PlayerPrefs.SetInt("Achivement09",1557);
        PlayerPrefs.Save();
        Ach09Image.SetActive(true);
        AchTitle.GetComponent<Text>().text = "Die 15 times";
        AchDesc.GetComponent<Text>().text = "...";
        AchivementsList.SetActive(true);
        yield return new WaitForSeconds(5);

        //Reseting UI
        AchivementsList.SetActive(false);
        Ach09Image.SetActive(false);
        AchTitle.GetComponent<Text>().text = "";
        AchDesc.GetComponent<Text>().text = "";
        AchivementsActive = false;
    }
          //Achivement 10
    IEnumerator Trigger10Ach()
    {
        AchivementsActive = true;
        Ach10Code = 1321335; 
        PlayerPrefs.SetInt("Achivement10",2232);
        PlayerPrefs.Save();
        Ach10Image.SetActive(true);
        AchTitle.GetComponent<Text>().text = "Die 20 times";
        AchDesc.GetComponent<Text>().text = "Ok I think thats it.";
        AchivementsList.SetActive(true);
        yield return new WaitForSeconds(5);

        //Reseting UI
        AchivementsList.SetActive(false);
        Ach10Image.SetActive(false);
        AchTitle.GetComponent<Text>().text = "";
        AchDesc.GetComponent<Text>().text = "";
        AchivementsActive = false;
    }



        //Achivement 11
        IEnumerator Ach11Time(float time)
            {
            yield return new WaitForSeconds(time);
            
            AchivementsActive = true;
            
            Ach11Image.SetActive(true);
            AchTitle.GetComponent<Text>().text = "Spend 30 into the game";
            AchDesc.GetComponent<Text>().text = "Keep Going.";
            AchivementsList.SetActive(true);
            yield return new WaitForSeconds(5);
            //Reseting UI

            AchivementsList.SetActive(false);
            Ach11Image.SetActive(false);
            AchTitle.GetComponent<Text>().text = "";
            AchDesc.GetComponent<Text>().text = "";
            AchivementsActive = false;    
            }

        IEnumerator Ach12Time(float time)
            {
            yield return new WaitForSeconds(time);
            
            AchivementsActive = true;
            
            Ach12Image.SetActive(true);
            AchTitle.GetComponent<Text>().text = "Spend 1m into the game";
            AchDesc.GetComponent<Text>().text = "You doing great.";
            AchivementsList.SetActive(true);
            yield return new WaitForSeconds(5);
            //Reseting UI

            AchivementsList.SetActive(false);
            Ach12Image.SetActive(false);
            AchTitle.GetComponent<Text>().text = "";
            AchDesc.GetComponent<Text>().text = "";
            AchivementsActive = false;    
            }

        IEnumerator Ach13Time(float time)
            {
            yield return new WaitForSeconds(time);
            
            AchivementsActive = true;
            
            Ach13Image.SetActive(true);
            AchTitle.GetComponent<Text>().text = "Spend 5m into the game";
            AchDesc.GetComponent<Text>().text = "Awesome";
            AchivementsList.SetActive(true);
            yield return new WaitForSeconds(5);
            //Reseting UI

            AchivementsList.SetActive(false);
            Ach13Image.SetActive(false);
            AchTitle.GetComponent<Text>().text = "";
            AchDesc.GetComponent<Text>().text = "";
            AchivementsActive = false;    
            }

        IEnumerator Ach14Time(float time)
            {
            yield return new WaitForSeconds(time);
            
            AchivementsActive = true;
            
            Ach14Image.SetActive(true);
            AchTitle.GetComponent<Text>().text = "Spend 10m into the game";
            AchDesc.GetComponent<Text>().text = "Holy. You rock.";
            AchivementsList.SetActive(true);
            yield return new WaitForSeconds(5);
            //Reseting UI

            AchivementsList.SetActive(false);
            Ach14Image.SetActive(false);
            AchTitle.GetComponent<Text>().text = "";
            AchDesc.GetComponent<Text>().text = "";
            AchivementsActive = false;    
            }
  
        IEnumerator Ach15Time(float time)
            {
            yield return new WaitForSeconds(time);
            
            AchivementsActive = true;
            
            Ach15Image.SetActive(true);
            AchTitle.GetComponent<Text>().text = "Spend 15m into the game";
            AchDesc.GetComponent<Text>().text = "Yes Boss";
            AchivementsList.SetActive(true);
            yield return new WaitForSeconds(5);
            //Reseting UI

            AchivementsList.SetActive(false);
            Ach15Image.SetActive(false);
            AchTitle.GetComponent<Text>().text = "";
            AchDesc.GetComponent<Text>().text = "";
            AchivementsActive = false;    
            }
}

