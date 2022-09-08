using System;
using System.Collections.Generic;
using System.Text;
namespace EngineerProgram
{
    abstract class Worker : IWorker
    {
        int id;
        string fullName;
        bool gender;
        DateTime birthday;
        string address;

        protected Worker()
        {
        }

        protected Worker(int id, string fullName, bool gender, DateTime birthday, string address)
        {
            this.id = id;
            this.fullName = fullName;
            this.gender = gender;
            this.birthday = birthday;
            this.address = address;
        }

        public int Id { get => id; set => id = value; }
        public string FullName { get => fullName; set => fullName = value; }
        public void SetFullName(string newFullname)
        {
            this.fullName = newFullname;
        }
        public bool Gender { get => gender; set => gender = value; }
        public DateTime Birthday { get => birthday; set => birthday = value; }
        public string Address { get => address; set => address = value; }

        public void display()
        {
            Console.WriteLine("Id: " + Id + " | FullName: " + FullName + " | Gender: " + Gender
                                        + " | Birthday: " + Birthday + " | Address: " + Address);
        }

        public void input()
        {
            Console.WriteLine("Nhap Id: ");
            Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap Full Name: ");
            FullName = Console.ReadLine();
            Console.WriteLine("Nhap gioi tinh: ");
            Gender = bool.Parse(Console.ReadLine());
            Console.WriteLine("Nhap ngay thang nam sinh: ");
            Birthday = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Nhap dia chi: ");
            Address = Console.ReadLine();
        }

        public double CaculateSalary()
        {
            return 0;
        }
    }
}
