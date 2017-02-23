//  --------------------------------------------------------------------------------------
// DataPassingDemo.StudentPairingData.cs
// 2017/02/22
//  --------------------------------------------------------------------------------------

using System.Collections.Generic;

namespace DataPassingDemo.Models
{
    public class StudentPairingData
    {
        public IList<string> PairedStudents { get; set; }

        public IList<string> Students { get; set; }

        public string UnpairedStudent { get; set; }
    }
}