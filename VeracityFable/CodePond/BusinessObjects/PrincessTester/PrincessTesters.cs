using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodePond.BusinessObjects
{
    public sealed class PrincessTesters
    {
        private static PrincessTesters instance;
        private static object syncRoot = new Object();

        public Dictionary<string,List<PrincessTester>> Testers = new Dictionary<string,List<PrincessTester>>();
        public Dictionary<string,PrincessTester> Princesses = new Dictionary<string,PrincessTester>();

        private PrincessTesters()
        {

        }

        public static PrincessTesters GetInstance
        {
            get
            {
                lock (syncRoot)
                {
                    if (instance == null)
                    {
                        instance = new PrincessTesters();
                    }
                }

                return instance;
            }
        }

        /*public List<PrincessTester> GetTesters(string userName)
        {
            if (Testers.ContainsKey(userName))
            {
                return Testers[userName];
            }
            else
            {
                List<PrincessTester> usersPrincesses = PrincessTesterLoader::GenerateTesters();
                Testers[userName] = usersPrincesses;
                return usersPrincesses;
            }
        }
        public PrincessTester GetPrincess(string userName)
        {
            if (Princesses.ContainsKey(userName))
            {
                return Princesses[userName];
            }
            else
            {
                List<PrincessTester> usersPrincess = PrincessTesterLoader::GeneratePrincess();
                Princesses[userName] = usersPrincess;
                return usersPrincesses;
            }
        }*/

        
    }
}