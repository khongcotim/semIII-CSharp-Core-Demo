using System;
using System.Collections.Generic;
using System.Text;

namespace ReviewFinal
{
    interface IPupil
    {
        void InputData();
        void DisplayData();
        List<Pupil> Search(string name);
    }
}
