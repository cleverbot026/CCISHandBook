using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CCISHandBook
{
    class ChatBotProcess
    {

        

        public string ChatBotAnswer (string pText)
        {
             string[] arrAnswer = 
            {
                "Hi there, I hope i can help you :)",
                "You must always wear appropriate clothes and ID",
                "Please always observe silence and maintain cleanliness",
                "You must always have a faculty-in-charge before entering",
                "Before using computer you must sign in the CUF",
                "CUF or Computer Usage Form",
                "All broken computer peripheral must be reported to LOO",
                "LOO or Laboratory Operations Office",
                "Swapping/Transfering computer peripherals are illegal",
                "No eating and drinking inside Lab Room. Eat Outside",
                "No vandalizing and loitering. Please Respect!",
                "No smoking. Smoke is bad to humans and for robots",
                "No playing games. Play Counter Strike outside please",
                "Installing software is not allowed. This is not your PC",
                "Please be quiet and no playing loud music at lab room",
                "No Charging. :(",
                "No browsing internet. NO PORN!",
                "No stealing computer peripherals",
                "JUST DON'T VIOLATE THE RULES!,",
                "What is it?"                 
            };

            string strAnswer = "";
            pText = pText.ToLower();
            Regex rgx = new Regex("[^a-zA-Z0-9 -]");
            pText = rgx.Replace(pText, "");
            string [] arrText = pText.Split(' ');
            int iCounter = 0;
            bool cont = true;

            while (iCounter != arrText.Length && cont == true)
            {
                switch (arrText[iCounter]) 
                {
                    case "ask":
                        {
                            strAnswer = arrAnswer[19];
                            cont = false;
                        }
                        break;
                    case "question":
                        {
                            strAnswer = arrAnswer[19];
                            cont = false;
                        }
                        break;

                        //introduction
                    case "hi":
                        {
                            strAnswer = arrAnswer[0];
                            cont = false;
                        }
                        break;
                    case "hey": 
                        {
                            strAnswer = arrAnswer[0];
                            cont = false;
                        }
                        break;
                    case "hello": 
                        {
                            strAnswer = arrAnswer[0];
                            cont = false;
                        }
                        break;

                       //Clothes
                    case "clothes":
                        {
                            strAnswer = arrAnswer[1];
                            cont = false;
                        }
                        break;
                    case "wear":
                        {
                            strAnswer = arrAnswer[1];
                            cont = false;
                        }
                        break;
                    case "display":
                        {
                            strAnswer = arrAnswer[1];
                            cont = false;
                        }
                        break;

                        //Behavior
                    case "behavior":
                        {
                            strAnswer = arrAnswer[2];
                            cont = false;
                        }
                        break;
                    case "cleanliness":
                        {
                            strAnswer = arrAnswer[2];
                            cont = false;
                        }
                        break;
                    //Enter
                    case "enter":
                        {
                            strAnswer = arrAnswer[3];
                            cont = false;
                        }
                        break;
                    case "faculty":
                        {
                            strAnswer = arrAnswer[3];
                            cont = false;
                        }
                        break;
                    //Hands on
                    case "use":
                        {
                            strAnswer = arrAnswer[4];
                            cont = false;
                        }
                        break;
                    case "using":
                        {
                            strAnswer = arrAnswer[4];
                            cont = false;
                        }
                        break;
                    case "hands":
                        {
                            strAnswer = arrAnswer[4];
                            cont = false;
                        }
                        break;
                    case "after":
                        {
                            strAnswer = arrAnswer[4];
                            cont = false;
                        }
                        break;
                        //CUF
                    case "cuf":
                        {
                            strAnswer = arrAnswer[5];
                            cont = false;
                        }
                        break;
                    //broken
                    case "defective":
                        {
                            strAnswer = arrAnswer[6];
                            cont = false;
                        }
                        break;
                    case "broken":
                        {
                            strAnswer = arrAnswer[6];
                            cont = false;
                        }
                        break;
                    case "incident":
                        {
                            strAnswer = arrAnswer[6];
                            cont = false;
                        }
                        break;
                    //loo
                    case "loo":
                        {
                            strAnswer = arrAnswer[7];
                            cont = false;
                        }
                        break;
                    //swap
                    case "swapping":
                        {
                            strAnswer = arrAnswer[8];
                            cont = false;
                        }
                        break;
                    case "swap":
                        {
                            strAnswer = arrAnswer[8];
                            cont = false;
                        }
                        break;
                    case "transfering":
                        {
                            strAnswer = arrAnswer[8];
                            cont = false;
                        }
                        break;
                    case "transfer":
                        {
                            strAnswer = arrAnswer[8];
                            cont = false;
                        }
                        break;
                    //foods
                    case "drinking":
                        {
                            strAnswer = arrAnswer[9];
                            cont = false;
                        }
                        break;
                    case "drink":
                        {
                            strAnswer = arrAnswer[9];
                            cont = false;
                        }
                        break;
                    case "eating":
                        {
                            strAnswer = arrAnswer[9];
                            cont = false;
                        }
                        break;
                    case "eat":
                        {
                            strAnswer = arrAnswer[9];
                            cont = false;
                        }
                        break;
                    //loit
                    case "loitering":
                        {
                            strAnswer = arrAnswer[10];
                            cont = false;
                        }
                        break;
                    case "dirt":
                        {
                            strAnswer = arrAnswer[10];
                            cont = false;
                        }
                        break;
                    case "trash":
                        {
                            strAnswer = arrAnswer[10];
                            cont = false;
                        }
                        break;
                    case "vandalizing":
                        {
                            strAnswer = arrAnswer[10];
                            cont = false;
                        }
                        break;
                    case "vandal":
                        {
                            strAnswer = arrAnswer[10];
                            cont = false;
                        }
                        break;
                    case "vandalism":
                        {
                            strAnswer = arrAnswer[10];
                            cont = false;
                        }
                        break;
                    //smoke
                    case "smoking":
                        {
                            strAnswer = arrAnswer[11];
                            cont = false;
                        }
                        break;
                    case "smoke":
                        {
                            strAnswer = arrAnswer[11];
                            cont = false;
                        }
                        break;
                    //games
                    case "games":
                        {
                            strAnswer = arrAnswer[12];
                            cont = false;
                        }
                        break;
                    case "play":
                        {
                            strAnswer = arrAnswer[12];
                            cont = false;
                        }
                        break;
                    //install
                    case "install":
                        {
                            strAnswer = arrAnswer[13];
                            cont = false;
                        }
                        break;

                    case "installing":
                        {
                            strAnswer = arrAnswer[13];
                            cont = false;
                        }
                        break;
                    case "software":
                        {
                            strAnswer = arrAnswer[13];
                            cont = false;
                        }
                        break;
                    //loit
                    case "music":
                        {
                            strAnswer = arrAnswer[14];
                            cont = false;
                        }
                        break;
                    case "noises":
                        {
                            strAnswer = arrAnswer[14];
                            cont = false;
                        }
                        break;
                    case "noise":
                        {
                            strAnswer = arrAnswer[14];
                            cont = false;
                        }
                        break;
                    //install
                    case "charging":
                        {
                            strAnswer = arrAnswer[15];
                            cont = false;
                        }
                        break;
                    case "charge":
                        {
                            strAnswer = arrAnswer[15];
                            cont = false;
                        }
                        break;
                    //install
                    case "browsing":
                        {
                            strAnswer = arrAnswer[16];
                            cont = false;
                        }
                        break;
                    case "browse":
                        {
                            strAnswer = arrAnswer[16];
                            cont = false;
                        }
                        break;
                    case "internet":
                        {
                            strAnswer = arrAnswer[16];
                            cont = false;
                        }
                        break;
                    case "porn":
                        {
                            strAnswer = arrAnswer[16];
                            cont = false;
                        }
                        break;
                    //stealing   
                    case "stealing":
                        {
                            strAnswer = arrAnswer[17];
                            cont = false;
                        }
                        break;
                    case "steal":
                        {
                            strAnswer = arrAnswer[17];
                            cont = false;
                        }
                        break;
                 
                    //offense
                    case "offenses":
                        {
                            strAnswer = arrAnswer[18];
                            cont = false;
                        }
                        break;
                    case "offense":
                        {
                            strAnswer = arrAnswer[18];
                            cont = false;
                        }
                        break;
                }
                iCounter++;
            }
            if (strAnswer == string.Empty)
            {
                strAnswer = "can you be more specific?";
            }
            return strAnswer;
        }
    }
}
