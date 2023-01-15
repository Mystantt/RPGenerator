using Assets.Scripts.Business.Account;
using Assets.Scripts.Business.RPG;
using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Test
{
    public class CampaignTest : MonoBehaviour
    {

        // Use this for initialization
        void Start()
        {
            Account a = new Account("Mystantt","mystanttLeBg@something.lol","123456789");
            Profile p = new Profile("OrbiterGM", GameRole.GameMaster);
            a.AddProfile(p);
            Campaign c = new Campaign("Orbiter", "Grosse campagne de fantaisie", new DnD5ERules(), p);
            Profile p2 = new Profile("OrbiterPlayer", GameRole.Player);
            p2.JoinCampaign(c);
            Profile p3 = new Profile("Impostor", GameRole.GameMaster);
            p3.JoinCampaign(c);
            Debug.Log(c.GetProfiles(p).Count);
        }
    }
}