using System;
using System.Collections;
using System.Collections.Generic;

namespace EngineerProgram
{
    class EngineerManager
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chao mung ban den voi chuong trinh cua chung toi: ");
            int choose = 0;
            List<Engineer> workers = new List<Engineer>();
            do
            {
                menu();
                choose = Convert.ToInt32(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        Console.WriteLine("Moi ban nhap so luong ky su: ");
                        int soluong = Convert.ToInt32(Console.ReadLine());
                        for (int i = 1; i <= soluong; i++)
                        {
                            Engineer newEngineer = new Engineer();
                            newEngineer.input();
                            workers.Add(newEngineer);
                        }
                        break;
                    case 2:
                        Console.WriteLine("\t Danh sach casc ky su vua nhap: ");
                        workers.ForEach(item =>
                        {
                            item.display();
                        });
                        break;
                    case 3:
                        Console.WriteLine("\t Danh sach cac ky su theo danh sach ten tang dan: ");
                        workers.ForEach(item =>
                        {
                            string fullName = item.FullName;
                            string engineerName = fullName.Substring(fullName.LastIndexOf(" "));
                            item.SetFullName(engineerName);
                        });
                        workers.Sort((s1, s2) => s1.FullName.CompareTo(s2.FullName));
                        workers.ForEach(item =>
                        {
                            item.display();
                        });
                        break;
                    case 4:
                        Console.WriteLine("\t Sắp xếp và hiển thị danh sách giảm dần theo lương");
                        workers.Sort((s1, s2) => s2.CaculateSalary().CompareTo(s1.CaculateSalary()));
                        workers.ForEach(item =>
                        {
                            item.display();
                        });
                        break;
                    case 5:
                        Console.WriteLine("Moi ban nhap ten ky su");
                        string nameWanted = Console.ReadLine();
                        workers.ForEach(item => {
                            bool check = item.FullName.Equals(nameWanted);
                            if (check == true)
                            {
                                Console.WriteLine("Ky su tim duoc la: ");
                                item.display();
                            }
                            else
                            {
                                Console.WriteLine("K tim thay ki su nao ten la: " + nameWanted);
                            }
                        });
                        break;
                    case 6:
                        System.Environment.Exit(0);
                        break;

                }
            } while (choose != 6);
        }

        static void menu()
        {
            Console.WriteLine("1.	Nhập vào thông tin của n kỹ sư \n" +
                              " 2.Hiển thị thông tin vừa nhập \n" +
                              " 3.Sắp xếp và hiển thị danh sách tăng dần theo tên(chỉ theo tên) \n" +
                              " 4.Sắp xếp và hiển thị danh sách giảm dần theo lương \n" +
                              " 5.Tìm kiếm và hiển thị thông tin kỹ sư theo tên \n" +
                              " 6.Kết thúc.");
        }
    }
}
