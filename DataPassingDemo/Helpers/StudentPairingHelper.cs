//  --------------------------------------------------------------------------------------
// DataPassingDemo.StudentPairingHelper.cs
// 2017/02/22
//  --------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using DataPassingDemo.Models;

namespace DataPassingDemo.Helpers
{
    
    public class StudentPairingHelper
    {
        public StudentPairingData PairStudents(StudentPairingData input)
        {
            // Copy the input Students so we don't go deleting data
            var unpairedStudents = new List<string>(input.Students);
            var pairedStudents = new List<string>();
            var random = new Random();
            // Pair the students
            for (int index = 0; index <= unpairedStudents.Count + 1; index++)
            {
                var first = unpairedStudents.First();
                if (unpairedStudents.Count == 0)
                    break;
                unpairedStudents.Remove(first);


                var randomIndex = random.Next(0, unpairedStudents.Count);
                var second = unpairedStudents[randomIndex];
                unpairedStudents.Remove(second);

                pairedStudents.Add($"{first} : {second}");
            }

            input.PairedStudents = pairedStudents;
            if (unpairedStudents.Count > 0)
                input.UnpairedStudent = unpairedStudents.First();


            //input.PairedStudents = input.Students.Reverse().ToList();
            // Assign the paired students to input.PairedStudents
            // If there is a leftover, assign it to input.UnpairedStudent
            return input;
        }
    }
}