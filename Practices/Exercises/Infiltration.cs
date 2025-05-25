using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practices.Exercises
{
    public class Infiltration
    {
        public static bool CanFastAttack(bool knightIsAwake)
        {
            // Implement the (static) QuestLogic.CanFastAttack() method that takes a Boolean value that indicates if the knight is awake. This method returns true if a fast attack can be made based on the state of the knight. Otherwise, returns false:

            if (knightIsAwake)
            {
                return false; // Cannot attack if the knight is awake
            }

            // System.NotImplementedException : Please implement the (static) QuestLogic.CanFastAttack() method
            return true; // Can attack if the knight is not awake
            throw new NotImplementedException("Please implement the (static) Infiltration.CanFastAttack() method");
        }

        public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake)
        {
            // mplement the (static) QuestLogic.CanSpy() method that takes three Boolean values, indicating if the knight, archer and the prisoner, respectively, are awake. The method returns true if the group can be spied upon, based on the state of the three characters. Otherwise, returns false:
            if (knightIsAwake || archerIsAwake || prisonerIsAwake)
            {
                return true; // Can spy if any of the characters is awake
            }
            return false; // Cannot spy if all characters are asleep
            throw new NotImplementedException("Please implement the (static) Infiltration.CanSpy() method");
        }

        public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake)
        {
            // Implement the (static) QuestLogic.CanSignalPrisoner() method that takes two Boolean values, indicating if the archer and the prisoner, respectively, are awake. The method returns true if the prisoner can be signalled, based on the state of the two characters. Otherwise, returns false:
            if (!archerIsAwake && prisonerIsAwake)
            {
                return true; // Can signal the prisoner if the archer is not awake and the prisoner is awake
            }
            return false; // Cannot signal the prisoner if the archer is awake or the prisoner is asleep
            throw new NotImplementedException("Please implement the (static) Infiltration.CanSignalPrisoner() method");
        }

        public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
        {

            // Implement the (static) QuestLogic.CanFreePrisoner() method that takes four Boolean values. The first three parameters indicate if the knight, archer and the prisoner, respectively, are awake. The last parameter indicates if Annalyn's pet dog is present. The method returns true if the prisoner can be freed based on the state of the three characters and Annalyn's pet dog presence. Otherwise, it returns false:
            if (petDogIsPresent && !archerIsAwake)
            {
                return true; // The pet dog presence allows freeing the prisoner regardless of the knight and archer's state
            }

            if (!knightIsAwake && !archerIsAwake && prisonerIsAwake)
            {
                return true; // The prisoner can be freed if both the knight and archer are asleep, and the prisoner is awake
            }
            return false; // Cannot free the prisoner if the knight is awake, the archer is awake, or the prisoner is asleep

            throw new NotImplementedException("Please implement the (static) Infiltration.CanFreePrisoner() method");
        }
    }
}