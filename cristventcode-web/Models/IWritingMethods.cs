using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cristventcode_web.Models
{
    interface IWritingMethods
    {
        void createWriting();
        List<Writing> getWritingAll();
        Writing getWritingById();
        void editWriting();
        void deleteWriting();
    }
}
