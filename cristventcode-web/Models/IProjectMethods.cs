using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cristventcode_web.Models
{
    interface IProjectMethods
    {
        void createProject();
        List<Project> getProjectAll();
        Project getProjectById();
        void editProject();
        void deleteProject();
    }
}
