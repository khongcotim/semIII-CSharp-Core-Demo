using System;
using System.Collections.Generic;
using System.Text;

namespace ReviewFinal
{
    class Pupil
    {
        string pupiltId;
        string fullName;
        string address;
        int age;
        string phone;

        public Pupil()
        {
        }

        public Pupil(string pupiltId, string fullName, string address, int age, string phone)
        {
            this.PupiltId = pupiltId;
            this.FullName = fullName;
            this.Address = address;
            this.Age = age;
            this.Phone = phone;
        }

        public string PupiltId { get => pupiltId; set => pupiltId = value; }
        public string FullName { get => fullName; set => fullName = value; }
        public string Address { get => address; set => address = value; }
        public int Age { get => age; set => age = value; }
        public string Phone { get => phone; set => phone = value; }
        public void Input()
        {
            Console.WriteLine("Moi ban nhap id cua pupil: ");
            PupiltId = Console.ReadLine();

            Console.WriteLine("Moi ban nhap ten cua pupil: ");
            FullName = Console.ReadLine();

            Console.WriteLine("Moi ban nhap dia chi cua pupil: ");
            Address = Console.ReadLine();

            Console.WriteLine("Moi ban nhap tuoi cua pupil: ");
            Age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Moi ban nhap so dien thoai cua pupil: ");
            Phone = Console.ReadLine();
        }
        public void Display()
        {
            Console.WriteLine("\t Item: \n \t \t Id:" + PupiltId + " | Full Name: " + FullName + " | Address: " + Address + " | Age: " + Age + " | Phone: " + Phone);
        }
    }
}
