using System;
using System.Collections.Generic;
namespace ReviewFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            int selection = 0;
            PupilService pupilService = new PupilService();
            do
            {
                menu();
                selection = Convert.ToInt32(Console.ReadLine());
                switch (selection)
                {
                    case 1:
                        pupilService.InputData();
                        break;
                    case 2:
                        pupilService.DisplayData();
                        break;
                    case 3:
                        Console.WriteLine("Vui long nhap ten muon kiem tra: ");
                        string nameWanted = Console.ReadLine();
                        List<Pupil> list = pupilService.Search(nameWanted);
                        list.ForEach(item=>
                        {
                            item.Display();
                        });
                        break;
                    case 4:
                        Console.WriteLine("Cam on ban da su dung dich vu cua chung toi!");
                        System.Environment.Exit(0);
                        break;
                    default:
                        System.Environment.Exit(0);
                        break;
                }
            }while (selection != 4);
        }

        static void menu()
        {
            Console.WriteLine("Vui long chon menu sau: \n");
            Console.WriteLine("1. Enter pupil’s information \n" +
                              "2.To display pupil’s information \n" +
                              "3.Search pupil by name and display \n" +
                              "4: Exit the program");
        }
    }
}
