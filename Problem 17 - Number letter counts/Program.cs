using System;
using System.Text;


class Program
{
    static void Main()
    {
        StringBuilder result = new StringBuilder();
        int totalLetters = 0;
        //int userInput = int.Parse(Console.ReadLine());
        for (int userInput = 1; userInput < 1000; userInput++)
        {
            int hundreds = userInput / 100;
            int tens = (userInput - hundreds * 100) / 10;
            int singles = userInput - hundreds * 100 - tens * 10;

            if (!(userInput / 1000 >= 1))
            {
                if (hundreds > 0)
                {
                    switch (hundreds)
                    {
                        case 1:
                            result.Append("One");
                            break;
                        case 2:
                            result.Append("Two");
                            break;
                        case 3:
                            result.Append("Three");
                            break;
                        case 4:
                            result.Append("Four");
                            break;
                        case 5:
                            result.Append("Five");
                            break;
                        case 6:
                            result.Append("Six");
                            break;
                        case 7:
                            result.Append("Seven");
                            break;
                        case 8:
                            result.Append("Eight");
                            break;
                        case 9:
                            result.Append("Nine");
                            break;
                        default:
                            Console.WriteLine("Something broke with the hundreds");
                            break;
                    }
                    result.Append("hundred");
                }
                if (tens > 0)
                {
                    if (tens == 1) // if it is zero add AND and stuff
                    {
                        if (hundreds > 0)
                        {
                            result.Append("and");
                        }
                        switch (singles)
                        {
                            case 0:
                                result.Append("ten");
                                break;
                            case 1:
                                result.Append("eleven");
                                break;
                            case 2:
                                result.Append("twelve");
                                break;
                            case 3:
                                result.Append("thirteen");
                                break;
                            case 4:
                                result.Append("fourteen");
                                break;
                            case 5:
                                result.Append("fifteen");
                                break;
                            case 6:
                                result.Append("sixteen");
                                break;
                            case 7:
                                result.Append("seventeen");
                                break;
                            case 8:
                                result.Append("eighteen");
                                break;
                            case 9:
                                result.Append("nineteen");
                                break;
                            default:
                                Console.WriteLine("Something broke with 11-19");
                                break;
                        }
                    }
                    else
                    {
                        if (singles > 0 && hundreds > 0)
                        {
                            result.Append("and");
                        }
                        switch (tens)
                        {
                            case 2:
                                result.Append("twenty");
                                break;
                            case 3:
                                result.Append("thirty");
                                break;
                            case 4:
                                result.Append("fourty");
                                break;
                            case 5:
                                result.Append("fifty");
                                break;
                            case 6:
                                result.Append("sixty");
                                break;
                            case 7:
                                result.Append("seventy");
                                break;
                            case 8:
                                result.Append("eighty");
                                break;
                            case 9:
                                result.Append("ninety");
                                break;
                            default:
                                break;
                        }
                        if (singles > 0)
                        {
                            switch (singles)
                            {
                                case 1:
                                    result.Append("one");
                                    break;
                                case 2:
                                    result.Append("two");
                                    break;
                                case 3:
                                    result.Append("three");
                                    break;
                                case 4:
                                    result.Append("four");
                                    break;
                                case 5:
                                    result.Append("five");
                                    break;
                                case 6:
                                    result.Append("six");
                                    break;
                                case 7:
                                    result.Append("seven");
                                    break;
                                case 8:
                                    result.Append("eight");
                                    break;
                                case 9:
                                    result.Append("nine");
                                    break;
                                default:
                                    break;
                            }
                        }
                    }
                } if (singles > 0 && tens == 0)
                {
                    if (hundreds > 0)
                    {
                        result.Append("and");
                    }
                    switch (singles)
                    {
                        case 1:
                            result.Append("one");
                            break;
                        case 2:
                            result.Append("two");
                            break;
                        case 3:
                            result.Append("three");
                            break;
                        case 4:
                            result.Append("four");
                            break;
                        case 5:
                            result.Append("five");
                            break;
                        case 6:
                            result.Append("six");
                            break;
                        case 7:
                            result.Append("seven");
                            break;
                        case 8:
                            result.Append("eight");
                            break;
                        case 9:
                            result.Append("nine");
                            break;
                        default:
                            break;
                    }
                }
            }
        }
        Console.WriteLine(result);
        Console.WriteLine(result.ToString().Length);
    }
}
