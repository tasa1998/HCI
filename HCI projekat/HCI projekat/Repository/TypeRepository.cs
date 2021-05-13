using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCI_projekat.Repository
{
    public class TypeRepository:Repository<Model.Type>
    {
        public static String path = @"..\..\Resources\Data\Type.txt";
    }
}
