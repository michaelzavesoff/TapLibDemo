using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Animations;
using UnityEngine.SceneManagement;

public class GameManager2 : MonoBehaviour
{
    

    private Scene scene;

    [Header("Dancer")]
    public Animator anim;

    //Begin Timer
    [Header("Countdown Timer")]
    public GameObject CountdownTimer;
    public GameObject threeText, twoText, oneText, goText;
    public float MaxTime;
    public float currentTime;

    [Space(10)]

    [Header("Score")]
    public Text scoreLabel;
    public int score;
    public int multiplier;
    public int streak;

 //   public Text enemyLabel;

    // public NetworkVariable<int> score1 = new NetworkVariable<int>(value: 0, NetworkVariableReadPermission.Everyone, NetworkVariableWritePermission.Owner);
  //   public NetworkVariable<int> score2 = new NetworkVariable<int>(value: 0, NetworkVariableReadPermission.Everyone, NetworkVariableWritePermission.Owner);

   // public int players;
   // public GameObject[] playersInGame;

   // [SerializeField] private GameObject wfpText;


    // public NetworkVariable<int> enemyScore = new NetworkVariable<int>();

    //public Text enemyScoreLabel;

    [Space(10)]

    [Header("Song")]
    public AudioSource song;

    [Header("Currency")]
    public Store store;

    [Header("Rewards")]
    public int correctLibs;

    #region ***********Libs***************
    [Header("Libs")]
    public GameObject lib1;
    public GameObject lib2;
    public GameObject lib3;
    public GameObject lib4;
    public GameObject lib5;
    public GameObject lib6;
    public GameObject lib7;
    public GameObject lib8;
    public GameObject lib9;
    public GameObject lib10;
    public GameObject lib11;
    public GameObject lib12;
    public GameObject lib13;
    public GameObject lib14;
    public GameObject lib15;
    public GameObject lib16;
    public GameObject lib17;
    public GameObject lib18;
    public GameObject lib19;
    public GameObject lib20;
    public GameObject lib21;
    public GameObject lib22;
    public GameObject lib23;
    public GameObject lib24;
    public GameObject lib25;
    public GameObject lib26;
    public GameObject lib27;
    public GameObject lib28;
    public GameObject lib29;
    public GameObject lib30;
    public GameObject lib31;
    public GameObject lib32;
    public GameObject lib33;
    public GameObject lib34;
    public GameObject lib35;
    public GameObject lib36;
    public GameObject lib37;
    public GameObject lib38;
    public GameObject lib39;
    public GameObject lib40;
    public GameObject lib41;
    public GameObject lib42;
    public GameObject lib43;
    public GameObject lib44;
    public GameObject lib45;
    public GameObject lib46;
    public GameObject lib47;
    public GameObject lib48;
    public GameObject lib49;
    public GameObject lib50;
    public GameObject lib51;
    public GameObject lib52;
    public GameObject lib53;
    public GameObject lib54;
    public GameObject lib55;
    public GameObject lib56;
    public GameObject lib57;
    public GameObject lib58;
    public GameObject lib59;
    public GameObject lib60;
    public GameObject lib61;
    public GameObject lib62;
    public GameObject lib63;
    public GameObject lib64;
    public GameObject lib65;
    public GameObject lib66;
    public GameObject lib67;
    public GameObject lib68;
    public GameObject lib69;
    public GameObject lib70;
    public GameObject lib71;
    public GameObject lib72;
    public GameObject lib73;
    public GameObject lib74;
    public GameObject lib75;
    public GameObject lib76;
    public GameObject lib77;
    public GameObject lib78;
    public GameObject lib79;
    public GameObject lib80;
    public GameObject lib81;
    public GameObject lib82;
    public GameObject lib83;
    public GameObject lib84;
    public GameObject lib85;
    public GameObject lib86;
    public GameObject lib87;
    public GameObject lib88;
    public GameObject lib89;
    public GameObject lib90;
    public GameObject lib91;
    public GameObject lib92;
    public GameObject lib93;
    public GameObject lib94;
    public GameObject lib95;
    public GameObject lib96;
    public GameObject lib97;
    public GameObject lib98;
    public GameObject lib99;
    public GameObject lib100;
    public GameObject lib101;
    public GameObject lib102;
    public GameObject lib103;
    public GameObject lib104;
    public GameObject lib105;
    public GameObject lib106;
    public GameObject lib107;
    public GameObject lib108;
    public GameObject lib109;
    public GameObject lib110;
    public GameObject lib111;
    public GameObject lib112;
    public GameObject lib113;
    public GameObject lib114;
    public GameObject lib115;
    public GameObject lib116;
    public GameObject lib117;
    public GameObject lib118;
    public GameObject lib119;
    public GameObject lib120;
    public GameObject lib121;
    public GameObject lib122;
    #endregion


    

    [Space(5)]

    public int randomWrong;
    public int randomRight;

    // Good Words
    [Header("Good Words")]
    public GameObject good1;
    public GameObject good2;
    public GameObject good3;
    public GameObject good4;
    public GameObject good5;

    [Space(5)]
    // Bad Words
    [Header("Bad Words")]
    public GameObject bad1;
    public GameObject bad2;
    public GameObject bad3;
    public GameObject bad4;

    [Space(5)]
    [Header("Timer")]
    public Timer t;

    [Space(5)]
    [Header("Final Screen")]
    public int reloadScene;

    //private Text playerName;

    public GameObject game;
    
   // public ulong networkPlayerName;

  //  public bool enoughPlayers;

   // [SerializeField] private Text waitForPlayersTXT;

    [SerializeField] private GameObject WinText;
    [SerializeField] private GameObject LoseText;
    [SerializeField] private GameObject final;
    [SerializeField] private Text finalScoreText;


    // [Header("Netcode")] //

    [Space(5)]
    public Image fade1, fade2, fade3, button1, button2, button3, bg, fx;
    public Sprite fadeNormal;
    public Sprite fadeStreak;
    public Sprite btnNormal;
    public Sprite btnStreak;
    public Sprite bgNormal, bgStreak;
    public Sprite fxNormal, fxStreak;
    public GameObject sparks;
    public AudioSource sparkMachine;
    public AudioSource crowdCheer;



    void Start()
    {
        Time.timeScale = 1f;
        game.SetActive(true);
        scene = SceneManager.GetActiveScene();

        switch (scene.name)
        {
            case "BB":
                StartCoroutine(startBBTimer());
                break;
            case "HotelLobby":
                StartCoroutine(startHLTimer());
                break;
            case "HotelLobby 1":
                StartCoroutine(startMIXTimer());
                break;
        }
    }

    void Update()
    {
        scene = SceneManager.GetActiveScene();
        scoreLabel.text = score.ToString();

        

        Debug.Log("GAME RUNNING"); // Delete

        #region RIGHTWORDS -----
        if (randomRight == 1)
        {
            good1.SetActive(true);
            good2.SetActive(false);
            good3.SetActive(false);
            good4.SetActive(false);
            good5.SetActive(false);
        }
        else if (randomRight == 2)
        {
            good1.SetActive(false);
            good2.SetActive(true);
            good3.SetActive(false);
            good4.SetActive(false);
            good5.SetActive(false);
        }
        else if (randomRight == 3)
        {
            good1.SetActive(false);
            good2.SetActive(false);
            good3.SetActive(true);
            good4.SetActive(false);
            good5.SetActive(false);
        }
        else if (randomRight == 4)
        {
            good1.SetActive(false);
            good2.SetActive(false);
            good3.SetActive(false);
            good4.SetActive(true);
            good5.SetActive(false);
        }
        else if (randomRight == 5)
        {
            good1.SetActive(false);
            good2.SetActive(false);
            good3.SetActive(false);
            good4.SetActive(false);
            good5.SetActive(true);
        }
        #endregion

        #region WRONGWORDS -----
        if (randomWrong == 1)
        {
            bad1.SetActive(true);
            bad2.SetActive(false);
            bad3.SetActive(false);
            bad4.SetActive(false);
        }
        else if (randomWrong == 2)
        {
            bad1.SetActive(false);
            bad2.SetActive(true);
            bad3.SetActive(false);
            bad4.SetActive(false);
        }
        else if (randomWrong == 3)
        {
            bad1.SetActive(false);
            bad2.SetActive(false);
            bad3.SetActive(true);
            bad4.SetActive(false);
        }
        else if (randomWrong == 4)
        {
            bad1.SetActive(false);
            bad2.SetActive(false);
            bad3.SetActive(false);
            bad4.SetActive(true);
        }
        #endregion

        if (randomWrong == 0)
        {
            bad1.SetActive(false);
            bad2.SetActive(false);
            bad3.SetActive(false);
            bad4.SetActive(false);
        }

        if (randomRight == 0)
        {
            good1.SetActive(false);
            good2.SetActive(false);
            good3.SetActive(false);
            good4.SetActive(false);
            good5.SetActive(false);
        }

        if(score < 0)
        {
            score = 0;
        }

        if(streak >= 3)
        {
            StartStreak();
        }
        else
        {
            ResetStreak();
        }
    }

    public void StartStreak()
    {
        fade1.sprite = fadeStreak;
        fade2.sprite = fadeStreak;
        fade3.sprite = fadeStreak;

        button1.sprite = btnStreak;
        button2.sprite = btnStreak;
        button3.sprite = btnStreak;

        bg.sprite = bgStreak;

        fx.sprite = fxStreak;

        sparks.SetActive(true);
        sparkMachine.Play();
        crowdCheer.Play();
    }

    public void ResetStreak()
    {
        fade1.sprite = fadeNormal;
        fade2.sprite = fadeNormal;
        fade3.sprite = fadeNormal;

        button1.sprite = btnNormal;
        button2.sprite = btnNormal;
        button3.sprite = btnNormal;

        bg.sprite = bgNormal;

        fx.sprite = fxNormal;

        sparks.SetActive(false);
        sparkMachine.Stop();
        crowdCheer.Stop();
    }


    public IEnumerator startBBTimer()
    {
        Debug.Log("Game Started");
        yield return new WaitForSeconds(1f);
        threeText.SetActive(true);
        yield return new WaitForSeconds(1f);
        threeText.SetActive(false);
        twoText.SetActive(true);
        yield return new WaitForSeconds(1f);
        twoText.SetActive(false);
        oneText.SetActive(true);
        yield return new WaitForSeconds(1f);
        oneText.SetActive(false);
        goText.SetActive(true);
        yield return new WaitForSeconds(1f);
        CountdownTimer.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        song.Play();
        t.enabled = true;
        StartCoroutine(startBBSong());
        yield return new WaitForSeconds(335f); 
        store.UpdateCoins();
        
    }

    public IEnumerator startBBSong()
    {
        yield return new WaitForSeconds(15f);
       // anim.SetBool("Dance", true);
        lib1.SetActive(true);
        yield return new WaitForSeconds(1.5f);
        lib2.SetActive(true);
        yield return new WaitForSeconds(2f);
        lib3.SetActive(true);
        yield return new WaitForSeconds(2f);
        lib4.SetActive(true);
        yield return new WaitForSeconds(1.6f);
        lib5.SetActive(true);
        yield return new WaitForSeconds(2f);
        lib6.SetActive(true);
        yield return new WaitForSeconds(2f);
        lib7.SetActive(true);
        yield return new WaitForSeconds(2f);
        lib8.SetActive(true);
        yield return new WaitForSeconds(1f);
        lib9.SetActive(true);
        yield return new WaitForSeconds(1.9f);
        lib10.SetActive(true);
        yield return new WaitForSeconds(2f);
        lib11.SetActive(true);
        yield return new WaitForSeconds(2f);
        lib12.SetActive(true);
        yield return new WaitForSeconds(2f);
        lib13.SetActive(true);
        yield return new WaitForSeconds(1.9f);
        lib14.SetActive(true);
        yield return new WaitForSeconds(1.8f);
        lib15.SetActive(true);
        yield return new WaitForSeconds(2f);
        lib16.SetActive(true);
        yield return new WaitForSeconds(8f);
        lib17.SetActive(true);
        yield return new WaitForSeconds(2f);
        lib18.SetActive(true);
        yield return new WaitForSeconds(1.8f);
        lib19.SetActive(true);
        yield return new WaitForSeconds(2f);
        lib20.SetActive(true);
        yield return new WaitForSeconds(2f);
        lib21.SetActive(true);
        yield return new WaitForSeconds(2f);
        lib22.SetActive(true);
        yield return new WaitForSeconds(1f);
        lib23.SetActive(true);
        yield return new WaitForSeconds(2f);
        lib24.SetActive(true);
        yield return new WaitForSeconds(2f);
        lib25.SetActive(true);
        yield return new WaitForSeconds(4f);
        lib26.SetActive(true);
        yield return new WaitForSeconds(2f);
        lib27.SetActive(true);
        yield return new WaitForSeconds(3f);
        lib28.SetActive(true);
        yield return new WaitForSeconds(3f);
        lib29.SetActive(true);
        yield return new WaitForSeconds(1f);
        lib30.SetActive(true);
        yield return new WaitForSeconds(2f);
        lib31.SetActive(true);
        yield return new WaitForSeconds(2f);
        lib32.SetActive(true);
        yield return new WaitForSeconds(2f);
        lib33.SetActive(true);
        yield return new WaitForSeconds(2f);
        lib34.SetActive(true);
        yield return new WaitForSeconds(2f);
        lib35.SetActive(true);
        yield return new WaitForSeconds(5f);
        lib36.SetActive(true);
        yield return new WaitForSeconds(2f);
        lib37.SetActive(true);
        yield return new WaitForSeconds(2f);
        lib38.SetActive(true);
        yield return new WaitForSeconds(2f);
        lib39.SetActive(true);
        yield return new WaitForSeconds(2f);
        lib40.SetActive(true);
        yield return new WaitForSeconds(1f);
        lib41.SetActive(true);
        yield return new WaitForSeconds(3f);
        lib42.SetActive(true);
        yield return new WaitForSeconds(2f);
        lib43.SetActive(true);
        yield return new WaitForSeconds(2f);
        lib44.SetActive(true);
        yield return new WaitForSeconds(2f);
        lib45.SetActive(true);
        yield return new WaitForSeconds(1f);
        lib46.SetActive(true);
        yield return new WaitForSeconds(2f);
        lib47.SetActive(true);
        yield return new WaitForSeconds(2f);
        lib48.SetActive(true);
        yield return new WaitForSeconds(2f);
        lib49.SetActive(true);
        yield return new WaitForSeconds(2f);
        lib50.SetActive(true);
        yield return new WaitForSeconds(1f);
        lib51.SetActive(true);
        yield return new WaitForSeconds(2f);
        lib52.SetActive(true);
        yield return new WaitForSeconds(2f);
        lib53.SetActive(true);
        yield return new WaitForSeconds(2f);
        lib54.SetActive(true);
        yield return new WaitForSeconds(2f);
        lib55.SetActive(true);
        yield return new WaitForSeconds(2f);
        lib56.SetActive(true);
        yield return new WaitForSeconds(2f);
        lib57.SetActive(true);
        yield return new WaitForSeconds(3f);
        lib58.SetActive(true);
        yield return new WaitForSeconds(4f);
        lib59.SetActive(true);
        yield return new WaitForSeconds(4f);
        lib60.SetActive(true);
        yield return new WaitForSeconds(2f);
        lib61.SetActive(true);
        yield return new WaitForSeconds(2f);
        lib62.SetActive(true);
        yield return new WaitForSeconds(2f);
        lib63.SetActive(true);
        yield return new WaitForSeconds(2f);
        lib64.SetActive(true);
        yield return new WaitForSeconds(3f);
        lib65.SetActive(true);
        yield return new WaitForSeconds(2f);
        lib66.SetActive(true);
        yield return new WaitForSeconds(2f);
        lib67.SetActive(true);
        yield return new WaitForSeconds(2f);
        lib68.SetActive(true);
        yield return new WaitForSeconds(2f);
        lib69.SetActive(true);
        yield return new WaitForSeconds(4f);
        lib70.SetActive(true);
        yield return new WaitForSeconds(4f);
        lib71.SetActive(true);
        yield return new WaitForSeconds(4f);
        lib72.SetActive(true);
        yield return new WaitForSeconds(5f);
        lib73.SetActive(true);
        yield return new WaitForSeconds(2f);
        lib74.SetActive(true);
        yield return new WaitForSeconds(2f);
        lib75.SetActive(true);
        yield return new WaitForSeconds(2f);
        lib76.SetActive(true);
        yield return new WaitForSeconds(1f);
        lib77.SetActive(true);
        yield return new WaitForSeconds(3f);
        lib78.SetActive(true);
        yield return new WaitForSeconds(1f);
        lib79.SetActive(true);
        yield return new WaitForSeconds(2f);
        lib80.SetActive(true);
        yield return new WaitForSeconds(2f);
        lib81.SetActive(true);
        yield return new WaitForSeconds(2f);
        lib82.SetActive(true);
        yield return new WaitForSeconds(2f);
        lib83.SetActive(true);
        yield return new WaitForSeconds(2f);
        lib84.SetActive(true);
        yield return new WaitForSeconds(2f);
        lib85.SetActive(true);
        yield return new WaitForSeconds(2f);
        lib86.SetActive(true);
        yield return new WaitForSeconds(2f);
        lib87.SetActive(true);
        yield return new WaitForSeconds(2f);
        lib88.SetActive(true);
        yield return new WaitForSeconds(1f);
        lib89.SetActive(true);
        yield return new WaitForSeconds(2f);
        lib90.SetActive(true);
        yield return new WaitForSeconds(2f);
        lib91.SetActive(true);
        yield return new WaitForSeconds(2f);
        lib92.SetActive(true);
        yield return new WaitForSeconds(2f);
        lib93.SetActive(true);
        yield return new WaitForSeconds(2f);
        lib94.SetActive(true);
        yield return new WaitForSeconds(1f);
        lib95.SetActive(true);
        yield return new WaitForSeconds(4f);
        lib96.SetActive(true);
        yield return new WaitForSeconds(6f);
        lib97.SetActive(true);
        yield return new WaitForSeconds(4f);
        lib98.SetActive(true);
        yield return new WaitForSeconds(2f);
        lib99.SetActive(true);
        yield return new WaitForSeconds(9f);
        lib100.SetActive(true);
        yield return new WaitForSeconds(4f);
        lib101.SetActive(true);
        yield return new WaitForSeconds(2f);
        lib102.SetActive(true);
        yield return new WaitForSeconds(4f);
        lib103.SetActive(true);
        yield return new WaitForSeconds(3f);
        lib104.SetActive(true);
        yield return new WaitForSeconds(18f);
        lib105.SetActive(true);
        yield return new WaitForSeconds(5f);
        lib106.SetActive(true);
        yield return new WaitForSeconds(4f);
        lib107.SetActive(true);
        yield return new WaitForSeconds(2f);
        lib108.SetActive(true);
        yield return new WaitForSeconds(2f);
        lib109.SetActive(true);
        yield return new WaitForSeconds(2f);
        lib110.SetActive(true);
        yield return new WaitForSeconds(2f);
        lib111.SetActive(true);
        yield return new WaitForSeconds(2f);
        lib112.SetActive(true);
        yield return new WaitForSeconds(2f);
        lib113.SetActive(true);
        yield return new WaitForSeconds(2f);
        lib114.SetActive(true);
        yield return new WaitForSeconds(1f);
        lib115.SetActive(true);
        yield return new WaitForSeconds(1f);
        lib116.SetActive(true);
        yield return new WaitForSeconds(2f);
        lib117.SetActive(true);
        yield return new WaitForSeconds(2f);
        lib118.SetActive(true);
        yield return new WaitForSeconds(2f);
        lib119.SetActive(true);
        yield return new WaitForSeconds(2f);
        lib120.SetActive(true);
        yield return new WaitForSeconds(2f);
        lib121.SetActive(true);
        yield return new WaitForSeconds(2f);
        lib122.SetActive(true);
        UpdateFinal();
    }

    public IEnumerator startHLSong()
    {
        yield return new WaitForSeconds(16.5f);
        lib1.SetActive(true);
        yield return new WaitForSeconds(3.75f);
        lib2.SetActive(true);
        yield return new WaitForSeconds(3);
        lib3.SetActive(true);
        yield return new WaitForSeconds(1.75f);
        lib4.SetActive(true);
        yield return new WaitForSeconds(3.75f);
        lib5.SetActive(true);
        yield return new WaitForSeconds(2.75f);
        lib6.SetActive(true);
        yield return new WaitForSeconds(4f);
        lib7.SetActive(true);
        yield return new WaitForSeconds(3f);
        lib8.SetActive(true);
        yield return new WaitForSeconds(2f);
        lib9.SetActive(true);
        yield return new WaitForSeconds(3.8f);
        lib10.SetActive(true);
        yield return new WaitForSeconds(3f);
        lib11.SetActive(true);
        yield return new WaitForSeconds(2f);
        lib12.SetActive(true);
        yield return new WaitForSeconds(2f);
        lib13.SetActive(true);
        yield return new WaitForSeconds(2f);
        lib14.SetActive(true);
        yield return new WaitForSeconds(2f);
        lib15.SetActive(true);
        yield return new WaitForSeconds(2f);
        lib16.SetActive(true);
        yield return new WaitForSeconds(2f);
        lib17.SetActive(true);
        yield return new WaitForSeconds(3f);
        lib18.SetActive(true);
        yield return new WaitForSeconds(4f);
        lib19.SetActive(true);
        yield return new WaitForSeconds(3f);
        lib20.SetActive(true);
        yield return new WaitForSeconds(4f);
        lib21.SetActive(true);
        yield return new WaitForSeconds(2f);
        lib22.SetActive(true);
        yield return new WaitForSeconds(2f);
        lib23.SetActive(true);
        yield return new WaitForSeconds(2f);
        lib24.SetActive(true);
        yield return new WaitForSeconds(2f);
        lib25.SetActive(true);
        yield return new WaitForSeconds(2f);
        lib26.SetActive(true);
        yield return new WaitForSeconds(3f);
        lib27.SetActive(true);
        yield return new WaitForSeconds(4f);
        lib28.SetActive(true);
        yield return new WaitForSeconds(3f);
        lib29.SetActive(true);
        yield return new WaitForSeconds(2f);
        lib30.SetActive(true);
        yield return new WaitForSeconds(2f);
        lib31.SetActive(true);
        yield return new WaitForSeconds(2f);
        lib32.SetActive(true);
        yield return new WaitForSeconds(1f);
        lib33.SetActive(true);
        yield return new WaitForSeconds(2f);
        lib34.SetActive(true);
        yield return new WaitForSeconds(2f);
        lib35.SetActive(true);
        yield return new WaitForSeconds(2f);
        lib36.SetActive(true);
        yield return new WaitForSeconds(2f);
        lib37.SetActive(true);
        yield return new WaitForSeconds(2f);
        lib38.SetActive(true);
        yield return new WaitForSeconds(2f);
        lib39.SetActive(true);
        yield return new WaitForSeconds(2f);
        lib40.SetActive(true);
        yield return new WaitForSeconds(2f);
        lib41.SetActive(true);
        yield return new WaitForSeconds(2f);
        lib42.SetActive(true);
        yield return new WaitForSeconds(2f);
        lib43.SetActive(true);
        yield return new WaitForSeconds(2f);
        lib44.SetActive(true);
        yield return new WaitForSeconds(4f);
        lib45.SetActive(true);
        yield return new WaitForSeconds(3f);
        lib46.SetActive(true);
        yield return new WaitForSeconds(3f);
        lib47.SetActive(true);
        yield return new WaitForSeconds(3f);
        lib48.SetActive(true);
    }

    public IEnumerator startHLTimer()
    {
        Debug.Log("Game Started");
        yield return new WaitForSeconds(1f);
        threeText.SetActive(true);
        yield return new WaitForSeconds(1f);
        threeText.SetActive(false);
        twoText.SetActive(true);
        yield return new WaitForSeconds(1f);
        twoText.SetActive(false);
        oneText.SetActive(true);
        yield return new WaitForSeconds(1f);
        oneText.SetActive(false);
        goText.SetActive(true);
        yield return new WaitForSeconds(1f);
        CountdownTimer.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        song.Play();
        t.enabled = true;
        StartCoroutine(startHLSong());
        yield return new WaitForSeconds(204f);
        store.UpdateCoins();

    }



    public IEnumerator startMIXTimer()
    {
        Debug.Log("timer started");
        yield return new WaitForSeconds(1f);
        threeText.SetActive(true);
        yield return new WaitForSeconds(1f);
        threeText.SetActive(false);
        twoText.SetActive(true);
        yield return new WaitForSeconds(1f);
        twoText.SetActive(false);
        oneText.SetActive(true);
        yield return new WaitForSeconds(1f);
        oneText.SetActive(false);
        goText.SetActive(true);
        yield return new WaitForSeconds(1f);
        CountdownTimer.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        song.Play();
        t.enabled = true;
        StartCoroutine(startMIXSong());
        yield return new WaitForSeconds(387f);
        store.UpdateCoins();
    }

    public IEnumerator startMIXSong()
    {
        yield return new WaitForSeconds(50f);
        anim.SetBool("Dance", true);
        lib1.SetActive(true);
        yield return new WaitForSeconds(2f);
        lib2.SetActive(true);
        yield return new WaitForSeconds(3f);
        lib3.SetActive(true);
        yield return new WaitForSeconds(1f);
        lib4.SetActive(true);
        yield return new WaitForSeconds(2f);
        lib5.SetActive(true);
        yield return new WaitForSeconds(3f);
        lib6.SetActive(true);
        yield return new WaitForSeconds(2f);
        lib7.SetActive(true);
        yield return new WaitForSeconds(3f);
        lib8.SetActive(true);
        yield return new WaitForSeconds(4f);
        lib9.SetActive(true);
        yield return new WaitForSeconds(4f);
        lib10.SetActive(true);
        yield return new WaitForSeconds(7f);
        lib11.SetActive(true);
        yield return new WaitForSeconds(21f);
        lib12.SetActive(true);
        yield return new WaitForSeconds(2f);
        lib13.SetActive(true);
        yield return new WaitForSeconds(3f);
        lib14.SetActive(true);
        yield return new WaitForSeconds(2f);
        lib15.SetActive(true);
        yield return new WaitForSeconds(3f);
        lib16.SetActive(true);
        yield return new WaitForSeconds(2f);
        lib17.SetActive(true);
        yield return new WaitForSeconds(3f);
        lib18.SetActive(true);
        yield return new WaitForSeconds(3f);
        lib19.SetActive(true);
        yield return new WaitForSeconds(1f);
        lib20.SetActive(true);
        yield return new WaitForSeconds(2f);
        lib21.SetActive(true);
        yield return new WaitForSeconds(2f);
        lib22.SetActive(true);
        yield return new WaitForSeconds(4f);
        lib23.SetActive(true);
        yield return new WaitForSeconds(4f);
        lib24.SetActive(true);
        yield return new WaitForSeconds(1f);
        lib25.SetActive(true);
        yield return new WaitForSeconds(2f);
        lib26.SetActive(true);
        yield return new WaitForSeconds(3f);
        lib27.SetActive(true);
        yield return new WaitForSeconds(31f);
        lib28.SetActive(true);
        yield return new WaitForSeconds(2f);
        lib29.SetActive(true);
        yield return new WaitForSeconds(2f);
        lib30.SetActive(true);
        yield return new WaitForSeconds(2f);
        lib31.SetActive(true);
        yield return new WaitForSeconds(1f);
        lib32.SetActive(true);
        yield return new WaitForSeconds(4f);
        lib33.SetActive(true);
        yield return new WaitForSeconds(2f);
        lib34.SetActive(true);
        yield return new WaitForSeconds(2f);
        lib35.SetActive(true);
        yield return new WaitForSeconds(1f);
        lib36.SetActive(true);
        yield return new WaitForSeconds(2f);
        lib37.SetActive(true);
        yield return new WaitForSeconds(2f);
        lib38.SetActive(true);
        yield return new WaitForSeconds(2f);
        lib39.SetActive(true);
        yield return new WaitForSeconds(3f);
        lib40.SetActive(true);
        yield return new WaitForSeconds(9f);
        lib41.SetActive(true);
        yield return new WaitForSeconds(1f);
        lib42.SetActive(true);
        yield return new WaitForSeconds(1f);
        lib43.SetActive(true);
        yield return new WaitForSeconds(7f);
        lib44.SetActive(true);
        yield return new WaitForSeconds(4f);
        lib45.SetActive(true);
        yield return new WaitForSeconds(4f);
        lib46.SetActive(true);
        yield return new WaitForSeconds(3f);
        lib47.SetActive(true);
        yield return new WaitForSeconds(4f);
        lib48.SetActive(true);
        yield return new WaitForSeconds(3f);
        lib49.SetActive(true);
        yield return new WaitForSeconds(7f);
        lib50.SetActive(true);
        yield return new WaitForSeconds(4f);
        lib51.SetActive(true);
        yield return new WaitForSeconds(3f);
        lib52.SetActive(true);
        yield return new WaitForSeconds(3f);
        lib53.SetActive(true);
        yield return new WaitForSeconds(1f);
        lib54.SetActive(true);
        yield return new WaitForSeconds(2f);
        lib55.SetActive(true);
        yield return new WaitForSeconds(4f);
        lib56.SetActive(true);
        yield return new WaitForSeconds(4f);
        lib57.SetActive(true);
        yield return new WaitForSeconds(2f);
        lib58.SetActive(true);
        yield return new WaitForSeconds(2f);
        lib59.SetActive(true);
        yield return new WaitForSeconds(2f);
        lib60.SetActive(true);
        yield return new WaitForSeconds(1f);
        lib61.SetActive(true);
        yield return new WaitForSeconds(2f);
        lib62.SetActive(true);
        yield return new WaitForSeconds(2f);
        lib63.SetActive(true);
        yield return new WaitForSeconds(1f);
        lib64.SetActive(true);
        yield return new WaitForSeconds(2f);
        lib65.SetActive(true);
        yield return new WaitForSeconds(2f);
        lib66.SetActive(true);
        yield return new WaitForSeconds(1f);
        lib67.SetActive(true);
        yield return new WaitForSeconds(2f);
        lib68.SetActive(true);
        yield return new WaitForSeconds(2f);
        lib69.SetActive(true);
        yield return new WaitForSeconds(2f);
        lib70.SetActive(true);
        yield return new WaitForSeconds(2f);
        lib71.SetActive(true);
        yield return new WaitForSeconds(7f);
        lib72.SetActive(true);
        yield return new WaitForSeconds(2f);
        lib73.SetActive(true);
        yield return new WaitForSeconds(3f);
        lib74.SetActive(true);
        yield return new WaitForSeconds(2f);
        lib75.SetActive(true);
        yield return new WaitForSeconds(1f);
        lib76.SetActive(true);
        yield return new WaitForSeconds(2f);
        lib77.SetActive(true);
        yield return new WaitForSeconds(4f);
        lib78.SetActive(true);
        yield return new WaitForSeconds(6f);
        lib79.SetActive(true);
        yield return new WaitForSeconds(2f);
        lib80.SetActive(true);
        yield return new WaitForSeconds(3f);
        lib81.SetActive(true);
        yield return new WaitForSeconds(3f);
        lib82.SetActive(true);
        yield return new WaitForSeconds(2f);
        lib83.SetActive(true);
        yield return new WaitForSeconds(1f);
        lib84.SetActive(true);
        yield return new WaitForSeconds(9f);
        lib85.SetActive(true);
        yield return new WaitForSeconds(3f);
        lib86.SetActive(true);
        yield return new WaitForSeconds(3f);
        lib87.SetActive(true);
        yield return new WaitForSeconds(3f);
        lib88.SetActive(true);
        yield return new WaitForSeconds(7f);
        lib89.SetActive(true);
        yield return new WaitForSeconds(7f);
        lib90.SetActive(true);
        yield return new WaitForSeconds(2f);
        lib91.SetActive(true);
        yield return new WaitForSeconds(3f);
        lib92.SetActive(true);
        yield return new WaitForSeconds(10f);
        lib93.SetActive(true);
        yield return new WaitForSeconds(3f);
        lib94.SetActive(true);
        yield return new WaitForSeconds(3f);
        lib95.SetActive(true);
    }

   

    public void UpdateFinal()
    {
        final.SetActive(true);

        if(score <= 10000)
        {
            LoseText.SetActive(true);
            WinText.SetActive(false);
        }
        else if(score >= 10000)
        {
            LoseText.SetActive(false);
            WinText.SetActive(true);
        }

        finalScoreText.text = score.ToString();
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene(reloadScene);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Start");
    }
    
   
}
