﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static int[] DO = new int[] { 131, 262, 523, 1046 };
        static int[] RE = new int[] { 147, 294, 587, 1174 };
        static int[] MI = new int[] { 165, 330, 659, 1318 };
        static int[] FA = new int[] { 175, 349, 698, 1396 };
        static int[] SO = new int[] { 196, 392, 784, 1568 };
        static int[] LA = new int[] { 220, 440, 880, 1760 };
        static int[] TI = new int[] { 247, 494, 988, 1976 };

        static void Main(string[] args)
        {
            int oct1 = 0;
            int oct2 = 1;
            int oct3 = 2;
            int oct4 = 3;

            //Console.Beep(DO[oct3], 100);
            //Console.Beep(RE[oct3], 100);
            //Console.Beep(MI[oct3], 100);
            //Console.Beep(FA[oct3], 100);
            //Console.Beep(SO[oct3], 100);
            //Console.Beep(LA[oct3], 100);
            //Console.Beep(TI[oct3], 100);
            //Console.Beep(DO[oct4], 100);
            sweetChild();
        }

        //so2 fa3 re3 do3 do4 re3 ti3
        //la2 fa3 re3 do3 do4 re3 ti3
        // do32 fa3 re3 do3 do4 re3 ti3
        static void sweetChild()
        {
            int oct1 = 0;
            int oct2 = 1;
            int oct3 = 2;
            int oct4 = 3;
            for (int i = 0; i < 2; i++)
            {
                Console.Beep(SO[oct2], 250);
                Console.Beep(SO[oct3], 250);
                Console.Beep(RE[oct3], 250);
                Console.Beep(DO[oct3], 250);
                Console.Beep(DO[oct4], 250);
                Console.Beep(RE[oct3], 250);
                Console.Beep(TI[oct3], 250);
                Console.Beep(RE[oct3], 250);
            }

            for (int i = 0; i < 2; i++)
            {
                Console.Beep(LA[oct2], 250);
                Console.Beep(SO[oct3], 250);
                Console.Beep(RE[oct3], 250);
                Console.Beep(DO[oct3], 250);
                Console.Beep(DO[oct4], 250);
                Console.Beep(RE[oct3], 250);
                Console.Beep(TI[oct3], 250);
                Console.Beep(RE[oct3], 250);
            }

            for (int i = 0; i < 2; i++)
            {
                Console.Beep(DO[oct3], 250);
                Console.Beep(SO[oct3], 250);
                Console.Beep(RE[oct3], 250);
                Console.Beep(DO[oct3], 250);
                Console.Beep(DO[oct4], 250);
                Console.Beep(RE[oct3], 250);
                Console.Beep(TI[oct3], 250);
                Console.Beep(RE[oct3], 250);
            }

            Console.Beep(SO[oct2], 250);
            Console.Beep(SO[oct3], 250);
            Console.Beep(RE[oct3], 250);
            Console.Beep(DO[oct3], 250);
            Console.Beep(DO[oct4], 250);
            Console.Beep(RE[oct3], 250);
            Console.Beep(TI[oct3], 250);
            Console.Beep(RE[oct3], 250);
        }
    }
}

