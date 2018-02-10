using KarateChop.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarateChop.Classes
{
    public class Chopper : IChopper
    {
        //searches an sorted Array for a number and returns -1 if not found , else the index of the first occourance
        public int chop(int NumberToSearch, int[] ArrayToChop)
        {

            int ReturnValue = -1;
            int CurrentIndex = 0;
            if (ArrayToChop != null)
            {
                if (ArrayToChop.Length > 0)
                {
                    foreach (var CurrentNumber in ArrayToChop)
                    {
                        if (CurrentNumber == NumberToSearch)
                            ReturnValue = CurrentIndex;
                        else
                            CurrentIndex++;
                    }
                }
            }
            return ReturnValue;

        }
    }
}
