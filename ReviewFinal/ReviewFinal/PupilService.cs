using System;
using System.Collections.Generic;
using System.Text;

namespace ReviewFinal
{
    class PupilService:IPupil
    {
        List<Pupil> pupils = new List<Pupil>();
        public void InputData()
        {
            Console.WriteLine("Moi ban nhap so luong pupil muon them: ");
            int slg = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= slg; i++)
            {
                Console.WriteLine("Nhap san pham thu " + i + ":");
                Pupil newPupil = new Pupil();
                newPupil.Input();
                pupils.Add(newPupil);
                Console.WriteLine("Them moi du lieu thanh cong!");
            }

        }

        public void DisplayData()
        {
            pupils.ForEach(item=>{
                item.Display();
            });

        }

        public List<Pupil> Search(string name) {
            List<Pupil> pupilSearched = new List<Pupil>();
            pupils.ForEach(item => {
                if (item.FullName.Contains(name))
                {
                    pupilSearched.Add(item);
                }
            });
            return pupilSearched;
        }
    }
}
