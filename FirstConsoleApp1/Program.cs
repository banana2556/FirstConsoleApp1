
internal class Program
{
    enum Weekdays : int
    {
        Monday = 1,
        Tuesday = 2,
        Wendsday = 3,
        Thursday = 4,
        Friday = 5,
        Saturday = 6,
        Sunday = 7,

    };
    private static void Main(string[] args)
    {
        //Console.WriteLine("───▄▀▀▀▄▄▄▄▄▄▄▀▀▀▄───");
        //Console.WriteLine("───█▒▒░░░░░░░░░░░░▒▒█───");
        //Console.WriteLine("────█░░█░░░░░░░░█░░█────");
        //Console.WriteLine("─▄▄──█░░░░▀█▀░░░░█──▄▄─");
        //Console.WriteLine("█░░░░█─▀▄░░░░░░░░░░▄▀─█░░░░█");

        //bool first, second, result;
        //first = 4 > 3;
        //second = 'a' == 'b';
        //result = first && second;
        //Console.WriteLine(result);

        //Console.WriteLine((4 > 3) || ('a' == 'b'));

        //int a,b,c;
        //a = 5;
        //Console.WriteLine("a = " + a);
        //b = a += 5;
        //Console.WriteLine("b = " + b);
        //c = a -= 5;
        //Console.WriteLine("c = " + c);

        //string name, heigh,data;
        //name = "黑暗騎士";
        //heigh = "189";
        //data = string.Format("{0}的身高是{1}", name, heigh);
        //Console.WriteLine(data);

        //string job = "森林遊俠";
        //int year = 20;
        //string data2 = $"{2}個{job}的年紀是{2*year}";
        //Console.WriteLine(data2);

        //int no1, no2;
        //Console.Write("第一個熔爐騎士的年紀");
        //no1 = int.Parse(Console.ReadLine());
        //Console.Write("第二個熔爐騎士的年紀");
        //no2 = int.Parse(Console.ReadLine());
        //Console.Write($"熔爐騎士年紀的總和是{no1 + no2}");

        //2-26
        //Console.WriteLine("1234567890");
        //Console.Write("a.{0}", 100);
        //Console.Write("     b.{0}", -200);
        //Console.WriteLine("");
        //Console.WriteLine("a.{0}     b.{1}",100,-200);

        //int no1, no2;
        //Console.WriteLine("In put No 1 :");
        //no1 = int.Parse(Console.ReadLine());
        //Console.WriteLine("In put No 2 :");
        //no2 = int.Parse(Console.ReadLine());
        //Console.WriteLine($"no1 + no2 = {no1} + {no2} = {no1 + no2}");


        ////2-27
        //string goods;
        //int price;
        //Console.WriteLine("輸入要修改的科目名稱:");
        //goods = Console.ReadLine();
        //Console.WriteLine("輸入希望的分數:");
        //price = int.Parse(Console.ReadLine());
        //Console.WriteLine($"科目:{goods} 已修改成{price}分");
        //Console.Read();

        //2-31
        //Console.WriteLine("1.已貨幣方式 C|c顯示資料 以NT$開頭");
        //Console.WriteLine("12345678901234567890");
        //Console.WriteLine("{0}/{1}/{2}",1234,-1234,123.4);
        //Console.WriteLine($"{5,0:C} {-5,0:c3}\n{-5,15:c3}\n{-5,-15:c3}");
        //Console.WriteLine("-------------------------------------------");
        //Console.WriteLine("2.以十進位方式 D|d顯示資料 空白處補0 =====");
        //Console.WriteLine("1234567890123456890");
        //Console.WriteLine("{0,0:d5}",25);
        //Console.WriteLine("{0,10:d5}",25);
        //Console.WriteLine("{0,-10:d5}",25);
        //Console.WriteLine("-------------------------------------------");
        //Console.WriteLine("3.以指數方式 E 顯示資料 ==== ");
        //Console.WriteLine("{0:E}", 25000);
        //Console.WriteLine("{0:E3}", 25000);
        //Console.WriteLine("{0:E3}", 0.0012345);
        //Console.WriteLine("{0,20:E3}",25000);
        //Console.WriteLine("{0,-20:E3}", 25000);
        //Console.WriteLine("-------------------------------------------");
        //Console.WriteLine("4.以浮點述方式 F|f 顯示資料 ====");
        //Console.WriteLine("{0:F}", 123.4567);
        //Console.WriteLine("{0:F0}", 123.4567);
        //Console.WriteLine("{0:F3}", 123.4567);
        //Console.WriteLine("{0,20:F3}", 123.4567);
        //Console.WriteLine("{0,-20:F3}", -123.45);
        //Console.Read(); 

        //2-33
        //Console.WriteLine("5.以一般方式 G|g 顯示資料 ====");
        //Console.WriteLine("12345678901234567890");
        //Console.WriteLine($"{123.4567:G}");
        //Console.WriteLine($"{123.4567:G0}");
        //Console.WriteLine($"{123.4567:G3}");
        //Console.WriteLine($"{123.4567,20:G5}");
        //Console.WriteLine($"{-123.4567,-20:G3}");
        //Console.WriteLine("-------------------------------------");
        //Console.WriteLine("6. 以千位符號 N|n 顯示資料 不加$ ====");
        //Console.WriteLine($"{250000:N}");
        //Console.WriteLine($"{250000:N0}");
        //Console.WriteLine($"{250000:N1}");
        //Console.WriteLine($"{250000,20:N2}");
        //Console.WriteLine($"{250000,-20:N2}");
        //Console.WriteLine("-------------------------------------");
        //Console.WriteLine("7. 以16進制 X|x 顯示資料 ====");
        //Console.WriteLine("12345678901234567890");
        //Console.WriteLine($"{255:x}");
        //Console.WriteLine($"{255,10:X}");
        //Console.WriteLine($"{255,-10:X}");
        //Console.WriteLine($"{12,0:x4}");
        //Console.WriteLine($"{12,2:x}");
        //Console.Read();

        //2-35
        //double myvar1 = 0801234567;
        //Console.WriteLine("1." + myvar1.ToString("(0##)-###-###"));
        //int myvar2 = -12345;
        //Console.WriteLine("2." + myvar2.ToString("######"));
        //int myvar3 = -12345;
        //Console.WriteLine("3." + myvar3.ToString("000000"));
        //double myvar4 = -2.455;
        //Console.WriteLine("4." + myvar4.ToString("#.##"));
        //double myvar5 = -2.4;
        //Console.WriteLine("5." + myvar5.ToString("0.00"));
        //double myvar6 = -2.455;
        //Console.WriteLine("4." + myvar6.ToString("00.00"));
        //double myvar7 = 1234567890;
        //Console.WriteLine("7." + myvar7.ToString("#,#"));
        //double myvar8 = 1234567890;
        //Console.WriteLine("8." + myvar8.ToString("#,"));
        //double myvar9 = 1234567890;
        //Console.WriteLine("9." + myvar9.ToString("#,,"));
        //double myvar10 = 1234567890;
        //Console.WriteLine("10." + myvar10.ToString("#,,,"));
        //double myvar11 = 1234567890;
        //Console.WriteLine("11." + myvar11.ToString("#,##0,,"));
        //double myvar12 = 0.086;
        //Console.WriteLine("12." + myvar12.ToString("#0.##%"));
        //double myvar13 = 0.08647;
        //Console.WriteLine("13." + myvar13.ToString("#0.##%"));
        //double myvar14 = 16800;
        //Console.WriteLine("14." + myvar14.ToString("0.###E+0"));
        //double myvar15 = 16800;
        //Console.WriteLine("15." + myvar15.ToString("0.###E+000"));
        //double myvar16 = 16800;
        //Console.WriteLine("16." + myvar16.ToString("0.###E-000"));
        //double myvar17 = 123456;
        //Console.WriteLine("17." + myvar17.ToString("[##-##-##]"));
        //int myvar18 = 1234;
        //Console.WriteLine("18." + myvar18.ToString("##;(##)"));
        //int myvar19 = 1234;
        //Console.WriteLine("19." + myvar19.ToString("(##);##"));
        //int myvar20 = -1234;
        //Console.WriteLine("20." + myvar20.ToString("##;(##)"));


        //2-38
        //string strl;
        //strl = "大家一起說 :\"大港開唱\"";
        //Console.WriteLine("1234567890123456789090123456789012345678901234567890");
        //Console.WriteLine("\t" + strl);
        //Console.WriteLine("\t" + "沒搶到票");
        //Console.WriteLine("\n 明年再來搶 \n");
        //Console.WriteLine("路徑 C:\\CS\\Game.exe");
        //Console.WriteLine(@"路徑 C:\CS\Game.exe");
        //Console.WriteLine("雙引號很酷");
        //Console.WriteLine("\"雙引號很酷\"");
        //string str2 = "\u0041pple";
        //string str3 = "電腦";
        //str2 += str3;
        //Console.WriteLine(str2);
        //string str4 = "\\\u0061\n\n";
        //Console.WriteLine(str4 + "Begin:");

        //int age;
        //Console.WriteLine("你現在幾歲:");
        //age = int.Parse(Console.ReadLine());
        //if (age < 1 || age > 18)
        //{
        //    Console.WriteLine($"你{age}歲，可以喝酒了");
        //}
        //else
        //{
        //    Console.WriteLine($"你只有{age}歲，未成年不准喝酒");
        //}
        //Console.ReadLine();

        //int n1, n2, n3, max;
        //string final;
        //Console.WriteLine("輸入第一家的餐點價格：");
        //n1 = int.Parse(Console.ReadLine());
        //Console.WriteLine("輸入第二家的餐點價格：");
        //n2= int.Parse(Console.ReadLine());
        //Console.WriteLine("輸入第三家的餐點價格：");
        //n3 = int.Parse(Console.ReadLine());

        //if (n1 > n2)
        //{
        //    if (n1 > n3)
        //    {
        //        max = n1;
        //        final = "一";
        //    }
        //    else
        //    {
        //        max = n3;
        //        final = "三";
        //    }
        //}
        //else
        //{
        //    if (n2 > n3)
        //    {
        //        max = n2;
        //        final = "二";
        //    }
        //    else
        //    {
        //        max = n3;
        //        final = "三";
        //    }
        //}
        //Console.WriteLine($"\n === 餐點價格分別是{n1},{n2},{n3},最盤的是第{final}家，價格是{max}！");
        //Console.ReadLine();

        //Console.WriteLine("題目\n");
        //Console.WriteLine("明天是大港開唱，但有一個人沒搶到票，請問是誰？");
        //Console.WriteLine("1.劉旭成        2.度要宇\n3.陳佑明        4.陳進偉");
        //Console.WriteLine("請作答：\n");
        //string ans = Console.ReadLine();
        //if (ans =="1" || ans == "2" || ans == "4") 
        //{
        //    Console.WriteLine("猜錯了，是3.陳佑明沒買到票，哈哈！");
        //}
        //else if (ans == "3")
        //{
        //    Console.WriteLine("猜對了！是陳佑明沒搶到票，明年再見！");
        //}
        //else
        //{
        //    Console.WriteLine("別亂猜欸！");
        //}

        //三元運算
        //int price;
        //int age = int.Parse(Console.ReadLine());

        //price = age <= 10 ? 100 : (age < 60 ? 150 : 200);

        // Console.WriteLine($"{price}");
        //====================================

        //2-44
        //Console.WriteLine($"星期三列舉常數值:{(int)Weekdays.Wendsday}");
        //Console.WriteLine($"星期五列舉常數值:{(int)Weekdays.Friday}");
        //Console.Read();

        //3-10
        double expIncome = 0; //擊敗怪物數量
        double expBonus = 0; //經驗加成
        bool classChange = false; //能否轉職
        double lvlUp = 0;//等級提高
        int stage = 0;//經驗加成倍率
        Console.WriteLine("\n >>>>>>請輸入擊敗的怪物數量");
        expIncome = double.Parse(Console.ReadLine());
        Console.WriteLine();
        if (expIncome > 0) //檢查經驗值是否大於零
        {
            stage = (expIncome <= 1000 ? 1 : (expIncome <= 2000 ? 2 : (expIncome <= 3000 ? 3 : (expIncome <= 4000 ? 4 : (expIncome <= 5000 ? 5 : 6)))));
        }
        else
        {
            Console.WriteLine("你沒獲得任何經驗值");

        }
        switch (stage)
        {
            case 1:
                expBonus = 0;
                lvlUp = (expIncome * (1 + expBonus)) / 50;
                classChange = (lvlUp >= 100 ? true : false);
                break;
            case 2:
                expBonus = 0.15;
                lvlUp = (expIncome * (1 + expBonus)) / 50;
                classChange = (lvlUp >= 100 ? true : false);
                break;
            case 3:
                expBonus = 0.3;
                lvlUp = (expIncome * (1 + expBonus)) / 50;
                classChange = (lvlUp >= 1000 ? true : false);
                break;
            case 4:
                expBonus = 0.45;
                lvlUp = (expIncome * (1 + expBonus)) / 50;
                classChange = (lvlUp >= 100 ? true : false);
                break;
            case 5:
                expBonus = 0.6;
                lvlUp = (expIncome * (1 + expBonus)) / 50;
                classChange = (lvlUp >= 100 ? true : false);
                break;
            case 6:
                expBonus = 0.8;
                lvlUp = (expIncome * (1 + expBonus)) / 50;
                classChange = (lvlUp >= 100 ? true : false);
                break;
            default:
                Console.WriteLine("你開外掛了");
                break;
        }
        Console.WriteLine($"\n == 你一共擊敗{expIncome:N0}隻怪物");
        Console.WriteLine($"\n == 獲得階級 {stage} 的獎勵經驗倍率 x{expBonus}");
        Console.WriteLine($"\n == 獲得 {expIncome} * {expBonus} = {expIncome * (1 + expBonus):N1} 經驗值");
        Console.WriteLine($"\n == 總共能提升{lvlUp:F0}等級");
        if (classChange == true)
        {
            Console.WriteLine("\n == 提示：等級已達上限請找教官轉職");
        }
        else
        {
            Console.WriteLine($"\n == 離轉職還需要 {1000 - lvlUp:F0} 等級");
        }


    }
}