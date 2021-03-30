static void Manual_Solution_Test()
        {
            var div_by_35 = new List<double>();
            var isDiv_by_35_noR = new List<bool>();
            // This bit here how is the jagg-ing working
            var div_by_5_and_7 = new List<double>[2];
            Console.WriteLine(div_by_5_and_7.GetType());
            var isDiv_by_5_and_7_noR = new List<bool>();
            for (int i = 0; i < 100; ++i)
            {
                div_by_35.Add(i / 35);
                isDiv_by_35_noR.Add(i % 35 == 0);

                // div_by_5_and_7[0].Add(i / 5);
                div_by_5_and_7[0].Add(12.2d);
                // div_by_5_and_7[1].Add(i / 7);:
                // div_by_5_and_7[1].Add(i / 7);
                // isDiv_by_5_and_7_noR.Add( ( i % 5 == 0) && (i % 7 == 0));
            }
            Console.WriteLine($"Check the debugger {Console.ReadLine()}");
        }
