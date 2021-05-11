using HCI_projekat.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCI_projekat.Repository
{
    public class LabelRepository: Repository<Label>
    {
        public static String path = @"..\..\Resources\Data\Labels.txt";
    }
}
