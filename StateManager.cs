using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImgOps
{
    public class StateManager
    {
        List<State> statesList = new List<State>();
        public void GetStates()
        {
            string statesPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/ImgOps/States/";
            statesList.AddRange(new List<State>{
            new State
            (
                0,
                "Login",
                null,
                "clientPanel",
                false
            ),
            new State
            (
                1,
                "ServerPick",
                null,
                "clientPanel",
                false
            ),
            new State
            (
                2,
                "CharacterPick",
                null,
                "clientPanel",
                false
            ),
            new State
            (
                3,
                "SubPassword",
                null,
                "clientPanel",
                false
            ),
            new State
            (
                4,
                "RunBot",
                null,
                "clientPanel",
                false
            ),
            new State
            (
                5,
                "ListenBot",
                null,
                "botPanel",
                false
            )
        });
        }
        public State SetState(int stateId)
        {
            statesList[stateId].isSet = true;
            return statesList[stateId];
        }
    }
}
