using System;
using System.Collections.Generic;
using System.Text;

namespace EngineerProgram
{
    class Engineer : Worker
    {
        string certificate;
        int level;
        float basicSalary;
        float coefficient;

        public Engineer()
        {
        }

        public Engineer(int id, string fullName, bool gender, DateTime birthday, string address, string certificate, int level, float basicSalary, float coefficient) : base()
        {
            this.certificate = certificate;
            this.level = level;
            this.basicSalary = basicSalary;
            this.coefficient = coefficient;
        }

        public string Certificate { get => certificate; set => certificate = value; }
        public int Level { get => level; set => level = value; }
        public float BasicSalary { get => basicSalary; set => basicSalary = value; }
        public float Coefficient { get => coefficient; set => coefficient = value; }

        public new void display()
        {
            base.display();
            Console.WriteLine("| Bang cap: " + Certificate + " | Cap bac: " + Level + " | Luong co ban: " + BasicSalary + " | He so luong: " + Coefficient);
        }

        public new void input()
        {
            base.input();
            Console.WriteLine("Nhap bang cap: ");
            Certificate = Console.ReadLine();
            Console.WriteLine("Nhap cap bac: ");
            Level = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap Luong co ban: ");
            BasicSalary = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap he so luong: ");
            Coefficient = float.Parse(Console.ReadLine());

        }

        public new double CaculateSalary()
        {
            return basicSalary * coefficient;
        }

    }
}
