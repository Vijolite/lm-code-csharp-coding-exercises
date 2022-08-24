﻿using System;
using Exercises.Models;

namespace Exercises
{
    public class Exercise002
    {
        public bool IsFromManchester( Person person )
        {
            if (person==null) return false;
            else if (person.City == "Manchester") return true;
            else return false;
        }

        public bool CanWatchFilm(Person person, int ageLimit)
        {
            return person.Age>=ageLimit;
        }
    }
}
