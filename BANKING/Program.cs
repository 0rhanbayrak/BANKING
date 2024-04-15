namespace Bank
{
    public class date
    {
        public int day;
        public int month;
        public int year;
    };

    class Account : date
    {
        public string name;
        int acc_no;
        double balance;
        Account() { }

        Account(string Name, int Acc_no, double Balance, int Day, int Month, int Year)
        {
            name = Name;
            acc_no = Acc_no;
            balance = Balance;
            day = Day;
            month = Month;
            year = Year;
        }

        void sort_acc_no(double[] arr)
        {
            Console.WriteLine("***Account No's in ascending order***");
            double temp;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            for (int k = 0; k < 5; k++)
            {
                Console.WriteLine(arr[k] + "\n");
            }
        }

        void find_acc_no(double[] arr, int no)
        {
            Console.WriteLine("***FIND ACCOUNT INFO***");
            int counter = 0;
            for (int i = 0; i < 5; i++)
            {
                if (arr[i] == no)
                {
                    Console.WriteLine("Account No " + no + " was found in the list.\n\n");
                    counter++;
                    break;
                }
            }
            if (counter == 0)
            {
                Console.WriteLine("Account No " + no + " was not found in the list.\n\n");
            }
        }

        void balance_info(double[] arr)
        {
            Console.Write("***BALANCE INFO***\n");
            double sum = 0;
            for (int i = 0; i < 5; i++)
            {
                sum = sum + arr[i];
            }
            Console.WriteLine("Average balance:" + sum / 5);

            double temp;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("Maximum balance:" + arr[4]);
        }

        static void Main()
        {
            Account a = new Account();
            Account[] accounts = new Account[5] {
        new Account("John", 120, 120.5,01,05,2009),
        new Account("Mehmet", 210, 540, 04,12,2012),
        new Account("Melis", 135, 700, 12,06,2016),
        new Account("Harold", 105, 32.75,11,01,2008),
        new Account("Jane", 115, 250.65,01,11,2021),
        };
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("**** INFORMATION OF CLIENT " + (i + 1) + " ****");
                Console.Write("Name:");
                Console.WriteLine(accounts[i].name);

                Console.Write("Accout Number:");
                Console.WriteLine(accounts[i].acc_no);

                Console.Write("Balance:");
                Console.WriteLine("$" + accounts[i].balance);

                Console.Write("Account Date:");
                Console.WriteLine(accounts[i].day + "/" + accounts[i].month + "/" + accounts[i].year + "\n");
            }
            double[] arrOfAccNo = {
        accounts[0].acc_no, accounts[1].acc_no, accounts[2].acc_no,
        accounts[3].acc_no, accounts[4].acc_no,
                                   };

            double[] arrOfBalance = {
        accounts[0].balance, accounts[1].balance, accounts[2].balance,
        accounts[3].balance, accounts[4].balance,
                                   };

            a.sort_acc_no(arrOfAccNo);
            a.find_acc_no(arrOfAccNo, 210);
            a.balance_info(arrOfBalance);
        }
    }
}